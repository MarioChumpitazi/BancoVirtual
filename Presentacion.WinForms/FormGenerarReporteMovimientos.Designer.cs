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
            this.dataMovimientosEntreCuentas = new System.Windows.Forms.DataGridView();
            this.TotalDolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuentaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelValorizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodemoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusuarioID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_cuentaID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_promedioValorización = new System.Windows.Forms.TextBox();
            this.txt_TotalTransferidoSoles = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_NivelMovimiento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TotalTransferidoDolares = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_totalGeneral = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataMovimientosEntreCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataMovimientosEntreCuentas
            // 
            this.dataMovimientosEntreCuentas.AllowUserToAddRows = false;
            this.dataMovimientosEntreCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMovimientosEntreCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TotalDolares,
            this.fecha,
            this.CuentaID,
            this.TotalMonto,
            this.NivelValorizacion,
            this.tipodemoneda,
            this.Column1});
            this.dataMovimientosEntreCuentas.Location = new System.Drawing.Point(47, 144);
            this.dataMovimientosEntreCuentas.Name = "dataMovimientosEntreCuentas";
            this.dataMovimientosEntreCuentas.Size = new System.Drawing.Size(804, 228);
            this.dataMovimientosEntreCuentas.TabIndex = 43;

            // 
            // TotalDolares
            // 
            this.TotalDolares.HeaderText = "TransaccionID";
            this.TotalDolares.Name = "TotalDolares";
            this.TotalDolares.Width = 120;
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
            // Column1
            // 
            this.Column1.HeaderText = "Tipo De Moneda";
            this.Column1.Name = "Column1";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "GENERAR REPORTE DE MOVIMIENTOS";
            // 
            // txtusuarioID
            // 
            this.txtusuarioID.Location = new System.Drawing.Point(810, 24);
            this.txtusuarioID.Name = "txtusuarioID";
            this.txtusuarioID.Size = new System.Drawing.Size(95, 20);
            this.txtusuarioID.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(719, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 54;
            this.label9.Text = "Usuario ID:";
            // 
            // txt_cuentaID
            // 
            this.txt_cuentaID.Location = new System.Drawing.Point(152, 93);
            this.txt_cuentaID.Name = "txt_cuentaID";
            this.txt_cuentaID.Size = new System.Drawing.Size(111, 20);
            this.txt_cuentaID.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "id Cuenta  :";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(278, 88);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(80, 29);
            this.btn_Buscar.TabIndex = 58;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(483, 395);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(113, 46);
            this.btn_Calcular.TabIndex = 59;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 16);
            this.label5.TabIndex = 61;
            this.label5.Text = "Monto Total Transferido Soles:";
            // 
            // txt_promedioValorización
            // 
            this.txt_promedioValorización.Location = new System.Drawing.Point(287, 394);
            this.txt_promedioValorización.Name = "txt_promedioValorización";
            this.txt_promedioValorización.Size = new System.Drawing.Size(111, 20);
            this.txt_promedioValorización.TabIndex = 62;
            // 
            // txt_TotalTransferidoSoles
            // 
            this.txt_TotalTransferidoSoles.Location = new System.Drawing.Point(287, 421);
            this.txt_TotalTransferidoSoles.Name = "txt_TotalTransferidoSoles";
            this.txt_TotalTransferidoSoles.Size = new System.Drawing.Size(111, 20);
            this.txt_TotalTransferidoSoles.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(95, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 16);
            this.label6.TabIndex = 64;
            this.label6.Text = "Nivel  de Valorización :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(106, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 16);
            this.label7.TabIndex = 65;
            this.label7.Text = "Nivel de Movimiento :";
            // 
            // txt_NivelMovimiento
            // 
            this.txt_NivelMovimiento.Location = new System.Drawing.Point(287, 482);
            this.txt_NivelMovimiento.Name = "txt_NivelMovimiento";
            this.txt_NivelMovimiento.Size = new System.Drawing.Size(111, 20);
            this.txt_NivelMovimiento.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 456);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 16);
            this.label8.TabIndex = 67;
            this.label8.Text = "Monto Total Transferido Dolares:";
            // 
            // txt_TotalTransferidoDolares
            // 
            this.txt_TotalTransferidoDolares.Location = new System.Drawing.Point(287, 452);
            this.txt_TotalTransferidoDolares.Name = "txt_TotalTransferidoDolares";
            this.txt_TotalTransferidoDolares.Size = new System.Drawing.Size(111, 20);
            this.txt_TotalTransferidoDolares.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(106, 514);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 16);
            this.label10.TabIndex = 69;
            this.label10.Text = "Total General :";
            // 
            // txt_totalGeneral
            // 
            this.txt_totalGeneral.Location = new System.Drawing.Point(287, 510);
            this.txt_totalGeneral.Name = "txt_totalGeneral";
            this.txt_totalGeneral.Size = new System.Drawing.Size(111, 20);
            this.txt_totalGeneral.TabIndex = 70;
            // 
            // FormGenerarReporteMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 573);
            this.Controls.Add(this.txt_totalGeneral);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_TotalTransferidoDolares);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_NivelMovimiento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_TotalTransferidoSoles);
            this.Controls.Add(this.txt_promedioValorización);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cuentaID);
            this.Controls.Add(this.txtusuarioID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataMovimientosEntreCuentas);
            this.Name = "FormGenerarReporteMovimientos";
            this.Text = "FormReporteMovimientoEntreCuentas";
            ((System.ComponentModel.ISupportInitialize)(this.dataMovimientosEntreCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataMovimientosEntreCuentas;
        public System.Windows.Forms.TextBox txtusuarioID;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txt_cuentaID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_promedioValorización;
        public System.Windows.Forms.TextBox txt_TotalTransferidoSoles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_NivelMovimiento;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_TotalTransferidoDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuentaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelValorizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodemoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txt_totalGeneral;
    }
}