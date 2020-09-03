using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Clase de conexion a SQL
using Project_OpenBar;

namespace OpenBar
{
    public partial class Frm_CambioContraseña : Form
    {
        public Frm_CambioContraseña()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((cboUsuario.Text.Trim()) == "" | txtActual.Text.Trim() == "")

            {
                MessageBox.Show("Seleccionar del combo desplegable Usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboUsuario.Text = "";
                return;
            }

            if ((txtNueva.Text.Trim()) == "")
            {
                MessageBox.Show("Ingresar nueva contraseña", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            {
                //Pongo el cursor como reloj de arena
                Cursor.Show();
                Cursor.Current = Cursors.WaitCursor;

                //Valido combo usuario y txt Contraseña
                if (OpenBar.Clases.Usuarios.ActualizarPass(cboUsuario.Text, txtActual.Text) > 0)
                {
                    MessageBox.Show("Contraseña actualizada con Exito", "Actualizacion Password");
                    // Pongo los text box en blanco
                    cboUsuario.Text = "";
                    txtActual.Text = "";
                    txtNueva.Text = "";
                }
                else
                    MessageBox.Show("No se pudo actualizar la contraseña del usuario");
            }


        }

        private void Frm_CambioContraseña_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader dr;
            //SqlDataReader dr = comando.ExecuteReader();
            cn.ConnectionString = Ruta_Servidor.strRutaServidorSQL;
            comando.Connection = cn;
            comando.CommandText = "SELECT USUARIO FROM USUARIOS";
            comando.CommandType = CommandType.Text;

            cn.Open();
            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                cboUsuario.Items.Add(dr["Usuario"].ToString());
            }
            cn.Close();
        }
    }
}
