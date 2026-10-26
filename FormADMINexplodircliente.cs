using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AgenciaDeViagens
{
    public partial class FormADMINexplodircliente : Form       
    {
        DAO bd;
        public FormADMINexplodircliente()
        {
            InitializeComponent();
            bd = new DAO();
            bd.PreencherVetor();            
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            bd.PreencherVetor();
            int indexPesquisa = bd.ProcurarCliente(Convert.ToInt32(TxtPesquisa.Text));
            if (indexPesquisa == 101)
            {
                MessageBox.Show("Código Inexistente!");
            }
            else
            {                
                //MessageBox.Show("Index Pesquisa" + indexPesquisa)
                //Busca os dados no banco carregado no programa atráves do indexAuxiliar
                MktxtCpf.Text = Convert.ToString(bd.cpf[indexPesquisa]);
                MktxtCpf.Text = Convert.ToString(bd.cpf[indexPesquisa]);
                MktxtTelefone.Text = bd.telefone[indexPesquisa];
                TxtNome.Text = bd.nome[indexPesquisa];
                TxtEmail.Text = bd.email[indexPesquisa];
                TxtEndereco.Text = bd.endereco[indexPesquisa];
                TxtSenha.Text = bd.senha[indexPesquisa];
                TxtSenhaConfirma.Text = bd.senha[indexPesquisa];

            }
        }

        private void BtnMostrarSenha_Click(object sender, EventArgs e)
        {
            if (TxtSenha.UseSystemPasswordChar == true)
            {
                TxtSenha.UseSystemPasswordChar = false;
                TxtSenhaConfirma.UseSystemPasswordChar = false;
                BtnMostrarSenha.BackgroundImage = Properties.Resources.hide_password;
            }
            else
            {
                TxtSenha.UseSystemPasswordChar = true;
                TxtSenhaConfirma.UseSystemPasswordChar = true;
                BtnMostrarSenha.BackgroundImage = Properties.Resources.show_password2;
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            long cpf = Convert.ToInt64(RemoverFormatacaoCPF(MktxtCpf.Text));

            try
            {
                if (TxtPesquisa.Text == "")
                {
                    MessageBox.Show("Digite o código do cliente que deseja alterar!");
                }
                if (TxtSenha.Text != TxtSenhaConfirma.Text)
                {
                    MessageBox.Show("Senhas não conferem!");
                }
                else
                {
                    //Pega o codigo na DAO e usa pra localizar no banco
                    MessageBox.Show(bd.AtualizarClienteADM(Convert.ToInt32(TxtPesquisa.Text), cpf, TxtNome.Text, MktxtTelefone.Text, TxtEmail.Text, TxtEndereco.Text, TxtSenha.Text));
                    LimparCampos();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro!\n\n" + erro);
            }

        }
        public string RemoverFormatacaoCPF(string cpf)
        {
            string cpfAlterado = cpf.Replace(",", "");
            cpfAlterado = cpfAlterado.Replace("-", "");
            return cpfAlterado;
        }//fim do RemoverFormataçãoCPF

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimparCampos()
        {
            TxtPesquisa.Text = "";
            MktxtCpf.Text = "";
            MktxtTelefone.Text = "";
            TxtNome.Text = "";
            TxtEmail.Text = "";
            TxtEndereco.Text = "";
            TxtSenha.Text = "";
            TxtSenhaConfirma.Text = "";

        }//Fim Limpar Campos

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {           
                if (TxtPesquisa.Text == "")
                {
                    MessageBox.Show("Digite o código do cliente que deseja excluir!");
                }
                else
                {
                    int codigo = Convert.ToInt32(TxtPesquisa.Text);
                    MessageBox.Show(bd.ExcluirCliente(codigo));
                    LimparCampos();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro!\n\n" + erro);
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            long cpf = Convert.ToInt64(RemoverFormatacaoCPF(MktxtCpf.Text));
            if(MktxtCpf.Text == "")
            {
                MessageBox.Show("Preencha os campos vazios!");
            }
            if (TxtSenha.Text != TxtSenhaConfirma.Text)
            {
                MessageBox.Show("Senhas não conferem!");
            }
            else if (bd.ProcurarCPF(cpf) != 101) { //diferente quer dizer que achou um cpf
                MessageBox.Show("Esse CPF já está cadastrado!");
            }
            else //igual a 101 quer dizer que não achou
            {
                MessageBox.Show(bd.Cadastrar(cpf, TxtNome.Text, MktxtTelefone.Text, TxtEmail.Text, TxtEndereco.Text, TxtSenha.Text));
                LimparCampos();
            }

        }
    }
}
