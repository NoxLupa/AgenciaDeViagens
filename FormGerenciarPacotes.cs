using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaDeViagens
{
    public partial class FormGerenciarPacotes : Form
    {
        DAO bd;      
        public FormGerenciarPacotes()
        {
            InitializeComponent();
            bd = new DAO();
            bd.PreencherVetorPacote();
            bd.PreencherVetorEmpresa();                        

            PreencherComboBox();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            string destino = TxtDestino.Text;
            decimal valor = Convert.ToDecimal(TxtValor.Text);
            string dataIda = MktxtDataIda.Text;
            string dataVolta = MktxtDataVolta.Text;
            string hotel = TxtHotel.Text;
            string descricao = TxtDescricao.Text;
            int codigoEmpresa = Convert.ToInt32(ComboBoxEmpresa.Text);
            try
            {
                if (TxtDestino.Text == "")
                {
                    MessageBox.Show("Preencha os campos vazios!");
                }
                else { 
                    MessageBox.Show(bd.CadastrarPacote(destino, valor, dataIda, dataVolta, hotel, descricao, codigoEmpresa));
                    LimparCampos();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado! \n\n" + erro);
            }
        }//Fim do Cadastrar

        public void LimparCampos()
        {
            TxtPesquisa.Text = "";
            TxtDestino.Text = "";
            TxtValor.Text = "";
            MktxtDataIda.Text = "";
            MktxtDataVolta.Text = "";
            TxtHotel.Text = "";
            TxtDescricao.Text = "";
            ComboBoxEmpresa.Text = "";
            LbEmpresa.Text = "";
        }//Fim do LimparCampos

        public void PreencherComboBox()
        {
            
            for (int i = 0; i < bd.QuantidadeDados(); i++)
            {
                ComboBoxEmpresa.Items.Add(bd.codigoEmpresa[i]);

            }//Fim do For            
            
        }//Fim Do Preencher Combo Box

        public void LocalizarEmpresaBanco()
        {
            int indexPesquisa = bd.ProcurarEmpresa(Convert.ToInt32(ComboBoxEmpresa.Text));
            
            LbEmpresa.Text = (Convert.ToString(bd.nomeEmpresa[indexPesquisa]) + " - " + bd.chaveTipoTransporte[indexPesquisa]);
           
        }//Fim Localizar Empresa
        private void BtnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBoxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocalizarEmpresaBanco();
        }//Fim doCombox Change

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(TxtPesquisa.Text);
            string destino = TxtDestino.Text;
            decimal valor = Convert.ToDecimal(TxtValor.Text);
            string dataIda = MktxtDataIda.Text;
            string dataVolta = MktxtDataVolta.Text;
            string hotel = TxtHotel.Text;
            string descricao = TxtDescricao.Text;
            int codigoEmpresa = Convert.ToInt32(ComboBoxEmpresa.Text);
            try
            {
                if (TxtPesquisa.Text == "")
                {
                    MessageBox.Show("Digite o código do pacote que deseja excluir!");
                }
                else 
                { 
                    //Pega o codigo na DAO e usa pra localizar no banco
                    MessageBox.Show(bd.AtualizarPacote(codigo, destino, valor, dataIda, dataVolta, hotel, descricao, codigoEmpresa));
                    LimparCampos();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro!\n\n" + erro);
            }
        }//Fim do Alterar

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtPesquisa.Text == "")
                {
                    MessageBox.Show("Digite o código do pacote que deseja excluir!");
                }
                else
                {
                    int codigo = Convert.ToInt32(TxtPesquisa.Text);
                    MessageBox.Show(bd.ExcluirPacote(codigo));
                    LimparCampos();                    
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado! \n\n" + erro);
            }
        }//Fim do Excluir

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            bd.PreencherVetorPacote();//Recarrega o vetor
            int indexPesquisa = bd.ProcurarPacote(Convert.ToInt32(TxtPesquisa.Text));
            if (indexPesquisa == 101)
            {
                MessageBox.Show("Código Inexistente!");
            }
            else
            { 
                //Busca os dados no banco carregado no programa atráves do indexAuxiliar
                TxtDestino.Text = bd.destino[indexPesquisa];
                TxtValor.Text = Convert.ToString(bd.valor[indexPesquisa]);
                MktxtDataIda.Text = bd.dataIda[indexPesquisa];
                MktxtDataVolta.Text = bd.dataVolta[indexPesquisa];
                TxtHotel.Text = bd.nomeHotel[indexPesquisa];
                TxtDescricao.Text = bd.descricao[indexPesquisa];
                ComboBoxEmpresa.Text = Convert.ToString(bd.chaveCodigoEmpresa[indexPesquisa]);
            }


        }//Fim do Pesquisar
    }//Fim do Form
}
