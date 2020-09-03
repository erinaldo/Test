namespace Project_OpenBar
{
    partial class Frm_AltaPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.txtDescCliente = new System.Windows.Forms.TextBox();
            this.cboVendedor = new System.Windows.Forms.ComboBox();
            this.btnGrabarPedido = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCli = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboCondVenta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcWindows = new System.Windows.Forms.Button();
            this.dtpFechaReg = new System.Windows.Forms.MaskedTextBox();
            this.dtpFechaEmision = new System.Windows.Forms.MaskedTextBox();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodArticulo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboDepSalida = new System.Windows.Forms.ComboBox();
            this.cboUnidadMedida = new System.Windows.Forms.ComboBox();
            this.dtpFechaEntregaItem = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEntregaItem = new System.Windows.Forms.Label();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cboListaPrecio = new System.Windows.Forms.ComboBox();
            this.lblLista = new System.Windows.Forms.Label();
            this.txtStockDisponible = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblUnidadDeMedida = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dgvItemsPedidos = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANT_PEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANT_ENTREGADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNID_MEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PORC_DESCUENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEP_SALIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LISTA_PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMP_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMP_IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMP_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FE_ENTREGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOCK_DISPONIBLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTOTAL = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.txtNumPedido = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsPedidos)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(70, 25);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCodCliente.TabIndex = 2;
            this.txtCodCliente.Text = "1010";
            // 
            // txtDescCliente
            // 
            this.txtDescCliente.Location = new System.Drawing.Point(249, 26);
            this.txtDescCliente.Name = "txtDescCliente";
            this.txtDescCliente.Size = new System.Drawing.Size(259, 20);
            this.txtDescCliente.TabIndex = 3;
            this.txtDescCliente.Text = "CAEDI";
            // 
            // cboVendedor
            // 
            this.cboVendedor.FormattingEnabled = true;
            this.cboVendedor.Items.AddRange(new object[] {
            "1001"});
            this.cboVendedor.Location = new System.Drawing.Point(90, 22);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.Size = new System.Drawing.Size(121, 21);
            this.cboVendedor.TabIndex = 4;
            this.cboVendedor.Text = "1001";
            // 
            // btnGrabarPedido
            // 
            this.btnGrabarPedido.Location = new System.Drawing.Point(925, 510);
            this.btnGrabarPedido.Name = "btnGrabarPedido";
            this.btnGrabarPedido.Size = new System.Drawing.Size(75, 29);
            this.btnGrabarPedido.TabIndex = 5;
            this.btnGrabarPedido.Text = "Guardar";
            this.btnGrabarPedido.UseVisualStyleBackColor = true;
            this.btnGrabarPedido.Click += new System.EventHandler(this.btnGrabarPedido_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(844, 510);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 29);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarCli);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodCliente);
            this.groupBox1.Controls.Add(this.txtDescCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 57);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // btnBuscarCli
            // 
            this.btnBuscarCli.Location = new System.Drawing.Point(514, 24);
            this.btnBuscarCli.Name = "btnBuscarCli";
            this.btnBuscarCli.Size = new System.Drawing.Size(49, 23);
            this.btnBuscarCli.TabIndex = 4;
            this.btnBuscarCli.Text = "...";
            this.btnBuscarCli.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cboCondVenta);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cboVendedor);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtCUIT);
            this.groupBox2.Location = new System.Drawing.Point(12, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 52);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos generales";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Condicion de Venta:";
            // 
            // cboCondVenta
            // 
            this.cboCondVenta.FormattingEnabled = true;
            this.cboCondVenta.Items.AddRange(new object[] {
            "CONTADO"});
            this.cboCondVenta.Location = new System.Drawing.Point(326, 22);
            this.cboCondVenta.Name = "cboCondVenta";
            this.cboCondVenta.Size = new System.Drawing.Size(121, 21);
            this.cboCondVenta.TabIndex = 6;
            this.cboCondVenta.Text = "CONTADO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vendedor:";
            // 
            // btnCalcWindows
            // 
            this.btnCalcWindows.Location = new System.Drawing.Point(909, 136);
            this.btnCalcWindows.Name = "btnCalcWindows";
            this.btnCalcWindows.Size = new System.Drawing.Size(91, 50);
            this.btnCalcWindows.TabIndex = 19;
            this.btnCalcWindows.Text = "Calculadora";
            this.btnCalcWindows.UseVisualStyleBackColor = true;
            this.btnCalcWindows.Click += new System.EventHandler(this.btnCalcWindows_Click);
            // 
            // dtpFechaReg
            // 
            this.dtpFechaReg.Location = new System.Drawing.Point(526, 41);
            this.dtpFechaReg.Mask = "00/00/0000";
            this.dtpFechaReg.Name = "dtpFechaReg";
            this.dtpFechaReg.Size = new System.Drawing.Size(84, 20);
            this.dtpFechaReg.TabIndex = 30;
            this.dtpFechaReg.ValidatingType = typeof(System.DateTime);
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Location = new System.Drawing.Point(526, 15);
            this.dtpFechaEmision.Mask = "00/00/0000";
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(84, 20);
            this.dtpFechaEmision.TabIndex = 29;
            this.dtpFechaEmision.ValidatingType = typeof(System.DateTime);
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Location = new System.Drawing.Point(418, 44);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(102, 13);
            this.lblFechaEntrega.TabIndex = 28;
            this.lblFechaEntrega.Text = "Fecha Registracion:";
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.Location = new System.Drawing.Point(418, 18);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(79, 13);
            this.lblFechaEmision.TabIndex = 27;
            this.lblFechaEmision.Text = "Fecha Emision:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Codigo articulo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descripcion:";
            // 
            // txtCodArticulo
            // 
            this.txtCodArticulo.Location = new System.Drawing.Point(95, 24);
            this.txtCodArticulo.Name = "txtCodArticulo";
            this.txtCodArticulo.Size = new System.Drawing.Size(100, 20);
            this.txtCodArticulo.TabIndex = 11;
            this.txtCodArticulo.Text = "200";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(278, 24);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(261, 20);
            this.txtDescripcion.TabIndex = 12;
            this.txtDescripcion.Text = "Articulo varios";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(821, 91);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(65, 23);
            this.btnQuitar.TabIndex = 15;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(892, 91);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Location = new System.Drawing.Point(545, 22);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(49, 23);
            this.btnBuscarArticulo.TabIndex = 18;
            this.btnBuscarArticulo.Text = "...";
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.cboDepSalida);
            this.groupBox3.Controls.Add(this.cboUnidadMedida);
            this.groupBox3.Controls.Add(this.dtpFechaEntregaItem);
            this.groupBox3.Controls.Add(this.lblFechaEntregaItem);
            this.groupBox3.Controls.Add(this.lblDeposito);
            this.groupBox3.Controls.Add(this.txtDescuento);
            this.groupBox3.Controls.Add(this.lblDescuento);
            this.groupBox3.Controls.Add(this.txtPrecio);
            this.groupBox3.Controls.Add(this.lblPrecio);
            this.groupBox3.Controls.Add(this.cboListaPrecio);
            this.groupBox3.Controls.Add(this.lblLista);
            this.groupBox3.Controls.Add(this.txtStockDisponible);
            this.groupBox3.Controls.Add(this.lblStock);
            this.groupBox3.Controls.Add(this.lblUnidadDeMedida);
            this.groupBox3.Controls.Add(this.txtCantidad);
            this.groupBox3.Controls.Add(this.lblCantidad);
            this.groupBox3.Controls.Add(this.dgvItemsPedidos);
            this.groupBox3.Controls.Add(this.btnBuscarArticulo);
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Controls.Add(this.btnQuitar);
            this.groupBox3.Controls.Add(this.txtDescripcion);
            this.groupBox3.Controls.Add(this.txtCodArticulo);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(988, 306);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Item";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(876, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 20);
            this.textBox1.TabIndex = 52;
            // 
            // cboDepSalida
            // 
            this.cboDepSalida.FormattingEnabled = true;
            this.cboDepSalida.Items.AddRange(new object[] {
            "CENTRAL"});
            this.cboDepSalida.Location = new System.Drawing.Point(296, 62);
            this.cboDepSalida.Name = "cboDepSalida";
            this.cboDepSalida.Size = new System.Drawing.Size(121, 21);
            this.cboDepSalida.TabIndex = 51;
            this.cboDepSalida.Text = "CENTRAL";
            // 
            // cboUnidadMedida
            // 
            this.cboUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidadMedida.FormattingEnabled = true;
            this.cboUnidadMedida.Items.AddRange(new object[] {
            "UNIDAD",
            "KG"});
            this.cboUnidadMedida.Location = new System.Drawing.Point(545, 62);
            this.cboUnidadMedida.Name = "cboUnidadMedida";
            this.cboUnidadMedida.Size = new System.Drawing.Size(121, 21);
            this.cboUnidadMedida.TabIndex = 50;
            // 
            // dtpFechaEntregaItem
            // 
            this.dtpFechaEntregaItem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntregaItem.Location = new System.Drawing.Point(744, 62);
            this.dtpFechaEntregaItem.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaEntregaItem.Name = "dtpFechaEntregaItem";
            this.dtpFechaEntregaItem.Size = new System.Drawing.Size(96, 20);
            this.dtpFechaEntregaItem.TabIndex = 43;
            // 
            // lblFechaEntregaItem
            // 
            this.lblFechaEntregaItem.AutoSize = true;
            this.lblFechaEntregaItem.Location = new System.Drawing.Point(673, 65);
            this.lblFechaEntregaItem.Name = "lblFechaEntregaItem";
            this.lblFechaEntregaItem.Size = new System.Drawing.Size(70, 13);
            this.lblFechaEntregaItem.TabIndex = 49;
            this.lblFechaEntregaItem.Text = "Entrega Item:";
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Location = new System.Drawing.Point(206, 65);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(84, 13);
            this.lblDeposito.TabIndex = 47;
            this.lblDeposito.Text = "Deposito Salida:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(500, 93);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(49, 20);
            this.txtDescuento.TabIndex = 46;
            this.txtDescuento.Text = "0";
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(406, 96);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(88, 13);
            this.lblDescuento.TabIndex = 45;
            this.lblDescuento.Text = "% de Descuento:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(296, 88);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(79, 20);
            this.txtPrecio.TabIndex = 44;
            this.txtPrecio.Text = "100";
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(250, 91);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 42;
            this.lblPrecio.Text = "Precio:";
            // 
            // cboListaPrecio
            // 
            this.cboListaPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboListaPrecio.FormattingEnabled = true;
            this.cboListaPrecio.Items.AddRange(new object[] {
            "LISTA A",
            "LISTA B"});
            this.cboListaPrecio.Location = new System.Drawing.Point(103, 88);
            this.cboListaPrecio.Name = "cboListaPrecio";
            this.cboListaPrecio.Size = new System.Drawing.Size(136, 21);
            this.cboListaPrecio.TabIndex = 41;
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(9, 91);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(80, 13);
            this.lblLista.TabIndex = 40;
            this.lblLista.Text = "Lista de Precio:";
            // 
            // txtStockDisponible
            // 
            this.txtStockDisponible.Enabled = false;
            this.txtStockDisponible.Location = new System.Drawing.Point(696, 24);
            this.txtStockDisponible.Name = "txtStockDisponible";
            this.txtStockDisponible.ReadOnly = true;
            this.txtStockDisponible.Size = new System.Drawing.Size(79, 20);
            this.txtStockDisponible.TabIndex = 39;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(600, 27);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(90, 13);
            this.lblStock.TabIndex = 38;
            this.lblStock.Text = "Stock Disponible:";
            // 
            // lblUnidadDeMedida
            // 
            this.lblUnidadDeMedida.AutoSize = true;
            this.lblUnidadDeMedida.Location = new System.Drawing.Point(442, 65);
            this.lblUnidadDeMedida.Name = "lblUnidadDeMedida";
            this.lblUnidadDeMedida.Size = new System.Drawing.Size(97, 13);
            this.lblUnidadDeMedida.TabIndex = 37;
            this.lblUnidadDeMedida.Text = "Unidad de Medida:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(103, 62);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(79, 20);
            this.txtCantidad.TabIndex = 36;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(9, 65);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(88, 13);
            this.lblCantidad.TabIndex = 35;
            this.lblCantidad.Text = "Cantidad Pedida:";
            // 
            // dgvItemsPedidos
            // 
            this.dgvItemsPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.COD_ARTICULO,
            this.ARTICULO,
            this.CANT_PEDIDA,
            this.CANT_ENTREGADA,
            this.UNID_MEDIDA,
            this.PORC_DESCUENTO,
            this.DEP_SALIDA,
            this.LISTA_PRECIO,
            this.IMP_UNITARIO,
            this.IMP_IVA,
            this.IMP_TOTAL,
            this.FE_ENTREGA,
            this.STOCK_DISPONIBLE});
            this.dgvItemsPedidos.Location = new System.Drawing.Point(12, 120);
            this.dgvItemsPedidos.Name = "dgvItemsPedidos";
            this.dgvItemsPedidos.Size = new System.Drawing.Size(970, 179);
            this.dgvItemsPedidos.TabIndex = 19;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 50;
            // 
            // COD_ARTICULO
            // 
            this.COD_ARTICULO.HeaderText = "Codigo";
            this.COD_ARTICULO.Name = "COD_ARTICULO";
            this.COD_ARTICULO.ReadOnly = true;
            // 
            // ARTICULO
            // 
            this.ARTICULO.HeaderText = "Descripcion";
            this.ARTICULO.Name = "ARTICULO";
            this.ARTICULO.ReadOnly = true;
            // 
            // CANT_PEDIDA
            // 
            this.CANT_PEDIDA.HeaderText = "Cant. Pedida";
            this.CANT_PEDIDA.Name = "CANT_PEDIDA";
            this.CANT_PEDIDA.ReadOnly = true;
            // 
            // CANT_ENTREGADA
            // 
            this.CANT_ENTREGADA.HeaderText = "Cant. Entregada";
            this.CANT_ENTREGADA.Name = "CANT_ENTREGADA";
            this.CANT_ENTREGADA.ReadOnly = true;
            // 
            // UNID_MEDIDA
            // 
            this.UNID_MEDIDA.HeaderText = "UM";
            this.UNID_MEDIDA.Name = "UNID_MEDIDA";
            this.UNID_MEDIDA.ReadOnly = true;
            // 
            // PORC_DESCUENTO
            // 
            this.PORC_DESCUENTO.HeaderText = "% Desc.";
            this.PORC_DESCUENTO.Name = "PORC_DESCUENTO";
            this.PORC_DESCUENTO.ReadOnly = true;
            // 
            // DEP_SALIDA
            // 
            this.DEP_SALIDA.HeaderText = "Deposito";
            this.DEP_SALIDA.Name = "DEP_SALIDA";
            this.DEP_SALIDA.ReadOnly = true;
            // 
            // LISTA_PRECIO
            // 
            this.LISTA_PRECIO.HeaderText = "Lista";
            this.LISTA_PRECIO.Name = "LISTA_PRECIO";
            this.LISTA_PRECIO.ReadOnly = true;
            // 
            // IMP_UNITARIO
            // 
            this.IMP_UNITARIO.HeaderText = "Precio";
            this.IMP_UNITARIO.Name = "IMP_UNITARIO";
            this.IMP_UNITARIO.ReadOnly = true;
            // 
            // IMP_IVA
            // 
            this.IMP_IVA.HeaderText = "IVA";
            this.IMP_IVA.Name = "IMP_IVA";
            this.IMP_IVA.ReadOnly = true;
            // 
            // IMP_TOTAL
            // 
            this.IMP_TOTAL.HeaderText = "Total";
            this.IMP_TOTAL.Name = "IMP_TOTAL";
            this.IMP_TOTAL.ReadOnly = true;
            // 
            // FE_ENTREGA
            // 
            this.FE_ENTREGA.HeaderText = "F.Entrega";
            this.FE_ENTREGA.Name = "FE_ENTREGA";
            this.FE_ENTREGA.ReadOnly = true;
            // 
            // STOCK_DISPONIBLE
            // 
            this.STOCK_DISPONIBLE.HeaderText = "Stock Disp.";
            this.STOCK_DISPONIBLE.Name = "STOCK_DISPONIBLE";
            this.STOCK_DISPONIBLE.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(669, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "TOTAL:";
            // 
            // txtTOTAL
            // 
            this.txtTOTAL.Enabled = false;
            this.txtTOTAL.Location = new System.Drawing.Point(720, 515);
            this.txtTOTAL.Name = "txtTOTAL";
            this.txtTOTAL.ReadOnly = true;
            this.txtTOTAL.Size = new System.Drawing.Size(79, 20);
            this.txtTOTAL.TabIndex = 26;
            this.txtTOTAL.Text = "121";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtSucursal);
            this.groupBox4.Controls.Add(this.txtNumPedido);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(12, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(395, 57);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pedido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "SUCURSAL:";
            // 
            // txtSucursal
            // 
            this.txtSucursal.Location = new System.Drawing.Point(95, 26);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(73, 20);
            this.txtSucursal.TabIndex = 2;
            this.txtSucursal.Text = "1000";
            // 
            // txtNumPedido
            // 
            this.txtNumPedido.Location = new System.Drawing.Point(290, 26);
            this.txtNumPedido.Name = "txtNumPedido";
            this.txtNumPedido.Size = new System.Drawing.Size(94, 20);
            this.txtNumPedido.TabIndex = 3;
            this.txtNumPedido.Text = "22020";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(182, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "NUMERO PEDIDO:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(805, 12);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(63, 20);
            this.txtUsuario.TabIndex = 20;
            this.txtUsuario.Text = "1002";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(753, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Usuario:";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(545, 22);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(112, 20);
            this.txtCUIT.TabIndex = 32;
            this.txtCUIT.Text = "291912";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(99, 498);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(185, 41);
            this.txtObservaciones.TabIndex = 33;
            this.txtObservaciones.Text = "Prueba pedido";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(504, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "CUIT:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 501);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Observaciones:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(305, 518);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "label11";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(456, 518);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "label14";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(352, 515);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 20);
            this.textBox2.TabIndex = 38;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(503, 515);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 39;
            // 
            // Frm_AltaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 551);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCalcWindows);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.dtpFechaReg);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblFechaEntrega);
            this.Controls.Add(this.dtpFechaEmision);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTOTAL);
            this.Controls.Add(this.lblFechaEmision);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabarPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Frm_AltaPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Pedido";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsPedidos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.TextBox txtDescCliente;
        private System.Windows.Forms.ComboBox cboVendedor;
        private System.Windows.Forms.Button btnGrabarPedido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarCli;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboCondVenta;
        private System.Windows.Forms.Button btnCalcWindows;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodArticulo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvItemsPedidos;
        private System.Windows.Forms.ComboBox cboUnidadMedida;
        private System.Windows.Forms.DateTimePicker dtpFechaEntregaItem;
        private System.Windows.Forms.Label lblFechaEntregaItem;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cboListaPrecio;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.TextBox txtStockDisponible;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblUnidadDeMedida;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.MaskedTextBox dtpFechaReg;
        private System.Windows.Forms.MaskedTextBox dtpFechaEmision;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.Label lblFechaEmision;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.TextBox txtNumPedido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANT_PEDIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANT_ENTREGADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNID_MEDIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PORC_DESCUENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEP_SALIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn LISTA_PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMP_UNITARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMP_IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMP_TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn FE_ENTREGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOCK_DISPONIBLE;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboDepSalida;
        private System.Windows.Forms.TextBox txtTOTAL;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}