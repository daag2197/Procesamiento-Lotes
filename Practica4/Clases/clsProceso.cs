using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SeminarioSO.Clases
{

    public class clsProceso
    {
        public enum OperacionEnum
        {
            Suma,
            Resta,
            Multiplicacion,
            Division
        }
        public enum Nombres
        {
            Diego,
            Alejandro,
            Sofia,
            Ricardo,
            Julio,
            Ruben,
            Cinthya,
            Guadalupe,
            Maria,
            Martha
        }

        public string Nombre;

        public string Operacion;
        public string Resultado;
        public int TME; //Tiempo Maximo Estimado
        public int TR; //Tiempo Restante
        public int Numero;
        public bool Concluido = false;

        public int Llegada = -1;
        public int Finalizacion;
        public int Retorno { get { return this.Finalizacion - this.Llegada; } }
        public int Respuesta;
        public int Espera { get { return this.Retorno - this.Servicio; } }
        public int Servicio;
        public int Bloqueado;

        private static int ID;

        public clsProceso(string Nombre, string Operacion, string Resultado, int TME, int Numero)
        {
            this.Nombre = Nombre;
            this.Operacion = Operacion;
            this.Resultado = Resultado;
            this.TME = this.Servicio = TME;
            this.TR = TME;
            this.Numero = Numero;
            this.Respuesta = -1;
        }

        //Se requiere recibir el Random para evitar la misma informacion
        public clsProceso(Random R)
        {
            decimal N1, N2, Resultado;
            char Signo;
            OperacionEnum Op;
            Nombres nombres;

            N1 = R.Next(1, 100);
            N2 = R.Next(1, 100);
            Op = (OperacionEnum)R.Next(4);
            nombres = (Nombres)R.Next(10);

            switch (Op)
            {
                case OperacionEnum.Suma:
                    Signo = '+';
                    Resultado = N1 + N2;
                    break;

                case OperacionEnum.Resta:
                    Signo = '-';
                    Resultado = N1 - N2;
                    break;

                case OperacionEnum.Multiplicacion:
                    Signo = '*';
                    Resultado = N1 * N2;
                    break;
                case OperacionEnum.Division:
                    Signo = '/';
                    Resultado = N1 / N2;
                    break;
                default:
                    Signo = '?';
                    Resultado = 0;
                    break;
            }

            this.Nombre = nombres.ToString();
            this.Operacion = N1.ToString() + Signo + N2.ToString();
            this.Resultado = Math.Round(Resultado, 4).ToString();
            this.TME = this.TR = this.Servicio = R.Next(7, 18);
            
            this.Numero = ID;
            this.Respuesta = -1;
            try
            {
                if(!File.Exists("Lotes.txt"))
                {
                    using (StreamWriter sw = File.CreateText("Lotes.txt"))
                    {
                        sw.WriteLine("Nombre Programador: " + this.Nombre + " Operación: " + this.Operacion + " Tiempo Maximo: " + this.TME + " Numero de Programa: " + this.Numero);
                        sw.Close();
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText("Lotes.txt"))
                    {
                        sw.WriteLine("Nombre Programador: " + this.Nombre + " Operación: " + this.Operacion + " Tiempo Maximo: " + this.TME + " Numero de Programa: " + this.Numero);
                        sw.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exeption: " + ex.Message);
            }
            this.Numero = ++ID;
        }

        public clsProceso() { }

        public clsProceso(clsProceso p)
        {
            this.Nombre = p.Nombre;
            this.Operacion = p.Operacion;
            this.Resultado = p.Resultado;
            this.TME = p.TME;
            this.TR = p.TR;
            this.Numero = p.Numero;
            this.Concluido = p.Concluido;

            this.Llegada = p.Llegada;
            this.Finalizacion = p.Finalizacion;
            this.Respuesta = p.Respuesta;
            this.Servicio = p.Servicio;
            this.Bloqueado = p.Bloqueado;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
