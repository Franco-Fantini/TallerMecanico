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

    public partial class Consultar_Vehiculos_y_Clientes : Consultas
    {
        public Consultar_Vehiculos_y_Clientes()
        {
            InitializeComponent();
        }

        private void Consultar_Vehiculos_y_Clientes_Load(object sender, EventArgs e)
        {
            dg1.DataSource = LlenarDataGV("vehiculoclientes").Tables[0];
        }

        private void BTBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;
                    string cmd = "Select * From vehiculoclientes Where nombre LIKE '%" + textBox1.Text.Trim() + "%'";
                    ds = Utilidades.Ejecutar(cmd);

                    dg1.DataSource = ds.Tables[0];

                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                }
                try
                {
                    DataSet ds;
                    string cmd = "Select * From vehiculoclientes Where patente LIKE '%" + textBox1.Text.Trim() + "%'";
                    ds = Utilidades.Ejecutar(cmd);
                    dg1.DataSource = ds.Tables[0];

                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                }
            }
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
            Mantvehicliente formMantvehicliente = new Mantvehicliente
            {
                MdiParent = this.MdiParent
            };
            formMantvehicliente.Show();
        }

        public override void Eliminar()
        {
            if (MessageBox.Show("Desea eliminar este cliente del programa?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    string key = Convert.ToString(dg1.CurrentRow.Cells["patente"].Value);
                    string cmd = string.Format("EXEC eliminavehiculoclientes '{0}'", key);
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Se han eliminado correctamente los datos");
                    dg1.DataSource = LlenarDataGV("vehiculoclientes").Tables[0];

                }
                catch (Exception error)
                {
                    MessageBox.Show("ha ocurrido un error : " + error.Message);
                }

            }

        }
        public override void Observar()
        {
           obper = dg1.CurrentRow.Cells["observacioncliente"].Value.ToString();
           obau = dg1.CurrentRow.Cells["observacionvehiculos"].Value.ToString();
            Observaciones formob = new Observaciones();
            formob.Show();

        }

      
    }
}
