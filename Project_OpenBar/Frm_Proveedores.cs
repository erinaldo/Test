using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenBar
{
    public partial class Frm_Proveedores : Form
    {
        public Frm_Proveedores()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Frm_AltaProveedores frm = new Frm_AltaProveedores();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if ((txtProveedor.Text.Trim()) == "" | txtCod.Text.Trim() == "")

            {
                MessageBox.Show("No ha seleccionado el Proveedor", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //  txtProveedor.Text = "";

                return;
            }
        }
    }
}
