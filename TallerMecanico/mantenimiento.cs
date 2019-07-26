using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;
namespace TallerMecanico
{
    public partial class Mantenimiento : FormBase
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

      
        private void BTGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void BTConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}
