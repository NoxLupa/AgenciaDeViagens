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
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.img_logoLogin = new System.Windows.Forms.PictureBox();
            this.btn_login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_logoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cadastrar.Location = new System.Drawing.Point(168, 297);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(175, 63);
            this.btn_cadastrar.TabIndex = 2;
            this.btn_cadastrar.Text = "Clientes";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // img_logoLogin
            // 
            this.img_logoLogin.Image = global::AgenciaDeViagens.Properties.Resources.logoAgencia;
            this.img_logoLogin.Location = new System.Drawing.Point(247, 3);
            this.img_logoLogin.Name = "img_logoLogin";
            this.img_logoLogin.Size = new System.Drawing.Size(291, 276);
            this.img_logoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.img_logoLogin.TabIndex = 3;
            this.img_logoLogin.TabStop = false;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_login.Location = new System.Drawing.Point(441, 295);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(161, 65);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Agências";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // FormADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.img_logoLogin);
            this.Controls.Add(this.btn_cadastrar);
            this.Name = "FormADMIN";
            this.Text = "FormADMIN";
            ((System.ComponentModel.ISupportInitialize)(this.img_logoLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.PictureBox img_logoLogin;
        private System.Windows.Forms.Button btn_login;
    }
}