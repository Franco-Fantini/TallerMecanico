﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerMecanico
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.DatosFactura' Puede moverla o quitarla según sea necesario.
           // this.DatosFacturaTableAdapter.Fill(this.DataSet1.DatosFactura);

            this.reportViewer1.RefreshReport();
        }
    }
}