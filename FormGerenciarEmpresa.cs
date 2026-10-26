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
    public partial class FormGerenciarEmpresa : Form
    {
        DAO bd;
        public FormGerenciarEmpresa()
        {
            InitializeComponent();
            bd = new DAO();
            bd.PreencherVetorEmpresa();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            long cnpj = Convert.ToInt64(RemoverFormatacaoCNPJ(MktxtCNPJ.Text));
            string tipoTransporte = ComboBoxTipo.Text;          
            try
            {
                if (TxtPesquisa.Text == "")
                {
                    MessageBox.Show("Digite o código da empresa que deseja alterar!");
                }
                else 
                { 
                    //Pega o codigo na DAO e usa pra localizar no banco
                    MessageBox.Show(bd.AtualizarEmpresa(Convert.ToInt32(TxtPesquisa.Text), TxtNome.Text, cnpj, tipoTransporte));
                    LimparCampos();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro!\n\n" + erro);
            }

        }//Fim Alterar Empresa
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {            
                long cnpj = Convert.ToInt64(RemoverFormatacaoCNPJ(MktxtCNPJ.Text));
                string tipoTransporte = ComboBoxTipo.Text;
                if (MktxtCNPJ.Text == "")
                {
                    MessageBox.Show("Preencha os campos vazios!");
                }

                if (bd.ProcurarCNPJ(cnpj) != 101)
                { 
                    MessageBox.Show("Esse CNPJ já está cadastrado!");
                }
                else
                {
                    MessageBox.Show(bd.CadastrarEmpresa(TxtNome.Text, cnpj, tipoTransporte));
                    LimparCampos();
                }
            }catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado! \n\n" + erro);
            }
        }//Fim do Cadastrar
        public string RemoverFormatacaoCNPJ(string cnpj)
        {
            string cnpjAlterado = cnpj.Replace(",", "");
            cnpjAlterado = cnpjAlterado.Replace("/", "");
            cnpjAlterado = cnpjAlterado.Replace("-", "");
            return cnpjAlterado;

        }//fim do RemoverFormataçãoCNPJ

        public void LimparCampos()
        {
            TxtPesquisa.Text = "";
            TxtNome.Text = "";
            MktxtCNPJ.Text = "";
            ComboBoxTipo.Text = "";
        }//Fim do Limpar Campos

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try 
            { 
                if (TxtPesquisa.Text == "")
                {
                    MessageBox.Show("Digite o código da empresa que deseja excluir!");
                }
                else
                {
                    int codigo = Convert.ToInt32(TxtPesquisa.Text);
                    MessageBox.Show(bd.ExcluirEmpresa(codigo));                    
                    LimparCampos();
                }
            }catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado! \n\n" + erro);
            }

        }//Fim do Excluir

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            bd.PreencherVetorEmpresa();
            int indexPesquisa = bd.ProcurarEmpresa(Convert.ToInt32(TxtPesquisa.Text));
            if (indexPesquisa == 101)
            {
                MessageBox.Show("Código Inexistente!");
            }
            else
            { 
                //Busca os dados no banco carregado no programa atráves do indexAuxiliar
                TxtNome.Text = Convert.ToString(bd.nomeEmpresa[indexPesquisa]);
                MktxtCNPJ.Text = Convert.ToString(bd.CNPJ[indexPesquisa]);
                ComboBoxTipo.Text = Convert.ToString(bd.chaveTipoTransporte[indexPesquisa]);
            }

        }//Fim do Pesquisar
    }

}
