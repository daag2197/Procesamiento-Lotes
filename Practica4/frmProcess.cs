﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeminarioSO.Clases;
using System.IO;

namespace SeminarioSO
{
    public partial class frmProcess : Form
    {
        const int MAX_PROCESOS = 6;
        int MAX_QUANTUM;

        Queue<clsProceso> ProcesosNuevos = new Queue<clsProceso>();
        Queue<clsProceso> ProcesosListos = new Queue<clsProceso>();
        Queue<clsProceso> ProcesosBloqueados = new Queue<clsProceso>();
        clsProceso ProcesoActual;

        List<clsProceso> Concluidos = new List<clsProceso>();
        List<string> Resultados = new List<string>();
        string RutaResultados = "Resultados.txt";

        int Counter = 0, CountProcesos = 0, Quantum = 0;
        Random R = new Random();

        public frmProcess(Queue<clsProceso> Nuevos, int Quantum)
        {
            this.ProcesosNuevos = Nuevos;
            MAX_QUANTUM = Quantum;
            InitializeComponent();
            timer1.Start();
            lblMaxQuantum.Text = Quantum.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Procesar();
        }

        private void Procesar()
        {
            while(CountProcesos < MAX_PROCESOS && ProcesosNuevos.Count > 0)
            {
                clsProceso P = ProcesosNuevos.Dequeue();
                P.Llegada = Counter;
                ProcesosListos.Enqueue(P);
                CountProcesos++;
            }

            if (ProcesoActual != null && ProcesoActual.TR > 0)
            {
                lblCounter.Text = (++Counter).ToString();
                txtTR.Text = (--ProcesoActual.TR).ToString();
                txtTT.Text = (ProcesoActual.TME - ProcesoActual.TR).ToString();
                lblQuantum.Text = (++Quantum).ToString();
            }
            else if (ProcesosListos.Count > 0)
            {
                AddConcluido();
                setActual();
            }
            else if(ProcesosNuevos.Count == 0 && ProcesosBloqueados.Count == 0)
            {
                AddConcluido();
                
                foreach (string resultado in Resultados)
                {
                    try
                    {
                        if (!File.Exists(RutaResultados))
                        {
                            using (StreamWriter sw = File.CreateText(RutaResultados))
                            {
                                sw.WriteLine("Resultado: " + resultado);
                                sw.Close();
                            }
                        }
                        else
                        {
                            using (StreamWriter sw = File.AppendText(RutaResultados))
                            {
                                sw.WriteLine("Resultado: " + resultado);
                                sw.Close();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exepcion: " + ex.Message);
                    }
                }
                timer1.Stop();
                frmConcluido Ventana = new frmConcluido(Counter, Concluidos);
                MessageBox.Show("Se han concluido todos los procesos", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Ventana.ShowDialog();
                this.Close();
            }
            else
            {
                lblCounter.Text = (++Counter).ToString();
            }

            lblCounterLote.Text = ProcesosNuevos.Count.ToString();
            setData(ProcesoActual);
            ProcessBloqueados();

            if(Quantum >= MAX_QUANTUM)
            {
                ProcesosListos.Enqueue(ProcesoActual);
                setActual();
            }
        }

        private DataTable SetListos(Queue<clsProceso> L)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Nombre Programador");
            dt.Columns.Add("TME");
            dt.Columns.Add("TR");

            foreach (clsProceso P in L)
            {
                dt.Rows.Add(P.Numero,P.Nombre,P.TME, P.TR);
            }

            return dt;
        }

        private void AddConcluido()
        {
            if (ProcesoActual == null)
            {
                return;
            }

            ProcesoActual.Finalizacion = Counter;
            ProcesoActual.Concluido = true;
            Concluidos.Add(ProcesoActual);
            Resultados.Add(ProcesoActual.Resultado);
            CountProcesos--;
        }

        private void ProcessBloqueados()
        {
            ProcesosBloqueados.Select(c => { c.Bloqueado++; return c; }).ToList();

            if(ProcesosBloqueados.Count > 0 && ProcesosBloqueados.First().Bloqueado > 9)
            {
                ProcesosListos.Enqueue(ProcesosBloqueados.Dequeue());
            }

            dgBloqueados.DataSource = SetBloqueados(ProcesosBloqueados);
        }

        private DataTable SetBloqueados(Queue<clsProceso> L)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Bloqueado");

            foreach (clsProceso P in L)
            {
                dt.Rows.Add(P.Numero, P.Bloqueado);
            }

            return dt;
        }

        private DataTable SetConcluidos(List<clsProceso> L)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Operacion");
            dt.Columns.Add("Resultado");

            foreach (clsProceso P in L)
            {
                dt.Rows.Add(P.Numero, P.Operacion, P.Resultado);
            }

            return dt;
        }

