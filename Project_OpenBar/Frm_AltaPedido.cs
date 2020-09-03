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
using System.Diagnostics; // Clase para usar los comandos de Windows, ejemplo la Calculadora.
using OpenBar;

namespace Project_OpenBar
{
    public partial class Frm_AltaPedido : Form
    {
        public Frm_AltaPedido()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if ((txtCodCliente.Text.Trim()) == "" | txtCodArticulo.Text.Trim() == "")

            {
                MessageBox.Show("Falta cargar un Codigo de Articulo!", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodArticulo.Text = "";
                return;
            }

            if ((txtDescripcion.Text.Trim()) == "")
            {
                MessageBox.Show("Debe apretar ENTER luego de seleccionar un Articulo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtCantidad.Text == "0")
            {
                MessageBox.Show("No se puede ingresar un Item con Cantidad Cero!", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                int renglon = dgvItemsPedidos.Rows.Add();
                dgvItemsPedidos.Rows[renglon].Cells["Item"].Value = "00" + (renglon + 1);
                dgvItemsPedidos.Rows[renglon].Cells["COD_ARTICULO"].Value = txtCodArticulo.Text;
                dgvItemsPedidos.Rows[renglon].Cells["ARTICULO"].Value = txtDescripcion.Text;
                dgvItemsPedidos.Rows[renglon].Cells["CANT_PEDIDA"].Value = txtCantidad.Text;
                dgvItemsPedidos.Rows[renglon].Cells["IMP_UNITARIO"].Value = txtPrecio.Text;
                
                //dgvItemsPedidos.Rows[renglon].Cells["txtPrecio"].Value = cboDeposito.SelectedValue;
                //dgvItemsPedidos.Rows[renglon].Cells["LISTA"].Value = cboListaPrecio.SelectedValue;
                //dgvItemsPedidos.Rows[renglon].Cells["PRECIO"].Value = txtPrecio.Text;
                //dgvItemsPedidos.Rows[renglon].Cells["DESCUENTO"].Value = txtDescuento.Text;
                //dgvItemsPedidos.Rows[renglon].Cells["FECRECEP"].Value = dtpFechaEntregaItem.Value;
                //dgvItemsPedidos.Rows[renglon].Cells["STOCKDISPONIBLE"].Value = txtStockDisponible.Text;

                txtCodArticulo.Text = "";
                txtDescripcion.Text = "";
                txtCantidad.Text = "";
                txtPrecio.Text = "";
                txtDescuento.Text = "";
                txtStockDisponible.Text = "";

                txtCodArticulo.Focus();
        }

        private void btnGrabarPedido_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.dgvItemsPedidos.Rows.Count) > 1)
            {
                if ((dtpFechaEmision.Text.Trim()) == "")

                {
                    MessageBox.Show("Debe ingresar una fecha de emision", "Pedidos - OpenBar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    dtpFechaEmision.Text = "";

                    return;
                }
                
                Boolean boolBuscoNumeracion = false;
                Boolean boolGraboCabeza = false;
                Boolean boolGraboNumeracion = false;

                Boolean boolGraboItem = false;
                //string strNumeroSucursal = "0001";
                //string strNumeroPedido = "00000000";

                for (int i = 0; i < (dgvItemsPedidos.Rows.Count - 1); i++)
                {
                    SqlConnection cn = new SqlConnection();
                    SqlCommand comando = new SqlCommand();
                    SqlDataReader dr;

                    cn.ConnectionString = Ruta_Servidor.strRutaServidorSQL;
                    comando.Connection = cn;

                    comando.CommandText = "INSERT INTO PEDIDOS (SUCURSAL, NUM_PEDIDO, FE_PEDIDO, COD_CLIENTE, CLIENTE," +
                                             " CONDICION, COD_VENDEDOR," +
                                             " COD_USUARIO, FE_REGISTRO, CUIT_CLIENTE," +
                                             " OBSERVACIONES" +
                                         ") Values ('" +
                                txtSucursal.Text +
                                "','" +
                                txtNumPedido.Text +
                                "','" +
                                string.Format("{0:dd-MM-yyyy hh:mm:ss.fff}", Convert.ToDateTime(dtpFechaEmision.Text)) +
                                "','" +
                                txtCodCliente.Text +
                                "','" +
                                txtDescCliente.Text +
                                "','" +
                                cboCondVenta.SelectedValue +
                                "','" +
                                cboVendedor.SelectedValue +
                                "','" +
                                txtUsuario.Text +
                                "','" +
                                string.Format("{0:dd-MM-yyyy hh:mm:ss.fff}", Convert.ToDateTime(dtpFechaReg.Text)) +
                                "','" +
                                txtCUIT.Text +
                                "','" +
                                txtObservaciones.Text +
                                "')";
                    comando.CommandType = CommandType.Text;
                    cn.Open();

                    try
                    {
                        dr = comando.ExecuteReader();
                        boolGraboCabeza = true;
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("No se Pudo Grabar la Cabeza del Pedido!");
                        boolGraboCabeza = false;
                    }
                    cn.Close();
                    ///////// FIN GRABACION CABEZA \\\\\\\\

                    // cs_Formulario.strNroPed = strNumeroSucursal + strNumeroPedido;
                    // MessageBox.Show("Pedido " + strNumeroSucursal + "-" + strNumeroPedido + " Guardado Correctamente!", "Pedido Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    if (boolGraboCabeza == true)
                    {
                        /////// INICIO GRABACION CONTROL AUDITORIA  NUMERACION \\\\\\\\
                        /*
                        SqlConnection cn2 = new SqlConnection();
                        SqlCommand comando2 = new SqlCommand();
                        SqlDataReader dr2;

                        cn2.ConnectionString = Ruta_Servidor.strRutaServidorSQL;
                        comando2.Connection = cn2;

                        comando2.CommandText = "UPDATE TABLAS SET FUNCION ='" + strNumeroPedido + "' + SUBSTRING(FUNCION,9,56) WHERE CLAVE = 'SI091PD0001X'";

                        comando2.CommandType = CommandType.Text;
                        cn2.Open();

                        try
                        {
                            dr2 = comando2.ExecuteReader();
                            // boolGraboNumeracion = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            MessageBox.Show("No se Pudo Grabar la Numeracion en TABLAS!");
                            boolGraboNumeracion = false;
                        }
                        cn2.Close();
                        //FIN GRABACION NUMERACION
                        */

                        if (boolGraboCabeza == true)
                        {
                            //INICIO GRABACION ITEMS
                            for (int p = 0; p < (dgvItemsPedidos.Rows.Count - 1); p++)
                            {
                                comando.CommandText = "INSERT INTO PEDIDOS_DET (SUCURSAL, NUM_PEDIDO," +
                                    "Item, COD_ARTICULO, ARTICULO, CANT_PEDIDA, CANT_ENTREGADA, UNID_MEDIDA," +
                                    "PORC_DESCUENTO, DEP_SALIDA, LISTA_PRECIO, IMP_UNITARIO, IMP_IVA," +
                                    "IMP_TOTAL, STOCK_DISPONIBLE" +
                                    ") Values ('" +
                                    // "ñ" +
                                    // "','" +
                                    txtSucursal.Text +
                                    "','" +
                                    txtNumPedido.Text +
                                    "','" +
                                    dgvItemsPedidos.Rows[i].Cells["Item"].Value +
                                    "','" +
                                    dgvItemsPedidos.Rows[i].Cells["COD_ARTICULO"].Value +
                                    "','" +
                                    dgvItemsPedidos.Rows[i].Cells["ARTICULO"].Value +
                                    "','" +
                                    dgvItemsPedidos.Rows[i].Cells["CANT_PEDIDA"].Value +
                                    // ((dgvItemsPedidos.Rows[i].Cells["CANT_PEDIDA"].Value).ToString()).Replace(",", ".") +
                                    "','" +
                                    dgvItemsPedidos.Rows[i].Cells["CANT_ENTREGADA"].Value +
                                    "','" +
                                    dgvItemsPedidos.Rows[i].Cells["UNID_MEDIDA"].Value +
                                    "','" +
                                    dgvItemsPedidos.Rows[i].Cells["PORC_DESCUENTO"].Value +
                                    "','" +
                                    dgvItemsPedidos.Rows[i].Cells["DEP_SALIDA"].Value +
                                    "','" +
                                    dgvItemsPedidos.Rows[i].Cells["LISTA_PRECIO"].Value +
                                    "','" +
                                    dgvItemsPedidos.Rows[i].Cells["IMP_UNITARIO"].Value +
                                    "','" +
                                    dgvItemsPedidos.Rows[i].Cells["IMP_IVA"].Value +
                                    "','" +
                                    dgvItemsPedidos.Rows[i].Cells["IMP_TOTAL"].Value +
                                    "','" +
                                //    string.Format("{0:dd-MM-yyyy hh:mm:ss.fff}", Convert.ToDateTime(dgvItemsPedidos.Rows[i].Cells["FE_ENTREGA"].Value)) +
                                 //   "','" +
                                    dgvItemsPedidos.Rows[i].Cells["STOCK_DISPONIBLE"].Value +
                                    "')";

                                comando.CommandType = CommandType.Text;
                                cn.Open();

                                try
                                {
                                    dr = comando.ExecuteReader();

                                    boolGraboItem = true;
                                }

                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                    MessageBox.Show("No se Pudieron Grabar Items!");
                                    boolGraboItem = false;
                                 //boolGraboItems = false;
                                }
                                cn.Close();
                                //// FIN DE GRABACION DE ITEMS \\\\\\\
                            }
                        }
                    }

                    MessageBox.Show("Pedido guardado correctamente");

                     txtSucursal.Text = "";
                    // txtNumPedido.Text = "";
                    // txtCantidad.Text = "";
                    // txtPrecio.Text = "";

                    //INICIO DE IMPRESION DE REPORTE

                    //Frm_Impresion_Pedidos frmReporteador2 = new Frm_Impresion_Pedidos();

                    if (Application.OpenForms["Frm_Impresion_Pedidos"] != null)
                    {
                        Application.OpenForms["Frm_Impresion_Pedidos"].Activate();
                    }
                    
                    else
                    {
                        // string strParamDesdeCliente = txtCliente.Text;
                        // string strParamHastaCliente = "";
                        // string strParamRuta = RutaReportes.strRutaReporte + "Pedidos.rpt";

                        try
                        {
                          //  Frm_Impresion_Pedido.ProListaReporte(strParamDesdeCliente, strParamHastaCliente, strParamRuta);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        //frmReporteador2.Show();
                        // FIN DE IMPRESION DE REPORTE
                    }

                    
                }

                //this.Close();

                /*
                Frm_Pedidos frmPedidos = new Frm_Pedidos();

                if (Application.OpenForms["frmPedidos"] != null)
                {
                    Application.OpenForms["frmPedidos"].Activate();
                }

                else
                {
                    frmPedidos.Show();
                }
                */
            }

            else
            {
                MessageBox.Show("No hay items ingresados", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnCalcWindows_Click(object sender, EventArgs e)
        {
            Process.Start("Calc.exe");
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            //this.dgvItemsPedidos.Rows.RemoveAt(e.RowIndex);

            if (dgvItemsPedidos.SelectedRows.Count > 0)
            {
                // utilizo el foreach para iterar los registros.
                // con el metodo de RemoveAt. le mando el indice del elemento a eliminar
                foreach (DataGridViewRow item in this.dgvItemsPedidos.SelectedRows)
                {
                    dgvItemsPedidos.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Cerrar Ventana de Pedidos
            DialogResult result = MessageBox.Show("¿Seguro que desea cerrar sin guardar?", "Pedidos", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                 Close();
            }
            else if (result == DialogResult.No)
            {

            }

        }
    }

}
