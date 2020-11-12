namespace Presentacion.WinForms
{
    partial class FormGenerarReporteMovimientos
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataMovimientosEntreCuentas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscarTransaccionesOtraCuenta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarTransaccionesCuentaPropia = new System.Windows.Forms.Button();
            this.txtusuarioID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNivelValorizacion = new System.Windows.Forms.ComboBox();
            this.txtNivelMovimiento = new System.Windows.Forms.ComboBox();
            this.txtTotalSoles = new System.Windows.Forms.ComboBox();
            this.txtTotalDolares = new System.Windows.Forms.ComboBox();
            this.txtGeneral = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.TotalDolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuentaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelValorizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodemoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataMovimientosEntreCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(724, 419);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(141, 48);
            this.btnSalir.TabIndex = 44;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dataMovimientosEntreCuentas
            // 
            this.dataMovimientosEntreCuentas.AllowUserToAddRows = false;
            this.dataMovimientosEntreCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMovimientosEntreCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TotalDolares,
            this.fecha,
            this.CuentaID,
            this.TipoMoneda,
            this.TotalMonto,
            this.NivelValorizacion,
            this.tipodemoneda});
            this.dataMovimientosEntreCuentas.Location = new System.Drawing.Point(23, 154);
            this.dataMovimientosEntreCuentas.Name = "dataMovimientosEntreCuentas";
            this.dataMovimientosEntreCuentas.Size = new System.Drawing.Size(684, 152);
            this.dataMovimientosEntreCuentas.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(551, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 50;
            // 
            // btn_buscarTransaccionesOtraCuenta
            // 
            this.btn_buscarTransaccionesOtraCuenta.Location = new System.Drawing.Point(766, 121);
            this.btn_buscarTransaccionesOtraCuenta.Name = "btn_buscarTransaccionesOtraCuenta";
            this.btn_buscarTransaccionesOtraCuenta.Size = new System.Drawing.Size(129, 37);
            this.btn_buscarTransaccionesOtraCuenta.TabIndex = 51;
            this.btn_buscarTransaccionesOtraCuenta.Text = "Transacciones a otra cuenta";
            this.btn_buscarTransaccionesOtraCuenta.UseVisualStyleBackColor = true;
            this.btn_buscarTransaccionesOtraCuenta.Click += new System.EventHandler(this.btn_buscarTransaccionesOtraCuenta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "GENERAR REPORTE DE MOVIMIENTOS";
            // 
            // btnBuscarTransaccionesCuentaPropia
            // 
            this.btnBuscarTransaccionesCuentaPropia.Location = new System.Drawing.Point(766, 178);
            this.btnBuscarTransaccionesCuentaPropia.Name = "btnBuscarTransaccionesCuentaPropia";
            this.btnBuscarTransaccionesCuentaPropia.Size = new System.Drawing.Size(129, 37);
            this.btnBuscarTransaccionesCuentaPropia.TabIndex = 53;
            this.btnBuscarTransaccionesCuentaPropia.Text = "Transacciones a cuenta propia";
            this.btnBuscarTransaccionesCuentaPropia.UseVisualStyleBackColor = true;
            this.btnBuscarTransaccionesCuentaPropia.Click += new System.EventHandler(this.btnBuscarTransaccionesCuentaPropia_Click);
            // 
            // txtusuarioID
            // 
            this.txtusuarioID.Location = new System.Drawing.Point(824, 23);
            this.txtusuarioID.Name = "txtusuarioID";
            this.txtusuarioID.Size = new System.Drawing.Size(95, 20);
            this.txtusuarioID.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(733, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 54;
            this.label9.Text = "Usuario ID:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(300, 80);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 30);
            this.btnBuscar.TabIndex = 56;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Cuenta Origen:";
            // 
            // txtCuenta
            // 
            this.txtCuenta.FormattingEnabled = true;
            this.txtCuenta.Location = new System.Drawing.Point(150, 83);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(132, 21);
            this.txtCuenta.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Nivel de Valorización:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Nivel de Movimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Total Transaccion Soles:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Total Transaccion Dolares:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Total Movimiento General:";
            // 
            // txtNivelValorizacion
            // 
            this.txtNivelValorizacion.FormattingEnabled = true;
            this.txtNivelValorizacion.Location = new System.Drawing.Point(175, 344);
            this.txtNivelValorizacion.Name = "txtNivelValorizacion";
            this.txtNivelValorizacion.Size = new System.Drawing.Size(121, 21);
            this.txtNivelValorizacion.TabIndex = 65;
            // 
            // txtNivelMovimiento
            // 
            this.txtNivelMovimiento.FormattingEnabled = true;
            this.txtNivelMovimiento.Location = new System.Drawing.Point(161, 376);
            this.txtNivelMovimiento.Name = "txtNivelMovimiento";
            this.txtNivelMovimiento.Size = new System.Drawing.Size(121, 21);
            this.txtNivelMovimiento.TabIndex = 66;
            // 
            // txtTotalSoles
            // 
            this.txtTotalSoles.FormattingEnabled = true;
            this.txtTotalSoles.Location = new System.Drawing.Point(180, 403);
            this.txtTotalSoles.Name = "txtTotalSoles";
            this.txtTotalSoles.Size = new System.Drawing.Size(121, 21);
            this.txtTotalSoles.TabIndex = 67;
            // 
            // txtTotalDolares
            // 
            this.txtTotalDolares.FormattingEnabled = true;
            this.txtTotalDolares.Location = new System.Drawing.Point(190, 427);
            this.txtTotalDolares.Name = "txtTotalDolares";
            this.txtTotalDolares.Size = new System.Drawing.Size(121, 21);
            this.txtTotalDolares.TabIndex = 68;
            // 
            // txtGeneral
            // 
            this.txtGeneral.FormattingEnabled = true;
            this.txtGeneral.Location = new System.Drawing.Point(186, 457);
            this.txtGeneral.Name = "txtGeneral";
            this.txtGeneral.Size = new System.Drawing.Size(121, 21);
            this.txtGeneral.TabIndex = 69;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(375, 390);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 41);
            this.btnCalcular.TabIndex = 72;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // TotalDolares
            // 
            this.TotalDolares.HeaderText = "TransaccionID";
            this.TotalDolares.Name = "TotalDolares";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Hora y fecha";
            this.fecha.Name = "fecha";
            // 
            // CuentaID
            // 
            this.CuentaID.HeaderText = "MontoTransferido";
            this.CuentaID.Name = "CuentaID";
            // 
            // TipoMoneda
            // 
            this.TipoMoneda.HeaderText = "Tipo Moneda";
            this.TipoMoneda.Name = "TipoMoneda";
            // 
            // TotalMonto
            // 
            this.TotalMonto.HeaderText = "Valoracion";
            this.TotalMonto.Name = "TotalMonto";
            // 
            // NivelValorizacion
            // 
            this.NivelValorizacion.HeaderText = "Cuenta Origen";
            this.NivelValorizacion.Name = "NivelValorizacion";
            this.NivelValorizacion.Width = 120;
            // 
            // tipodemoneda
            // 
            this.tipodemoneda.HeaderText = "Cuenta Destino";
            this.tipodemoneda.Name = "tipodemoneda";
            this.tipodemoneda.Width = 120;
            // 
            // FormGenerarReporteMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 490);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtGeneral);
            this.Controls.Add(this.txtTotalDolares);
            this.Controls.Add(this.txtTotalSoles);
            this.Controls.Add(this.txtNivelMovimiento);
            this.Controls.Add(this.txtNivelValorizacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtusuarioID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBuscarTransaccionesCuentaPropia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_buscarTransaccionesOtraCuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataMovimientosEntreCuentas);
            this.Name = "FormGenerarReporteMovimientos";
            this.Text = "FormReporteMovimientoEntreCuentas";
            ((System.ComponentModel.ISupportInitialize)(this.dataMovimientosEntreCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscarTransaccionesOtraCuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarTransaccionesCuentaPropia;
        public System.Windows.Forms.DataGridView dataMovimientosEntreCuentas;
        public System.Windows.Forms.TextBox txtusuarioID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtNivelValorizacion;
        private System.Windows.Forms.ComboBox txtNivelMovimiento;
        private System.Windows.Forms.ComboBox txtTotalSoles;
        private System.Windows.Forms.ComboBox txtTotalDolares;
        private System.Windows.Forms.ComboBox txtGeneral;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuentaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelValorizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodemoneda;
    }
}