        private void setData(clsProceso P)
        {
            if (P != null)
            {
                txtOp.Text = P.Operacion;
                txtNumero.Text = P.Numero.ToString();
                txtTME.Text = P.TME.ToString();
                txtTT.Text = (P.TME - P.TR).ToString();
                txtTR.Text = (P.TR).ToString();
                lblQuantum.Text = Quantum.ToString();
            }
            else
            {
                txtOp.Text = "";
                txtNumero.Text = "";
                txtTME.Text = "";
                txtTT.Text = "";
                txtTR.Text = "";
                lblQuantum.Text = "";
            }
            dgActual.DataSource = SetListos(ProcesosListos);
            dgConcluidos.DataSource = SetConcluidos(Concluidos);
        }

        private void dgActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressKey((Keys)char.ToUpper(e.KeyChar));
        }

        private void PressKey(Keys K){
            switch (K)
            {
                case Keys.I:
                    if (timer1.Enabled)
                    {
                        ProcesoActual.Bloqueado = 0;
                        ProcesosBloqueados.Enqueue(ProcesoActual);
                        setActual();
                        setData(ProcesoActual);
                    }
                    break;
                case Keys.E:
                    if (timer1.Enabled)
                    {
                        ProcesoActual.Resultado = "Error";
                        ProcesoActual.Servicio = ProcesoActual.TME - ProcesoActual.TR;
                        ProcesoActual.TR = 0;
                        Procesar();
                    }
                    break;
                case Keys.P:
                    timer1.Stop();
                    lblTitle.Text = "Procesos en Pausa";
                    break;
                case Keys.C:
                    timer1.Start();
                    lblTitle.Text = "Procesos en Ejecución";
                    break;
                case Keys.N:
                    if (timer1.Enabled)
                    {
                        ProcesosNuevos.Enqueue(new clsProceso(R));
                        Procesar();
                    }
                    break;
                case Keys.T:
                    if (timer1.Enabled)
                    {
                        timer1.Stop();
                        List<clsProceso> BCP = new List<clsProceso>();
                        BCP.AddRange(Concluidos);

                        if (ProcesoActual != null)
                        {
                            BCP.Add(ProcesoActual);
                        }

                        BCP.AddRange(ProcesosListos);
                        BCP.AddRange(ProcesosBloqueados);
                        BCP.AddRange(ProcesosNuevos);

                        foreach (clsProceso p in BCP) {
                            if (!p.Concluido)
                            {
                                p.Finalizacion = Counter;
                                p.Servicio = p.TME - p.TR;
                            }
                        }

                        frmConcluido Ventana = new frmConcluido(Counter, BCP, false);
                        this.Hide();
                        Ventana.ShowDialog();
                        this.Show();
                        dgActual.Focus();
                        timer1.Start();
                    }
                    break;

            }
        }

        private void setActual()
        {
            if (ProcesosListos.Count > 0)
            {
                ProcesoActual = ProcesosListos.Dequeue();
                if(ProcesoActual.Respuesta == -1)
                {
                    ProcesoActual.Respuesta = Counter - ProcesoActual.Llegada;
                }
                Quantum = 0;
            }
            else
            {
                ProcesoActual = null;
            }
        }
    }
}
