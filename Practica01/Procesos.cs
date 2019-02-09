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

namespace Practica01
{
    public partial class WIN_Procesos : Form
    {
        Queue<Lote> Lotes = new Queue<Lote>();
        Lote LoteActual = new Lote();
        Proceso ProcesoActual;
        List<Proceso> Concluidos = new List<Proceso>();
        int TiempoTranscurrido = 0;
        int TiempoRestante = 0;
        int TiempoTotal = 0;

        public WIN_Procesos(Queue<Lote> Lotes)
        {
            this.Lotes = Lotes;
            InitializeComponent();
            Cronometro.Start();
        }

        private void Cronometro_Tick(object sender, EventArgs e)
        {
            if(TiempoRestante > 0)
            {
                Cont.Text = (++TiempoTotal).ToString();
                TT.Text = (++TiempoTranscurrido).ToString();
                TR.Text = (--TiempoRestante).ToString();
            }
            else if(LoteActual.Procesos.Count > 0)
            {

            }
        }

        private DataTable SetEspera(Lote lote)
        {
            DataTable dt = new DataTable();
            
            foreach(Proceso p in lote.Procesos)
            {
                dt.Rows.Add(p.NumPrograma, p.Nombre, p.TiempoMaximo);
            }

            return dt;
        }

        private DataTable SetActual(Lote lote)
        {
            DataTable dt = new DataTable();

            foreach(Proceso p in lote.Procesos)
            {
                dt.Rows.Add(p.Nombre, p.Operacion, p.TiempoMaximo, p.NumPrograma);
            }
            return dt;
        }
    }
}
