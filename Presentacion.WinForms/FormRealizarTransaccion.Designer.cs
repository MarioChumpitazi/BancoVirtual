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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEntreCuentas = new System.Windows.Forms.Button();
            this.btnTercero = new System.Windows.Forms.Button();
            this.btnBuscarID = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontoDescontado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApellidosUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRealizarOtraTransferencia = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "REALIZAR TRANSACCION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Cuenta Destino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "*Comisión de 0.50 céntimos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(483, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "*Comisión de 0.15%";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 28;
            // 
            // btnEntreCuentas
            // 
            this.btnEntreCuentas.Location = new System.Drawing.Point(169, 53);
            this.btnEntreCuentas.Name = "btnEntreCuentas";
            this.btnEntreCuentas.Size = new System.Drawing.Size(144, 51);
            this.btnEntreCuentas.TabIndex = 30;
            this.btnEntreCuentas.Text = "Realizar Transferencia entre mis cuentas";
            this.btnEntreCuentas.UseVisualStyleBackColor = true;
            this.btnEntreCuentas.Click += new System.EventHandler(this.btnEntreCuentas_Click);
            // 
            // btnTercero
            // 
            this.btnTercero.Location = new System.Drawing.Point(474, 53);
            this.btnTercero.Name = "btnTercero";
            this.btnTercero.Size = new System.Drawing.Size(127, 51);
            this.btnTercero.TabIndex = 31;
            this.btnTercero.Text = "Realizar Transferencia a un tercero";
            this.btnTercero.UseVisualStyleBackColor = true;
            this.btnTercero.Click += new System.EventHandler(this.btnTercero_Click);
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.Location = new System.Drawing.Point(435, 156);
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
            this.label2.Location = new System.Drawing.Point(42, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Clave";
            // 
            // txtMontoDescontado
            // 
            this.txtMontoDescontado.Location = new System.Drawing.Point(180, 365);
            this.txtMontoDescontado.Name = "txtMontoDescontado";
            this.txtMontoDescontado.Size = new System.Drawing.Size(151, 20);
            this.txtMontoDescontado.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 16);
            this.label6.TabIndex = 80;
            this.label6.Text = "Monto Descontado:";
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(132, 289);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(199, 20);
            this.txtComision.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 78;
            this.label7.Text = "Comision:";
            // 
            // txtApellidosUsuario
            // 
            this.txtApellidosUsuario.Location = new System.Drawing.Point(132, 238);
            this.txtApellidosUsuario.Name = "txtApellidosUsuario";
            this.txtApellidosUsuario.Size = new System.Drawing.Size(199, 20);
            this.txtApellidosUsuario.TabIndex = 75;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(132, 201);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(199, 20);
            this.txtNombreUsuario.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 72;
            this.label9.Text = "Apellidos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 71;
            this.label10.Text = "Nombre:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(511, 365);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 35);
            this.btnSalir.TabIndex = 70;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnRealizarOtraTransferencia
            // 
            this.btnRealizarOtraTransferencia.Location = new System.Drawing.Point(273, 402);
            this.btnRealizarOtraTransferencia.Name = "btnRealizarOtraTransferencia";
            this.btnRealizarOtraTransferencia.Size = new System.Drawing.Size(143, 45);
            this.btnRealizarOtraTransferencia.TabIndex = 69;
            this.btnRealizarOtraTransferencia.Text = "Realizar otra Transferencia";
            this.btnRealizarOtraTransferencia.UseVisualStyleBackColor = true;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(224, 324);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(107, 20);
            this.txtMonto.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 328);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 16);
            this.label12.TabIndex = 66;
            this.label12.Text = "Monto Transferido:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(76, 465);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(255, 16);
            this.label13.TabIndex = 65;
            this.label13.Text = "Se realizó con exito la transferencia";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(96, 415);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(151, 20);
            this.txtClave.TabIndex = 82;
            // 
            // FormRealizarTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtMontoDescontado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtComision);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtApellidosUsuario);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRealizarOtraTransferencia);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarID);
            this.Controls.Add(this.btnTercero);
            this.Controls.Add(this.btnEntreCuentas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormRealizarTransaccion";
            this.Text = "FormRealizarTransaccion";
            this.Load += new System.EventHandler(this.FormRealizarTransaccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEntreCuentas;
        private System.Windows.Forms.Button btnTercero;
        private System.Windows.Forms.Button btnBuscarID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMontoDescontado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApellidosUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRealizarOtraTransferencia;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtClave;
    }
}