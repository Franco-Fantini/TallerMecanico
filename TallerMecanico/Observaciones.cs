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
    public partial class Observaciones : FormBase
    {
        public Observaciones()
        {
            InitializeComponent();
        }

   
        public void Observaciones_Load(object sender, EventArgs e)
        {
            rtpersona.Text = obper;
            rtauto.Text = obau;

        }
    }
}
