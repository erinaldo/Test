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
    public partial class Frm_Empleados : Form
    {
        public Frm_Empleados()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Project_OpenBar.Frm_AltaEmpleados frm = new Project_OpenBar.Frm_AltaEmpleados();
            frm.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Empleados_Load(object sender, EventArgs e)
        {

        }
    }
}
