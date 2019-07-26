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
    public partial class Facturacion : FormBase
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        //cargar el nombre del usuario que esta efectuando la venta
        private void Facturacion_Load(object sender, EventArgs e)
        {
            string cmd = "Select * from Usuarios Where id_user=" + VentanaLogin.codigo;
            DataSet ds;
            ds = Utilidades.Ejecutar(cmd);
            lblatiende.Text = ds.Tables[0].Rows[0]["name"].ToString() + " " + ds.Tables[0].Rows[0]["surname"].ToString();
        }
      
        // Buscar clientes 
        private void Btbuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcodigocli.Text.Trim()) == false)
            {

                try
                {
                    string cmd = string.Format("Select nombre FROM vehiculoclientes where patente='{0}'", txtcodigocli.Text.Trim());
                    DataSet ds = Utilidades.Ejecutar(cmd);
                    txtcliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString().Trim();
                    txtcodigoproducto.Focus();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido el siguiente error : " + error);
                }
            }
        }

        //variable para contar las filas para la sumatoria del total
        public static int cont_fila = 0;

        //variable para el total del importe
        public static double total;

        // colocar todo los datos para efectuar la facturacion
        private void Btcolocar_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                bool existe = false;
                int num_fila = 0;

                if (cont_fila == 0)
                {
                    dg1.Rows.Add(txtcodigoproducto.Text, txtdescripcion.Text, txtprecio.Text, txtcantidad.Text);
                    double importe = Convert.ToDouble(dg1.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dg1.Rows[cont_fila].Cells[3].Value);
                    dg1.Rows[cont_fila].Cells[4].Value = importe;
                    cont_fila++;
                }
                else
                {
                    foreach (DataGridViewRow Fila in dg1.Rows)
                    {
                        if (Fila.Cells[0].Value.ToString() == txtcodigoproducto.Text)
                        {
                            existe = true;
                            num_fila = Fila.Index;
                        }
                    }
                    if (existe == true)
                    {
                        dg1.Rows[num_fila].Cells[3].Value = (Convert.ToDouble(txtcantidad.Text) + Convert.ToDouble(dg1.Rows[num_fila].Cells[3].Value)).ToString();
                        double importe = Convert.ToDouble(dg1.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(dg1.Rows[num_fila].Cells[3].Value);
                        dg1.Rows[num_fila].Cells[4].Value = importe;
                    }
                    else
                    {
                        dg1.Rows.Add(txtcodigoproducto.Text, txtdescripcion.Text, txtprecio.Text, txtcantidad.Text);
                        double importe = Convert.ToDouble(dg1.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dg1.Rows[cont_fila].Cells[3].Value);
                        dg1.Rows[cont_fila].Cells[4].Value = importe;
                        cont_fila++;
                    }

                }

                total = 0;

                foreach (DataGridViewRow Fila in dg1.Rows)
                {
                    total += Convert.ToDouble(Fila.Cells[4].Value);

                }
                lbltotal.Text = "$" + total.ToString();
            }
        }

        //eliminar una fila de producto seleccionada
        private void Bteliminar_Click(object sender, EventArgs e)
        {
            if (cont_fila > 0)
            {
                total = total - (Convert.ToDouble(dg1.Rows[dg1.CurrentRow.Index].Cells[4].Value));
                lbltotal.Text = "$" + total.ToString();
                dg1.Rows.RemoveAt(dg1.CurrentRow.Index);
                cont_fila--;

            }
        }

        //seleccion de clientes a traves del formulario de clientes
        private void Btclientes_Click(object sender, EventArgs e)
        {
            Consultar_Vehiculos_y_Clientes formconcli = new Consultar_Vehiculos_y_Clientes();
            MdiParent = this.MdiParent;
            formconcli.ShowDialog();
            if (formconcli.DialogResult == DialogResult.OK)
            {
                txtcodigocli.Text = formconcli.dg1.Rows[formconcli.dg1.CurrentRow.Index].Cells[0].Value.ToString();
                txtcliente.Text = formconcli.dg1.Rows[formconcli.dg1.CurrentRow.Index].Cells[1].Value.ToString();
                txtcodigoproducto.Focus();

            }
        }

        //seleccion de clientes a traves del formulario de productos
        private void Btproductos_Click(object sender, EventArgs e)
        {
            Consulta_de_productos formconpro = new Consulta_de_productos();
            MdiParent = this.MdiParent;
            formconpro.ShowDialog();
            if (formconpro.DialogResult == DialogResult.OK)
            {
                txtcodigoproducto.Text = formconpro.dg1.Rows[formconpro.dg1.CurrentRow.Index].Cells[0].Value.ToString();
                txtdescripcion.Text = formconpro.dg1.Rows[formconpro.dg1.CurrentRow.Index].Cells[1].Value.ToString();
                txtprecio.Text = formconpro.dg1.Rows[formconpro.dg1.CurrentRow.Index].Cells[2].Value.ToString();
                txtcantidad.Focus();

            }
        }
        // Borrar todo para una nueva factura
        private void Btnuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        // Borrar todo para una nueva factura
        public override void Nuevo()
        {
            txtcodigocli.Text = "";
            txtcliente.Text = "";
            txtcodigoproducto.Text = "";
            txtdescripcion.Text = "";
            txtprecio.Text = "";
            txtcantidad.Text = "";
            lbltotal.Text = "";
            dg1.Rows.Clear();
            cont_fila = 0;
            total = 0;
            txtcodigocli.Focus();
        }

        //boton para facturar todo los datos cargados
        private void Btfacturar_Click(object sender, EventArgs e)
        {
            if(cont_fila != 0)
            {
                try
                {
                    string cmd = string.Format("Exec ActualizaFacturas '{0}'", txtcodigocli.Text.Trim());

                    DataSet ds = Utilidades.Ejecutar(cmd);

                    string Numfac = ds.Tables[0].Rows[0]["NumFac"].ToString().Trim();

                    foreach (DataGridViewRow Fila in dg1.Rows)
                    { cmd = string.Format("Exec ActualizaDetalles '{0}','{1}','{2}','{3}'", Numfac, Fila.Cells[0].Value.ToString(), Fila.Cells[2].Value, Fila.Cells[3].Value);
                      ds = Utilidades.Ejecutar(cmd);   
                    }
                  
                    cmd = "Exec DatosFactura " + Numfac;

                    ds = Utilidades.Ejecutar(cmd);

                    //ventana reporte
                    Reporte rp = new Reporte();
                    rp.reportViewer1.LocalReport.DataSources[0].Value = ds.Tables[0];
                    rp.ShowDialog();
                    Nuevo();
                }            

                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
    }
}
