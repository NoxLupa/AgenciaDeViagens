using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaDeViagens
{
    public partial class TelaLogin : Form
    {
        DAO bd;
        Form4 telCompra1;
        public TelaLogin()
        {
            InitializeComponent();
            bd = new DAO();
            bd.PreencherVetor();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btn_confirmar_Click(object sender, EventArgs e)
        {         
            //Auxiliares
            long cpfDigitado = Convert.ToInt64(RemoverFormatacaoCPF(mktxt_cpf.Text));
            string senhaDigitada = txt_senha.Text;
            
            try {
                if (bd.ValidarLogin(cpfDigitado, senhaDigitada) == 0)
                {
                    telCompra1 = new Form4(bd.userLogado, bd.indexAuxiliar);                    
                    telCompra1.ShowDialog();
                    LimparLogin();                    
                }
                else if(bd.ValidarLogin(cpfDigitado, senhaDigitada) == 1)
                {
                    MessageBox.Show("Usuário e/ou senha não confirmam!");
                }                                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
            this.Close();

        }//fim Botão_Confirmar

        public string RemoverFormatacaoCPF(string cpf)
        {
            string cpfAlterado = cpf.Replace(",", "");
            cpfAlterado = cpfAlterado.Replace("-", "");
            return cpfAlterado;
        }//fim do remover formatação

        public void LimparLogin()
        {
            mktxt_cpf.Text = "";
            txt_senha.Text = "";
        }

        private void btn_mostrarSenha_Click(object sender, EventArgs e)
        {
            if (txt_senha.UseSystemPasswordChar == true)
            {
                txt_senha.UseSystemPasswordChar = false;                
                btn_mostrarSenha.BackColor = Color.Red;
            }
            else
            {
                txt_senha.UseSystemPasswordChar = true;                
                btn_mostrarSenha.BackColor = Color.Lime;
            }
        }
    }
}
