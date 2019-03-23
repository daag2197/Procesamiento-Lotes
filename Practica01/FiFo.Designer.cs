namespace Practica01
{
    partial class WIN_FIFO
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
            this.Cronometro = new System.Windows.Forms.Timer(this.components);
            this.TR = new System.Windows.Forms.Label();
            this.TT = new System.Windows.Forms.Label();
            this.Cont = new System.Windows.Forms.Label();
            this.STC_TiempoTotal = new System.Windows.Forms.Label();
            this.STC_TiempoRestante = new System.Windows.Forms.Label();
            this.STC_TiempoTranscurrido = new System.Windows.Forms.Label();
            this.STC_ProcesoEjecucion = new System.Windows.Forms.Label();
            this.Ejecucion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Ejecucion)).BeginInit();
            this.SuspendLayout();
            // 
            // Cronometro
            // 
            this.Cronometro.Tick += new System.EventHandler(this.Cronometro_Tick);
            // 
            // TR
            // 
            this.TR.AutoSize = true;
            this.TR.Location = new System.Drawing.Point(136, 32);
            this.TR.Name = "TR";
            this.TR.Size = new System.Drawing.Size(0, 13);
            this.TR.TabIndex = 23;
            // 
            // TT
            // 
            this.TT.AutoSize = true;
            this.TT.Location = new System.Drawing.Point(136, 9);
            this.TT.Name = "TT";
            this.TT.Size = new System.Drawing.Size(0, 13);
            this.TT.TabIndex = 22;
            // 
            // Cont
            // 
            this.Cont.AutoSize = true;
            this.Cont.Location = new System.Drawing.Point(106, 57);
            this.Cont.Name = "Cont";
            this.Cont.Size = new System.Drawing.Size(0, 13);
            this.Cont.TabIndex = 21;
            // 
            // STC_TiempoTotal
            // 
            this.STC_TiempoTotal.AutoSize = true;
            this.STC_TiempoTotal.Location = new System.Drawing.Point(13, 57);
            this.STC_TiempoTotal.Name = "STC_TiempoTotal";
            this.STC_TiempoTotal.Size = new System.Drawing.Size(75, 13);
            this.STC_TiempoTotal.TabIndex = 20;
            this.STC_TiempoTotal.Text = "Tiempo Total: ";
            // 
            // STC_TiempoRestante
            // 
            this.STC_TiempoRestante.AutoSize = true;
            this.STC_TiempoRestante.Location = new System.Drawing.Point(13, 32);
            this.STC_TiempoRestante.Name = "STC_TiempoRestante";
            this.STC_TiempoRestante.Size = new System.Drawing.Size(94, 13);
            this.STC_TiempoRestante.TabIndex = 19;
            this.STC_TiempoRestante.Text = "Tiempo Restante: ";
            // 
            // STC_TiempoTranscurrido
            // 
            this.STC_TiempoTranscurrido.AutoSize = true;
            this.STC_TiempoTranscurrido.Location = new System.Drawing.Point(12, 9);
            this.STC_TiempoTranscurrido.Name = "STC_TiempoTranscurrido";
            this.STC_TiempoTranscurrido.Size = new System.Drawing.Size(110, 13);
            this.STC_TiempoTranscurrido.TabIndex = 18;
            this.STC_TiempoTranscurrido.Text = "Tiempo Transcurrido: ";
            // 
            // STC_ProcesoEjecucion
            // 
            this.STC_ProcesoEjecucion.AutoSize = true;
            this.STC_ProcesoEjecucion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_ProcesoEjecucion.Location = new System.Drawing.Point(338, 149);
            this.STC_ProcesoEjecucion.Name = "STC_ProcesoEjecucion";
            this.STC_ProcesoEjecucion.Size = new System.Drawing.Size(172, 23);
            this.STC_ProcesoEjecucion.TabIndex = 25;
            this.STC_ProcesoEjecucion.Text = "Proceso en Ejecucion";
            // 
            // Ejecucion
            // 
            this.Ejecucion.AllowUserToAddRows = false;
            this.Ejecucion.AllowUserToDeleteRows = false;
            this.Ejecucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ejecucion.Location = new System.Drawing.Point(342, 175);
            this.Ejecucion.Name = "Ejecucion";
            this.Ejecucion.ReadOnly = true;
            this.Ejecucion.Size = new System.Drawing.Size(450, 356);
            this.Ejecucion.TabIndex = 24;
            // 
            // WIN_FIFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 562);
            this.Controls.Add(this.STC_ProcesoEjecucion);
            this.Controls.Add(this.Ejecucion);
            this.Controls.Add(this.TR);
            this.Controls.Add(this.TT);
            this.Controls.Add(this.Cont);
            this.Controls.Add(this.STC_TiempoTotal);
            this.Controls.Add(this.STC_TiempoRestante);
            this.Controls.Add(this.STC_TiempoTranscurrido);
            this.Name = "WIN_FIFO";
            this.Text = "FiFo";
            ((System.ComponentModel.ISupportInitialize)(this.Ejecucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Cronometro;
        private System.Windows.Forms.Label TR;
        private System.Windows.Forms.Label TT;
        private System.Windows.Forms.Label Cont;
        private System.Windows.Forms.Label STC_TiempoTotal;
        private System.Windows.Forms.Label STC_TiempoRestante;
        private System.Windows.Forms.Label STC_TiempoTranscurrido;
        private System.Windows.Forms.Label STC_ProcesoEjecucion;
        private System.Windows.Forms.DataGridView Ejecucion;
    }
}