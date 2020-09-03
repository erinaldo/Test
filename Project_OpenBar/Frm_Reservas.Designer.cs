namespace OpenBar
{
    partial class Frm_Reservas
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
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Fe_Reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H_Inicio_Reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H_Fin_Reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNueva
            // 
            this.btnNueva.Location = new System.Drawing.Point(12, 308);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(96, 23);
            this.btnNueva.TabIndex = 0;
            this.btnNueva.Text = "Nueva reserva";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(674, 308);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fe_Reserva,
            this.H_Inicio_Reserva,
            this.H_Fin_Reserva,
            this.Nom_Cliente,
            this.Tel_Cliente,
            this.Detalle,
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 251);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(123, 308);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(12, 20);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(42, 13);
            this.lblNombreCliente.TabIndex = 4;
            this.lblNombreCliente.Text = "Cliente:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Fe_Reserva
            // 
            this.Fe_Reserva.HeaderText = "Fecha";
            this.Fe_Reserva.Name = "Fe_Reserva";
            this.Fe_Reserva.ReadOnly = true;
            // 
            // H_Inicio_Reserva
            // 
            this.H_Inicio_Reserva.HeaderText = "Hora Ini";
            this.H_Inicio_Reserva.Name = "H_Inicio_Reserva";
            this.H_Inicio_Reserva.ReadOnly = true;
            // 
            // H_Fin_Reserva
            // 
            this.H_Fin_Reserva.HeaderText = "Hora Fin";
            this.H_Fin_Reserva.Name = "H_Fin_Reserva";
            this.H_Fin_Reserva.ReadOnly = true;
            // 
            // Nom_Cliente
            // 
            this.Nom_Cliente.HeaderText = "Cliente";
            this.Nom_Cliente.Name = "Nom_Cliente";
            this.Nom_Cliente.ReadOnly = true;
            // 
            // Tel_Cliente
            // 
            this.Tel_Cliente.HeaderText = "Telefono";
            this.Tel_Cliente.Name = "Tel_Cliente";
            this.Tel_Cliente.ReadOnly = true;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Frm_Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 343);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnNueva);
            this.MaximizeBox = false;
            this.Name = "Frm_Reservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fe_Reserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn H_Inicio_Reserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn H_Fin_Reserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}