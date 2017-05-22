namespace ProyectoET
{
    partial class Administracion
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
            this.btnSalirSys = new System.Windows.Forms.Button();
            this.tbPing = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPingSitio = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nUsolicitud = new System.Windows.Forms.NumericUpDown();
            this.btnPing = new System.Windows.Forms.Button();
            this.tbPing.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUsolicitud)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirSys
            // 
            this.btnSalirSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirSys.Location = new System.Drawing.Point(557, 322);
            this.btnSalirSys.Name = "btnSalirSys";
            this.btnSalirSys.Size = new System.Drawing.Size(75, 23);
            this.btnSalirSys.TabIndex = 0;
            this.btnSalirSys.Text = "SALIR";
            this.btnSalirSys.UseVisualStyleBackColor = true;
            this.btnSalirSys.Click += new System.EventHandler(this.btnSalirSys_Click);
            // 
            // tbPing
            // 
            this.tbPing.Controls.Add(this.tabPage1);
            this.tbPing.Controls.Add(this.tabPage2);
            this.tbPing.Location = new System.Drawing.Point(3, 7);
            this.tbPing.Name = "tbPing";
            this.tbPing.SelectedIndex = 0;
            this.tbPing.Size = new System.Drawing.Size(629, 290);
            this.tbPing.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.btnPing);
            this.tabPage1.Controls.Add(this.nUsolicitud);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtURL);
            this.tabPage1.Controls.Add(this.lblPingSitio);
            this.tabPage1.Controls.Add(this.lblTitulo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(621, 264);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connexion Red";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(621, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Informacion Red";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(6, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(133, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Realizar Ping";
            // 
            // lblPingSitio
            // 
            this.lblPingSitio.AutoSize = true;
            this.lblPingSitio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPingSitio.Location = new System.Drawing.Point(7, 56);
            this.lblPingSitio.Name = "lblPingSitio";
            this.lblPingSitio.Size = new System.Drawing.Size(122, 13);
            this.lblPingSitio.TabIndex = 1;
            this.lblPingSitio.Text = "Ingrese URL or Sitio";
            // 
            // txtURL
            // 
            this.txtURL.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.txtURL.Location = new System.Drawing.Point(154, 56);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(217, 20);
            this.txtURL.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero de Solicitudes";
            // 
            // nUsolicitud
            // 
            this.nUsolicitud.Location = new System.Drawing.Point(154, 86);
            this.nUsolicitud.Name = "nUsolicitud";
            this.nUsolicitud.Size = new System.Drawing.Size(40, 20);
            this.nUsolicitud.TabIndex = 4;
            // 
            // btnPing
            // 
            this.btnPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPing.Location = new System.Drawing.Point(511, 235);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(104, 23);
            this.btnPing.TabIndex = 5;
            this.btnPing.Text = "Diagnosticar";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(644, 357);
            this.Controls.Add(this.tbPing);
            this.Controls.Add(this.btnSalirSys);
            this.Name = "Administracion";
            this.Text = "ADMINISTRACION";
            this.Load += new System.EventHandler(this.Administracion_Load);
            this.tbPing.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUsolicitud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalirSys;
        private System.Windows.Forms.TabControl tbPing;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.NumericUpDown nUsolicitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblPingSitio;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabPage tabPage2;
    }
}