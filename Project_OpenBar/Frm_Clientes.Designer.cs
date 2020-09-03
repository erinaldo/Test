namespace Project_OpenBar
{
    partial class Frm_Clientes
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLblExportar = new System.Windows.Forms.LinkLabel();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.COD_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRE_CLI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOCALIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_POSTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEL_CONTACTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVACIONES_CLI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(726, 379);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 379);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(92, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo Cliente";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(110, 379);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(61, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(144, 20);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(292, 12);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(509, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // linkLblExportar
            // 
            this.linkLblExportar.AutoSize = true;
            this.linkLblExportar.Location = new System.Drawing.Point(202, 384);
            this.linkLblExportar.Name = "linkLblExportar";
            this.linkLblExportar.Size = new System.Drawing.Size(84, 13);
            this.linkLblExportar.TabIndex = 8;
            this.linkLblExportar.TabStop = true;
            this.linkLblExportar.Text = "Exportar a Excel";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_CLIENTE,
            this.CLIENTE,
            this.CUIT,
            this.DIRE_CLI,
            this.LOCALIDAD,
            this.COD_POSTAL,
            this.TEL_CONTACTO,
            this.OBSERVACIONES_CLI});
            this.dgvClientes.Location = new System.Drawing.Point(1, 38);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.Size = new System.Drawing.Size(810, 335);
            this.dgvClientes.TabIndex = 9;
            // 
            // COD_CLIENTE
            // 
            this.COD_CLIENTE.HeaderText = "Cod. Cliente";
            this.COD_CLIENTE.Name = "COD_CLIENTE";
            this.COD_CLIENTE.ReadOnly = true;
            // 
            // CLIENTE
            // 
            this.CLIENTE.HeaderText = "Nombre / Razon Social";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.ReadOnly = true;
            this.CLIENTE.Width = 250;
            // 
            // CUIT
            // 
            this.CUIT.HeaderText = "CUIT";
            this.CUIT.Name = "CUIT";
            this.CUIT.ReadOnly = true;
            // 
            // DIRE_CLI
            // 
            this.DIRE_CLI.HeaderText = "Direccion";
            this.DIRE_CLI.Name = "DIRE_CLI";
            this.DIRE_CLI.ReadOnly = true;
            this.DIRE_CLI.Width = 150;
            // 
            // LOCALIDAD
            // 
            this.LOCALIDAD.HeaderText = "Localidad";
            this.LOCALIDAD.Name = "LOCALIDAD";
            this.LOCALIDAD.ReadOnly = true;
            this.LOCALIDAD.Width = 150;
            // 
            // COD_POSTAL
            // 
            this.COD_POSTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.COD_POSTAL.HeaderText = "Cod. Postal";
            this.COD_POSTAL.Name = "COD_POSTAL";
            this.COD_POSTAL.ReadOnly = true;
            // 
            // TEL_CONTACTO
            // 
            this.TEL_CONTACTO.HeaderText = "Tel. Contacto";
            this.TEL_CONTACTO.Name = "TEL_CONTACTO";
            this.TEL_CONTACTO.ReadOnly = true;
            // 
            // OBSERVACIONES_CLI
            // 
            this.OBSERVACIONES_CLI.HeaderText = "Observaciones";
            this.OBSERVACIONES_CLI.Name = "OBSERVACIONES_CLI";
            this.OBSERVACIONES_CLI.ReadOnly = true;
            this.OBSERVACIONES_CLI.Width = 300;
            // 
            // Frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 414);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.linkLblExportar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnAceptar);
            this.Name = "Frm_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Frm_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLblExportar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRE_CLI;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOCALIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_POSTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEL_CONTACTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACIONES_CLI;
    }
}