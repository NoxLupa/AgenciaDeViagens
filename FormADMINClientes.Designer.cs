namespace AgenciaDeViagens
{
    partial class FormADMINClientes
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
            this.BtnGerenciar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.img_logoLogin = new System.Windows.Forms.PictureBox();
            this.BtnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_logoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGerenciar
            // 
            this.BtnGerenciar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnGerenciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGerenciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnGerenciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGerenciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGerenciar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnGerenciar.Location = new System.Drawing.Point(161, 348);
            this.BtnGerenciar.Name = "BtnGerenciar";
            this.BtnGerenciar.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.BtnGerenciar.Size = new System.Drawing.Size(175, 63);
            this.BtnGerenciar.TabIndex = 1;
            this.BtnGerenciar.Text = "Gerenciar\r\nClientes\r\n\r\n";
            this.BtnGerenciar.UseVisualStyleBackColor = false;
            this.BtnGerenciar.Click += new System.EventHandler(this.BtnGerenciar_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnConsultar.Location = new System.Drawing.Point(479, 348);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.BtnConsultar.Size = new System.Drawing.Size(175, 63);
            this.BtnConsultar.TabIndex = 2;
            this.BtnConsultar.Text = "Consultar\r\nClientes";
            this.BtnConsultar.UseVisualStyleBackColor = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // img_logoLogin
            // 
            this.img_logoLogin.Image = global::AgenciaDeViagens.Properties.Resources.logoAgencia;
            this.img_logoLogin.Location = new System.Drawing.Point(183, 39);
            this.img_logoLogin.Name = "img_logoLogin";
            this.img_logoLogin.Size = new System.Drawing.Size(411, 284);
            this.img_logoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.img_logoLogin.TabIndex = 6;
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
            this.BtnVoltar.TabIndex = 3;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // FormADMINClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.img_logoLogin);
            this.Controls.Add(this.BtnGerenciar);
            this.Name = "FormADMINClientes";
            this.Text = "FormADMINClientes";
            ((System.ComponentModel.ISupportInitialize)(this.img_logoLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGerenciar;
        private System.Windows.Forms.PictureBox img_logoLogin;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnVoltar;
    }
}