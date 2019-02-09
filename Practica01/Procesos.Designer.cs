namespace Practica01
{
    partial class WIN_Procesos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.LotesPendientes = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STC_ProcesosEspera = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.STC_ProcesoEjecucion = new System.Windows.Forms.Label();
            this.STC_ProcesoFin = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Cronometro = new System.Windows.Forms.Timer(this.components);
            this.STC_TiempoTranscurrido = new System.Windows.Forms.Label();
            this.STC_TiempoRestante = new System.Windows.Forms.Label();
            this.STC_TiempoTotal = new System.Windows.Forms.Label();
            this.Cont = new System.Windows.Forms.Label();
            this.TT = new System.Windows.Forms.Label();
            this.TR = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Programador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(422, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Procesamiento de Lotes";
            // 
            // LotesPendientes
            // 
            this.LotesPendientes.AutoSize = true;
            this.LotesPendientes.Location = new System.Drawing.Point(12, 66);
            this.LotesPendientes.Name = "LotesPendientes";
            this.LotesPendientes.Size = new System.Drawing.Size(85, 13);
            this.LotesPendientes.TabIndex = 5;
            this.LotesPendientes.Text = "Lotes Faltantes: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.TME});
            this.dataGridView1.Location = new System.Drawing.Point(16, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(280, 356);
            this.dataGridView1.TabIndex = 6;
            // 
            // STC_ProcesosEspera
            // 
            this.STC_ProcesosEspera.AutoSize = true;
            this.STC_ProcesosEspera.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_ProcesosEspera.Location = new System.Drawing.Point(12, 167);
            this.STC_ProcesosEspera.Name = "STC_ProcesosEspera";
            this.STC_ProcesosEspera.Size = new System.Drawing.Size(159, 23);
            this.STC_ProcesosEspera.TabIndex = 7;
            this.STC_ProcesosEspera.Text = "Procesos en Espera";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Programador,
            this.Operacion,
            this.TiempoME,
            this.NP});
            this.dataGridView2.Location = new System.Drawing.Point(314, 193);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(450, 356);
            this.dataGridView2.TabIndex = 8;
            // 
            // STC_ProcesoEjecucion
            // 
            this.STC_ProcesoEjecucion.AutoSize = true;
            this.STC_ProcesoEjecucion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_ProcesoEjecucion.Location = new System.Drawing.Point(310, 167);
            this.STC_ProcesoEjecucion.Name = "STC_ProcesoEjecucion";
            this.STC_ProcesoEjecucion.Size = new System.Drawing.Size(172, 23);
            this.STC_ProcesoEjecucion.TabIndex = 9;
            this.STC_ProcesoEjecucion.Text = "Proceso en Ejecucion";
            // 
            // STC_ProcesoFin
            // 
            this.STC_ProcesoFin.AutoSize = true;
            this.STC_ProcesoFin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_ProcesoFin.Location = new System.Drawing.Point(781, 167);
            this.STC_ProcesoFin.Name = "STC_ProcesoFin";
            this.STC_ProcesoFin.Size = new System.Drawing.Size(173, 23);
            this.STC_ProcesoFin.TabIndex = 11;
            this.STC_ProcesoFin.Text = "Procesos Terminados";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(785, 193);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(350, 356);
            this.dataGridView3.TabIndex = 10;
            // 
            // Cronometro
            // 
            this.Cronometro.Tick += new System.EventHandler(this.Cronometro_Tick);
            // 
            // STC_TiempoTranscurrido
            // 
            this.STC_TiempoTranscurrido.AutoSize = true;
            this.STC_TiempoTranscurrido.Location = new System.Drawing.Point(12, 93);
            this.STC_TiempoTranscurrido.Name = "STC_TiempoTranscurrido";
            this.STC_TiempoTranscurrido.Size = new System.Drawing.Size(110, 13);
            this.STC_TiempoTranscurrido.TabIndex = 12;
            this.STC_TiempoTranscurrido.Text = "Tiempo Transcurrido: ";
            // 
            // STC_TiempoRestante
            // 
            this.STC_TiempoRestante.AutoSize = true;
            this.STC_TiempoRestante.Location = new System.Drawing.Point(13, 116);
            this.STC_TiempoRestante.Name = "STC_TiempoRestante";
            this.STC_TiempoRestante.Size = new System.Drawing.Size(94, 13);
            this.STC_TiempoRestante.TabIndex = 13;
            this.STC_TiempoRestante.Text = "Tiempo Restante: ";
            // 
            // STC_TiempoTotal
            // 
            this.STC_TiempoTotal.AutoSize = true;
            this.STC_TiempoTotal.Location = new System.Drawing.Point(13, 141);
            this.STC_TiempoTotal.Name = "STC_TiempoTotal";
            this.STC_TiempoTotal.Size = new System.Drawing.Size(75, 13);
            this.STC_TiempoTotal.TabIndex = 14;
            this.STC_TiempoTotal.Text = "Tiempo Total: ";
            // 
            // Cont
            // 
            this.Cont.AutoSize = true;
            this.Cont.Location = new System.Drawing.Point(106, 141);
            this.Cont.Name = "Cont";
            this.Cont.Size = new System.Drawing.Size(0, 13);
            this.Cont.TabIndex = 15;
            // 
            // TT
            // 
            this.TT.AutoSize = true;
            this.TT.Location = new System.Drawing.Point(136, 93);
            this.TT.Name = "TT";
            this.TT.Size = new System.Drawing.Size(0, 13);
            this.TT.TabIndex = 16;
            // 
            // TR
            // 
            this.TR.AutoSize = true;
            this.TR.Location = new System.Drawing.Point(136, 116);
            this.TR.Name = "TR";
            this.TR.Size = new System.Drawing.Size(0, 13);
            this.TR.TabIndex = 17;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "NombreP";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // TME
            // 
            this.TME.HeaderText = "TME";
            this.TME.Name = "TME";
            this.TME.ReadOnly = true;
            this.TME.Width = 75;
            // 
            // Programador
            // 
            this.Programador.HeaderText = "NombreP";
            this.Programador.Name = "Programador";
            this.Programador.ReadOnly = true;
            // 
            // Operacion
            // 
            this.Operacion.HeaderText = "Operacion";
            this.Operacion.Name = "Operacion";
            this.Operacion.ReadOnly = true;
            // 
            // TiempoME
            // 
            this.TiempoME.HeaderText = "TME";
            this.TiempoME.Name = "TiempoME";
            this.TiempoME.ReadOnly = true;
            // 
            // NP
            // 
            this.NP.HeaderText = "NP";
            this.NP.Name = "NP";
            this.NP.ReadOnly = true;
            // 
            // WIN_Procesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.TR);
            this.Controls.Add(this.TT);
            this.Controls.Add(this.Cont);
            this.Controls.Add(this.STC_TiempoTotal);
            this.Controls.Add(this.STC_TiempoRestante);
            this.Controls.Add(this.STC_TiempoTranscurrido);
            this.Controls.Add(this.STC_ProcesoFin);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.STC_ProcesoEjecucion);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.STC_ProcesosEspera);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LotesPendientes);
            this.Controls.Add(this.label1);
            this.Name = "WIN_Procesos";
            this.Text = "Procesos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LotesPendientes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label STC_ProcesosEspera;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label STC_ProcesoEjecucion;
        private System.Windows.Forms.Label STC_ProcesoFin;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Timer Cronometro;
        private System.Windows.Forms.Label STC_TiempoTranscurrido;
        private System.Windows.Forms.Label STC_TiempoRestante;
        private System.Windows.Forms.Label STC_TiempoTotal;
        private System.Windows.Forms.Label Cont;
        private System.Windows.Forms.Label TT;
        private System.Windows.Forms.Label TR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Programador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoME;
        private System.Windows.Forms.DataGridViewTextBoxColumn NP;
    }
}