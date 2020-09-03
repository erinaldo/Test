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
    public partial class Frm_Usuarios : Form
    {
        public Frm_Usuarios()
        {
            InitializeComponent();
        }

        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader dr;

            cn.ConnectionString = Ruta_Servidor.strRutaServidorSQL;
            comando.Connection = cn;
            comando.CommandText = "SELECT COD_USUARIO FROM USUARIOS"; //+
                                     //   "WHERE COD_PEDIDO LIKE '%" + txtNPedido.Text + "%'";
            comando.CommandType = CommandType.Text;

            //Abro la conexion a la base
            cn.Open();
            dgvUsuarios.Rows.Clear();
            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                int renglon = dgvUsuarios.Rows.Add();

                dgvUsuarios.Rows[renglon].Cells["COD_USUARIO"].Value = dr.GetValue(dr.GetOrdinal("COD_USUARIO"));
                //dgvUsuarios.Rows[renglon].Cells["NOM_EMPLEADO"].Value = dr.GetString(dr.GetOrdinal("NOM_EMPLEADO"));
                //dgvUsuarios.Rows[renglon].Cells["APE_EMPLEADO"].Value = dr.GetString(dr.GetOrdinal("APE_EMPLEADO"));
                //dgvPedidos.Rows[renglon].Cells["APE_EMPLEADO"].Value = dr.GetString(dr.GetOrdinal("APE_EMPLEADO"));
                //dgvPedidos.Rows[renglon].Cells["APE_EMPLEADO"].Value = dr.GetString(dr.GetOrdinal("APE_EMPLEADO"));
                //dgvPedidos.Rows[renglon].Cells["APE_EMPLEADO"].Value = dr.GetString(dr.GetOrdinal("APE_EMPLEADO"));
                //dgvPedidos.Rows[renglon].Cells["APE_EMPLEADO"].Value = dr.GetString(dr.GetOrdinal("APE_EMPLEADO"));
                //dgvPedidos.Rows[renglon].Cells["APE_EMPLEADO"].Value = dr.GetString(dr.GetOrdinal("APE_EMPLEADO"));
            }

            cn.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Debe seleccionar Usuario", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);



            return;
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            Frm_AltaUsuarios frm = new Frm_AltaUsuarios();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
