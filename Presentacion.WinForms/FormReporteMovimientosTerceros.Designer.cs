namespace Presentacion.WinForms
{
    partial class FormReporteMovimientosTerceros
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
            this.dataMovimientosTerceros = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelValorizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalGeneral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarID = new System.Windows.Forms.Button();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.txtCuentaID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataMovimientosTerceros)).BeginInit();
            this.SuspendLayout();
            // 
            // dataMovimientosTerceros
            // 
            this.dataMovimientosTerceros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMovimientosTerceros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mes,
            this.UsuarioID,
            this.TotalMonto,
            this.NivelValorizacion,
            this.NivelMovimiento,
            this.TotalSoles,
            this.TotalDolares,
            this.TotalGeneral});
            this.dataMovimientosTerceros.Location = new System.Drawing.Point(27, 162);
            this.dataMovimientosTerceros.Name = "dataMovimientosTerceros";
            this.dataMovimientosTerceros.Size = new System.Drawing.Size(867, 224);
            this.dataMovimientosTerceros.TabIndex = 40;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(649, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 41;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(236, 392);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 42;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // Mes
            // 
            this.Mes.FillWeight = 50F;
            this.Mes.HeaderText = "N° Mes";
            this.Mes.Name = "Mes";
            // 
            // UsuarioID
            // 
            this.UsuarioID.HeaderText = "ID Usuario";
            this.UsuarioID.Name = "UsuarioID";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Numero de Mes";
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.Location = new System.Drawing.Point(499, 97);
            this.btnBuscarID.Name = "btnBuscarID";
            this.btnBuscarID.Size = new System.Drawing.Size(83, 23);
            this.btnBuscarID.TabIndex = 46;
            this.btnBuscarID.Text = "Buscar";
            this.btnBuscarID.UseVisualStyleBackColor = true;
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "Soles",
            "Dolares"});
            this.cmbMes.Location = new System.Drawing.Point(229, 59);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 21);
            this.cmbMes.TabIndex = 45;
            // 
            // txtCuentaID
            // 
            this.txtCuentaID.Location = new System.Drawing.Point(239, 100);
            this.txtCuentaID.Name = "txtCuentaID";
            this.txtCuentaID.Size = new System.Drawing.Size(236, 20);
            this.txtCuentaID.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "ID Cuenta Destino:";
            // 
            // FormReporteMovimientosTerceros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarID);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.txtCuentaID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataMovimientosTerceros);
            this.Name = "FormReporteMovimientosTerceros";
            this.Text = "FormReporteMovimientosTerceros";
            ((System.ComponentModel.ISupportInitialize)(this.dataMovimientosTerceros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataMovimientosTerceros;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelValorizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalGeneral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarID;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.TextBox txtCuentaID;
        private System.Windows.Forms.Label label3;
    }
}