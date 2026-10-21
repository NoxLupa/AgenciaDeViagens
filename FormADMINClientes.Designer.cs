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
            this.btn_login = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.img_logoLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_logoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_login.Location = new System.Drawing.Point(161, 348);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(161, 65);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Gerenciar";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(479, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 65);
            this.button3.TabIndex = 9;
            this.button3.Text = "Consultar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // img_logoLogin
            // 
            this.img_logoLogin.Image = global::AgenciaDeViagens.Properties.Resources.logoAgencia;
            this.img_logoLogin.Location = new System.Drawing.Point(183, 39);
            this.img_logoLogin.Name = "img_logoLogin";
            this.img_logoLogin.Size = new System.Drawing.Size(411, 284);
            this.img_logoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_logoLogin.TabIndex = 6;
            this.img_logoLogin.TabStop = false;
            // 
            // FormADMINClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.img_logoLogin);
            this.Controls.Add(this.btn_login);
            this.Name = "FormADMINClientes";
            this.Text = "FormADMINClientes";
            ((System.ComponentModel.ISupportInitialize)(this.img_logoLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.PictureBox img_logoLogin;
        private System.Windows.Forms.Button button3;
    }
}