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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDeCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDeMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbTipoMoneda = new System.Windows.Forms.ComboBox();
            this.btnEntreCuentas = new System.Windows.Forms.Button();
            this.btnTercero = new System.Windows.Forms.Button();
            this.btnBuscarID = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "REALIZAR TRANSACCION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Cuenta Destino:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellidos,
            this.DNI,
            this.NumeroDeCuenta,
            this.MontoActual,
            this.TipoDeMoneda});
            this.dataGridView1.Location = new System.Drawing.Point(59, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(673, 132);
            this.dataGridView1.TabIndex = 10;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // NumeroDeCuenta
            // 
            this.NumeroDeCuenta.HeaderText = "NumeroDeCuenta";
            this.NumeroDeCuenta.Name = "NumeroDeCuenta";
            this.NumeroDeCuenta.Width = 150;
            // 
            // MontoActual
            // 
            this.MontoActual.HeaderText = "MontoActual";
            this.MontoActual.Name = "MontoActual";
            this.MontoActual.Width = 80;
            // 
            // TipoDeMoneda
            // 
            this.TipoDeMoneda.HeaderText = "TipoDeMoneda";
            this.TipoDeMoneda.Name = "TipoDeMoneda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "*Comisión de 0.50 céntimos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(449, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "*Comisión de 0.15%";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(227, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 28;
            // 
            // cmbTipoMoneda
            // 
            this.cmbTipoMoneda.FormattingEnabled = true;
            this.cmbTipoMoneda.Items.AddRange(new object[] {
            "Soles",
            "Dolares"});
            this.cmbTipoMoneda.Location = new System.Drawing.Point(227, 130);
            this.cmbTipoMoneda.Name = "cmbTipoMoneda";
            this.cmbTipoMoneda.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoMoneda.TabIndex = 29;
            // 
            // btnEntreCuentas
            // 
            this.btnEntreCuentas.Location = new System.Drawing.Point(191, 338);
            this.btnEntreCuentas.Name = "btnEntreCuentas";
            this.btnEntreCuentas.Size = new System.Drawing.Size(144, 51);
            this.btnEntreCuentas.TabIndex = 30;
            this.btnEntreCuentas.Text = "Realizar Transferencia entre mis cuentas";
            this.btnEntreCuentas.UseVisualStyleBackColor = true;
            this.btnEntreCuentas.Click += new System.EventHandler(this.btnEntreCuentas_Click);
            // 
            // btnTercero
            // 
            this.btnTercero.Location = new System.Drawing.Point(440, 338);
            this.btnTercero.Name = "btnTercero";
            this.btnTercero.Size = new System.Drawing.Size(127, 51);
            this.btnTercero.TabIndex = 31;
            this.btnTercero.Text = "Realizar Transferencia a un tercero";
            this.btnTercero.UseVisualStyleBackColor = true;
            this.btnTercero.Click += new System.EventHandler(this.btnTercero_Click);
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.Location = new System.Drawing.Point(492, 104);
            this.btnBuscarID.Name = "btnBuscarID";
            this.btnBuscarID.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarID.TabIndex = 32;
            this.btnBuscarID.Text = "Buscar";
            this.btnBuscarID.UseVisualStyleBackColor = true;
            this.btnBuscarID.Click += new System.EventHandler(this.btnBuscarID_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tipo de Moneda";
            // 
            // FormRealizarTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarID);
            this.Controls.Add(this.btnTercero);
            this.Controls.Add(this.btnEntreCuentas);
            this.Controls.Add(this.cmbTipoMoneda);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormRealizarTransaccion";
            this.Text = "FormRealizarTransaccion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDeCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDeMoneda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbTipoMoneda;
        private System.Windows.Forms.Button btnEntreCuentas;
        private System.Windows.Forms.Button btnTercero;
        private System.Windows.Forms.Button btnBuscarID;
        private System.Windows.Forms.Label label2;
    }
}