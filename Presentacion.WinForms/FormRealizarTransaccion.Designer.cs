namespace Presentacion.WinForms
{
    partial class FormRealizarTransaccion
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
            this.label3 = new System.Windows.Forms.Label();
            this.dataTransaccion = new System.Windows.Forms.DataGridView();
            this.IDCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDeMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text_idDestino = new System.Windows.Forms.TextBox();
            this.btnEntreCuentas = new System.Windows.Forms.Button();
            this.btnBuscarID = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValoracion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textEstado = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtusuarioID = new System.Windows.Forms.TextBox();
            this.txtCuentaOrigen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMontoDescontado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTipoMoneda = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtApellidosUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtCuentaDestino = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMontoTransferido = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtVerificarClave = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMonedaDestino = new System.Windows.Forms.TextBox();
            this.txtintento = new System.Windows.Forms.TextBox();
            this.btnRegresarMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTransaccion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "REALIZAR TRANSACCION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Cuenta Destino:";
            // 
            // dataTransaccion
            // 
            this.dataTransaccion.AllowUserToAddRows = false;
            this.dataTransaccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTransaccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTransaccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCuenta,
            this.Saldo,
            this.TipoDeMoneda,
            this.Apellidos});
            this.dataTransaccion.Location = new System.Drawing.Point(88, 80);
            this.dataTransaccion.Name = "dataTransaccion";
            this.dataTransaccion.Size = new System.Drawing.Size(646, 124);
            this.dataTransaccion.TabIndex = 10;
            // 
            // IDCuenta
            // 
            this.IDCuenta.HeaderText = "IDCuenta";
            this.IDCuenta.Name = "IDCuenta";
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            // 
            // TipoDeMoneda
            // 
            this.TipoDeMoneda.HeaderText = "TipoDeMoneda";
            this.TipoDeMoneda.Name = "TipoDeMoneda";
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Estado";
            this.Apellidos.Name = "Apellidos";
            // 
            // text_idDestino
            // 
            this.text_idDestino.Location = new System.Drawing.Point(195, 221);
            this.text_idDestino.Name = "text_idDestino";
            this.text_idDestino.Size = new System.Drawing.Size(142, 20);
            this.text_idDestino.TabIndex = 28;
            // 
            // btnEntreCuentas
            // 
            this.btnEntreCuentas.Location = new System.Drawing.Point(413, 351);
            this.btnEntreCuentas.Name = "btnEntreCuentas";
            this.btnEntreCuentas.Size = new System.Drawing.Size(134, 43);
            this.btnEntreCuentas.TabIndex = 30;
            this.btnEntreCuentas.Text = "Realizar Transferencia ";
            this.btnEntreCuentas.UseVisualStyleBackColor = true;
            this.btnEntreCuentas.Click += new System.EventHandler(this.btnEntreCuentas_Click);
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.Location = new System.Drawing.Point(354, 221);
            this.btnBuscarID.Name = "btnBuscarID";
            this.btnBuscarID.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarID.TabIndex = 32;
            this.btnBuscarID.Text = "Buscar";
            this.btnBuscarID.UseVisualStyleBackColor = true;
            this.btnBuscarID.Click += new System.EventHandler(this.btnBuscarID_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(193, 247);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(144, 20);
            this.txtMonto.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Monto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Valoración:";
            // 
            // txtValoracion
            // 
            this.txtValoracion.Location = new System.Drawing.Point(193, 277);
            this.txtValoracion.Name = "txtValoracion";
            this.txtValoracion.Size = new System.Drawing.Size(144, 20);
            this.txtValoracion.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(490, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Nombre :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(496, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Estado :";
            // 
            // textEstado
            // 
            this.textEstado.Location = new System.Drawing.Point(567, 250);
            this.textEstado.Name = "textEstado";
            this.textEstado.ReadOnly = true;
            this.textEstado.Size = new System.Drawing.Size(142, 20);
            this.textEstado.TabIndex = 40;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(567, 222);
            this.textNombre.Name = "textNombre";
            this.textNombre.ReadOnly = true;
            this.textNombre.Size = new System.Drawing.Size(142, 20);
            this.textNombre.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(570, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Usuario :";
            // 
            // txtusuarioID
            // 
            this.txtusuarioID.Location = new System.Drawing.Point(653, 39);
            this.txtusuarioID.Name = "txtusuarioID";
            this.txtusuarioID.Size = new System.Drawing.Size(95, 20);
            this.txtusuarioID.TabIndex = 42;
            // 
            // txtCuentaOrigen
            // 
            this.txtCuentaOrigen.Location = new System.Drawing.Point(278, 432);
            this.txtCuentaOrigen.Name = "txtCuentaOrigen";
            this.txtCuentaOrigen.ReadOnly = true;
            this.txtCuentaOrigen.Size = new System.Drawing.Size(130, 20);
            this.txtCuentaOrigen.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 84;
            this.label4.Text = "ID Cuenta Origen";
            // 
            // txtMontoDescontado
            // 
            this.txtMontoDescontado.Location = new System.Drawing.Point(585, 531);
            this.txtMontoDescontado.Name = "txtMontoDescontado";
            this.txtMontoDescontado.ReadOnly = true;
            this.txtMontoDescontado.Size = new System.Drawing.Size(151, 20);
            this.txtMontoDescontado.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(441, 535);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 16);
            this.label5.TabIndex = 82;
            this.label5.Text = "Monto Descontado:";
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(230, 639);
            this.txtComision.Name = "txtComision";
            this.txtComision.ReadOnly = true;
            this.txtComision.Size = new System.Drawing.Size(199, 20);
            this.txtComision.TabIndex = 81;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(126, 639);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 80;
            this.label11.Text = "Comision:";
            // 
            // txtTipoMoneda
            // 
            this.txtTipoMoneda.Location = new System.Drawing.Point(243, 577);
            this.txtTipoMoneda.Name = "txtTipoMoneda";
            this.txtTipoMoneda.ReadOnly = true;
            this.txtTipoMoneda.Size = new System.Drawing.Size(165, 20);
            this.txtTipoMoneda.TabIndex = 79;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(61, 581);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 16);
            this.label12.TabIndex = 78;
            this.label12.Text = "Tipo de Moneda Origen:";
            // 
            // txtApellidosUsuario
            // 
            this.txtApellidosUsuario.Location = new System.Drawing.Point(209, 543);
            this.txtApellidosUsuario.Name = "txtApellidosUsuario";
            this.txtApellidosUsuario.ReadOnly = true;
            this.txtApellidosUsuario.Size = new System.Drawing.Size(199, 20);
            this.txtApellidosUsuario.TabIndex = 77;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(209, 506);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.ReadOnly = true;
            this.txtNombreUsuario.Size = new System.Drawing.Size(199, 20);
            this.txtNombreUsuario.TabIndex = 76;
            // 
            // txtCuentaDestino
            // 
            this.txtCuentaDestino.Location = new System.Drawing.Point(278, 466);
            this.txtCuentaDestino.Name = "txtCuentaDestino";
            this.txtCuentaDestino.ReadOnly = true;
            this.txtCuentaDestino.Size = new System.Drawing.Size(130, 20);
            this.txtCuentaDestino.TabIndex = 75;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(111, 543);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 16);
            this.label13.TabIndex = 74;
            this.label13.Text = "Apellidos:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(111, 506);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 16);
            this.label14.TabIndex = 73;
            this.label14.Text = "Nombre:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(105, 466);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 16);
            this.label15.TabIndex = 70;
            this.label15.Text = "ID Cuenta Destino";
            // 
            // txtMontoTransferido
            // 
            this.txtMontoTransferido.Location = new System.Drawing.Point(592, 493);
            this.txtMontoTransferido.Name = "txtMontoTransferido";
            this.txtMontoTransferido.ReadOnly = true;
            this.txtMontoTransferido.Size = new System.Drawing.Size(107, 20);
            this.txtMontoTransferido.TabIndex = 69;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(441, 494);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(138, 16);
            this.label16.TabIndex = 68;
            this.label16.Text = "Monto Transferido:";
            // 
            // txtVerificarClave
            // 
            this.txtVerificarClave.Location = new System.Drawing.Point(195, 312);
            this.txtVerificarClave.Name = "txtVerificarClave";
            this.txtVerificarClave.PasswordChar = '*';
            this.txtVerificarClave.Size = new System.Drawing.Size(144, 20);
            this.txtVerificarClave.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 16);
            this.label10.TabIndex = 87;
            this.label10.Text = "Ingresar clave Cuenta:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(61, 611);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(183, 16);
            this.label17.TabIndex = 88;
            this.label17.Text = "Tipo de Moneda Destino:";
            // 
            // txtMonedaDestino
            // 
            this.txtMonedaDestino.Location = new System.Drawing.Point(243, 607);
            this.txtMonedaDestino.Name = "txtMonedaDestino";
            this.txtMonedaDestino.ReadOnly = true;
            this.txtMonedaDestino.Size = new System.Drawing.Size(165, 20);
            this.txtMonedaDestino.TabIndex = 89;
            // 
            // txtintento
            // 
            this.txtintento.Location = new System.Drawing.Point(435, 638);
            this.txtintento.Name = "txtintento";
            this.txtintento.ReadOnly = true;
            this.txtintento.Size = new System.Drawing.Size(16, 20);
            this.txtintento.TabIndex = 90;
            // 
            // btnRegresarMenu
            // 
            this.btnRegresarMenu.Location = new System.Drawing.Point(195, 351);
            this.btnRegresarMenu.Name = "btnRegresarMenu";
            this.btnRegresarMenu.Size = new System.Drawing.Size(106, 43);
            this.btnRegresarMenu.TabIndex = 91;
            this.btnRegresarMenu.Text = "Regresar";
            this.btnRegresarMenu.UseVisualStyleBackColor = true;
            this.btnRegresarMenu.Click += new System.EventHandler(this.btnRegresarMenu_Click);
            // 
            // FormRealizarTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 749);
            this.Controls.Add(this.btnRegresarMenu);
            this.Controls.Add(this.txtintento);
            this.Controls.Add(this.txtMonedaDestino);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtVerificarClave);
            this.Controls.Add(this.txtCuentaOrigen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMontoDescontado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtComision);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTipoMoneda);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtApellidosUsuario);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.txtCuentaDestino);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtMontoTransferido);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtusuarioID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtValoracion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.btnBuscarID);
            this.Controls.Add(this.btnEntreCuentas);
            this.Controls.Add(this.text_idDestino);
            this.Controls.Add(this.dataTransaccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormRealizarTransaccion";
            this.Text = "FormRealizarTransaccion";
            ((System.ComponentModel.ISupportInitialize)(this.dataTransaccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_idDestino;
        private System.Windows.Forms.Button btnEntreCuentas;
        private System.Windows.Forms.Button btnBuscarID;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValoracion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDeMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtusuarioID;
        public System.Windows.Forms.DataGridView dataTransaccion;
        private System.Windows.Forms.TextBox txtCuentaOrigen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMontoDescontado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTipoMoneda;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtApellidosUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtCuentaDestino;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMontoTransferido;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtVerificarClave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMonedaDestino;
        private System.Windows.Forms.TextBox txtintento;
        private System.Windows.Forms.Button btnRegresarMenu;
    }
}