namespace AgenciaDeViagens
{
    partial class FormADMIN
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
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnAgencias = new System.Windows.Forms.Button();
            this.img_logoLogin = new System.Windows.Forms.PictureBox();
            this.BtnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_logoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClientes
            // 
            this.BtnClientes.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnClientes.Location = new System.Drawing.Point(161, 348);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(175, 63);
            this.BtnClientes.TabIndex = 1;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = false;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnAgencias
            // 
            this.BtnAgencias.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAgencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnAgencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgencias.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAgencias.Location = new System.Drawing.Point(479, 348);
            this.BtnAgencias.Name = "BtnAgencias";
            this.BtnAgencias.Size = new System.Drawing.Size(175, 63);
            this.BtnAgencias.TabIndex = 2;
            this.BtnAgencias.Text = "Agências";
            this.BtnAgencias.UseVisualStyleBackColor = false;
            this.BtnAgencias.Click += new System.EventHandler(this.BtnAgencias_Click);
            // 
            // img_logoLogin
            // 
            this.img_logoLogin.Image = global::AgenciaDeViagens.Properties.Resources.logoAgencia;
            this.img_logoLogin.Location = new System.Drawing.Point(183, 39);
            this.img_logoLogin.Name = "img_logoLogin";
            this.img_logoLogin.Size = new System.Drawing.Size(411, 284);
            this.img_logoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.img_logoLogin.TabIndex = 3;
            this.img_logoLogin.TabStop = false;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVoltar.FlatAppearance.BorderSize = 0;
            this.BtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnVoltar.Location = new System.Drawing.Point(3, 1);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(77, 50);
            this.BtnVoltar.TabIndex = 4;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // FormADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnAgencias);
            this.Controls.Add(this.img_logoLogin);
            this.Controls.Add(this.BtnClientes);
            this.Name = "FormADMIN";
            this.Text = "FormADMIN";
            ((System.ComponentModel.ISupportInitialize)(this.img_logoLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.PictureBox img_logoLogin;
        private System.Windows.Forms.Button BtnAgencias;
        private System.Windows.Forms.Button BtnVoltar;
    }
}