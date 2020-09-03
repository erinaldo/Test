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
    public partial class Frm_Pedidos : Form
    {
        public Frm_Pedidos()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNPedido_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader dr;

            cn.ConnectionString = Ruta_Servidor.strRutaServidorSQL;
            comando.Connection = cn;
            comando.CommandText = "SELECT COD_PEDIDO, NUM_PEDIDO, APE_EMPLEADO From PEDIDOS ";
                               //         "WHERE COD_PEDIDO=" txtNPedido.Text ";
            comando.CommandType = CommandType.Text;

            //Abro la conexion a la base
            cn.Open();
            dgvPedidos.Rows.Clear();
            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                int renglon = dgvPedidos.Rows.Add();

                dgvPedidos.Rows[renglon].Cells["COD_EMPLEADO"].Value = dr.GetValue(dr.GetOrdinal("COD_EMPLEADO"));
                dgvPedidos.Rows[renglon].Cells["NOM_EMPLEADO"].Value = dr.GetString(dr.GetOrdinal("NOM_EMPLEADO"));
                dgvPedidos.Rows[renglon].Cells["APE_EMPLEADO"].Value = dr.GetString(dr.GetOrdinal("APE_EMPLEADO"));
                //dgvPedidos.Rows[renglon].Cells["APE_EMPLEADO"].Value = dr.GetString(dr.GetOrdinal("APE_EMPLEADO"));
                //dgvPedidos.Rows[renglon].Cells["APE_EMPLEADO"].Value = dr.GetString(dr.GetOrdinal("APE_EMPLEADO"));
                //dgvPedidos.Rows[renglon].Cells["APE_EMPLEADO"].Value = dr.GetString(dr.GetOrdinal("APE_EMPLEADO"));
                //dgvPedidos.Rows[renglon].Cells["APE_EMPLEADO"].Value = dr.GetString(dr.GetOrdinal("APE_EMPLEADO"));
                //dgvPedidos.Rows[renglon].Cells["APE_EMPLEADO"].Value = dr.GetString(dr.GetOrdinal("APE_EMPLEADO"));
            }

            cn.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Frm_AltaPedido frm = new Frm_AltaPedido();
          
            frm.ShowDialog();
        }

        private void Frm_Pedidos_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader dr;

            cn.ConnectionString = Ruta_Servidor.strRutaServidorSQL;
            comando.Connection = cn;
            comando.CommandText = "SELECT SUCURSAL, NUM_PEDIDO, FE_PEDIDO, COD_CLIENTE, CLIENTE," +
                " CONDICION, COD_VENDEDOR, COD_USUARIO, FE_REGISTRO," +
                " CUIT_CLIENTE, OBSERVACIONES FROM PEDIDOS";
            comando.CommandType = CommandType.Text;

            cn.Open();

            dgvPedidos.Rows.Clear();

            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                int renglon = dgvPedidos.Rows.Add();

                dgvPedidos.Rows[renglon].Cells["SUCURSAL"].Value = dr.GetDecimal(dr.GetOrdinal("SUCURSAL"));
                dgvPedidos.Rows[renglon].Cells["NUM_PEDIDO"].Value = dr.GetDecimal(dr.GetOrdinal("NUM_PEDIDO"));
                dgvPedidos.Rows[renglon].Cells["FE_PEDIDO"].Value = dr.GetDateTime(dr.GetOrdinal("FE_PEDIDO"));
                dgvPedidos.Rows[renglon].Cells["COD_CLIENTE"].Value = dr.GetInt32(dr.GetOrdinal("COD_CLIENTE"));
                dgvPedidos.Rows[renglon].Cells["CLIENTE"].Value = dr.GetString(dr.GetOrdinal("CLIENTE"));
                dgvPedidos.Rows[renglon].Cells["CONDICION"].Value = dr.GetString(dr.GetOrdinal("CONDICION"));
                dgvPedidos.Rows[renglon].Cells["COD_VENDEDOR"].Value = dr.GetInt32(dr.GetOrdinal("COD_VENDEDOR"));
                dgvPedidos.Rows[renglon].Cells["COD_USUARIO"].Value = dr.GetInt32(dr.GetOrdinal("COD_USUARIO"));
                dgvPedidos.Rows[renglon].Cells["FE_REGISTRO"].Value = dr.GetDateTime(dr.GetOrdinal("FE_REGISTRO"));
                dgvPedidos.Rows[renglon].Cells["CUIT_CLIENTE"].Value = dr.GetDecimal(dr.GetOrdinal("CUIT_CLIENTE"));
                dgvPedidos.Rows[renglon].Cells["OBSERVACIONES"].Value = dr.GetString(dr.GetOrdinal("OBSERVACIONES"));
               
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            OpenBar.Frm_BajaPedido frm = new OpenBar.Frm_BajaPedido();
            frm.ShowDialog();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader dr;

            cn.ConnectionString = Ruta_Servidor.strRutaServidorSQL;
            comando.Connection = cn;
            comando.CommandText = "SELECT NUM_PEDIDO, FE_PEDIDO, COD_CLIENTE, CLIENTE, CONDICION From PEDIDOS " +
                                     " WHERE CLIENTE LIKE '%" + txtCliente.Text + "%'";
            comando.CommandType = CommandType.Text;

            cn.Open();

            dgvPedidos.Rows.Clear();

            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                int renglon = dgvPedidos.Rows.Add();

                dgvPedidos.Rows[renglon].Cells["NUM_PEDIDO"].Value = dr.GetDecimal(dr.GetOrdinal("NUM_PEDIDO"));
                dgvPedidos.Rows[renglon].Cells["FE_PEDIDO"].Value = dr.GetDateTime(dr.GetOrdinal("FE_PEDIDO"));
                dgvPedidos.Rows[renglon].Cells["COD_CLIENTE"].Value = dr.GetDecimal(dr.GetOrdinal("COD_CLIENTE"));
                dgvPedidos.Rows[renglon].Cells["CLIENTE"].Value = dr.GetString(dr.GetOrdinal("CLIENTE"));
                dgvPedidos.Rows[renglon].Cells["CONDICION"].Value = dr.GetString(dr.GetOrdinal("CONDICION"));
            }

            cn.Close();
        }
    }
}
