using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica01;
using System.IO;
using System.Threading;

namespace Practica01
{
    public partial class WIN_Procesos : Form
    {
        Queue<Proceso> ProcesosDiagrama = new Queue<Proceso>();//Lista de Procesos Listos
        Queue<Proceso> ProcesosNuevos = new Queue<Proceso>();//Lista de Procesos Nuevos
        Queue<Proceso> ProcesosBloqueados = new Queue<Proceso>();//Procesos Bloqueados

        List<Proceso> Concluidos = new List<Proceso>();//Procesos Terminados

        Proceso ProcesoActual;
        
        List<string> Resultados = new List<string>();
        int TiempoTranscurrido = 0;
        int TiempoRestante = 0;
        int TiempoTotal = 0;
        string Ruta = "Procesamiento.txt";
        string RutaResultados = "Resultados.txt";
        bool bandera = false;
        bool banderas = false;
        bool isPaused = false;

        public WIN_Procesos(Queue<Proceso> ProcesosNuevos)
        {
            InitializeComponent();
            this.ProcesosNuevos = ProcesosNuevos;

            while (ProcesosDiagrama.Count < 5)
            {
                if (bandera == false)
                {
                    ProcesoActual = ProcesosNuevos.Dequeue();
                    TiempoRestante = ProcesoActual.TiempoMaximo;
                    TiempoTotal = 0;
                    TR.Text = TiempoRestante.ToString();
                    TT.Text = TiempoTotal.ToString();
                    Ejecucion.DataSource = SetActual(ProcesoActual);
                    bandera = true;
                }
                if(ProcesosNuevos.Count > 0)
                {
                    ProcesosDiagrama.Enqueue(ProcesosNuevos.Dequeue());
                    Espera.DataSource = SetEspera(ProcesosDiagrama, bandera);
                    Nuevos.DataSource = SetEspera(ProcesosNuevos, bandera);
                }
                else
                {
                    break;
                }
                
            }
            
            Cronometro.Start();
        }
        private void Cronometro_Tick(object sender, EventArgs e)
        {
            this.Focus();

            if (TiempoRestante > 0)
            {
                Cont.Text = (++TiempoTotal).ToString();
                TT.Text = (++TiempoTranscurrido).ToString();
                TR.Text = (--TiempoRestante).ToString();
            }
            else if(ProcesosDiagrama.Count > 0)
            {
                if(ProcesoActual != null)
                {
                    Concluidos.Add(ProcesoActual);
                    Resultados.Add(ProcesoActual.Resultado);

                    if (Concluidos.Count > 0)
                    {
                        Terminado.DataSource = SetCompletados(Concluidos);
                    }
                    ProcesoActual = ProcesosDiagrama.Dequeue();
                    if(ProcesosNuevos.Count > 0)
                    {    
                        ProcesosDiagrama.Enqueue(ProcesosNuevos.Dequeue());
                    } 
                    Ejecucion.DataSource = SetActual(ProcesoActual);
                    TiempoRestante = ProcesoActual.TiempoMaximo;
                    TiempoTotal = 0;
                    TR.Text = TiempoRestante.ToString();
                    TT.Text = TiempoTotal.ToString();
                    Espera.DataSource = SetEspera(ProcesosDiagrama, bandera);
                    Nuevos.DataSource = SetEspera(ProcesosNuevos, bandera);
                }
            }
            else
            {
                if (ProcesoActual != null)
                {
                    Concluidos.Add(ProcesoActual);
                    Resultados.Add(ProcesoActual.Resultado);
                    Terminado.DataSource = SetCompletados(Concluidos);
                    ProcesoActual = null;
                    Ejecucion.DataSource = null;
                    int Contador = 0;
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
                        Contador++;
                    }
                    Cronometro.Stop();
                }
            }

            System.Threading.Thread.Sleep(1000);
        }

