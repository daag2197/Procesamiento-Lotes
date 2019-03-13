namespace Practica01
{
    partial class WIN_Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.STC_Titulo = new System.Windows.Forms.Label();
            this.STC_NumeroProcesos = new System.Windows.Forms.Label();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.EDT_NumeroProcesos = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.EDT_NumeroProcesos)).BeginInit();
            this.SuspendLayout();
            // 
            // STC_Titulo
            // 
            this.STC_Titulo.AutoSize = true;
            this.STC_Titulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Titulo.Location = new System.Drawing.Point(102, 13);
            this.STC_Titulo.Name = "STC_Titulo";
            this.STC_Titulo.Size = new System.Drawing.Size(81, 23);
            this.STC_Titulo.TabIndex = 3;
            this.STC_Titulo.Text = "Procesos";
            // 
            // STC_NumeroProcesos
            // 
            this.STC_NumeroProcesos.AutoSize = true;
            this.STC_NumeroProcesos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_NumeroProcesos.Location = new System.Drawing.Point(70, 98);
            this.STC_NumeroProcesos.Name = "STC_NumeroProcesos";
            this.STC_NumeroProcesos.Size = new System.Drawing.Size(162, 15);
            this.STC_NumeroProcesos.TabIndex = 0;
            this.STC_NumeroProcesos.Text = "Ingrese Numero de Procesos";
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Agregar.Location = new System.Drawing.Point(108, 146);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Agregar.TabIndex = 2;
            this.BTN_Agregar.Text = "Agregar Procesos";
            this.BTN_Agregar.UseVisualStyleBackColor = true;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // EDT_NumeroProcesos
            // 
            this.EDT_NumeroProcesos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_NumeroProcesos.Location = new System.Drawing.Point(73, 117);
            this.EDT_NumeroProcesos.Name = "EDT_NumeroProcesos";
            this.EDT_NumeroProcesos.Size = new System.Drawing.Size(159, 23);
            this.EDT_NumeroProcesos.TabIndex = 4;
            // 
            // WIN_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.EDT_NumeroProcesos);
            this.Controls.Add(this.STC_Titulo);
            this.Controls.Add(this.BTN_Agregar);
            this.Controls.Add(this.STC_NumeroProcesos);
            this.Name = "WIN_Inicio";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.EDT_NumeroProcesos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label STC_Titulo;
        private System.Windows.Forms.Label STC_NumeroProcesos;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.NumericUpDown EDT_NumeroProcesos;
    }
}

