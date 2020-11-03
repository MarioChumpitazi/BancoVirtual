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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_idDestino = new System.Windows.Forms.TextBox();
            this.btnEntreCuentas = new System.Windows.Forms.Button();
            this.btnTercero = new System.Windows.Forms.Button();
            this.btnBuscarID = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValoracion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textEstado = new System.Windows.Forms.TextBox();
            this.IDCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDeMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtusuarioID = new System.Windows.Forms.TextBox();
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
            this.label3.Location = new System.Drawing.Point(56, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Cuenta Destino:";
            // 
            // dataTransaccion
            // 
            this.dataTransaccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTransaccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCuenta,
            this.Saldo,
            this.TipoDeMoneda,
            this.Apellidos});
            this.dataTransaccion.Location = new System.Drawing.Point(88, 80);
            this.dataTransaccion.Name = "dataTransaccion";
            this.dataTransaccion.Size = new System.Drawing.Size(644, 132);
            this.dataTransaccion.TabIndex = 10;
            this.dataTransaccion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(245, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "*Comisión de 0.50 céntimos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(524, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "*Comisión de 0.15%";
            // 
            // text_idDestino
            // 
            this.text_idDestino.Location = new System.Drawing.Point(204, 240);
            this.text_idDestino.Name = "text_idDestino";
            this.text_idDestino.Size = new System.Drawing.Size(142, 20);
            this.text_idDestino.TabIndex = 28;
            // 
            // btnEntreCuentas
            // 
            this.btnEntreCuentas.Location = new System.Drawing.Point(264, 345);
            this.btnEntreCuentas.Name = "btnEntreCuentas";
            this.btnEntreCuentas.Size = new System.Drawing.Size(144, 51);
            this.btnEntreCuentas.TabIndex = 30;
            this.btnEntreCuentas.Text = "Realizar Transferencia ";
            this.btnEntreCuentas.UseVisualStyleBackColor = true;
            this.btnEntreCuentas.Click += new System.EventHandler(this.btnEntreCuentas_Click);
            // 
            // btnTercero
            // 
            this.btnTercero.Location = new System.Drawing.Point(515, 345);
            this.btnTercero.Name = "btnTercero";
            this.btnTercero.Size = new System.Drawing.Size(127, 51);
            this.btnTercero.TabIndex = 31;
            this.btnTercero.Text = "Realizar Transferencia a un tercero";
            this.btnTercero.UseVisualStyleBackColor = true;
            this.btnTercero.Click += new System.EventHandler(this.btnTercero_Click);
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.Location = new System.Drawing.Point(366, 238);
            this.btnBuscarID.Name = "btnBuscarID";
            this.btnBuscarID.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarID.TabIndex = 32;
            this.btnBuscarID.Text = "Buscar";
            this.btnBuscarID.UseVisualStyleBackColor = true;
            this.btnBuscarID.Click += new System.EventHandler(this.btnBuscarID_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(178, 273);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(144, 20);
            this.txtMonto.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Monto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Valoración:";
            // 
            // txtValoracion
            // 
            this.txtValoracion.Location = new System.Drawing.Point(178, 302);
            this.txtValoracion.Name = "txtValoracion";
            this.txtValoracion.Size = new System.Drawing.Size(144, 20);
            this.txtValoracion.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(496, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Nombre :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(496, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Estado :";
            // 
            // textEstado
            // 
            this.textEstado.Location = new System.Drawing.Point(573, 273);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(142, 20);
            this.textEstado.TabIndex = 40;
            // 
            // IDCuenta
            // 
            this.IDCuenta.HeaderText = "IDCuenta";
            this.IDCuenta.Name = "IDCuenta";
            this.IDCuenta.Width = 150;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.Width = 150;
            // 
            // TipoDeMoneda
            // 
            this.TipoDeMoneda.HeaderText = "TipoDeMoneda";
            this.TipoDeMoneda.Name = "TipoDeMoneda";
            this.TipoDeMoneda.Width = 150;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Estado";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Width = 150;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(573, 243);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(142, 20);
            this.textNombre.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(594, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Usuario :";
            // 
            // txtusuarioID
            // 
            this.txtusuarioID.Location = new System.Drawing.Point(670, 41);
            this.txtusuarioID.Name = "txtusuarioID";
            this.txtusuarioID.Size = new System.Drawing.Size(95, 20);
            this.txtusuarioID.TabIndex = 42;
            // 
            // FormRealizarTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.btnTercero);
            this.Controls.Add(this.btnEntreCuentas);
            this.Controls.Add(this.text_idDestino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataTransaccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormRealizarTransaccion";
            this.Text = "FormRealizarTransaccion";
            this.Load += new System.EventHandler(this.FormRealizarTransaccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTransaccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_idDestino;
        private System.Windows.Forms.Button btnEntreCuentas;
        private System.Windows.Forms.Button btnTercero;
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
    }
}