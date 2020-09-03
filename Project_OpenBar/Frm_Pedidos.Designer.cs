namespace Project_OpenBar
{
    partial class Frm_Pedidos
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
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNPedido = new System.Windows.Forms.TextBox();
            this.SUCURSAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FE_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONDICION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_VENDEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FE_REGISTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIT_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVACIONES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SUCURSAL,
            this.NUM_PEDIDO,
            this.FE_PEDIDO,
            this.COD_CLIENTE,
            this.CLIENTE,
            this.CONDICION,
            this.COD_VENDEDOR,
            this.COD_USUARIO,
            this.FE_REGISTRO,
            this.CUIT_CLIENTE,
            this.OBSERVACIONES});
            this.dgvPedidos.Location = new System.Drawing.Point(12, 39);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(1166, 340);
            this.dgvPedidos.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(1103, 399);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 399);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(115, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(133, 399);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Anular Pedido";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(258, 13);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(463, 20);
            this.txtCliente.TabIndex = 5;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "N° Pedido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cliente:";
            // 
            // txtNPedido
            // 
            this.txtNPedido.Location = new System.Drawing.Point(76, 12);
            this.txtNPedido.Name = "txtNPedido";
            this.txtNPedido.Size = new System.Drawing.Size(100, 20);
            this.txtNPedido.TabIndex = 8;
            this.txtNPedido.TextChanged += new System.EventHandler(this.txtNPedido_TextChanged);
            // 
            // SUCURSAL
            // 
            this.SUCURSAL.HeaderText = "SUCURSAL";
            this.SUCURSAL.Name = "SUCURSAL";
            this.SUCURSAL.ReadOnly = true;
            // 
            // NUM_PEDIDO
            // 
            this.NUM_PEDIDO.HeaderText = "NUMERO PEDIDO";
            this.NUM_PEDIDO.Name = "NUM_PEDIDO";
            this.NUM_PEDIDO.ReadOnly = true;
            // 
            // FE_PEDIDO
            // 
            this.FE_PEDIDO.HeaderText = "FECHA";
            this.FE_PEDIDO.Name = "FE_PEDIDO";
            this.FE_PEDIDO.ReadOnly = true;
            // 
            // COD_CLIENTE
            // 
            this.COD_CLIENTE.HeaderText = "CODIGO CLIENTE";
            this.COD_CLIENTE.Name = "COD_CLIENTE";
            this.COD_CLIENTE.ReadOnly = true;
            // 
            // CLIENTE
            // 
            this.CLIENTE.HeaderText = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.ReadOnly = true;
            // 
            // CONDICION
            // 
            this.CONDICION.HeaderText = "CONDICION";
            this.CONDICION.Name = "CONDICION";
            this.CONDICION.ReadOnly = true;
            // 
            // COD_VENDEDOR
            // 
            this.COD_VENDEDOR.HeaderText = "COD_VENDEDOR";
            this.COD_VENDEDOR.Name = "COD_VENDEDOR";
            this.COD_VENDEDOR.ReadOnly = true;
            // 
            // COD_USUARIO
            // 
            this.COD_USUARIO.HeaderText = "COD_USUARIO";
            this.COD_USUARIO.Name = "COD_USUARIO";
            this.COD_USUARIO.ReadOnly = true;
            // 
            // FE_REGISTRO
            // 
            this.FE_REGISTRO.HeaderText = "FE_REGISTRO";
            this.FE_REGISTRO.Name = "FE_REGISTRO";
            this.FE_REGISTRO.ReadOnly = true;
            // 
            // CUIT_CLIENTE
            // 
            this.CUIT_CLIENTE.HeaderText = "CUIT_CLIENTE";
            this.CUIT_CLIENTE.Name = "CUIT_CLIENTE";
            this.CUIT_CLIENTE.ReadOnly = true;
            // 
            // OBSERVACIONES
            // 
            this.OBSERVACIONES.FillWeight = 250F;
            this.OBSERVACIONES.HeaderText = "OBSERVACIONES";
            this.OBSERVACIONES.Name = "OBSERVACIONES";
            this.OBSERVACIONES.ReadOnly = true;
            // 
            // Frm_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 434);
            this.Controls.Add(this.txtNPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvPedidos);
            this.MaximizeBox = false;
            this.Name = "Frm_Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Frm_Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUCURSAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FE_PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONDICION;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_VENDEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FE_REGISTRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACIONES;
    }
}