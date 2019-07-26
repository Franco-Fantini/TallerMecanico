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
    public partial class Consulta_de_productos : Consultas
    {
        public Consulta_de_productos()
        {
            InitializeComponent();
        }

        
        private void BTBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;
                    string cmd = "Select * From Article Where id_articulo LIKE '%" + textBox1.Text.Trim() + "%'";
                    ds = Utilidades.Ejecutar(cmd);

                    dg1.DataSource = ds.Tables[0];

                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                }
            }        
        }


            private void Consulta_de_productos_Load(object sender, EventArgs e)
        {
            dg1.DataSource = LlenarDataGV("Article").Tables[0];
        }

        private void Consulta_de_productos_Load_1(object sender, EventArgs e)
        {
            dg1.DataSource = LlenarDataGV("Article").Tables[0];
        }

        public override void Seleccionar()
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
        public override void Modificar()
        {
            MantenimientoProducto formPro = new MantenimientoProducto
            {
                MdiParent = this.MdiParent
            };
            formPro.Show();
            
        }


        public override void Eliminar()
        {
            if (MessageBox.Show("Desea eliminar este cliente del programa?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    string key = Convert.ToString(dg1.CurrentRow.Cells["id_articulo"].Value);
                    string cmd = string.Format("EXEC EliminarArticulos '{0}'", key);
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Se han eliminado correctamente los datos");
                    dg1.DataSource = LlenarDataGV("Article").Tables[0];

                }
                catch (Exception error)
                {
                    MessageBox.Show("ha ocurrido un error : " + error.Message);
                }
            }
        }

        private void Btselect_Click(object sender, EventArgs e)
        {

        }

  
    }
}
