using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Clase de coneccion a SQL

namespace Project_OpenBar
{
    public partial class Frm_AltaArticulos : Form
    {
        public Frm_AltaArticulos()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Articulos_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Valida si se ingreso un Articulo
            if ((txtCodArticulo.Text.Trim() == "") & (txtArticulo.Text.Trim() == ""))
            {
                MessageBox.Show("Debe Ingresar Articulo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodArticulo.Focus();

                return;
            }
            //_________________________________________________________________
            //
            //GRABACION DE DATOS.
            SqlConnection cn = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader dr;
            
            cn.ConnectionString = Ruta_Servidor.strRutaServidorSQL;
            comando.Connection = cn;
            // comando.CommandText = "Insert into ARTICULOS (CG_ART,DES_ART)" +
            // "VALUES ('" + dtpFechaCargaDeParte.Value.Date.ToString("dd/MM/yyyy") + "','" +
            // txtCodArticulo.Text + "','" + txtArticulo.Text + "','" + cboUnidadStock.Text + "')";

            comando.CommandType = CommandType.Text;

            cn.Open();

            try
            {
                dr = comando.ExecuteReader();

                MessageBox.Show("Articulo Guardado Correctamente", "Articulos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCodArticulo.Text = "";
                txtArticulo.Text = "";
                //cboUnidadStock.Text = "";

                //txtCantidadHoras.Text = "";
                //txtBaseDeDatos.Text = "";
                //txtDescripcionTareaRealizada.Text = "";
                //txtMail.Text = "";
                //txtBuscadorRapido.Text = "";
                //lblServicio.Enabled = false;
                //cboServicio.Enabled = false;
                //lblValorHora.Enabled = false;
                //txtValorHora.Enabled = false;
                //lblHoras.Enabled = false;

                //dtpFechaDesdeHistorico.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01).AddMonths(-3);
                //chkMuestraTodosLosClientes.Checked = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            cn.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
