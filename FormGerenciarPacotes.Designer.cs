namespace AgenciaDeViagens
{
    partial class FormGerenciarPacotes
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDestino = new System.Windows.Forms.TextBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.LbCnpj = new System.Windows.Forms.Label();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbNome = new System.Windows.Forms.Label();
            this.lbl_dados = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.MktxtDataIda = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MktxtDataVolta = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtHotel = new System.Windows.Forms.TextBox();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.LbEmpresa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(33, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 85;
            this.label2.Text = "Data Ida:";
            // 
            // TxtDestino
            // 
            this.TxtDestino.AccessibleDescription = "Digite seu Nome Completo";
            this.TxtDestino.AccessibleName = "Campo do Nome";
            this.TxtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDestino.Location = new System.Drawing.Point(296, 180);
            this.TxtDestino.Name = "TxtDestino";
            this.TxtDestino.Size = new System.Drawing.Size(377, 29);
            this.TxtDestino.TabIndex = 3;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCadastrar.FlatAppearance.BorderSize = 0;
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCadastrar.Location = new System.Drawing.Point(487, 592);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(139, 40);
            this.BtnCadastrar.TabIndex = 12;
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
            this.BtnExcluir.Location = new System.Drawing.Point(325, 592);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(139, 40);
            this.BtnExcluir.TabIndex = 11;
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
            this.BtnAlterar.Location = new System.Drawing.Point(649, 592);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(139, 40);
            this.BtnAlterar.TabIndex = 13;
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
            this.BtnVoltar.Location = new System.Drawing.Point(12, 592);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(139, 40);
            this.BtnVoltar.TabIndex = 10;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click_1);
            // 
            // LbCnpj
            // 
            this.LbCnpj.AutoSize = true;
            this.LbCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCnpj.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LbCnpj.Location = new System.Drawing.Point(33, 215);
            this.LbCnpj.Name = "LbCnpj";
            this.LbCnpj.Size = new System.Drawing.Size(68, 25);
            this.LbCnpj.TabIndex = 84;
            this.LbCnpj.Text = "Valor:";
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
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 83;
            this.label1.Text = "Código Pacote:";
            // 
            // LbNome
            // 
            this.LbNome.AutoSize = true;
            this.LbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LbNome.Location = new System.Drawing.Point(33, 180);
            this.LbNome.Name = "LbNome";
            this.LbNome.Size = new System.Drawing.Size(91, 25);
            this.LbNome.TabIndex = 82;
            this.LbNome.Text = "Destino:";
            // 
            // lbl_dados
            // 
            this.lbl_dados.AutoSize = true;
            this.lbl_dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dados.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_dados.Location = new System.Drawing.Point(290, 32);
            this.lbl_dados.Name = "lbl_dados";
            this.lbl_dados.Size = new System.Drawing.Size(252, 33);
            this.lbl_dados.TabIndex = 81;
            this.lbl_dados.Text = "Dados do Pacote";
            // 
            // TxtValor
            // 
            this.TxtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValor.Location = new System.Drawing.Point(296, 215);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(377, 31);
            this.TxtValor.TabIndex = 4;
            // 
            // MktxtDataIda
            // 
            this.MktxtDataIda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MktxtDataIda.Location = new System.Drawing.Point(296, 249);
            this.MktxtDataIda.Mask = "00/00/0000";
            this.MktxtDataIda.Name = "MktxtDataIda";
            this.MktxtDataIda.Size = new System.Drawing.Size(116, 31);
            this.MktxtDataIda.TabIndex = 5;
            this.MktxtDataIda.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(33, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 89;
            this.label4.Text = "Data Volta:";
            // 
            // MktxtDataVolta
            // 
            this.MktxtDataVolta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MktxtDataVolta.Location = new System.Drawing.Point(296, 286);
            this.MktxtDataVolta.Mask = "00/00/0000";
            this.MktxtDataVolta.Name = "MktxtDataVolta";
            this.MktxtDataVolta.Size = new System.Drawing.Size(116, 31);
            this.MktxtDataVolta.TabIndex = 6;
            this.MktxtDataVolta.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(33, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 91;
            this.label3.Text = "Nome Hotel:";
            // 
            // TxtHotel
            // 
            this.TxtHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHotel.Location = new System.Drawing.Point(296, 323);
            this.TxtHotel.Name = "TxtHotel";
            this.TxtHotel.Size = new System.Drawing.Size(377, 31);
            this.TxtHotel.TabIndex = 7;
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.AllowDrop = true;
            this.TxtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescricao.Location = new System.Drawing.Point(296, 360);
            this.TxtDescricao.Multiline = true;
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(377, 107);
            this.TxtDescricao.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(33, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 94;
            this.label5.Text = "Descrição:";
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.AllowDrop = true;
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
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(33, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 25);
            this.label6.TabIndex = 95;
            this.label6.Text = "Código Empresa:";
            // 
            // ComboBoxEmpresa
            // 
            this.ComboBoxEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxEmpresa.FormattingEnabled = true;
            this.ComboBoxEmpresa.Location = new System.Drawing.Point(296, 477);
            this.ComboBoxEmpresa.Name = "ComboBoxEmpresa";
            this.ComboBoxEmpresa.Size = new System.Drawing.Size(55, 33);
            this.ComboBoxEmpresa.TabIndex = 9;
            this.ComboBoxEmpresa.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEmpresa_SelectedIndexChanged);
            // 
            // LbEmpresa
            // 
            this.LbEmpresa.AutoSize = true;
            this.LbEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmpresa.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LbEmpresa.Location = new System.Drawing.Point(357, 485);
            this.LbEmpresa.Name = "LbEmpresa";
            this.LbEmpresa.Size = new System.Drawing.Size(0, 25);
            this.LbEmpresa.TabIndex = 98;
            // 
            // FormGerenciarPacotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.LbEmpresa);
            this.Controls.Add(this.ComboBoxEmpresa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDescricao);
            this.Controls.Add(this.TxtHotel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MktxtDataVolta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MktxtDataIda);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDestino);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.LbCnpj);
            this.Controls.Add(this.TxtPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbNome);
            this.Controls.Add(this.lbl_dados);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormGerenciarPacotes";
            this.Text = "FormGerenciarPacotes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDestino;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Label LbCnpj;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbNome;
        private System.Windows.Forms.Label lbl_dados;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.MaskedTextBox MktxtDataIda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MktxtDataVolta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtHotel;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboBoxEmpresa;
        private System.Windows.Forms.Label LbEmpresa;
    }
}