using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_OpenBar
{
    public partial class Frm_Articulos : Form
    {
        public Frm_Articulos()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Frm_AltaArticulos frm = new Frm_AltaArticulos();
            frm.Show();
        }
    }
}
