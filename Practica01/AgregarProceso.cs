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

namespace Practica01
{
    public partial class AgregarProceso : Form
    {
        const int MaximoLote = 6; //Maximo Por Lotes
        int NProcesos; //Numero de Procesos
        int TiempoMax;
        int NumeroPrograma = 1;
        int Valor1, Valor2;
        string Nombre;
        string Operacion;
        int Resultado;
        string[] Nombres = new string[3];
        string[] Operaciones = new string[4];
        //int Contador = 1; //Contador de Procesos
        string Oper;
        string RutaLotesTxt = "d:\\Users\\Darevalo\\Desktop\\Nueva carpeta\\Lotes.txt";

        Queue<Proceso> ColaProcesos = new Queue<Proceso>();//Cola de los Procesos

        
        
        public AgregarProceso(int NumeroP)
        {
            NProcesos = NumeroP;
            InitializeComponent();

            //Declaramos los Nombres
            Nombres[0] = "Diego";
            Nombres[1] = "Alejandro";
            Nombres[2] = "Pancho";

            //Declaramos las Operaciones
            Operaciones[0] = "+";
            Operaciones[1] = "-";
            Operaciones[2] = "*";
            Operaciones[3] = "/";


            
        }

        private void BTN_AgregarProceso_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            

            for (int cont = 0; cont < NProcesos; cont++)
             {
                Nombre = Nombres[rand.Next(0, 3)];
                TiempoMax = rand.Next(1, 7);
                Valor1 = rand.Next(1, 100);
                Valor2 = rand.Next(1, 100);
                Operacion = Operaciones[rand.Next(0, 4)];
                
                switch (Operacion)
                {
                    case "+":
                        Resultado = Valor1 + Valor2;
                        Oper = Valor1.ToString() + Operacion + Valor2.ToString(); 
                        break;

                    case "-":
                        if(Valor2 > Valor1)
                        {
                            Resultado = Valor2 - Valor1;
                            Oper = Valor2.ToString() + Operacion + Valor1.ToString();
                        }
                        else
                        {
                            Resultado = Valor1 - Valor2;
                            Oper = Valor1.ToString() + Operacion + Valor2.ToString();
                        }

                        break;

                    case "*":
                        Resultado = Valor1 * Valor2;
                        Oper = Valor1.ToString() + Operacion + Valor2.ToString();
                        break;
                    case "/":
                        if (Valor2 > Valor1)
                        {
                            Resultado = Valor2 / Valor1;
                            Oper = Valor2.ToString() + Operacion + Valor1.ToString();
                        }
                        else
                        {
                            Resultado = Valor1 / Valor2;
                            Oper = Valor1.ToString() + Operacion + Valor2.ToString();
                        }
                        break;
                    default:
                        Resultado = 0;
                        break;
                }
                Proceso proceso = new Proceso(Nombre, Oper, TiempoMax, NumeroPrograma);
                ColaProcesos.Enqueue(proceso);
                try
                {
                    if(!File.Exists(RutaLotesTxt))
                    {
                        using (StreamWriter sw = File.CreateText(RutaLotesTxt))
                        {
                            sw.WriteLine("Nombre Programador: " + Nombre + " Operación: " + Operacion + " Tiempo Maximo: " + TiempoMax + " Numero de Programa: " + NumeroPrograma);
                            sw.Close();
                        }
                    }
                    else
                    {
                        using (StreamWriter sw = File.AppendText(RutaLotesTxt))
                        {
                            sw.WriteLine("Nombre Programador: " + Nombre + " Operación: " + Operacion + " Tiempo Maximo: " + TiempoMax + " Numero de Programa: " + NumeroPrograma);
                            sw.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exeption: " + ex.Message);
                }
                NumeroPrograma++;
            }
             int i = 0;
             Queue<Lote> ListaLotes = new Queue<Lote>();
             Queue<Proceso> lote = new Queue<Proceso>();
             while(ColaProcesos.Count > 0)
             {
               lote.Enqueue(ColaProcesos.Dequeue());
               if(++i >= MaximoLote)
               {
                  i = 0;
                  ListaLotes.Enqueue(new Lote(lote));
                  lote = new Queue<Proceso>();
               }
             }
             if(lote.Count > 0)
             {
                ListaLotes.Enqueue(new Lote(lote));
             }
             WIN_Procesos Ventana = new WIN_Procesos(ListaLotes);
            this.Hide();
            Ventana.Show();
        }
    }
}
