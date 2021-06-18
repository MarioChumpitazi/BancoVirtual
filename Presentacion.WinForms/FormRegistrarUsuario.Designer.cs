namespace Presentacion.WinForms
{
    partial class FormRegistrarUsuario
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
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btnRegresarIniciarSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtApellidosUsuario = new System.Windows.Forms.TextBox();
            this.txtDniUsuario = new System.Windows.Forms.TextBox();
            this.txtClaveUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumeroDeTarjeta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Location = new System.Drawing.Point(286, 318);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(90, 34);
            this.btnCrearUsuario.TabIndex = 0;
            this.btnCrearUsuario.Text = "Crear";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // btnRegresarIniciarSesion
            // 
            this.btnRegresarIniciarSesion.Location = new System.Drawing.Point(126, 318);
            this.btnRegresarIniciarSesion.Name = "btnRegresarIniciarSesion";
            this.btnRegresarIniciarSesion.Size = new System.Drawing.Size(87, 34);
            this.btnRegresarIniciarSesion.TabIndex = 1;
            this.btnRegresarIniciarSesion.Text = "Regresar";
            this.btnRegresarIniciarSesion.UseVisualStyleBackColor = true;
            this.btnRegresarIniciarSesion.Click += new System.EventHandler(this.btnRegresarIniciarSesion_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registro de Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "DNI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Clave:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(126, 106);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(183, 20);
            this.txtNombreUsuario.TabIndex = 9;
            // 
            // txtApellidosUsuario
            // 
            this.txtApellidosUsuario.Location = new System.Drawing.Point(126, 151);
            this.txtApellidosUsuario.Name = "txtApellidosUsuario";
            this.txtApellidosUsuario.Size = new System.Drawing.Size(183, 20);
            this.txtApellidosUsuario.TabIndex = 10;
            // 
            // txtDniUsuario
            // 
            this.txtDniUsuario.Location = new System.Drawing.Point(90, 195);
            this.txtDniUsuario.Name = "txtDniUsuario";
            this.txtDniUsuario.Size = new System.Drawing.Size(123, 20);
            this.txtDniUsuario.TabIndex = 11;
            // 
            // txtClaveUsuario
            // 
            this.txtClaveUsuario.Location = new System.Drawing.Point(114, 264);
            this.txtClaveUsuario.Name = "txtClaveUsuario";
            this.txtClaveUsuario.PasswordChar = '*';
            this.txtClaveUsuario.Size = new System.Drawing.Size(112, 20);
            this.txtClaveUsuario.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Numero de Tarjeta:";
            // 
            // txtNumeroDeTarjeta
            // 
            this.txtNumeroDeTarjeta.Location = new System.Drawing.Point(193, 233);
            this.txtNumeroDeTarjeta.Name = "txtNumeroDeTarjeta";
            this.txtNumeroDeTarjeta.Size = new System.Drawing.Size(153, 20);
            this.txtNumeroDeTarjeta.TabIndex = 15;
            // 
            // FormRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 388);
            this.Controls.Add(this.txtNumeroDeTarjeta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtClaveUsuario);
            this.Controls.Add(this.txtDniUsuario);
            this.Controls.Add(this.txtApellidosUsuario);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresarIniciarSesion);
            this.Controls.Add(this.btnCrearUsuario);
            this.Name = "FormRegistrarUsuario";
            this.Text = "FormRegistrarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btnRegresarIniciarSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtApellidosUsuario;
        private System.Windows.Forms.TextBox txtDniUsuario;
        private System.Windows.Forms.TextBox txtClaveUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumeroDeTarjeta;
    }
}