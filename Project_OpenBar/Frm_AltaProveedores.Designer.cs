namespace OpenBar
{
    partial class Frm_AltaProveedores
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_DatosGenerales = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ActivoNO = new System.Windows.Forms.RadioButton();
            this.ActivoSI = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tp_MasDatos = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tp_CuentaImputacion = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tp_Retenciones = new System.Windows.Forms.TabPage();
            this.tp_DatosdeEntrega = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tp_DatosGenerales.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tp_MasDatos.SuspendLayout();
            this.tp_CuentaImputacion.SuspendLayout();
            this.tp_DatosdeEntrega.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(573, 365);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(492, 365);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 58);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(263, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(367, 20);
            this.textBox2.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_DatosGenerales);
            this.tabControl1.Controls.Add(this.tp_MasDatos);
            this.tabControl1.Controls.Add(this.tp_CuentaImputacion);
            this.tabControl1.Controls.Add(this.tp_Retenciones);
            this.tabControl1.Controls.Add(this.tp_DatosdeEntrega);
            this.tabControl1.Location = new System.Drawing.Point(12, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(636, 283);
            this.tabControl1.TabIndex = 9;
            // 
            // tp_DatosGenerales
            // 
            this.tp_DatosGenerales.Controls.Add(this.groupBox2);
            this.tp_DatosGenerales.Controls.Add(this.checkBox1);
            this.tp_DatosGenerales.Controls.Add(this.label14);
            this.tp_DatosGenerales.Controls.Add(this.maskedTextBox3);
            this.tp_DatosGenerales.Controls.Add(this.label8);
            this.tp_DatosGenerales.Controls.Add(this.comboBox5);
            this.tp_DatosGenerales.Controls.Add(this.label10);
            this.tp_DatosGenerales.Controls.Add(this.comboBox4);
            this.tp_DatosGenerales.Controls.Add(this.label9);
            this.tp_DatosGenerales.Controls.Add(this.comboBox3);
            this.tp_DatosGenerales.Controls.Add(this.label7);
            this.tp_DatosGenerales.Controls.Add(this.maskedTextBox4);
            this.tp_DatosGenerales.Controls.Add(this.comboBox2);
            this.tp_DatosGenerales.Controls.Add(this.maskedTextBox2);
            this.tp_DatosGenerales.Controls.Add(this.maskedTextBox1);
            this.tp_DatosGenerales.Controls.Add(this.label6);
            this.tp_DatosGenerales.Controls.Add(this.label5);
            this.tp_DatosGenerales.Controls.Add(this.label4);
            this.tp_DatosGenerales.Location = new System.Drawing.Point(4, 22);
            this.tp_DatosGenerales.Name = "tp_DatosGenerales";
            this.tp_DatosGenerales.Padding = new System.Windows.Forms.Padding(3);
            this.tp_DatosGenerales.Size = new System.Drawing.Size(628, 257);
            this.tp_DatosGenerales.TabIndex = 0;
            this.tp_DatosGenerales.Text = "Datos Generales";
            this.tp_DatosGenerales.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ActivoNO);
            this.groupBox2.Controls.Add(this.ActivoSI);
            this.groupBox2.Location = new System.Drawing.Point(25, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 37);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Activo";
            // 
            // ActivoNO
            // 
            this.ActivoNO.AutoSize = true;
            this.ActivoNO.Location = new System.Drawing.Point(88, 14);
            this.ActivoNO.Name = "ActivoNO";
            this.ActivoNO.Size = new System.Drawing.Size(39, 17);
            this.ActivoNO.TabIndex = 1;
            this.ActivoNO.TabStop = true;
            this.ActivoNO.Text = "No";
            this.ActivoNO.UseVisualStyleBackColor = true;
            // 
            // ActivoSI
            // 
            this.ActivoSI.AutoSize = true;
            this.ActivoSI.Location = new System.Drawing.Point(48, 14);
            this.ActivoSI.Name = "ActivoSI";
            this.ActivoSI.Size = new System.Drawing.Size(34, 17);
            this.ActivoSI.TabIndex = 0;
            this.ActivoSI.TabStop = true;
            this.ActivoSI.Text = "Si";
            this.ActivoSI.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(411, 162);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Es Proveedor Varios";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(352, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Localidad:";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(83, 95);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(130, 20);
            this.maskedTextBox3.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "C.U.I.T.:";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(380, 123);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(148, 21);
            this.comboBox5.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(274, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Condicion de Pago:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(105, 121);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(148, 21);
            this.comboBox4.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Condicion IVA:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(83, 68);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(250, 21);
            this.comboBox3.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Pais:";
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(414, 41);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(119, 20);
            this.maskedTextBox4.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(83, 41);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(250, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(433, 15);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 4;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(83, 15);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Provincia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Codigo Postal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Direccion:";
            // 
            // tp_MasDatos
            // 
            this.tp_MasDatos.Controls.Add(this.label13);
            this.tp_MasDatos.Controls.Add(this.label12);
            this.tp_MasDatos.Controls.Add(this.label11);
            this.tp_MasDatos.Location = new System.Drawing.Point(4, 22);
            this.tp_MasDatos.Name = "tp_MasDatos";
            this.tp_MasDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tp_MasDatos.Size = new System.Drawing.Size(628, 257);
            this.tp_MasDatos.TabIndex = 1;
            this.tp_MasDatos.Text = "Mas Datos";
            this.tp_MasDatos.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "label11";
            // 
            // tp_CuentaImputacion
            // 
            this.tp_CuentaImputacion.Controls.Add(this.label3);
            this.tp_CuentaImputacion.Controls.Add(this.button3);
            this.tp_CuentaImputacion.Controls.Add(this.comboBox1);
            this.tp_CuentaImputacion.Location = new System.Drawing.Point(4, 22);
            this.tp_CuentaImputacion.Name = "tp_CuentaImputacion";
            this.tp_CuentaImputacion.Size = new System.Drawing.Size(628, 257);
            this.tp_CuentaImputacion.TabIndex = 2;
            this.tp_CuentaImputacion.Text = "Cuenta de Imputacion";
            this.tp_CuentaImputacion.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Imputacion:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(408, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Buscar Cuenta";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(303, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // tp_Retenciones
            // 
            this.tp_Retenciones.Location = new System.Drawing.Point(4, 22);
            this.tp_Retenciones.Name = "tp_Retenciones";
            this.tp_Retenciones.Size = new System.Drawing.Size(628, 257);
            this.tp_Retenciones.TabIndex = 4;
            this.tp_Retenciones.Text = "Retenciones";
            this.tp_Retenciones.UseVisualStyleBackColor = true;
            // 
            // tp_DatosdeEntrega
            // 
            this.tp_DatosdeEntrega.Controls.Add(this.textBox3);
            this.tp_DatosdeEntrega.Location = new System.Drawing.Point(4, 22);
            this.tp_DatosdeEntrega.Name = "tp_DatosdeEntrega";
            this.tp_DatosdeEntrega.Size = new System.Drawing.Size(628, 257);
            this.tp_DatosdeEntrega.TabIndex = 3;
            this.tp_DatosdeEntrega.Text = "Datos de Entrega";
            this.tp_DatosdeEntrega.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 3);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(282, 145);
            this.textBox3.TabIndex = 0;
            // 
            // Frm_AltaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 402);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.MaximizeBox = false;
            this.Name = "Frm_AltaProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta/Modificacion - Proveedores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tp_DatosGenerales.ResumeLayout(false);
            this.tp_DatosGenerales.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tp_MasDatos.ResumeLayout(false);
            this.tp_MasDatos.PerformLayout();
            this.tp_CuentaImputacion.ResumeLayout(false);
            this.tp_CuentaImputacion.PerformLayout();
            this.tp_DatosdeEntrega.ResumeLayout(false);
            this.tp_DatosdeEntrega.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_DatosGenerales;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ActivoNO;
        private System.Windows.Forms.RadioButton ActivoSI;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tp_MasDatos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tp_CuentaImputacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tp_Retenciones;
        private System.Windows.Forms.TabPage tp_DatosdeEntrega;
        private System.Windows.Forms.TextBox textBox3;
    }
}