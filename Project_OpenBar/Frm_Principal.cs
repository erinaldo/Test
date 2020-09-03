using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Clase de conexion a SQL.
using System.Data.OleDb; // Clase de coneccion a ACCESS.
using System.Configuration; //Clase para leer Appconfig.
using OpenBar;

namespace Project_OpenBar
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
            toolStripStatusLblFecha.Text = String.Format("{0:G}", DateTime.Now);
            toolStripStatuslblUsuario.Text = "- Sesion Iniciada -";
        }

        private void acercaDeOpenBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Muestra ventana de Acercade//
            Frm_Acerca frm = new Frm_Acerca();
            frm.ShowDialog();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
               if (MessageBox.Show("¿Estás Seguro que desea salir?", "OpenBar - Matias", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
               e.Cancel = true;//Guarda el botón pulsado del Mensaje y si es NO simplemente cancela el cierre 
               else
               Application.Exit();

            */

            {
                DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?",
                           "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                  //  Application.Exit();
                }
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Login frmLogin = new Login();
            //frmLogin.Show();
            //this.Hide();
            // Al cerrar sesion se grisan los botos del menustip: //
          
            if (toolStripStatuslblUsuario.Text == "- Debe Iniciar Sesion -")
            {
                MessageBox.Show("No hay ninguna Sesión iniciada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            SqlConnection cn = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            //SqlDataReader dr;

            cn.ConnectionString = Ruta_Servidor.strRutaServidorSQL;
            comando.Connection = cn;
            comando.CommandText = "SELECT COD_USUARIO, NOM_EMPLEADO, APE_EMPLEADO From USUARIOS " +
                                        "WHERE COD_CARGO = 5002";
            comando.CommandType = CommandType.Text;

            cn.Open();

            toolStripStatuslblUsuario.Text = "- Debe Iniciar Sesion -";
            toolStripUsuario.Text = "Login.COD_USUARIO";

            //toolStripStatuslblStrUsuario.Text = "Usuario Prueba";
            clientesMenuItem.Enabled = false;
            ventasMenuItem.Enabled = false;
            articulosMenuItem.Enabled = false;
            clientesMenuItem.Enabled = false;
            proveedoresMenuItem.Enabled = false;
            rrhhMenuItem.Enabled = false;
            opcionesMenuItem.Enabled = false;
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login frm = new Frm_Login();
            frm.ShowDialog();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            //variable
            //this.Close();
           // Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
           // Application.Exit();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            // Comandos para llamar a la calculadora de Windows
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "calc.exe";
            p.StartInfo.Arguments = "";
            p.Start();
        }

        private void configuracionBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Configuracion frm = new Frm_Configuracion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vendedoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_Vendedores frm = new Frm_Vendedores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Usuarios frm = new Frm_Usuarios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Clientes frm = new Frm_Clientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripClientes_Click(object sender, EventArgs e)
        {
            Frm_Clientes frm = new Frm_Clientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cONTROLMESASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Control_Mesas frm = new Frm_Control_Mesas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Empleados frm = new Frm_Empleados();
            frm.MdiParent = this;
            frm.Show();
        }

        private void articulosYPreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Articulos frm = new Frm_Articulos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripProductos_Click(object sender, EventArgs e)
        {
            Frm_Articulos frm = new Frm_Articulos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Frm_Control_Mesas frm = new Frm_Control_Mesas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripVenta_Click(object sender, EventArgs e)
        {
            Frm_AltaPedido frm = new Frm_AltaPedido();
            frm.MdiParent = this;
            frm.Show();
        }

        private void comprobantesDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Compras frm = new Frm_Compras();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            Calculadora frm = new Calculadora();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Pedidos frm = new Frm_Pedidos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void operacionesDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MovimientosSTOCK frm = new Frm_MovimientosSTOCK();
            frm.MdiParent = this;
            frm.Show();
        }

        private void supervisoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Proveedores frm = new Frm_Proveedores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cambioDeContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CambioContraseña frm = new Frm_CambioContraseña();
            frm.ShowDialog();
        }

        private void ordenDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OrdendePago frm = new Frm_OrdendePago();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Ayuda frm = new Frm_Ayuda();
            frm.MdiParent = this;
            frm.Show();
        }

        private void listaDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListadePrecios frm = new Frm_ListadePrecios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void feriadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Feriados frm = new Frm_Feriados();
            frm.MdiParent = this;
            frm.Show();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Reservas frm = new Frm_Reservas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    
}
