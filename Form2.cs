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
    public partial class TelaCadastro : Form
    {
        DAO bd;
        public TelaCadastro()
        {
            InitializeComponent();
            bd = new DAO();
        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {            

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {            
            this.Close();                 
        }

        private void btn_mostrarSenha_Click(object sender, EventArgs e)
        {
            if(txt_senha.UseSystemPasswordChar == true)
            {
                txt_senha.UseSystemPasswordChar = false;
                txt_senhaConfirma.UseSystemPasswordChar = false;
                btn_mostrarSenha.BackColor = Color.Red;
            }
            else
            {
                txt_senha.UseSystemPasswordChar = true;
                txt_senhaConfirma.UseSystemPasswordChar = true;
                btn_mostrarSenha.BackColor = Color.Lime;
            }
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {                        
            //Validações - verificar se o cpf já existe
            try
            {
                if (txt_senha.Text != txt_senhaConfirma.Text)
                {                    
                    MessageBox.Show("Senhas não conferem!");                    
                }
                else
                {
                    long cpf = Convert.ToInt64(RemoverFormatacaoCPF(mktxt_cpf.Text));
                    string nome = txt_nome.Text;
                    string telefone = mktxt_telefone.Text;
                    string email = txt_email.Text;
                    string endereco = txt_endereco.Text;
                    string senha = txt_senha.Text;

                    MessageBox.Show(bd.Cadastrar(cpf, nome, telefone, email, endereco, senha));

                    LimparTela();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }            
        }//fim do Cadastrar

        public string RemoverFormatacaoCPF(string cpf)
        {
            string cpfAlterado = cpf.Replace(",", "");
            cpfAlterado = cpfAlterado.Replace("-", "");
            return cpfAlterado;
        }//fim do remover formatação
       

        public void LimparTela()
        {
            mktxt_cpf.Text = "";
            txt_nome.Text = "";
            mktxt_telefone.Text = "";
            txt_email.Text = "";
            txt_endereco.Text = "";
            txt_senha.Text = "";
            txt_senhaConfirma.Text = "";

        }
    }
}
