namespace TallerMecanico
{
    partial class VentanaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaUsuario));
            this.lblcodeuser = new System.Windows.Forms.Label();
            this.lbluseruser = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BTCprincipal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LBLnomuser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PBPerfil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // BTsalir
            // 
            this.BTsalir.Location = new System.Drawing.Point(246, 82);
            this.BTsalir.Size = new System.Drawing.Size(117, 24);
            // 
            // lblcodeuser
            // 
            this.lblcodeuser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcodeuser.Location = new System.Drawing.Point(98, 136);
            this.lblcodeuser.Name = "lblcodeuser";
            this.lblcodeuser.Size = new System.Drawing.Size(98, 21);
            this.lblcodeuser.TabIndex = 29;
            this.lblcodeuser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbluseruser
            // 
            this.lbluseruser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbluseruser.Location = new System.Drawing.Point(98, 80);
            this.lbluseruser.Name = "lbluseruser";
            this.lbluseruser.Size = new System.Drawing.Size(98, 21);
            this.lbluseruser.TabIndex = 28;
            this.lbluseruser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(246, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 25);
            this.button2.TabIndex = 23;
            this.button2.Text = "Cambiar Contraseña";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BTCprincipal
            // 
            this.BTCprincipal.Location = new System.Drawing.Point(246, 18);
            this.BTCprincipal.Name = "BTCprincipal";
            this.BTCprincipal.Size = new System.Drawing.Size(117, 23);
            this.BTCprincipal.TabIndex = 22;
            this.BTCprincipal.Text = "Contenedor Principal";
            this.BTCprincipal.UseVisualStyleBackColor = true;
            this.BTCprincipal.Click += new System.EventHandler(this.BTCprincipal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Código :";
            // 
            // LBLnomuser
            // 
            this.LBLnomuser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBLnomuser.Location = new System.Drawing.Point(98, 27);
            this.LBLnomuser.Name = "LBLnomuser";
            this.LBLnomuser.Size = new System.Drawing.Size(98, 21);
            this.LBLnomuser.TabIndex = 20;
            this.LBLnomuser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Usuario : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre :";
            // 
            // PBPerfil
            // 
            this.PBPerfil.BackColor = System.Drawing.SystemColors.Control;
            this.PBPerfil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBPerfil.InitialImage = ((System.Drawing.Image)(resources.GetObject("PBPerfil.InitialImage")));
            this.PBPerfil.Location = new System.Drawing.Point(19, 184);
            this.PBPerfil.Name = "PBPerfil";
            this.PBPerfil.Size = new System.Drawing.Size(153, 162);
            this.PBPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBPerfil.TabIndex = 27;
            this.PBPerfil.TabStop = false;
            // 
            // VentanaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(397, 358);
            this.Controls.Add(this.lblcodeuser);
            this.Controls.Add(this.lbluseruser);
            this.Controls.Add(this.PBPerfil);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTCprincipal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LBLnomuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaUsuario";
            this.Text = "Panel de usuario";
            this.Load += new System.EventHandler(this.VentanaUsuario_Load_1);
            this.Controls.SetChildIndex(this.BTsalir, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.LBLnomuser, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.BTCprincipal, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.PBPerfil, 0);
            this.Controls.SetChildIndex(this.lbluseruser, 0);
            this.Controls.SetChildIndex(this.lblcodeuser, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PBPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodeuser;
        private System.Windows.Forms.Label lbluseruser;
        private System.Windows.Forms.PictureBox PBPerfil;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTCprincipal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBLnomuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}