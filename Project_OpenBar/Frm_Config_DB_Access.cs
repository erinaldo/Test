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
    public partial class Frm_Config_DB_Access : Form
    {
        public Frm_Config_DB_Access()
        {
            InitializeComponent();
        }

        private void btnBuscarRuta_Click(object sender, EventArgs e)
        {
            OpenFileDialog m_OpenFile = new OpenFileDialog();
            m_OpenFile.Title = "Buscar Base de datos de Microsoft Access";
            m_OpenFile.Filter = "Todos los archivos(*.*)|*.*|Base de datos Access (*.mdb)|*.mdb";
            m_OpenFile.FilterIndex = 2;

            if (m_OpenFile.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = m_OpenFile.FileName.ToString();

            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
