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
            this.btnGenerarOtro = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataMovimientosEntreCuentas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarID = new System.Windows.Forms.Button();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuarioID = new System.Windows.Forms.TextBox();
            this.txtMovimiento = new System.Windows.Forms.TextBox();
            this.txtNivelMovimiento = new System.Windows.Forms.TextBox();
            this.txtTransaccionSoles = new System.Windows.Forms.TextBox();
            this.txtTransaccionDolaes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalGeneral = new System.Windows.Forms.TextBox();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuentaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valorizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNivelValorizacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataMovimientosEntreCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerarOtro
            // 
            this.btnGenerarOtro.Location = new System.Drawing.Point(571, 454);
            this.btnGenerarOtro.Name = "btnGenerarOtro";
            this.btnGenerarOtro.Size = new System.Drawing.Size(87, 34);
            this.btnGenerarOtro.TabIndex = 45;
            this.btnGenerarOtro.Text = "Generar otro Reporte";
            this.btnGenerarOtro.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(698, 454);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(72, 34);
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
            this.tipoMoneda,
            this.CuentaID,
            this.TotalMonto,
            this.Valorizacion});
            this.dataMovimientosEntreCuentas.Location = new System.Drawing.Point(12, 122);
            this.dataMovimientosEntreCuentas.Name = "dataMovimientosEntreCuentas";
            this.dataMovimientosEntreCuentas.Size = new System.Drawing.Size(689, 173);
            this.dataMovimientosEntreCuentas.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Numero de Mes";
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.Location = new System.Drawing.Point(510, 25);
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
            this.cmbMes.Location = new System.Drawing.Point(173, 84);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 21);
            this.cmbMes.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Tipo Movimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "ID Usuario Destino:";
            // 
            // txtUsuarioID
            // 
            this.txtUsuarioID.Location = new System.Drawing.Point(173, 22);
            this.txtUsuarioID.Name = "txtUsuarioID";
            this.txtUsuarioID.Size = new System.Drawing.Size(236, 20);
            this.txtUsuarioID.TabIndex = 53;
            this.txtUsuarioID.TextChanged += new System.EventHandler(this.txtUsuarioID_TextChanged);
            // 
            // txtMovimiento
            // 
            this.txtMovimiento.Location = new System.Drawing.Point(173, 58);
            this.txtMovimiento.Name = "txtMovimiento";
            this.txtMovimiento.Size = new System.Drawing.Size(236, 20);
            this.txtMovimiento.TabIndex = 54;
            // 
            // txtNivelMovimiento
            // 
            this.txtNivelMovimiento.Location = new System.Drawing.Point(240, 355);
            this.txtNivelMovimiento.Name = "txtNivelMovimiento";
            this.txtNivelMovimiento.Size = new System.Drawing.Size(236, 20);
            this.txtNivelMovimiento.TabIndex = 55;
            // 
            // txtTransaccionSoles
            // 
            this.txtTransaccionSoles.Location = new System.Drawing.Point(240, 388);
            this.txtTransaccionSoles.Name = "txtTransaccionSoles";
            this.txtTransaccionSoles.Size = new System.Drawing.Size(236, 20);
            this.txtTransaccionSoles.TabIndex = 56;
            // 
            // txtTransaccionDolaes
            // 
            this.txtTransaccionDolaes.Location = new System.Drawing.Point(240, 421);
            this.txtTransaccionDolaes.Name = "txtTransaccionDolaes";
            this.txtTransaccionDolaes.Size = new System.Drawing.Size(236, 20);
            this.txtTransaccionDolaes.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Nivel de Movimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "Total Transaccion Soles :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "Total Transaccion Dolares: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 61;
            this.label7.Text = "Total General:";
            // 
            // txtTotalGeneral
            // 
            this.txtTotalGeneral.Location = new System.Drawing.Point(240, 454);
            this.txtTotalGeneral.Name = "txtTotalGeneral";
            this.txtTotalGeneral.Size = new System.Drawing.Size(236, 20);
            this.txtTotalGeneral.TabIndex = 62;
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
            // tipoMoneda
            // 
            this.tipoMoneda.HeaderText = "Tipo Moneda";
            this.tipoMoneda.Name = "tipoMoneda";
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
            // Valorizacion
            // 
            this.Valorizacion.HeaderText = "Valorizacion";
            this.Valorizacion.Name = "Valorizacion";
            this.Valorizacion.Width = 150;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 16);
            this.label8.TabIndex = 63;
            this.label8.Text = "Nivel de Valorizacion:";
            // 
            // txtNivelValorizacion
            // 
            this.txtNivelValorizacion.Location = new System.Drawing.Point(240, 320);
            this.txtNivelValorizacion.Name = "txtNivelValorizacion";
            this.txtNivelValorizacion.Size = new System.Drawing.Size(236, 20);
            this.txtNivelValorizacion.TabIndex = 64;
            // 
            // FormReporteMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 505);
            this.Controls.Add(this.txtNivelValorizacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalGeneral);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTransaccionDolaes);
            this.Controls.Add(this.txtTransaccionSoles);
            this.Controls.Add(this.txtNivelMovimiento);
            this.Controls.Add(this.txtMovimiento);
            this.Controls.Add(this.txtUsuarioID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarID);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGenerarOtro);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataMovimientosEntreCuentas);
            this.Name = "FormReporteMovimientos";
            this.Text = "FormReporteMovimiento";
            this.Load += new System.EventHandler(this.FormReporteMovimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataMovimientosEntreCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarOtro;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataMovimientosEntreCuentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarID;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuarioID;
        private System.Windows.Forms.TextBox txtMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuentaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valorizacion;
        private System.Windows.Forms.TextBox txtNivelMovimiento;
        private System.Windows.Forms.TextBox txtTransaccionSoles;
        private System.Windows.Forms.TextBox txtTransaccionDolaes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalGeneral;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNivelValorizacion;
    }
}