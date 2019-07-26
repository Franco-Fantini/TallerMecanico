namespace TallerMecanico
{
    partial class MantenimientoProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcodprod = new MiLibreria.ErrorTxtBox();
            this.tbdescripcion = new MiLibreria.ErrorTxtBox();
            this.tbprecio = new MiLibreria.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTConsultar
            // 
            this.BTConsultar.Location = new System.Drawing.Point(417, 76);
            this.BTConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.BTConsultar.Size = new System.Drawing.Size(93, 31);
            this.BTConsultar.Click += new System.EventHandler(this.BTConsultar_Click);
            // 
            // BTGuardar
            // 
            this.BTGuardar.Location = new System.Drawing.Point(417, 39);
            this.BTGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BTGuardar.Size = new System.Drawing.Size(93, 29);
            this.BTGuardar.Click += new System.EventHandler(this.BTGuardar_Click);
            // 
            // BTsalir
            // 
            this.BTsalir.Location = new System.Drawing.Point(417, 115);
            this.BTsalir.Margin = new System.Windows.Forms.Padding(4);
            this.BTsalir.Size = new System.Drawing.Size(93, 29);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Codigo de producto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(13, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descripcion";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(13, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Precio";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbcodprod
            // 
            this.tbcodprod.Location = new System.Drawing.Point(177, 41);
            this.tbcodprod.Name = "tbcodprod";
            this.tbcodprod.Size = new System.Drawing.Size(165, 24);
            this.tbcodprod.SoloNumeros = true;
            this.tbcodprod.TabIndex = 15;
            this.tbcodprod.Validar = true;
            this.tbcodprod.TextChanged += new System.EventHandler(this.Tbcodprod_TextChanged);
            // 
            // tbdescripcion
            // 
            this.tbdescripcion.Location = new System.Drawing.Point(177, 115);
            this.tbdescripcion.Name = "tbdescripcion";
            this.tbdescripcion.Size = new System.Drawing.Size(165, 24);
            this.tbdescripcion.SoloNumeros = false;
            this.tbdescripcion.TabIndex = 16;
            this.tbdescripcion.Validar = true;
            // 
            // tbprecio
            // 
            this.tbprecio.Location = new System.Drawing.Point(177, 188);
            this.tbprecio.Name = "tbprecio";
            this.tbprecio.Size = new System.Drawing.Size(165, 24);
            this.tbprecio.SoloNumeros = true;
            this.tbprecio.TabIndex = 17;
            this.tbprecio.Validar = true;
            // 
            // MantenimientoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 240);
            this.Controls.Add(this.tbprecio);
            this.Controls.Add(this.tbdescripcion);
            this.Controls.Add(this.tbcodprod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "MantenimientoProducto";
            this.Text = "Mantenimiento de Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.tbcodprod, 0);
            this.Controls.SetChildIndex(this.BTsalir, 0);
            this.Controls.SetChildIndex(this.BTConsultar, 0);
            this.Controls.SetChildIndex(this.BTGuardar, 0);
            this.Controls.SetChildIndex(this.tbdescripcion, 0);
            this.Controls.SetChildIndex(this.tbprecio, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MiLibreria.ErrorTxtBox tbcodprod;
        private MiLibreria.ErrorTxtBox tbdescripcion;
        private MiLibreria.ErrorTxtBox tbprecio;
    }
}