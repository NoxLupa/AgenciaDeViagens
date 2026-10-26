namespace AgenciaDeViagens
{
    partial class FormConsultarEmpresas
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
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DgEmpresas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnVoltar.Location = new System.Drawing.Point(12, 398);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(139, 40);
            this.BtnVoltar.TabIndex = 12;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(226, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "Consultar Empresas";
            // 
            // DgEmpresas
            // 
            this.DgEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgEmpresas.Location = new System.Drawing.Point(12, 54);
            this.DgEmpresas.Name = "DgEmpresas";
            this.DgEmpresas.Size = new System.Drawing.Size(776, 328);
            this.DgEmpresas.TabIndex = 10;
            // 
            // FormConsultarEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgEmpresas);
            this.Name = "FormConsultarEmpresas";
            this.Text = "FormConsultarEmpresas";
            ((System.ComponentModel.ISupportInitialize)(this.DgEmpresas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgEmpresas;
    }
}