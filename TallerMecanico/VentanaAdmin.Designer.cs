namespace TallerMecanico
{
    partial class VentanaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBLnomadm = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTCprincipal = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.LBLusadmin = new System.Windows.Forms.Label();
            this.lblCodadm = new System.Windows.Forms.Label();
            this.PBAdmin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // BTsalir
            // 
            this.BTsalir.Location = new System.Drawing.Point(268, 119);
            this.BTsalir.Size = new System.Drawing.Size(117, 23);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario : ";
            // 
            // LBLnomadm
            // 
            this.LBLnomadm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBLnomadm.Location = new System.Drawing.Point(97, 28);
            this.LBLnomadm.Name = "LBLnomadm";
            this.LBLnomadm.Size = new System.Drawing.Size(98, 21);
            this.LBLnomadm.TabIndex = 2;
            this.LBLnomadm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Código :";
            // 
            // BTCprincipal
            // 
            this.BTCprincipal.Location = new System.Drawing.Point(268, 28);
            this.BTCprincipal.Name = "BTCprincipal";
            this.BTCprincipal.Size = new System.Drawing.Size(117, 23);
            this.BTCprincipal.TabIndex = 6;
            this.BTCprincipal.Text = "Contenedor Principal";
            this.BTCprincipal.UseVisualStyleBackColor = true;
            this.BTCprincipal.Click += new System.EventHandler(this.BTCprincipal_Click_1);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(268, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 25);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cambiar Contraseña";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(268, 57);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 25);
            this.button5.TabIndex = 14;
            this.button5.Text = "Administrar Usuarios";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // LBLusadmin
            // 
            this.LBLusadmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBLusadmin.Location = new System.Drawing.Point(97, 83);
            this.LBLusadmin.Name = "LBLusadmin";
            this.LBLusadmin.Size = new System.Drawing.Size(98, 21);
            this.LBLusadmin.TabIndex = 16;
            this.LBLusadmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodadm
            // 
            this.lblCodadm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodadm.Location = new System.Drawing.Point(97, 142);
            this.lblCodadm.Name = "lblCodadm";
            this.lblCodadm.Size = new System.Drawing.Size(98, 21);
            this.lblCodadm.TabIndex = 17;
            this.lblCodadm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBAdmin
            // 
            this.PBAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBAdmin.Location = new System.Drawing.Point(19, 184);
            this.PBAdmin.Name = "PBAdmin";
            this.PBAdmin.Size = new System.Drawing.Size(176, 162);
            this.PBAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBAdmin.TabIndex = 15;
            this.PBAdmin.TabStop = false;
            // 
            // VentanaAdmin
            // 
            this.AcceptButton = this.BTCprincipal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 358);
            this.Controls.Add(this.lblCodadm);
            this.Controls.Add(this.LBLusadmin);
            this.Controls.Add(this.PBAdmin);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTCprincipal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LBLnomadm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaAdmin";
            this.Text = "Panel de administrador";
            this.Load += new System.EventHandler(this.VentanaAdmin_Load_1);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.LBLnomadm, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.BTCprincipal, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.PBAdmin, 0);
            this.Controls.SetChildIndex(this.LBLusadmin, 0);
            this.Controls.SetChildIndex(this.lblCodadm, 0);
            this.Controls.SetChildIndex(this.BTsalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PBAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBLnomadm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTCprincipal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox PBAdmin;
        private System.Windows.Forms.Label LBLusadmin;
        private System.Windows.Forms.Label lblCodadm;
    }
}