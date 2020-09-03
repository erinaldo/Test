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

namespace OpenBar
{
    public partial class Frm_BajaPedido : Form
    {
        public Frm_BajaPedido()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtNumPedido.Text.Trim()) == "")
                {
                    MessageBox.Show("Debe ingresar un numero de pedido para anular", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlConnection conexion = new SqlConnection();
                //Ruta del servidor
                conexion.ConnectionString = Project_OpenBar.Ruta_Servidor.strRutaServidorSQL;
                conexion.Open();
                SqlCommand comando = new SqlCommand("UPDATE PEDIDOS SET CLIENTE='ANULADO', OBSERVACIONES = 'PEDIDO ANULADO' " +
                    "WHERE NUM_PEDIDO=" + txtNumPedido.Text.Trim(), conexion);

                if (comando.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Pedido anulado correctamente");
                }
                else
                {
                    MessageBox.Show("No se encuentra Numero de pedido ingresado");
                }
                conexion.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error:" + ex.Message); }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
 }


