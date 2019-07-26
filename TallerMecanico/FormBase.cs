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
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        public virtual void Nuevo()
        {

        }

        public virtual void Modificar()
        {

        }
        public virtual void Consultar()
        {

        }
        public virtual Boolean Guardar()
        {
            return false;

        }
        public virtual void Eliminar()
        {

        }
        public virtual void Seleccionar()
        {

        }
        public virtual void Observar()
        {
            string obper;
                string obau;
         }
     
        private void BTCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaLogin formulariologin = new VentanaLogin();
            formulariologin.Show();

        }
        private void FormBase_Load(object sender, EventArgs e)
        {

        }
        public static string obper;
        public static string obau;
        private void BTsalir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir del programa?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
