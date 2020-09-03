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
//using Project_OpenBar.Class;
//using proTienda.Class;
//using System.Windows.Forms;
using System.Data.SqlClient; //Clase de conexion a SQL
//using System.Data;

namespace Project_OpenBar
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
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
            if (OpenBar.Clases.Usuarios.Login(cboUsuario.Text, txtContraseña.Text) > 0)
            {
                Frm_Principal frmPrincipal = new Frm_Principal(); //instanciando el formulario principal

                //Desactivo el cursor como reloj de arena
                Cursor.Hide();
                Cursor.Current = Cursors.Default;

                frmPrincipal.Show(); //Abro el formulario principal
                this.Hide(); //Oculto el formulario de login
            }
            else
                //Si la contraseña es erronea muestro el mensaje
                //dentro de los parentesis va: "Mensaje a mostrar","Titulo de la ventana",botones a mostrar en este caso OK, icono a mostrar en este caso uno de error
                MessageBox.Show("Usuario y/o Contraseña son invalidos", "Error al Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
            
            //    MessageBox.Show("El Usuario y/o la Contraseña son incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
           
   /*
            try
            {
                //Creando la conexion
                /////("Data source=MATIAS\\SQLPRUEBA17; Initial Catalog=OpenBar; User Id=sa; Password=1234"
                SqlConnection conexion = new SqlConnection(Ruta_Servidor.strRutaServidorSQL);
                //Abro conexion
                conexion.Open();

                //conexion.ConnectionString = Ruta_Servidor.strRutaServidorSQL;
                SqlCommand comando = new SqlCommand("SELECT Usuario, Contraseña FROM Usuarios" +
                    " WHERE Usuario = '" + cboUsuario.Text + "'And Contraseña = '" + txtContraseña.Text + "' ", conexion);
                
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
                // BACKUP 
                //if ((cboUsuario.Text == DR["Usuario"].ToString()) || (txtContraseña.Text == DR["pwdencrypt('Contraseña')"].ToString()))
                if ((cboUsuario.Text == DR["Usuario"].ToString()) || (txtContraseña.Text == DR["convert(varbinary(255),pwdencrypt('Contraseña'))"].ToString()))
                {       
                    Frm_Principal frmPrincipal = new Frm_Principal(); //instanciando el formulario principal

                    //Desactivo el cursor como reloj de arena
                    Cursor.Hide();
                    Cursor.Current = Cursors.Default;

                    frmPrincipal.Show(); //Abro el formulario principal
                    this.Hide(); //Oculto el formulario de login
                }
            }
            catch
            {
                //Si la contraseña es erronea muestro el mensaje
                //dentro de los parentesis va: "Mensaje a mostrar","Titulo de la ventana",botones a mostrar en este caso OK, icono a mostrar en este caso uno de error
                MessageBox.Show("Usuario y/o Contraseña son invalidos", "Error al Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Application.Exit();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
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
                cboUsuario.Items.Add(dr ["Usuario"].ToString());
            }
            cn.Close();
        }
    }
}

