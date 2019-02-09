namespace Practica01
{
    partial class AgregarProceso
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
            this.STC_Titulo = new System.Windows.Forms.Label();
            this.BTN_AgregarProceso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // STC_Titulo
            // 
            this.STC_Titulo.AutoSize = true;
            this.STC_Titulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Titulo.Location = new System.Drawing.Point(127, 9);
            this.STC_Titulo.Name = "STC_Titulo";
            this.STC_Titulo.Size = new System.Drawing.Size(180, 29);
            this.STC_Titulo.TabIndex = 1;
            this.STC_Titulo.Text = "Agregar Procesos";
            // 
            // BTN_AgregarProceso
            // 
            this.BTN_AgregarProceso.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AgregarProceso.Location = new System.Drawing.Point(132, 71);
            this.BTN_AgregarProceso.Name = "BTN_AgregarProceso";
            this.BTN_AgregarProceso.Size = new System.Drawing.Size(167, 47);
            this.BTN_AgregarProceso.TabIndex = 3;
            this.BTN_AgregarProceso.Text = "Agregar Proceso";
            this.BTN_AgregarProceso.UseVisualStyleBackColor = true;
            this.BTN_AgregarProceso.Click += new System.EventHandler(this.BTN_AgregarProceso_Click);
            // 
            // AgregarProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 130);
            this.Controls.Add(this.BTN_AgregarProceso);
            this.Controls.Add(this.STC_Titulo);
            this.Name = "AgregarProceso";
            this.Text = "AgregarProceso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label STC_Titulo;
        private System.Windows.Forms.Button BTN_AgregarProceso;
    }
}