namespace TallerMecanico
{
    partial class Mantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenimiento));
            this.BTConsultar = new System.Windows.Forms.Button();
            this.BTGuardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTsalir
            // 
            this.BTsalir.Location = new System.Drawing.Point(38, 96);
            this.BTsalir.Size = new System.Drawing.Size(113, 29);
            // 
            // BTConsultar
            // 
            this.BTConsultar.Location = new System.Drawing.Point(38, 26);
            this.BTConsultar.Name = "BTConsultar";
            this.BTConsultar.Size = new System.Drawing.Size(113, 29);
            this.BTConsultar.TabIndex = 2;
            this.BTConsultar.Text = "Consultar";
            this.BTConsultar.UseVisualStyleBackColor = true;
            this.BTConsultar.Click += new System.EventHandler(this.BTConsultar_Click);
            // 
            // BTGuardar
            // 
            this.BTGuardar.Location = new System.Drawing.Point(38, 61);
            this.BTGuardar.Name = "BTGuardar";
            this.BTGuardar.Size = new System.Drawing.Size(113, 29);
            this.BTGuardar.TabIndex = 3;
            this.BTGuardar.Text = "Guardar";
            this.BTGuardar.UseVisualStyleBackColor = true;
            this.BTGuardar.Click += new System.EventHandler(this.BTGuardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 215);
            this.Controls.Add(this.BTGuardar);
            this.Controls.Add(this.BTConsultar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mantenimiento";
            this.Text = "mantenimiento";
            this.Controls.SetChildIndex(this.BTsalir, 0);
            this.Controls.SetChildIndex(this.BTConsultar, 0);
            this.Controls.SetChildIndex(this.BTGuardar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button BTConsultar;
        public System.Windows.Forms.Button BTGuardar;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}