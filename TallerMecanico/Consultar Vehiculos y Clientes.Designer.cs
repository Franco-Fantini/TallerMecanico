namespace TallerMecanico
{
    partial class Consultar_Vehiculos_y_Clientes
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
            this.SuspendLayout();
            // 
            // btimprimir
            // 
            this.btimprimir.Enabled = false;
            // 
            // BTBuscar
            // 
            this.BTBuscar.Location = new System.Drawing.Point(258, 31);
            this.BTBuscar.Click += new System.EventHandler(this.BTBuscar_Click);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.Text = "Nombre o Patente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 31);
            // 
            // Consultar_Vehiculos_y_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 699);
            this.Name = "Consultar_Vehiculos_y_Clientes";
            this.Text = "Consulta de Vehiculos - Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Consultar_Vehiculos_y_Clientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}