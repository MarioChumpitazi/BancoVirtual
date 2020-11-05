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
            this.UsuarioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuentaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelValorizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscarTransaccionesOtraCuenta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarTransaccionesCuentaPropia = new System.Windows.Forms.Button();
            this.txtusuarioID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataMovimientosEntreCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(383, 419);
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
            this.UsuarioID,
            this.TotalSoles,
            this.TotalDolares,
            this.CuentaID,
            this.TotalMonto,
            this.NivelValorizacion,
            this.mes});
            this.dataMovimientosEntreCuentas.Location = new System.Drawing.Point(81, 152);
            this.dataMovimientosEntreCuentas.Name = "dataMovimientosEntreCuentas";
            this.dataMovimientosEntreCuentas.Size = new System.Drawing.Size(795, 224);
            this.dataMovimientosEntreCuentas.TabIndex = 43;
            // 
            // UsuarioID
            // 
            this.UsuarioID.FillWeight = 50F;
            this.UsuarioID.HeaderText = "Nombre";
            this.UsuarioID.Name = "UsuarioID";
            // 
            // TotalSoles
            // 
            this.TotalSoles.HeaderText = "Apellidos";
            this.TotalSoles.Name = "TotalSoles";
            // 
            // TotalDolares
            // 
            this.TotalDolares.HeaderText = "CuentaID";
            this.TotalDolares.Name = "TotalDolares";
            // 
            // CuentaID
            // 
            this.CuentaID.HeaderText = "Saldo";
            this.CuentaID.Name = "CuentaID";
            // 
            // TotalMonto
            // 
            this.TotalMonto.HeaderText = "Monto Total Transferido";
            this.TotalMonto.Name = "TotalMonto";
            // 
            // NivelValorizacion
            // 
            this.NivelValorizacion.HeaderText = "Promedio Valorización";
            this.NivelValorizacion.Name = "NivelValorizacion";
            this.NivelValorizacion.Width = 150;
            // 
            // mes
            // 
            this.mes.HeaderText = "Mes";
            this.mes.Name = "mes";
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
            this.btn_buscarTransaccionesOtraCuenta.Location = new System.Drawing.Point(580, 98);
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
            this.btnBuscarTransaccionesCuentaPropia.Location = new System.Drawing.Point(240, 98);
            this.btnBuscarTransaccionesCuentaPropia.Name = "btnBuscarTransaccionesCuentaPropia";
            this.btnBuscarTransaccionesCuentaPropia.Size = new System.Drawing.Size(129, 37);
            this.btnBuscarTransaccionesCuentaPropia.TabIndex = 53;
            this.btnBuscarTransaccionesCuentaPropia.Text = "Transacciones a otra cuenta";
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
            // FormGenerarReporteMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 490);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuentaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelValorizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
    }
}