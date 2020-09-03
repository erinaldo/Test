//----------OpenBar ----------- Matias Sajeras 
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
    public partial class Frm_BackupDBSql : Form
    {
        public Frm_BackupDBSql()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((cboBaseSQL.Text.Trim()) == "" | txtRuta.Text.Trim() == "")

            {
                MessageBox.Show("Seleccionar Base de Datos", "Backup SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cboBaseSQL.Text = "";

                return;
            }

            //Pongo el cursor como reloj de arena
            Cursor.Show();
            Cursor.Current = Cursors.WaitCursor;

            
            // Backup directo en unidad de red del mismo servidor.
            string strBackup = "BACKUP DATABASE " + this.cboBaseSQL.Text +
                 " TO DISK = N'" + this.txtRuta.Text +
                 "' WITH NOFORMAT, NOINIT, NAME =N'" + this.cboBaseSQL.Text +
                 " - Full Database Backup',SKIP, STATS = 10";

            // Backup directo en unidad de red de la pc local.
            //string strBackup = "BACKUP DATABASE " + this.txtBase.Text +
            //     " TO DISK = N'" + "\\\\" + Environment.MachineName + "\\" + this.txtRuta.Text +
            //     "' WITH NOFORMAT, NOINIT, NAME =N'" + this.txtBase.Text +
            //     " - Full Database Backup',SKIP, STATS = 10";

            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();

            // csb.DataSource = this.txtServidor.Text;
            // csb.InitialCatalog = this.txtBase.Text;
            // csb.IntegratedSecurity = true;

            using (SqlConnection con = new SqlConnection(csb.ConnectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmdBackUp = new SqlCommand(strBackup, con);

                    cmdBackUp.ExecuteNonQuery();

                    MessageBox.Show("Se ha creado un BackUp de La base de datos satisfactoriamente en la Ruta Local del Servidor (" + txtServidor.Text + "): " + txtRuta.Text,
                        "Copia de seguridad de base de datos",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al copiar la base de datos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Desactivo el cursor como reloj de arena
                Cursor.Hide();
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
