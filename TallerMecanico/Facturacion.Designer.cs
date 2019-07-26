namespace TallerMecanico
{
    partial class Facturacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btcolocar = new System.Windows.Forms.Button();
            this.bteliminar = new System.Windows.Forms.Button();
            this.btclientes = new System.Windows.Forms.Button();
            this.btproductos = new System.Windows.Forms.Button();
            this.btnuevo = new System.Windows.Forms.Button();
            this.btfacturar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btbuscar = new System.Windows.Forms.Button();
            this.lblatiende = new System.Windows.Forms.Label();
            this.txtcodigocli = new MiLibreria.ErrorTxtBox();
            this.txtcliente = new MiLibreria.ErrorTxtBox();
            this.txtcodigoproducto = new MiLibreria.ErrorTxtBox();
            this.txtdescripcion = new MiLibreria.ErrorTxtBox();
            this.txtprecio = new MiLibreria.ErrorTxtBox();
            this.txtcantidad = new MiLibreria.ErrorTxtBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTsalir
            // 
            this.BTsalir.Location = new System.Drawing.Point(712, 441);
            this.BTsalir.Size = new System.Drawing.Size(92, 20);
            // 
            // btcolocar
            // 
            this.btcolocar.Location = new System.Drawing.Point(596, 207);
            this.btcolocar.Name = "btcolocar";
            this.btcolocar.Size = new System.Drawing.Size(87, 20);
            this.btcolocar.TabIndex = 2;
            this.btcolocar.Text = "+";
            this.btcolocar.UseVisualStyleBackColor = true;
            this.btcolocar.Click += new System.EventHandler(this.Btcolocar_Click);
            // 
            // bteliminar
            // 
            this.bteliminar.Location = new System.Drawing.Point(712, 252);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(92, 20);
            this.bteliminar.TabIndex = 3;
            this.bteliminar.Text = "Eliminar";
            this.bteliminar.UseVisualStyleBackColor = true;
            this.bteliminar.Click += new System.EventHandler(this.Bteliminar_Click);
            // 
            // btclientes
            // 
            this.btclientes.Location = new System.Drawing.Point(712, 345);
            this.btclientes.Name = "btclientes";
            this.btclientes.Size = new System.Drawing.Size(92, 20);
            this.btclientes.TabIndex = 4;
            this.btclientes.Text = "Clientes";
            this.btclientes.UseVisualStyleBackColor = true;
            this.btclientes.Click += new System.EventHandler(this.Btclientes_Click);
            // 
            // btproductos
            // 
            this.btproductos.Location = new System.Drawing.Point(712, 392);
            this.btproductos.Name = "btproductos";
            this.btproductos.Size = new System.Drawing.Size(92, 20);
            this.btproductos.TabIndex = 5;
            this.btproductos.Text = "Productos";
            this.btproductos.UseVisualStyleBackColor = true;
            this.btproductos.Click += new System.EventHandler(this.Btproductos_Click);
            // 
            // btnuevo
            // 
            this.btnuevo.Location = new System.Drawing.Point(712, 208);
            this.btnuevo.Name = "btnuevo";
            this.btnuevo.Size = new System.Drawing.Size(92, 20);
            this.btnuevo.TabIndex = 6;
            this.btnuevo.Text = "Nuevo";
            this.btnuevo.UseVisualStyleBackColor = true;
            this.btnuevo.Click += new System.EventHandler(this.Btnuevo_Click);
            // 
            // btfacturar
            // 
            this.btfacturar.Location = new System.Drawing.Point(712, 297);
            this.btfacturar.Name = "btfacturar";
            this.btfacturar.Size = new System.Drawing.Size(92, 21);
            this.btfacturar.TabIndex = 7;
            this.btfacturar.Text = "Facturar";
            this.btfacturar.UseVisualStyleBackColor = true;
            this.btfacturar.Click += new System.EventHandler(this.Btfacturar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Atendido por : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Patente : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cliente : ";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(153, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descripción";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(26, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Código";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(471, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cantidad";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(339, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Precio";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(580, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Importe";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dg1
            // 
            this.dg1.AllowUserToAddRows = false;
            this.dg1.AllowUserToDeleteRows = false;
            this.dg1.AllowUserToResizeColumns = false;
            this.dg1.AllowUserToResizeRows = false;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.ColumnHeadersVisible = false;
            this.dg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColDescripcion,
            this.ColPrecio,
            this.ColCantidad,
            this.ColImporte});
            this.dg1.Location = new System.Drawing.Point(26, 252);
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dg1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg1.Size = new System.Drawing.Size(657, 384);
            this.dg1.TabIndex = 16;
            // 
            // ColCodigo
            // 
            this.ColCodigo.HeaderText = "Codigo";
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            this.ColCodigo.Width = 140;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.HeaderText = "Descripcion";
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            this.ColDescripcion.Width = 170;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            this.ColPrecio.Width = 140;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            this.ColCantidad.Width = 110;
            // 
            // ColImporte
            // 
            this.ColImporte.HeaderText = "Importe";
            this.ColImporte.Name = "ColImporte";
            this.ColImporte.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::TallerMecanico.Properties.Resources.IMG_20190718_131220;
            this.pictureBox1.Location = new System.Drawing.Point(505, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 132);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(526, 647);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 18);
            this.label9.TabIndex = 25;
            this.label9.Text = "Total : ";
            // 
            // lbltotal
            // 
            this.lbltotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(593, 647);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(90, 26);
            this.lbltotal.TabIndex = 26;
            this.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btbuscar
            // 
            this.btbuscar.Location = new System.Drawing.Point(269, 92);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(65, 23);
            this.btbuscar.TabIndex = 2;
            this.btbuscar.Text = "Buscar";
            this.btbuscar.UseVisualStyleBackColor = true;
            this.btbuscar.Click += new System.EventHandler(this.Btbuscar_Click);
            // 
            // lblatiende
            // 
            this.lblatiende.BackColor = System.Drawing.SystemColors.Control;
            this.lblatiende.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblatiende.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblatiende.Location = new System.Drawing.Point(137, 41);
            this.lblatiende.Name = "lblatiende";
            this.lblatiende.Size = new System.Drawing.Size(197, 25);
            this.lblatiende.TabIndex = 28;
            // 
            // txtcodigocli
            // 
            this.txtcodigocli.Location = new System.Drawing.Point(137, 95);
            this.txtcodigocli.Name = "txtcodigocli";
            this.txtcodigocli.Size = new System.Drawing.Size(118, 20);
            this.txtcodigocli.SoloNumeros = false;
            this.txtcodigocli.TabIndex = 1;
            this.txtcodigocli.Validar = true;
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(137, 148);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(197, 20);
            this.txtcliente.SoloNumeros = false;
            this.txtcliente.TabIndex = 30;
            this.txtcliente.Validar = true;
            // 
            // txtcodigoproducto
            // 
            this.txtcodigoproducto.Location = new System.Drawing.Point(41, 208);
            this.txtcodigoproducto.Name = "txtcodigoproducto";
            this.txtcodigoproducto.Size = new System.Drawing.Size(100, 20);
            this.txtcodigoproducto.SoloNumeros = false;
            this.txtcodigoproducto.TabIndex = 31;
            this.txtcodigoproducto.Validar = true;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(174, 208);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(140, 20);
            this.txtdescripcion.SoloNumeros = false;
            this.txtdescripcion.TabIndex = 32;
            this.txtdescripcion.Validar = true;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(354, 208);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.SoloNumeros = false;
            this.txtprecio.TabIndex = 33;
            this.txtprecio.Validar = true;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(474, 208);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.SoloNumeros = false;
            this.txtcantidad.TabIndex = 34;
            this.txtcantidad.Validar = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 686);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtcodigoproducto);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.txtcodigocli);
            this.Controls.Add(this.lblatiende);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btfacturar);
            this.Controls.Add(this.btnuevo);
            this.Controls.Add(this.btproductos);
            this.Controls.Add(this.btclientes);
            this.Controls.Add(this.bteliminar);
            this.Controls.Add(this.btcolocar);
            this.Controls.Add(this.dg1);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.Controls.SetChildIndex(this.dg1, 0);
            this.Controls.SetChildIndex(this.BTsalir, 0);
            this.Controls.SetChildIndex(this.btcolocar, 0);
            this.Controls.SetChildIndex(this.bteliminar, 0);
            this.Controls.SetChildIndex(this.btclientes, 0);
            this.Controls.SetChildIndex(this.btproductos, 0);
            this.Controls.SetChildIndex(this.btnuevo, 0);
            this.Controls.SetChildIndex(this.btfacturar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.lbltotal, 0);
            this.Controls.SetChildIndex(this.btbuscar, 0);
            this.Controls.SetChildIndex(this.lblatiende, 0);
            this.Controls.SetChildIndex(this.txtcodigocli, 0);
            this.Controls.SetChildIndex(this.txtcliente, 0);
            this.Controls.SetChildIndex(this.txtcodigoproducto, 0);
            this.Controls.SetChildIndex(this.txtdescripcion, 0);
            this.Controls.SetChildIndex(this.txtprecio, 0);
            this.Controls.SetChildIndex(this.txtcantidad, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcolocar;
        private System.Windows.Forms.Button bteliminar;
        private System.Windows.Forms.Button btclientes;
        private System.Windows.Forms.Button btproductos;
        private System.Windows.Forms.Button btnuevo;
        private System.Windows.Forms.Button btfacturar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btbuscar;
        private System.Windows.Forms.Label lblatiende;
        private MiLibreria.ErrorTxtBox txtcodigocli;
        private MiLibreria.ErrorTxtBox txtcliente;
        private MiLibreria.ErrorTxtBox txtcodigoproducto;
        private MiLibreria.ErrorTxtBox txtdescripcion;
        private MiLibreria.ErrorTxtBox txtprecio;
        private MiLibreria.ErrorTxtBox txtcantidad;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImporte;
    }
}