namespace AgenciaDeViagens
{
    partial class FormGerenciarEmpresa
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
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.MktxtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.LbCnpj = new System.Windows.Forms.Label();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbNome = new System.Windows.Forms.Label();
            this.lbl_dados = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxTipo = new System.Windows.Forms.ComboBox();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            this.TxtNome.AccessibleDescription = "Digite seu Nome Completo";
            this.TxtNome.AccessibleName = "Campo do Nome";
            this.TxtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(296, 180);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(377, 29);
            this.TxtNome.TabIndex = 3;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCadastrar.FlatAppearance.BorderSize = 0;
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCadastrar.Location = new System.Drawing.Point(487, 499);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(139, 40);
            this.BtnCadastrar.TabIndex = 9;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.Firebrick;
            this.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcluir.FlatAppearance.BorderSize = 0;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnExcluir.Location = new System.Drawing.Point(325, 499);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(139, 40);
            this.BtnExcluir.TabIndex = 8;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAlterar.Location = new System.Drawing.Point(649, 499);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(139, 40);
            this.BtnAlterar.TabIndex = 10;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = false;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnVoltar.Location = new System.Drawing.Point(12, 499);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(139, 40);
            this.BtnVoltar.TabIndex = 7;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // MktxtCNPJ
            // 
            this.MktxtCNPJ.AccessibleDescription = "Digite seu telefone";
            this.MktxtCNPJ.AccessibleName = "Campo do telefone";
            this.MktxtCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MktxtCNPJ.Location = new System.Drawing.Point(296, 215);
            this.MktxtCNPJ.Mask = "99.999.999/9999-99";
            this.MktxtCNPJ.Name = "MktxtCNPJ";
            this.MktxtCNPJ.Size = new System.Drawing.Size(377, 29);
            this.MktxtCNPJ.TabIndex = 5;
            // 
            // LbCnpj
            // 
            this.LbCnpj.AutoSize = true;
            this.LbCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCnpj.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LbCnpj.Location = new System.Drawing.Point(33, 215);
            this.LbCnpj.Name = "LbCnpj";
            this.LbCnpj.Size = new System.Drawing.Size(73, 25);
            this.LbCnpj.TabIndex = 70;
            this.LbCnpj.Text = "CNPJ:";
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.AccessibleDescription = "Digite seu Nome Completo";
            this.TxtPesquisa.AccessibleName = "Campo do Nome";
            this.TxtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPesquisa.Location = new System.Drawing.Point(296, 145);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(82, 29);
            this.TxtPesquisa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(33, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 69;
            this.label1.Text = "Código Empresa:";
            // 
            // LbNome
            // 
            this.LbNome.AutoSize = true;
            this.LbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LbNome.Location = new System.Drawing.Point(33, 180);
            this.LbNome.Name = "LbNome";
            this.LbNome.Size = new System.Drawing.Size(74, 25);
            this.LbNome.TabIndex = 68;
            this.LbNome.Text = "Nome:";
            // 
            // lbl_dados
            // 
            this.lbl_dados.AutoSize = true;
            this.lbl_dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dados.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_dados.Location = new System.Drawing.Point(290, 31);
            this.lbl_dados.Name = "lbl_dados";
            this.lbl_dados.Size = new System.Drawing.Size(280, 33);
            this.lbl_dados.TabIndex = 67;
            this.lbl_dados.Text = "Dados da Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(33, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 71;
            this.label2.Text = "Tipo de Transporte:";
            // 
            // ComboBoxTipo
            // 
            this.ComboBoxTipo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboBoxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxTipo.FormattingEnabled = true;
            this.ComboBoxTipo.Items.AddRange(new object[] {
            "Avião",
            "Ônibus",
            "Navio",
            "Trem"});
            this.ComboBoxTipo.Location = new System.Drawing.Point(296, 249);
            this.ComboBoxTipo.Name = "ComboBoxTipo";
            this.ComboBoxTipo.Size = new System.Drawing.Size(126, 32);
            this.ComboBoxTipo.TabIndex = 6;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.BtnPesquisar.BackgroundImage = global::AgenciaDeViagens.Properties.Resources.pesquisar;
            this.BtnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPesquisar.FlatAppearance.BorderSize = 0;
            this.BtnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisar.Location = new System.Drawing.Point(384, 142);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(79, 32);
            this.BtnPesquisar.TabIndex = 2;
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgenciaDeViagens.Properties.Resources.logo_da_agencia_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // FormGerenciarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.ComboBoxTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.MktxtCNPJ);
            this.Controls.Add(this.LbCnpj);
            this.Controls.Add(this.TxtPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbNome);
            this.Controls.Add(this.lbl_dados);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormGerenciarEmpresa";
            this.Text = "FormGerenciarEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.MaskedTextBox MktxtCNPJ;
        private System.Windows.Forms.Label LbCnpj;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbNome;
        private System.Windows.Forms.Label lbl_dados;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxTipo;
    }
}