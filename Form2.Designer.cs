namespace AgenciaDeViagens
{
    partial class TelaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            this.lbl_dados = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.mktxt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.mktxt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_senhaConfirma = new System.Windows.Forms.Label();
            this.btn_mostrarSenha = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_senhaConfirma = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_dados
            // 
            this.lbl_dados.AutoSize = true;
            this.lbl_dados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dados.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_dados.Location = new System.Drawing.Point(288, 60);
            this.lbl_dados.Name = "lbl_dados";
            this.lbl_dados.Size = new System.Drawing.Size(182, 33);
            this.lbl_dados.TabIndex = 0;
            this.lbl_dados.Text = "Seus Dados";
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_voltar.Location = new System.Drawing.Point(198, 388);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(139, 40);
            this.btn_voltar.TabIndex = 8;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.AccessibleDescription = "Digite seu Nome Completo";
            this.txt_nome.AccessibleName = "Campo do Nome";
            this.txt_nome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(198, 147);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(377, 29);
            this.txt_nome.TabIndex = 2;
            // 
            // mktxt_cpf
            // 
            this.mktxt_cpf.AccessibleDescription = "Digite seu CPF";
            this.mktxt_cpf.AccessibleName = "Campo do CPF";
            this.mktxt_cpf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktxt_cpf.Location = new System.Drawing.Point(198, 112);
            this.mktxt_cpf.Mask = "999.999.999-99";
            this.mktxt_cpf.Name = "mktxt_cpf";
            this.mktxt_cpf.Size = new System.Drawing.Size(377, 29);
            this.mktxt_cpf.TabIndex = 1;
            // 
            // mktxt_telefone
            // 
            this.mktxt_telefone.AccessibleDescription = "Digite seu telefone";
            this.mktxt_telefone.AccessibleName = "Campo do telefone";
            this.mktxt_telefone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktxt_telefone.Location = new System.Drawing.Point(198, 182);
            this.mktxt_telefone.Mask = "+99(99)99999-9999";
            this.mktxt_telefone.Name = "mktxt_telefone";
            this.mktxt_telefone.Size = new System.Drawing.Size(377, 29);
            this.mktxt_telefone.TabIndex = 3;
            // 
            // txt_email
            // 
            this.txt_email.AccessibleDescription = "Digite seu email";
            this.txt_email.AccessibleName = "Campo do email";
            this.txt_email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(198, 217);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(377, 29);
            this.txt_email.TabIndex = 4;
            // 
            // txt_endereco
            // 
            this.txt_endereco.AccessibleDescription = "Digite seu endereco";
            this.txt_endereco.AccessibleName = "Campo do endereco";
            this.txt_endereco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_endereco.Location = new System.Drawing.Point(198, 252);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(377, 29);
            this.txt_endereco.TabIndex = 5;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_cpf.Location = new System.Drawing.Point(14, 117);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(60, 24);
            this.lbl_cpf.TabIndex = 0;
            this.lbl_cpf.Text = "CPF:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_nome.Location = new System.Drawing.Point(12, 148);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(181, 24);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome Completo:";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_telefone.Location = new System.Drawing.Point(12, 183);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(105, 24);
            this.lbl_telefone.TabIndex = 0;
            this.lbl_telefone.Text = "Telefone:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_email.Location = new System.Drawing.Point(12, 218);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(81, 24);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "E-mail:";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endereco.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_endereco.Location = new System.Drawing.Point(12, 253);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(115, 24);
            this.lbl_endereco.TabIndex = 0;
            this.lbl_endereco.Text = "Endereço:";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_confirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_confirmar.Location = new System.Drawing.Point(436, 388);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(139, 40);
            this.btn_confirmar.TabIndex = 9;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_senha.Location = new System.Drawing.Point(14, 292);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(81, 24);
            this.lbl_senha.TabIndex = 9;
            this.lbl_senha.Text = "Senha:";
            // 
            // lbl_senhaConfirma
            // 
            this.lbl_senhaConfirma.AutoSize = true;
            this.lbl_senhaConfirma.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senhaConfirma.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_senhaConfirma.Location = new System.Drawing.Point(14, 329);
            this.lbl_senhaConfirma.Name = "lbl_senhaConfirma";
            this.lbl_senhaConfirma.Size = new System.Drawing.Size(169, 22);
            this.lbl_senhaConfirma.TabIndex = 10;
            this.lbl_senhaConfirma.Text = "Confirmar Senha:";
            // 
            // btn_mostrarSenha
            // 
            this.btn_mostrarSenha.BackColor = System.Drawing.Color.Lime;
            this.btn_mostrarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mostrarSenha.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_mostrarSenha.Location = new System.Drawing.Point(581, 287);
            this.btn_mostrarSenha.Name = "btn_mostrarSenha";
            this.btn_mostrarSenha.Size = new System.Drawing.Size(31, 29);
            this.btn_mostrarSenha.TabIndex = 0;
            this.btn_mostrarSenha.UseVisualStyleBackColor = false;
            this.btn_mostrarSenha.Click += new System.EventHandler(this.btn_mostrarSenha_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.AccessibleDescription = "Digite sua senha";
            this.txt_senha.AccessibleName = "Campo da senha";
            this.txt_senha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(198, 287);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(377, 29);
            this.txt_senha.TabIndex = 6;
            this.txt_senha.UseSystemPasswordChar = true;
            // 
            // txt_senhaConfirma
            // 
            this.txt_senhaConfirma.AccessibleDescription = "Confirme sua senha";
            this.txt_senhaConfirma.AccessibleName = "Campo para redigitar a senha";
            this.txt_senhaConfirma.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senhaConfirma.Location = new System.Drawing.Point(198, 322);
            this.txt_senhaConfirma.Name = "txt_senhaConfirma";
            this.txt_senhaConfirma.Size = new System.Drawing.Size(377, 29);
            this.txt_senhaConfirma.TabIndex = 7;
            this.txt_senhaConfirma.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgenciaDeViagens.Properties.Resources.logo_da_agencia_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(-23, -36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_senhaConfirma);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.btn_mostrarSenha);
            this.Controls.Add(this.lbl_senhaConfirma);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.lbl_endereco);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.mktxt_telefone);
            this.Controls.Add(this.mktxt_cpf);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lbl_dados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.TelaCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dados;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.MaskedTextBox mktxt_cpf;
        private System.Windows.Forms.MaskedTextBox mktxt_telefone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label lbl_senhaConfirma;
        private System.Windows.Forms.Button btn_mostrarSenha;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_senhaConfirma;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}