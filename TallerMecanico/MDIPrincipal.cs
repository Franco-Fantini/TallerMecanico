using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerMecanico
{
    public partial class MDIPrincipal : FormBase
    {
        private int childFormNumber = 0;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Abre el formulario del mantenimiento cliente 
            Mantvehicliente formMantvehicliente = new Mantvehicliente
            {
                MdiParent = this
            };
            formMantvehicliente.Show();
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoProducto formMantProducto = new MantenimientoProducto
            {
                MdiParent = this
            };
            formMantProducto.Show();
        }

        private void ProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_de_productos formconsultapro = new Consulta_de_productos
            {
                MdiParent = this

            };
        formconsultapro.Show();}

        private void ClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultar_Vehiculos_y_Clientes formconsultascli = new Consultar_Vehiculos_y_Clientes
            {
                MdiParent = this

            };
            formconsultascli.Show();
        }

        private void FacturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturacion formfactu = new Facturacion
            {
                MdiParent = this
            };
            formfactu.Show();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Taller Mecanico version 1.01" + " " + "- Desarrollado por Franco Fantini - (franco.fantini.1993@gmail.com)", "Acerca de " , MessageBoxButtons.OK); 
        }

     
    }
}
