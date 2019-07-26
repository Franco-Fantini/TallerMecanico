namespace TallerMecanico
{
    partial class Consulta_de_productos
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
            // Btselect
            // 
            this.Btselect.Click += new System.EventHandler(this.Btselect_Click);
            // 
            // btimprimir
            // 
            this.btimprimir.Enabled = false;
            this.btimprimir.Location = new System.Drawing.Point(99, 650);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.Text = "Producto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 32);
            // 
            // btmodificar
            // 
            this.btmodificar.Location = new System.Drawing.Point(191, 650);
            // 
            // bteliminar
            // 
            this.bteliminar.Location = new System.Drawing.Point(282, 650);
            // 
            // btobservaciones
            // 
            this.btobservaciones.Enabled = false;
            this.btobservaciones.Location = new System.Drawing.Point(1071, 695);
            this.btobservaciones.Visible = false;
            // 
            // Consulta_de_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 690);
            this.Name = "Consulta_de_productos";
            this.Text = "Consulta de productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Consulta_de_productos_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}