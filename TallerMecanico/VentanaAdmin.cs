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
    
    public partial class VentanaAdmin : FormBase
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void BTSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            VentanaLogin formularioLogin = new VentanaLogin();

            this.Hide();
            formularioLogin.Show();
        }
     
        // codigo para entrar en el contenedor principal con el click contenedor

        private void BTCprincipal_Click_1(object sender, EventArgs e)
        {
            MDIPrincipal ContenedorPrincipal = new MDIPrincipal();
            this.Hide();
            ContenedorPrincipal.Show();
        }

        // codigo para generar el nombre en el label admin, usuario y codigo 
        private void VentanaAdmin_Load_1(object sender, EventArgs e)
        {
            
                string cmd = "SELECT * FROM Usuarios WHERE id_user=" + VentanaLogin.codigo;
                DataSet ds = Utilidades.Ejecutar(cmd);
                LBLnomadm.Text = ds.Tables[0].Rows[0]["name"].ToString() + " " + ds.Tables[0].Rows[0]["surname"].ToString();
                LBLusadmin.Text = ds.Tables[0].Rows[0]["account"].ToString();
                lblCodadm.Text = ds.Tables[0].Rows[0]["id_user"].ToString();
                string url = ds.Tables[0].Rows[0]["foto"].ToString();
                PBAdmin.Image = Image.FromFile(url);
            
        }
    }
}

