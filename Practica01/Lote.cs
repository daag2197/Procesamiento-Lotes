using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01
{
    public class Lote
    {
        public Queue<Proceso> Procesos;

        public Lote()
        {
            Procesos = new Queue<Proceso>();
        }

        public Lote(Queue<Proceso> Procesos)
        {
            this.Procesos = Procesos;
        }
    }
}
