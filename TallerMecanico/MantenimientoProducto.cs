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

    public partial class MantenimientoProducto : Mantenimiento
    {
        public MantenimientoProducto()
        {
            InitializeComponent();
        }


        //codigo para guardar los articulos
        public override Boolean Guardar()
        {
           if (Utilidades.ValidarFormulario(this,errorProvider1) == false)
            {
                try
                {
                    string cmd = string.Format("EXEC ActualizaArticulos '{0}','{1}','{2}'", tbcodprod.Text.Trim(), tbdescripcion.Text.Trim(), tbprecio.Text.Trim());
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Se ha guardado correctamente los datos");
                    tbcodprod.Text = "";
                    tbdescripcion.Text = "";
                    tbprecio.Text = "";
                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("ha ocurrido un error : " + error.Message);
                    return false;
                }
            }
            else{ return false; }
        }

        private void Tbcodprod_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        public override void  Consultar()
        {
            Consulta_de_productos formconpro = new Consulta_de_productos
            {
                MdiParent = this.MdiParent
            };
            formconpro.Show();

        }

        private void BTConsultar_Click(object sender, EventArgs e)
        {

        }

        private void BTGuardar_Click(object sender, EventArgs e)
        {

        }


        //codigo para eliminar los articulos

    }

}
