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
   
    public partial class Mantvehicliente : Mantenimiento
    {
        public Mantvehicliente()
        {
            InitializeComponent();
        }


        // codigo para guardar datos de vehiculos y clientes
        public override Boolean Guardar()
        {

            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {
                    string cmd = string.Format("EXEC vehiculosclientes '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}'", tbpatente.Text.Trim(), tbname.Text.Trim(), tbphone.Text.Trim(), tbadress.Text.Trim(), tbmail.Text.Trim(), tbdni.Text.Trim(), tbcuit.Text.Trim(), RTBobcli.Text.Trim(), TBMarca.Text.Trim(), TBModelo.Text.Trim(), TBKM.Text.Trim(), TBNchasis.Text.Trim(), tbnmotor.Text.Trim(), tbnumvehiculo.Text.Trim(), RTBobvehi.Text.Trim());
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Se ha guardado correctamente los datos");

                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("ha ocurrido un error : " + error.Message);
                    return false;
                }
            }
            else { return false; }
            }

        private void BTNuevo_Click(object sender, EventArgs e)
        {
            if (tbpatente.Enabled == false)
            {
                tbname.Enabled = true;
                tbpatente.Enabled = true;
                tbphone.Enabled = true;
                tbadress.Enabled = true;
                tbmail.Enabled = true;
                tbdni.Enabled = true;
                tbname.Enabled = true;
                RTBobcli.Enabled = true;
                TBMarca.Enabled = true;
                TBModelo.Enabled = true;
                TBKM.Enabled = true;
                TBNchasis.Enabled = true;
                tbnmotor.Enabled = true;
                tbpatente.Enabled = true;
                RTBobvehi.Enabled = true;


            }
            else if (tbpatente.Enabled == true)
            {
                tbname.Enabled = false;
                tbpatente.Enabled = false;
                tbphone.Enabled = false;
                tbadress.Enabled = false;
                tbmail.Enabled = false;
                tbdni.Enabled = false;
                tbname.Enabled = false;
                RTBobcli.Enabled = false;
                TBMarca.Enabled = false;
                TBModelo.Enabled = false;
                TBKM.Enabled = false;
                TBNchasis.Enabled = false;
                tbnmotor.Enabled = false;
                tbpatente.Enabled = false;
                RTBobvehi.Enabled = false;
            }
        }
        public override void Consultar()
        {
            Consultar_Vehiculos_y_Clientes formconcli = new Consultar_Vehiculos_y_Clientes
            {
                MdiParent = this.MdiParent
            };
            formconcli.Show();

        }

        private void Tbpatente_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void TBMarca_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void TBModelo_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void TBKM_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void TBNchasis_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void Tbnmotor_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void Tbnumvehiculo_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void Tbcuit_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void Tbdni_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void Tbmail_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void Tbadress_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void Tbphone_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void Tbname_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void BTConsultar_Click(object sender, EventArgs e)
        {

        }
    }

}