        private DataTable SetEspera(Queue<Proceso> ProcesoEspera, bool bandera)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Nombre Programador");
            dt.Columns.Add("Tiempo Maximo Espera");
            if (bandera == true)
            {
                try
                {
                    if (!File.Exists(Ruta))
                    {
                        using (StreamWriter sw = File.CreateText(Ruta))
                        {
                            sw.WriteLine("Esperando Entrada");
                            sw.Close();
                        }
                    }
                    else
                    {
                        using (StreamWriter sw = File.AppendText(Ruta))
                        {
                            sw.WriteLine("Esperando Entrada");
                            sw.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exepcion: " + ex);
                }
            }
            foreach (Proceso p in ProcesoEspera)
            {
                dt.Rows.Add(p.NumPrograma, p.Nombre, p.TiempoMaximo);
                if (bandera == true)
                {
                    try
                    {
                        using (StreamWriter sw = File.AppendText(Ruta))
                        {
                            sw.WriteLine("Id: " + p.NumPrograma + " Nombre Programador: " + p.Nombre + " TME: " + p.TiempoMaximo);
                            sw.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exeption: " + ex.Message);
                    }
                }
            }
            return dt;
        }

        private DataTable SetActual(Proceso p)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre Programador");
            dt.Columns.Add("Operacion");
            dt.Columns.Add("Tiempo Maximo Espera");
            dt.Columns.Add("Numero de Programa");

            dt.Rows.Add(p.Nombre, p.Operacion, p.TiempoMaximo, p.NumPrograma);
            try
            {
                using (StreamWriter sw = File.AppendText(Ruta))
                {
                    sw.WriteLine("Proceso en Ejecucion");
                    sw.WriteLine("Nombre Programador: " + p.Nombre + " Operacion: " + p.Operacion + " TME: " + p.TiempoMaximo + " Numero de Programa: " + p.NumPrograma);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exeption: " + ex.Message);
            }
            return dt;
        }

        private DataTable SetCompletados(List<Proceso> L)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Operacion");
            dt.Columns.Add("Resultado");
            try
            {
                using (StreamWriter sw = File.AppendText(Ruta))
                {
                    sw.WriteLine("Procesos Concluidos");
                    sw.Close();
                }
            }
            catch (Exception expt)
            {
                MessageBox.Show("Exeption: " + expt.Message);
            }
            foreach (Proceso p in L)
            {
                dt.Rows.Add(p.NumPrograma, p.Operacion, p.Resultado);
                try
                {
                    using (StreamWriter sw = File.AppendText(Ruta))
                    {
                        sw.WriteLine("ID: " + p.NumPrograma + " Operacion: " + p.Operacion + " Resultado: " + p.Resultado);
                        sw.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exeption: " + ex.Message);
                }
            }
            return dt;
        }


        private void Espera_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case (int)Keys.I:
                    if(isPaused == false)
                    {
                        Queue<Proceso> miProceso = new Queue<Proceso>();

                        if (banderas == false)
                        {
                            miProceso = ProcesosDiagrama;

                            ProcesosBloqueados.Enqueue(ProcesoActual);

                            if (miProceso.Count > 0)
                            {
                                ProcesoActual = miProceso.Dequeue();
                                Bloqueados.DataSource = SetEspera(ProcesosBloqueados, true);
                            }
                            else
                            {
                                ProcesoActual = ProcesosDiagrama.Dequeue();
                                Bloqueados.DataSource = SetEspera(ProcesosBloqueados, true);
                            }
                            SetActual(ProcesoActual);
                            banderas = true;
                        }
                        else
                        {
                            ProcesosDiagrama.Enqueue(ProcesosBloqueados.Dequeue());
                            Bloqueados.DataSource = null;
                            banderas = false;
                        }
                        
                    }
                    break;
                case (int)Keys.E:
                    if(isPaused == false)
                    {
                        ProcesoActual.Resultado = "Error";
                        ProcesoActual.TiempoMaximo = 0;
                        TiempoRestante = 0;
                    }
                    break;
                case (int)Keys.P:
                    if (isPaused == false)
                    {
                        Cronometro.Stop();
                        isPaused = true;
                    }
                    break;
                case (int)Keys.C:
                    if (isPaused)
                    {
                        Cronometro.Start();
                        isPaused = false;
                    }
                    break;
            }
        }
    }
}
