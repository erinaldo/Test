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
    public partial class Frm_AltaClientes : Form
    {
        public Frm_AltaClientes()
        {
            InitializeComponent();
        }

        private void txtCodigo_MouseDown(object sender, MouseEventArgs e)
        {
            //EVENTO CLICK DERECHO

            //if (e.Button == MouseButtons.Right)
            //{
            //    DialogResult ResultadoDelDialogo = new DialogResult();
            //    Frm_BuscarClientes Frm_BuscarClientes = new Frm_BuscarClientes();
            //    ResultadoDelDialogo = Frm_BuscarClientes.ShowDialog();

            //    if (ResultadoDelDialogo == DialogResult.OK)
            //    {
            //        //this.Close();

            //        Frm_BuscarClientes.ActiveForm.Show();

            //        txtCodigo.Focus();
            //        //txtPara.Text = csCliente.strCodCliente;

            //        //proAceptaCliente();

            //    }

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
