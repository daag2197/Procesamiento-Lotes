using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Practica01
{
    public partial class WIN_FIFO : Form
    {
        Queue<Proceso> ProcesosDiagrama = new Queue<Proceso>();//Lista de Procesos Listos
        Queue<Proceso> ProcesosNuevos = new Queue<Proceso>();//Lista de Procesos Nuevos

        Proceso ProcesoActual; //Proceso en Ejecución
        List<Proceso> Concluidos = new List<Proceso>(); //Lista de Procesos Terminados
        List<string> Resultados = new List<string>(); // Lista de Resultados
        int TiempoTranscurrido = 0;
        int TiempoRestante = 0;
        int TiempoTotal = 0;
        string Ruta = "Procesamiento.txt";
        string RutaResultados = "Resultados.txt";
        bool bandera = false;
        bool isPaused = false;

        public WIN_FIFO(Queue<Proceso> ProcesosNuevos)
        {
            this.ProcesosNuevos = ProcesosNuevos;

            /*ProcesoActual = ProcesosNuevos.Dequeue();
            TiempoRestante = ProcesoActual.TiempoMaximo;
            TiempoTotal = 0;
            TR.Text = TiempoRestante.ToString();
            TT.Text = TiempoTotal.ToString();*/
            while (ProcesosDiagrama.Count < 7)
            {
                if(bandera == false)
                {
                    ProcesoActual = ProcesosNuevos.Dequeue();
                    TiempoRestante = ProcesoActual.TiempoMaximo;
                    TiempoTotal = 0;
                    TR.Text = TiempoRestante.ToString();
                    TT.Text = TiempoTotal.ToString();
                    Ejecucion.DataSource = SetActual(ProcesoActual);
                    bandera = true;
                }
                ProcesosDiagrama.Enqueue(ProcesosNuevos.Dequeue());
            }
            InitializeComponent();
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
            /*else if(ProcesosListos.Count > 0)
            {
                bandera = true;
                if(ProcesoActual != null)
                {
                    Concluidos.Add(ProcesoActual);
                    Resultados.Add(ProcesoActual.Resultado);
                    if(Concluidos.Count > 0)
                    {
                        //Llenar Tabla de Terminados

                    }
                }
                ProcesoActual = ProcesosListos.Dequeue();
                ProcesosListos.Enqueue(ProcesosNuevos.Dequeue());
                MessageBox.Show(ProcesosListos.Count.ToString());
                //Llenar Proceso en Ejecución
                TiempoRestante = ProcesoActual.TiempoMaximo;
                TiempoTotal = 0;
                TR.Text = TiempoRestante.ToString();
                TT.Text = TiempoTotal.ToString();
            }*/
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

    }
}
