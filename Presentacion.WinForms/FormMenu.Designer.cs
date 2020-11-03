namespace Presentacion.WinForms
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.txtMenuUsuario = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnRealizarTransferencia = new System.Windows.Forms.Button();
            this.btnGenerarReporteMovimientos = new System.Windows.Forms.Button();
            this.txtusuarioID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMenuUsuario
            // 
            this.txtMenuUsuario.AutoSize = true;
            this.txtMenuUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenuUsuario.Location = new System.Drawing.Point(147, 59);
            this.txtMenuUsuario.Name = "txtMenuUsuario";
            this.txtMenuUsuario.Size = new System.Drawing.Size(200, 24);
            this.txtMenuUsuario.TabIndex = 3;
            this.txtMenuUsuario.Text = "MENU DE USUARIO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(124, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 141);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(523, 120);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(141, 141);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // btnRealizarTransferencia
            // 
            this.btnRealizarTransferencia.Location = new System.Drawing.Point(133, 292);
            this.btnRealizarTransferencia.Name = "btnRealizarTransferencia";
            this.btnRealizarTransferencia.Size = new System.Drawing.Size(123, 35);
            this.btnRealizarTransferencia.TabIndex = 11;
            this.btnRealizarTransferencia.Text = "Realizar Transacción";
            this.btnRealizarTransferencia.UseVisualStyleBackColor = true;
            this.btnRealizarTransferencia.Click += new System.EventHandler(this.btnRealizarTransferencia_Click);
            // 
            // btnGenerarReporteMovimientos
            // 
            this.btnGenerarReporteMovimientos.Location = new System.Drawing.Point(523, 285);
            this.btnGenerarReporteMovimientos.Name = "btnGenerarReporteMovimientos";
            this.btnGenerarReporteMovimientos.Size = new System.Drawing.Size(126, 48);
            this.btnGenerarReporteMovimientos.TabIndex = 12;
            this.btnGenerarReporteMovimientos.Text = "Generar Reporte de Movimientos";
            this.btnGenerarReporteMovimientos.UseVisualStyleBackColor = true;
            this.btnGenerarReporteMovimientos.Click += new System.EventHandler(this.btnGenerarReporteMovimientos_Click);
            // 
            // txtusuarioID
            // 
            this.txtusuarioID.Location = new System.Drawing.Point(661, 49);
            this.txtusuarioID.Name = "txtusuarioID";
            this.txtusuarioID.Size = new System.Drawing.Size(95, 20);
            this.txtusuarioID.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(570, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Usuario ID:";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtusuarioID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGenerarReporteMovimientos);
            this.Controls.Add(this.btnRealizarTransferencia);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtMenuUsuario);
            this.Name = "FormMenu";
            this.Text = "FormMenuUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtMenuUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnRealizarTransferencia;
        private System.Windows.Forms.Button btnGenerarReporteMovimientos;
        public System.Windows.Forms.TextBox txtusuarioID;
        private System.Windows.Forms.Label label9;
    }
}