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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGenerarReporteMovimientos));
            this.label1 = new System.Windows.Forms.Label();
            this.btnReporteEntreCuentas = new System.Windows.Forms.Button();
            this.btnReporteTerceros = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "GENERAR REPORTES";
            // 
            // btnReporteEntreCuentas
            // 
            this.btnReporteEntreCuentas.Location = new System.Drawing.Point(140, 186);
            this.btnReporteEntreCuentas.Name = "btnReporteEntreCuentas";
            this.btnReporteEntreCuentas.Size = new System.Drawing.Size(161, 62);
            this.btnReporteEntreCuentas.TabIndex = 44;
            this.btnReporteEntreCuentas.Text = "Generar Reporte entre sus Cuentas ";
            this.btnReporteEntreCuentas.UseVisualStyleBackColor = true;
            this.btnReporteEntreCuentas.Click += new System.EventHandler(this.btnReporteEntreCuentas_Click);
            // 
            // btnReporteTerceros
            // 
            this.btnReporteTerceros.Location = new System.Drawing.Point(606, 190);
            this.btnReporteTerceros.Name = "btnReporteTerceros";
            this.btnReporteTerceros.Size = new System.Drawing.Size(197, 55);
            this.btnReporteTerceros.TabIndex = 43;
            this.btnReporteTerceros.Text = "Generar Reporte de Cuentas de Terceros";
            this.btnReporteTerceros.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(356, 125);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(198, 201);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            // 
            // FormGenerarReporteMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnReporteEntreCuentas);
            this.Controls.Add(this.btnReporteTerceros);
            this.Controls.Add(this.label1);
            this.Name = "FormGenerarReporteMovimientos";
            this.Text = "FormGenerarReporteMovimientos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReporteEntreCuentas;
        private System.Windows.Forms.Button btnReporteTerceros;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}