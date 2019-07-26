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
    public partial class VentanaUsuario : FormBase
    {
        public VentanaUsuario()
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

  

        private void BTCprincipal_Click(object sender, EventArgs e)
        {
            MDIPrincipal ContenedorPrincipal = new MDIPrincipal();
            this.Hide();
            ContenedorPrincipal.Show();
        }

        private void VentanaUsuario_Load_1(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM Usuarios WHERE id_user=" + VentanaLogin.codigo;
            DataSet ds = Utilidades.Ejecutar(cmd);
            LBLnomuser.Text = ds.Tables[0].Rows[0]["name"].ToString() + " " + ds.Tables[0].Rows[0]["surname"].ToString();
            lbluseruser.Text = ds.Tables[0].Rows[0]["account"].ToString();
            lblcodeuser.Text = ds.Tables[0].Rows[0]["id_user"].ToString();
        }
    }}



