using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
//using System.Windows.Forms;
using System.Data.SqlClient; //Clase de coneccion a SQL
//using System.Data;

namespace Project_OpenBar
{
    public partial class Frm_NuevoInicio : Form
    {
        public Frm_NuevoInicio()
        {
            InitializeComponent();
        }

        Frm_Principal Principal = new Frm_Principal();


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Pongo el cursor como reloj de arena
            Cursor.Show();
            Cursor.Current = Cursors.WaitCursor;

            //Valido combo usuario y txt Contraseña
            if (cboUsuario.Text.Trim() == "" || txtContraseña.Text.Trim() == "")
            {
                MessageBox.Show("El Usuario y/o la Contraseña son incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                //Creando la conexion
                SqlConnection conexion = new SqlConnection(Ruta_Servidor.strRutaServidorSQL);
                //SqlConnection conexion = new SqlConnection("Data source=MATIAS\\SQLPRUEBA17; Initial Catalog=OpenBar; User Id=sa; Password=1234");
                conexion.Open();//Abro conexion

                SqlCommand comando = new SqlCommand("SELECT Usuario, Contraseña FROM Usuarios" +
                                                "WHERE Usuario = '" + cboUsuario.Text + "'And Contraseña = '" + txtContraseña.Text + "' ", conexion);

                //Ejecuta una instruccion de sql devolviendo el numero de las filas afectadas
                comando.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(comando);

                //Llenando el dataAdapter
                da.Fill(ds, "Usuario");
                //utilizado para representar una fila de la tabla q necesitas en este caso usuario
                DataRow DR;
                DR = ds.Tables["Usuario"].Rows[0];

                //Evaluo que la contraseña y usuario sean correctos
                if ((cboUsuario.Text == DR["Usuario"].ToString()) || (txtContraseña.Text == DR["Contraseña"].ToString()))
                {

                    
                    //Frm_Principal frmPrincipal = new Frm_Principal(); //instanciando el formulario principal

                    //Desactivo el cursor como reloj de arena
                    Cursor.Hide();
                    Cursor.Current = Cursors.Default;

                    //frmPrincipal.Show(); //Abro el formulario principal
                    this.Hide(); //Oculto el formulario de login
                }

                // Activacion del MENU

                //consultasToolStripMenuItem.Enabled = True;
                //OpcionesToolStripMenuItem.Enabled = false;
            }
            catch
            {
                //Si la contraseña es erronea muestro el mensaje
                //dentro de los parentesis va: "Mensaje a mostrar","Titulo de la ventana",botones a mostrar en este caso OK, icono a mostrar en este caso uno de error
                MessageBox.Show("Usuario y/o Contraseña son invalidos", "Error al Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
