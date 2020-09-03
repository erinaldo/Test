using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Clase de conexion a SQL
using System.Windows.Forms;
using System.Data.OleDb;
using Project_OpenBar;

namespace OpenBar
{
    public partial class Frm_Cobrar : Form
    {
        public Frm_Cobrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // Declaro las variables:
        int varFolio = 0;
        double varTotal = 0;


        private void btnOK_Click(object sender, EventArgs e)
        {
            if ((txtEfectivo.Text != "") && (Convert.ToDouble(txtEfectivo.Text) >= varTotal))
            {
                DialogResult _Resp = new DialogResult();
                _Resp = MessageBox.Show("¿Desea imprimir el ticket?",
                    "Ticket", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (_Resp == DialogResult.Yes)
                {
                    //Imprmmir el ticket
                    GenerarTicket(varFolio);
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Debe introducir una Cantidad Valida",
                    "Faltan datos");
            }
        }


        private void GenerarTicket(int prmFOLIO)
        {
            try
            {
                /*
                string Ticket = "Nombre de la tienda: " + AppConfig._NEGOCIO + "\n" +
                    "RFC:" + AppConfig._RFC + "\n" +
                    "------------------------------\n" +
                    "ARTICULO   CANT   PRECIO   TOTAL\n" +
                    "------------------------------\n";
                */
                string Ticket = "Nombre de la tienda: " +  "------------------------------\n" +
                   "ARTICULO   CANT   PRECIO   TOTAL\n" +
                   "------------------------------\n";


                string varSQL =
                    "SELECT LEFT(DESC_PRODUCTO,10) as DESC_PRODUCTO," +
                    " CANTIDAD,P_UNITARIO,TOTAL" +
                    " FROM vVENTAS WHERE FOLIO=" + prmFOLIO + "";

                string DetalleTicket = "";
                double varGranTotal = 0;

                //Creando la conexion
               
                SqlConnection conexion = new SqlConnection(Ruta_Servidor.strRutaServidorSQL);
                
                SqlConnection cnnTicket = new SqlConnection(Ruta_Servidor.strRutaServidorSQL);
                //Abro las conexiones
                conexion.Open();
                cnnTicket.Open();
                SqlCommand cmdTicket = new SqlCommand(varSQL, cnnTicket);
                SqlDataReader drTicket;
                drTicket = cmdTicket.ExecuteReader();
                //*/
                while (drTicket.Read())
                {
                    DetalleTicket +=
                        drTicket["DESC_PRODUCTO"].ToString() + "   " +
                        drTicket["CANTIDAD"].ToString() + "   " +
                        String.Format("{0:c}",
                        drTicket["P_UNITARIO"]) + "   " +
                        String.Format("{0:c}",
                        drTicket["TOTAL"]) + "\n";
                    varGranTotal += (double)drTicket["TOTAL"];
                }

                DetalleTicket += "------------------------------\n" +
                    "TOTAL: " + String.Format("{0:c}", varGranTotal);
                Ticket += DetalleTicket;
                /*
                mPrintDocument _mPrintDocument = new mPrintDocument(Ticket);
                _mPrintDocument.PrintPreview();
                */

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
