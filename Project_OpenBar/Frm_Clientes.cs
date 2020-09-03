using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; //Clase de coneccion a SQL


namespace Project_OpenBar
{
    public partial class Frm_Clientes : Form
    {
        public Frm_Clientes()
        {
            InitializeComponent();
        }

        private void Frm_Clientes_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader dr;

            cn.ConnectionString = Ruta_Servidor.strRutaServidorSQL;
            comando.Connection = cn;
            comando.CommandText = "SELECT COD_CLIENTE, CLIENTE FROM Clientes";
            comando.CommandType = CommandType.Text;

            cn.Open();

            dgvClientes.Rows.Clear();

            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                int renglon = dgvClientes.Rows.Add();

                dgvClientes.Rows[renglon].Cells["COD_CLIENTE"].Value = dr.GetValue(dr.GetOrdinal("COD_CLIENTE"));
                dgvClientes.Rows[renglon].Cells["CLIENTE"].Value = dr.GetString(dr.GetOrdinal("CLIENTE"));

                ////Valido que el campo Descripcion no tenga valores NULL para que no tire ERROR.
                //if (dr.GetValue(dr.GetOrdinal("CUIT")) != DBNull.Value)
                //{
                //    dgvProveedores.Rows[renglon].Cells["CUIT"].Value = dr.GetString(dr.GetOrdinal("CUIT"));
                //}
                //else
                //{
                //    dgvProveedores.Rows[renglon].Cells["CUIT"].Value = "";
                //}

            }

            cn.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader dr;

            cn.ConnectionString = Ruta_Servidor.strRutaServidorSQL;
            comando.Connection = cn;
            comando.CommandText = "Select CG_CLI, DES_CLI From CLIENTES where CG_CLI LIKE '%" + txtCodigo.Text + "%'";
            comando.CommandType = CommandType.Text;

            cn.Open();

            dgvClientes.Rows.Clear();

            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                int renglon = dgvClientes.Rows.Add();

                dgvClientes.Rows[renglon].Cells["COD_CLIENTE"].Value = dr.GetValue(dr.GetOrdinal("COD_CLIENTE"));
                dgvClientes.Rows[renglon].Cells["DES_CLI"].Value = dr.GetString(dr.GetOrdinal("DES_CLI"));


                ////Valido que el campo Descripcion no tenga valores NULL para que no tire ERROR.
                //if (dr.GetValue(dr.GetOrdinal("CUIT")) != DBNull.Value)
                //{
                //    dgvProveedores.Rows[renglon].Cells["CUIT"].Value = dr.GetString(dr.GetOrdinal("CUIT"));
                //}
                //else
                //{
                //    dgvProveedores.Rows[renglon].Cells["CUIT"].Value = "";
                //}

            }

            cn.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Frm_AltaClientes frm = new Frm_AltaClientes();
            frm.ShowDialog();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
