using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Clase de coneccion a SQL.
using System.Data.OleDb; // Clase de coneccion a ACCESS.
using System.Configuration; //Clase para leer Appconfig.

namespace Project_OpenBar
{
    public partial class Frm_Vendedores : Form
    {
        public Frm_Vendedores()
        {
            InitializeComponent();
        }

        private void Frm_Vendedores_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader dr;

            cn.ConnectionString = Ruta_Servidor.strRutaServidorSQL;
            comando.Connection = cn;
            comando.CommandText = "SELECT COD_EMPLEADO, NOM_EMPLEADO, APE_EMPLEADO From EMPLEADOS " +
                                        "WHERE COD_CARGO = 5002";
            comando.CommandType = CommandType.Text;

            cn.Open();

            dgvVendedores.Rows.Clear();

            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                int renglon = dgvVendedores.Rows.Add();

                dgvVendedores.Rows[renglon].Cells["COD_EMPLEADO"].Value = dr.GetValue(dr.GetOrdinal("COD_EMPLEADO"));
                dgvVendedores.Rows[renglon].Cells["NOM_EMPLEADO"].Value = dr.GetString(dr.GetOrdinal("NOM_EMPLEADO"));
                dgvVendedores.Rows[renglon].Cells["APE_EMPLEADO"].Value = dr.GetString(dr.GetOrdinal("APE_EMPLEADO"));
                
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

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader dr;

            cn.ConnectionString = Ruta_Servidor.strRutaServidorSQL;
            comando.Connection = cn;
            comando.CommandText = "SELECT COD_EMPLEADO, NOM_EMPLEADO, APE_EMPLEADO From EMPLEADOS " +
                                        "WHERE COD_CARGO = 5002 AND COD_EMPLEADO LIKE '%" + txtCodigo.Text + "%'";
            comando.CommandType = CommandType.Text;

            cn.Open();
            dgvVendedores.Rows.Clear();
            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                int renglon = dgvVendedores.Rows.Add();

                dgvVendedores.Rows[renglon].Cells["COD_EMPLEADO"].Value = dr.GetValue(dr.GetOrdinal("COD_EMPLEADO"));
                dgvVendedores.Rows[renglon].Cells["NOM_EMPLEADO"].Value = dr.GetString(dr.GetOrdinal("NOM_EMPLEADO"));
                dgvVendedores.Rows[renglon].Cells["APE_EMPLEADO"].Value = dr.GetString(dr.GetOrdinal("APE_EMPLEADO"));
                //dgvVendedores.Rows[renglon].Cells["APE_EMPLEADO"].Value = dr.GetString(dr.GetOrdinal("APE_EMPLEADO"));
                //dgvVendedores.Rows[renglon].Cells["APE_EMPLEADO"].Value = dr.GetString(dr.GetOrdinal("APE_EMPLEADO"));
                //dgvVendedores.Rows[renglon].Cells["APE_EMPLEADO"].Value = dr.GetString(dr.GetOrdinal("APE_EMPLEADO"));
                //dgvVendedores.Rows[renglon].Cells["APE_EMPLEADO"].Value = dr.GetString(dr.GetOrdinal("APE_EMPLEADO"));
                //dgvVendedores.Rows[renglon].Cells["APE_EMPLEADO"].Value = dr.GetString(dr.GetOrdinal("APE_EMPLEADO"));
            }

            cn.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader dr;

            cn.ConnectionString = Ruta_Servidor.strRutaServidorSQL;
            comando.Connection = cn;
            comando.CommandText = "SELECT COD_EMPLEADO, NOM_EMPLEADO, APE_EMPLEADO From EMPLEADOS" +
                                     " WHERE COD_CARGO = 5002 AND NOM_EMPLEADO LIKE '%" + txtNombre.Text + "%'";
            comando.CommandType = CommandType.Text;

            cn.Open();

            dgvVendedores.Rows.Clear();

            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                int renglon = dgvVendedores.Rows.Add();

                dgvVendedores.Rows[renglon].Cells["COD_EMPLEADO"].Value = dr.GetValue(dr.GetOrdinal("COD_EMPLEADO"));
                dgvVendedores.Rows[renglon].Cells["NOM_EMPLEADO"].Value = dr.GetString(dr.GetOrdinal("NOM_EMPLEADO"));
                dgvVendedores.Rows[renglon].Cells["APE_EMPLEADO"].Value = dr.GetString(dr.GetOrdinal("APE_EMPLEADO"));

            }

            cn.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Frm_AltaEmpleados frm = new Frm_AltaEmpleados();
            //frm.MdiParent = this;
            frm.Show();
        }
    }
}
