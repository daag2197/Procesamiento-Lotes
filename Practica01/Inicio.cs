using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica01
{
    public partial class WIN_Inicio : Form
    {
        public WIN_Inicio()
        {
            InitializeComponent();
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            if(EDT_NumeroProcesos.Value <= 0)
            {
                MessageBox.Show("Número de Procesos Inválido debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AgregarProceso agregarProceso = new AgregarProceso(decimal.ToInt32(EDT_NumeroProcesos.Value));
            this.Hide();
            agregarProceso.Show();
        }
    }
}
