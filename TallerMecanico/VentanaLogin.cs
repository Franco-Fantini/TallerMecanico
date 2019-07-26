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
    public partial class VentanaLogin : FormBase
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }
        //Codigo para devolver el id de usuario para poder cargar foto
        public static String codigo = "";


        // boton de iniciar el LOGIN
        private void Button1_Click(object sender, EventArgs e)
        {


            try
            {
                string CMD = string.Format("Select * FROM Usuarios WHERE account ='{0}' AND password='{1}'", TBUser.Text.Trim(), TBPass.Text.Trim());

                DataSet DS = Utilidades.Ejecutar(CMD);


                codigo = DS.Tables[0].Rows[0]["id_user"].ToString().Trim();

                string cuenta = DS.Tables[0].Rows[0]["account"].ToString().Trim();
                string contraseña = DS.Tables[0].Rows[0]["password"].ToString().Trim();


                if (cuenta == TBUser.Text.Trim() && contraseña == TBPass.Text.Trim())
                {
                    if (Convert.ToBoolean(DS.Tables[0].Rows[0]["admin"]) == true)
                    {
                        MessageBox.Show("Se ha iniciado correctamente como administrador");
                        VentanaAdmin formularioadministrador = new VentanaAdmin();
                        this.Hide();
                        formularioadministrador.Show();

                    }
                    else
                    {
                        VentanaUsuario formularousuario = new VentanaUsuario();
                        MessageBox.Show("Se ha iniciado correctamente");
                        this.Hide();
                        formularousuario.Show();

                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
                TBPass.Text = "";
            }
        }

        private void BIniciar_Click(object sender, EventArgs e)
        {

        }
    }
}
