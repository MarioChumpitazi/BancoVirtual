namespace Presentacion.WinForms
{
    partial class FormCambiarClaveUsuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClaveActualUsuario = new System.Windows.Forms.TextBox();
            this.txtClaveNuevaUsuario = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtusuarioID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "CAMBIAR CLAVE USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Clave Actual :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Clave Nueva :";
            // 
            // txtClaveActualUsuario
            // 
            this.txtClaveActualUsuario.Location = new System.Drawing.Point(207, 145);
            this.txtClaveActualUsuario.Name = "txtClaveActualUsuario";
            this.txtClaveActualUsuario.Size = new System.Drawing.Size(105, 20);
            this.txtClaveActualUsuario.TabIndex = 47;
            // 
            // txtClaveNuevaUsuario
            // 
            this.txtClaveNuevaUsuario.Location = new System.Drawing.Point(207, 187);
            this.txtClaveNuevaUsuario.Name = "txtClaveNuevaUsuario";
            this.txtClaveNuevaUsuario.Size = new System.Drawing.Size(105, 20);
            this.txtClaveNuevaUsuario.TabIndex = 48;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(219, 285);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 38);
            this.btnGuardar.TabIndex = 74;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 75;
            this.label4.Text = "Usuario:";
            // 
            // txtusuarioID
            // 
            this.txtusuarioID.Location = new System.Drawing.Point(431, 23);
            this.txtusuarioID.Name = "txtusuarioID";
            this.txtusuarioID.Size = new System.Drawing.Size(51, 20);
            this.txtusuarioID.TabIndex = 76;
            // 
            // FormCambiarClaveUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 374);
            this.Controls.Add(this.txtusuarioID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtClaveNuevaUsuario);
            this.Controls.Add(this.txtClaveActualUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCambiarClaveUsuario";
            this.Text = "FormCambiarClave";
            this.Load += new System.EventHandler(this.FormCambiarClaveUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtClaveActualUsuario;
        public System.Windows.Forms.TextBox txtClaveNuevaUsuario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtusuarioID;
    }
}