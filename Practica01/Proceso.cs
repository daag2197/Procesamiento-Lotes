using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01
{
    public class Proceso
    {
        public string Nombre;
        public string Operacion;
        public int TiempoMaximo;
        public int NumPrograma;
        
        public Proceso(string Nombre,string Operacion,int TiempoMaximo,int NumPrograma)
        {
            this.Nombre = Nombre;
            this.Operacion = Operacion;
            this.TiempoMaximo = TiempoMaximo;
            this.NumPrograma = NumPrograma;
        }
        public Proceso()
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
