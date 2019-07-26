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
    public partial class Consultas : FormBase
    {
        public Consultas()
        {
            InitializeComponent();
        }
        // metodo para llenar el data grid view 
        public DataSet LlenarDataGV(string tabla)
        {
            DataSet DS;
            string cmd = string.Format("SELECT * FROM " + tabla);
            DS = Utilidades.Ejecutar(cmd);
            return DS;
        }

        private void Bteliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void Btmodificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void Btselect_Click(object sender, EventArgs e)
        {
            if (dg1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Btobservaciones_Click(object sender, EventArgs e)
        {
            Observar();
        }
    }
    }
    

