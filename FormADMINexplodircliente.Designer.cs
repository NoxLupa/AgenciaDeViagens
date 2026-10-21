namespace AgenciaDeViagens
{
    partial class FormADMINexplodircliente
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
            this.lbl_dados = new System.Windows.Forms.Label();
            this.mktxt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.mktxt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_mostrarSenha = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.txt_senhaConfirma = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_senhaConfirma = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_dados
            // 
            this.lbl_dados.AutoSize = true;
            this.lbl_dados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dados.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_dados.Location = new System.Drawing.Point(275, 96);
            this.lbl_dados.Name = "lbl_dados";
            this.lbl_dados.Size = new System.Drawing.Size(254, 33);
            this.lbl_dados.TabIndex = 32;
            this.lbl_dados.Text = "Dados do Cliente";
            this.lbl_dados.Click += new System.EventHandler(this.lbl_dados_Click);
            // 
            // mktxt_cpf
            // 
            this.mktxt_cpf.AccessibleDescription = "Digite seu CPF";
            this.mktxt_cpf.AccessibleName = "Campo do CPF";
            this.mktxt_cpf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktxt_cpf.Location = new System.Drawing.Point(296, 220);
            this.mktxt_cpf.Mask = "999.999.999-99";
            this.mktxt_cpf.Name = "mktxt_cpf";
            this.mktxt_cpf.Size = new System.Drawing.Size(377, 29);
            this.mktxt_cpf.TabIndex = 34;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_cpf.Location = new System.Drawing.Point(24, 220);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(60, 24);
            this.lbl_cpf.TabIndex = 33;
            this.lbl_cpf.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(24, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Consultar Codigo Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.AccessibleDescription = "Digite seu Nome Completo";
            this.txt_nome.AccessibleName = "Campo do Nome";
            this.txt_nome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(296, 173);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(377, 29);
            this.txt_nome.TabIndex = 36;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_telefone.Location = new System.Drawing.Point(24, 262);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(105, 24);
            this.lbl_telefone.TabIndex = 37;
            this.lbl_telefone.Text = "Telefone:";
            // 
            // mktxt_telefone
            // 
            this.mktxt_telefone.AccessibleDescription = "Digite seu telefone";
            this.mktxt_telefone.AccessibleName = "Campo do telefone";
            this.mktxt_telefone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktxt_telefone.Location = new System.Drawing.Point(296, 262);
            this.mktxt_telefone.Mask = "+99(99)99999-9999";
            this.mktxt_telefone.Name = "mktxt_telefone";
            this.mktxt_telefone.Size = new System.Drawing.Size(377, 29);
            this.mktxt_telefone.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgenciaDeViagens.Properties.Resources.logo_da_agencia_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btn_mostrarSenha
            // 
            this.btn_mostrarSenha.BackColor = System.Drawing.Color.Transparent;
            this.btn_mostrarSenha.BackgroundImage = global::AgenciaDeViagens.Properties.Resources.show_password2;
            this.btn_mostrarSenha.FlatAppearance.BorderSize = 0;
            this.btn_mostrarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mostrarSenha.ForeColor = System.Drawing.Color.Transparent;
            this.btn_mostrarSenha.Location = new System.Drawing.Point(679, 377);
            this.btn_mostrarSenha.Name = "btn_mostrarSenha";
            this.btn_mostrarSenha.Size = new System.Drawing.Size(31, 29);
            this.btn_mostrarSenha.TabIndex = 44;
            this.btn_mostrarSenha.UseVisualStyleBackColor = false;
            // 
            // txt_email
            // 
            this.txt_email.AccessibleDescription = "Digite seu email";
            this.txt_email.AccessibleName = "Campo do email";
            this.txt_email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(296, 300);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(377, 29);
            this.txt_email.TabIndex = 40;
            // 
            // txt_endereco
            // 
            this.txt_endereco.AccessibleDescription = "Digite seu endereco";
            this.txt_endereco.AccessibleName = "Campo do endereco";
            this.txt_endereco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_endereco.Location = new System.Drawing.Point(296, 335);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(377, 29);
            this.txt_endereco.TabIndex = 41;
            // 
            // txt_senhaConfirma
            // 
            this.txt_senhaConfirma.AccessibleDescription = "Confirme sua senha";
            this.txt_senhaConfirma.AccessibleName = "Campo para redigitar a senha";
            this.txt_senhaConfirma.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senhaConfirma.Location = new System.Drawing.Point(296, 410);
            this.txt_senhaConfirma.Name = "txt_senhaConfirma";
            this.txt_senhaConfirma.Size = new System.Drawing.Size(377, 29);
            this.txt_senhaConfirma.TabIndex = 43;
            this.txt_senhaConfirma.UseSystemPasswordChar = true;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_email.Location = new System.Drawing.Point(33, 300);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(81, 24);
            this.lbl_email.TabIndex = 46;
            this.lbl_email.Text = "E-mail:";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endereco.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_endereco.Location = new System.Drawing.Point(31, 336);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(115, 24);
            this.lbl_endereco.TabIndex = 47;
            this.lbl_endereco.Text = "Endereço:";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_senha.Location = new System.Drawing.Point(33, 375);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(81, 24);
            this.lbl_senha.TabIndex = 48;
            this.lbl_senha.Text = "Senha:";
            // 
            // lbl_senhaConfirma
            // 
            this.lbl_senhaConfirma.AutoSize = true;
            this.lbl_senhaConfirma.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senhaConfirma.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_senhaConfirma.Location = new System.Drawing.Point(31, 410);
            this.lbl_senhaConfirma.Name = "lbl_senhaConfirma";
            this.lbl_senhaConfirma.Size = new System.Drawing.Size(190, 24);
            this.lbl_senhaConfirma.TabIndex = 49;
            this.lbl_senhaConfirma.Text = "Confirmar Senha:";
            // 
            // txt_senha
            // 
            this.txt_senha.AccessibleDescription = "Digite sua senha";
            this.txt_senha.AccessibleName = "Campo da senha";
            this.txt_senha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(296, 375);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(377, 29);
            this.txt_senha.TabIndex = 42;
            this.txt_senha.UseSystemPasswordChar = true;
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_excluir.Location = new System.Drawing.Point(324, 499);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(139, 40);
            this.btn_excluir.TabIndex = 51;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_alterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_alterar.Location = new System.Drawing.Point(648, 499);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(139, 40);
            this.btn_alterar.TabIndex = 50;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = false;
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_voltar.Location = new System.Drawing.Point(11, 499);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(139, 40);
            this.btn_voltar.TabIndex = 52;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(486, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 40);
            this.button1.TabIndex = 53;
            this.button1.Text = "Adcionar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormADMINexplodircliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_mostrarSenha);
            this.Controls.Add(this.txt_senhaConfirma);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.lbl_senhaConfirma);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_endereco);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.mktxt_telefone);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mktxt_cpf);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_dados);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormADMINexplodircliente";
            this.Text = "FormADMINexplodircliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_dados;
        private System.Windows.Forms.MaskedTextBox mktxt_cpf;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.MaskedTextBox mktxt_telefone;
        private System.Windows.Forms.Button btn_mostrarSenha;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.TextBox txt_senhaConfirma;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label lbl_senhaConfirma;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button button1;
    }
}