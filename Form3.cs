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
            //ValidarLogin();
            //Auxiliares
            long cpfDigitado = Convert.ToInt64(RemoverFormatacaoCPF(mktxt_cpf.Text));
            string senhaDigitada = txt_senha.Text;
            long cpfBanco;
            string senhaBanco;

            int posSenha;
            int i = 0;
            try {
                bd.ValidarLogin(cpfDigitado, senhaDigitada);
                /* //Achar o cpf no banco            
                 while (cpf != bd.cpf[i])
                 {

                     if (cpf == bd.cpf[i])
                     {
                         MessageBox.Show(Convert.ToString(bd.cpf[i]));

                         //Pegar a posição da senha no banco
                         posSenha = i;
                         cpfBanco = bd.cpf[posSenha];
                         senhaBanco = bd.senha[posSenha];
                         if ((cpf == cpfBanco) && (txt_senha.Text == senhaBanco))
                         {
                             MessageBox.Show("Logado com sucesso!");
                         }
                         else
                         {
                             MessageBox.Show("CPF ou senha inválidos!");
                         }
                     }//fim if
                     i++;
                 }//fim while*/
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
            //pegar cpf
            //buscar cpf na lista
            //ver se senha do campo é igual ao do banco.

        }//fim Botão Confirmar

        public string RemoverFormatacaoCPF(string cpf)
        {
            string cpfAlterado = cpf.Replace(",", "");
            cpfAlterado = cpfAlterado.Replace("-", "");
            return cpfAlterado;
        }//fim do remover formatação
    }
}
