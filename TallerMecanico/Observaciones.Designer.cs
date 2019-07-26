namespace TallerMecanico
{
    partial class Observaciones
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
            this.rtpersona = new System.Windows.Forms.RichTextBox();
            this.rtauto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BTsalir
            // 
            this.BTsalir.Location = new System.Drawing.Point(406, 488);
            // 
            // rtpersona
            // 
            this.rtpersona.Location = new System.Drawing.Point(35, 22);
            this.rtpersona.Name = "rtpersona";
            this.rtpersona.Size = new System.Drawing.Size(446, 209);
            this.rtpersona.TabIndex = 0;
            this.rtpersona.Text = "";
            // 
            // rtauto
            // 
            this.rtauto.Location = new System.Drawing.Point(35, 274);
            this.rtauto.Name = "rtauto";
            this.rtauto.Size = new System.Drawing.Size(446, 192);
            this.rtauto.TabIndex = 1;
            this.rtauto.Text = "";
            // 
            // Observaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 530);
            this.Controls.Add(this.rtauto);
            this.Controls.Add(this.rtpersona);
            this.Name = "Observaciones";
            this.Text = "Observaciones";
            this.Load += new System.EventHandler(this.Observaciones_Load);
            this.Controls.SetChildIndex(this.rtpersona, 0);
            this.Controls.SetChildIndex(this.rtauto, 0);
            this.Controls.SetChildIndex(this.BTsalir, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtpersona;
        private System.Windows.Forms.RichTextBox rtauto;
    }
}