namespace Presentacion.WinForms
{
    partial class FormReporteMovimientos
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataMovimientosEntreCuentas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarID = new System.Windows.Forms.Button();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.txtCuentaID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuarioID = new System.Windows.Forms.TextBox();
            this.txtMovimiento = new System.Windows.Forms.TextBox();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuentaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelValorizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalGeneral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataMovimientosEntreCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(161, 405);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 45;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(416, 405);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 44;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dataMovimientosEntreCuentas
            // 
            this.dataMovimientosEntreCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMovimientosEntreCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mes,
            this.usuarioID,
            this.tipoMovimiento,
            this.CuentaID,
            this.TotalMonto,
            this.NivelValorizacion,
            this.NivelMovimiento,
            this.TotalSoles,
            this.TotalDolares,
            this.TotalGeneral});
            this.dataMovimientosEntreCuentas.Location = new System.Drawing.Point(12, 162);
            this.dataMovimientosEntreCuentas.Name = "dataMovimientosEntreCuentas";
            this.dataMovimientosEntreCuentas.Size = new System.Drawing.Size(1047, 224);
            this.dataMovimientosEntreCuentas.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Numero de Mes";
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.Location = new System.Drawing.Point(522, 60);
            this.btnBuscarID.Name = "btnBuscarID";
            this.btnBuscarID.Size = new System.Drawing.Size(83, 23);
            this.btnBuscarID.TabIndex = 49;
            this.btnBuscarID.Text = "Buscar";
            this.btnBuscarID.UseVisualStyleBackColor = true;
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "Soles",
            "Dolares"});
            this.cmbMes.Location = new System.Drawing.Point(185, 119);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 21);
            this.cmbMes.TabIndex = 48;
            // 
            // txtCuentaID
            // 
            this.txtCuentaID.Location = new System.Drawing.Point(185, 31);
            this.txtCuentaID.Name = "txtCuentaID";
            this.txtCuentaID.Size = new System.Drawing.Size(236, 20);
            this.txtCuentaID.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Tipo Movimiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "ID Cuenta Destino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "ID Usuario Destino:";
            // 
            // txtUsuarioID
            // 
            this.txtUsuarioID.Location = new System.Drawing.Point(185, 57);
            this.txtUsuarioID.Name = "txtUsuarioID";
            this.txtUsuarioID.Size = new System.Drawing.Size(236, 20);
            this.txtUsuarioID.TabIndex = 53;
            // 
            // txtMovimiento
            // 
            this.txtMovimiento.Location = new System.Drawing.Point(185, 93);
            this.txtMovimiento.Name = "txtMovimiento";
            this.txtMovimiento.Size = new System.Drawing.Size(236, 20);
            this.txtMovimiento.TabIndex = 54;
            // 
            // Mes
            // 
            this.Mes.FillWeight = 50F;
            this.Mes.HeaderText = "N° Mes";
            this.Mes.Name = "Mes";
            // 
            // usuarioID
            // 
            this.usuarioID.HeaderText = "ID Usuario";
            this.usuarioID.Name = "usuarioID";
            // 
            // tipoMovimiento
            // 
            this.tipoMovimiento.HeaderText = "Tipo Movimiento";
            this.tipoMovimiento.Name = "tipoMovimiento";
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
            // FormReporteMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 450);
            this.Controls.Add(this.txtMovimiento);
            this.Controls.Add(this.txtUsuarioID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarID);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.txtCuentaID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataMovimientosEntreCuentas);
            this.Name = "FormReporteMovimientos";
            this.Text = "FormReporteMovimientoEntreCuentas";
            ((System.ComponentModel.ISupportInitialize)(this.dataMovimientosEntreCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataMovimientosEntreCuentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarID;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.TextBox txtCuentaID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuentaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelValorizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalGeneral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuarioID;
        private System.Windows.Forms.TextBox txtMovimiento;
    }
}