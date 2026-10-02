namespace AgenciaDeViagens
{
    partial class TelaLogin
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
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.lbl_dados = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.img_logoLogin = new System.Windows.Forms.PictureBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.mktxt_cpf = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_logoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endereco.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_endereco.Location = new System.Drawing.Point(142, 208);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(81, 24);
            this.lbl_endereco.TabIndex = 2;
            this.lbl_endereco.Text = "Senha:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_email.Location = new System.Drawing.Point(142, 165);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(60, 24);
            this.lbl_email.TabIndex = 8;
            this.lbl_email.Text = "CPF:";
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_voltar.Location = new System.Drawing.Point(146, 326);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(139, 40);
            this.btn_voltar.TabIndex = 3;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // lbl_dados
            // 
            this.lbl_dados.AutoSize = true;
            this.lbl_dados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dados.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_dados.Location = new System.Drawing.Point(346, 19);
            this.lbl_dados.Name = "lbl_dados";
            this.lbl_dados.Size = new System.Drawing.Size(95, 33);
            this.lbl_dados.TabIndex = 12;
            this.lbl_dados.Text = "Login";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_confirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_confirmar.Location = new System.Drawing.Point(510, 326);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(139, 40);
            this.btn_confirmar.TabIndex = 4;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            // 
            // img_logoLogin
            // 
            this.img_logoLogin.Image = global::AgenciaDeViagens.Properties.Resources.logoAgencia;
            this.img_logoLogin.Location = new System.Drawing.Point(12, 2);
            this.img_logoLogin.Name = "img_logoLogin";
            this.img_logoLogin.Size = new System.Drawing.Size(195, 123);
            this.img_logoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_logoLogin.TabIndex = 14;
            this.img_logoLogin.TabStop = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.AccessibleDescription = "Digite sua senha";
            this.maskedTextBox1.AccessibleName = "Campo da senha";
            this.maskedTextBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(272, 207);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PasswordChar = '*';
            this.maskedTextBox1.Size = new System.Drawing.Size(377, 29);
            this.maskedTextBox1.TabIndex = 15;
            // 
            // mktxt_cpf
            // 
            this.mktxt_cpf.AccessibleDescription = "Digite seu CPF";
            this.mktxt_cpf.AccessibleName = "Campo do CPF";
            this.mktxt_cpf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktxt_cpf.Location = new System.Drawing.Point(272, 164);
            this.mktxt_cpf.Mask = "999.999.999-99";
            this.mktxt_cpf.Name = "mktxt_cpf";
            this.mktxt_cpf.Size = new System.Drawing.Size(377, 29);
            this.mktxt_cpf.TabIndex = 16;
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mktxt_cpf);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.img_logoLogin);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.lbl_dados);
            this.Controls.Add(this.lbl_endereco);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.btn_voltar);
            this.Name = "TelaLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.img_logoLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label lbl_dados;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.PictureBox img_logoLogin;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox mktxt_cpf;
    }
}