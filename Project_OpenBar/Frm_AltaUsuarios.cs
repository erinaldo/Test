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

namespace Project_OpenBar
{
    public partial class Frm_AltaUsuarios : Form
    {
        public Frm_AltaUsuarios()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Valida si se ingreso un Articulo
            if ((txtUsuario.Text.Trim() == "") & (txtContraseña.Text.Trim() == ""))
            {
                MessageBox.Show("Debe Ingresar un nombre de usuario y Contraseña valida", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();

                return;
            }
            if ((txtContraseña.Text.Trim()) != (txtConfirContraseña.Text.Trim()))

            {
                MessageBox.Show("No coincide la contraseña ingresada!", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirContraseña.Text = "";
                return;
            }

            if ((txtContraseña.Text.Trim() == txtConfirContraseña.Text.Trim()))
            {
                if (OpenBar.Clases.Usuarios.AltaCuentas(txtUsuario.Text, txtContraseña.Text) > 0)
                {
                    MessageBox.Show("Usuario dado de alta con exito", "Alta Usuario");
                    // Pongo los text box en blanco
                    txtUsuario.Text = "";
                    txtContraseña.Text = "";
                    txtConfirContraseña.Text = "";
                }
                else
                    MessageBox.Show("No se pudo crear el usuario");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Cerrar Ventana de Pedidos
            //this.Close();
            DialogResult result = MessageBox.Show("¿Seguro que desea cerrar sin guardar?", "Usuarios", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void tpGeneral_Click(object sender, EventArgs e)
        {

        }

        private void Frm_AltaUsuarios_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader dr;
            //SqlDataReader dr = comando.ExecuteReader();
            cn.ConnectionString = Ruta_Servidor.strRutaServidorSQL;
            comando.Connection = cn;
            comando.CommandText = "SELECT TIPO_USUARIO FROM TIPO_USUARIO";
            comando.CommandType = CommandType.Text;

            cn.Open();
            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                cboTipoUsuario.Items.Add(dr["TIPO_USUARIO"].ToString());
            }
            cn.Close();
        }
    }
}
