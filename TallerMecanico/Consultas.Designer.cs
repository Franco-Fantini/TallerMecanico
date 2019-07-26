namespace TallerMecanico
{
    partial class Consultas
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
            this.Btselect = new System.Windows.Forms.Button();
            this.btimprimir = new System.Windows.Forms.Button();
            this.BTBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.btmodificar = new System.Windows.Forms.Button();
            this.bteliminar = new System.Windows.Forms.Button();
            this.btobservaciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTsalir
            // 
            this.BTsalir.Location = new System.Drawing.Point(1283, 650);
            // 
            // Btselect
            // 
            this.Btselect.Location = new System.Drawing.Point(3, 650);
            this.Btselect.Name = "Btselect";
            this.Btselect.Size = new System.Drawing.Size(75, 23);
            this.Btselect.TabIndex = 2;
            this.Btselect.Text = "Seleccionar";
            this.Btselect.UseVisualStyleBackColor = true;
            this.Btselect.Click += new System.EventHandler(this.Btselect_Click);
            // 
            // btimprimir
            // 
            this.btimprimir.Location = new System.Drawing.Point(197, 650);
            this.btimprimir.Name = "btimprimir";
            this.btimprimir.Size = new System.Drawing.Size(75, 23);
            this.btimprimir.TabIndex = 3;
            this.btimprimir.Text = "Imprimir";
            this.btimprimir.UseVisualStyleBackColor = true;
            // 
            // BTBuscar
            // 
            this.BTBuscar.Location = new System.Drawing.Point(231, 30);
            this.BTBuscar.Name = "BTBuscar";
            this.BTBuscar.Size = new System.Drawing.Size(75, 23);
            this.BTBuscar.TabIndex = 4;
            this.BTBuscar.Text = "Buscar";
            this.BTBuscar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 6;
            // 
            // dg1
            // 
            this.dg1.AllowUserToAddRows = false;
            this.dg1.AllowUserToDeleteRows = false;
            this.dg1.AllowUserToOrderColumns = true;
            this.dg1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Location = new System.Drawing.Point(3, 76);
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.RowHeadersVisible = false;
            this.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg1.Size = new System.Drawing.Size(1368, 568);
            this.dg1.TabIndex = 7;  
            // 
            // btmodificar
            // 
            this.btmodificar.Location = new System.Drawing.Point(289, 650);
            this.btmodificar.Name = "btmodificar";
            this.btmodificar.Size = new System.Drawing.Size(75, 23);
            this.btmodificar.TabIndex = 8;
            this.btmodificar.Text = "Modificar";
            this.btmodificar.UseVisualStyleBackColor = true;
            this.btmodificar.Click += new System.EventHandler(this.Btmodificar_Click);
            // 
            // bteliminar
            // 
            this.bteliminar.Location = new System.Drawing.Point(380, 650);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(75, 23);
            this.bteliminar.TabIndex = 9;
            this.bteliminar.Text = "Eliminar";
            this.bteliminar.UseVisualStyleBackColor = true;
            this.bteliminar.Click += new System.EventHandler(this.Bteliminar_Click);
            // 
            // btobservaciones
            // 
            this.btobservaciones.Location = new System.Drawing.Point(95, 650);
            this.btobservaciones.Name = "btobservaciones";
            this.btobservaciones.Size = new System.Drawing.Size(86, 23);
            this.btobservaciones.TabIndex = 10;
            this.btobservaciones.Text = "Observaciones";
            this.btobservaciones.UseVisualStyleBackColor = true;
            this.btobservaciones.Click += new System.EventHandler(this.Btobservaciones_Click);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 685);
            this.Controls.Add(this.btobservaciones);
            this.Controls.Add(this.bteliminar);
            this.Controls.Add(this.btmodificar);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTBuscar);
            this.Controls.Add(this.btimprimir);
            this.Controls.Add(this.Btselect);
            this.Name = "Consultas";
            this.Text = "  Consulta ";
            this.Controls.SetChildIndex(this.BTsalir, 0);
            this.Controls.SetChildIndex(this.Btselect, 0);
            this.Controls.SetChildIndex(this.btimprimir, 0);
            this.Controls.SetChildIndex(this.BTBuscar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.dg1, 0);
            this.Controls.SetChildIndex(this.btmodificar, 0);
            this.Controls.SetChildIndex(this.bteliminar, 0);
            this.Controls.SetChildIndex(this.btobservaciones, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dg1;
        public System.Windows.Forms.Button Btselect;
        public System.Windows.Forms.Button btimprimir;
        public System.Windows.Forms.Button BTBuscar;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btmodificar;
        public System.Windows.Forms.Button bteliminar;
        public System.Windows.Forms.Button btobservaciones;
    }
}