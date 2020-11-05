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
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuentaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelValorizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalGeneral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscarTransaccionesOtraCuenta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarTransaccionesCuentaPropia = new System.Windows.Forms.Button();
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
            this.dataMovimientosEntreCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMovimientosEntreCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mes,
            this.CuentaID,
            this.TotalMonto,
            this.NivelValorizacion,
            this.NivelMovimiento,
            this.TotalSoles,
            this.TotalDolares,
            this.TotalGeneral});
            this.dataMovimientosEntreCuentas.Location = new System.Drawing.Point(23, 162);
            this.dataMovimientosEntreCuentas.Name = "dataMovimientosEntreCuentas";
            this.dataMovimientosEntreCuentas.Size = new System.Drawing.Size(867, 224);
            this.dataMovimientosEntreCuentas.TabIndex = 43;
            // 
            // Mes
            // 
            this.Mes.FillWeight = 50F;
            this.Mes.HeaderText = "N° Mes";
            this.Mes.Name = "Mes";
            // 
            // CuentaID
            // 
            this.CuentaID.HeaderText = "ID Cuenta";
            this.CuentaID.Name = "CuentaID";
            // 
            // TotalMonto
            // 
            this.TotalMonto.HeaderText = "Monto Total ";
            this.TotalMonto.Name = "TotalMonto";
            // 
            // NivelValorizacion
            // 
            this.NivelValorizacion.HeaderText = "Nivel Valorizacion";
            this.NivelValorizacion.Name = "NivelValorizacion";
            this.NivelValorizacion.Width = 150;
            // 
            // NivelMovimiento
            // 
            this.NivelMovimiento.HeaderText = "Nivel de Movimiento";
            this.NivelMovimiento.Name = "NivelMovimiento";
            this.NivelMovimiento.Width = 80;
            // 
            // TotalSoles
            // 
            this.TotalSoles.HeaderText = "Total Soles";
            this.TotalSoles.Name = "TotalSoles";
            // 
            // TotalDolares
            // 
            this.TotalDolares.HeaderText = "Total Dolares";
            this.TotalDolares.Name = "TotalDolares";
            // 
            // TotalGeneral
            // 
            this.TotalGeneral.HeaderText = "TotalGeneral";
            this.TotalGeneral.Name = "TotalGeneral";
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
            // FormGenerarReporteMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 490);
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
        private System.Windows.Forms.DataGridView dataMovimientosEntreCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuentaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelValorizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalGeneral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscarTransaccionesOtraCuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarTransaccionesCuentaPropia;
    }
}