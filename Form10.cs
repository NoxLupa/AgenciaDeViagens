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
    public partial class FormCompraP2 : Form
    {
        DAO bd;
        FormPacote2 pacote2;
        int codigoAux;
        decimal valorPorPessoa;
        int taxa;
        decimal valorTotal;
        decimal totalPessoas;
        int codigoP;
        public FormCompraP2(FormPacote2 pacoteTela, int indexAuxiliar, int codigoPacote)
        {
            InitializeComponent();
            this.pacote2 = pacoteTela;
            this.codigoP = codigoPacote;
            bd = new DAO();
            bd.PreencherVetor();                       
            bd.PreencherVetorEmpresa();

            if (bd.GetPacote2() != 0)
            {
                CarregarDados();
            }

            //Preenchimento automático dos Dados Cliente
            codigoAux = bd.codigo[indexAuxiliar];
            //Busca os dados no banco carregado no programa atráves do indexAuxiliar
            TxtNome.Text = bd.nome[indexAuxiliar];
            TxtCPF.Text = Convert.ToString(bd.cpf[indexAuxiliar]);
            TxtEmail.Text = bd.email[indexAuxiliar];
            TxtTelefone.Text = bd.telefone[indexAuxiliar];

            //Bloqueia alteração para o cliente
            TxtNome.ReadOnly = true;
            TxtCPF.ReadOnly = true;
            TxtEmail.ReadOnly = true;
            TxtTelefone.ReadOnly = true;

            this.taxa = 250;
            this.valorPorPessoa = 3499;
            taxaPorPessoa.Text = "R$" + this.valorPorPessoa;

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            pacote2.Close();
            this.Close();
        }
        public void CarregarDados()
        {
            bd.PreencherVetorPacote();
            //bd.PreencherVetorEmpresa();
            int indexPesquisa = bd.ProcurarPacote(this.codigoP);
            LbDestino.Text = bd.destino[indexPesquisa];
            LbDataIda.Text = "Data da Ida: " + bd.dataIda[indexPesquisa];
            LbDataVolta.Text = "Data da Volta: " + bd.dataVolta[indexPesquisa];
            LbHotel.Text = bd.nomeHotel[indexPesquisa];

            int idE = bd.chaveCodigoEmpresa[indexPesquisa];
            int indiceE = bd.ProcurarEmpresa(idE);
            //MessageBox.Show("ID " + idE);
            LbEmpresa.Text = bd.nomeEmpresa[indiceE];
            LbTransporte.Text = bd.chaveTipoTransporte[indiceE];
        }//Fim Carregar Dados

        private void Total_TextChanged(object sender, EventArgs e)
        {

        }

        private void numero_ValueChanged(object sender, EventArgs e)
        {
            //Calculo dos Preços

            this.totalPessoas = numero.Value;
            valorTotal = (valorPorPessoa * totalPessoas) + taxa;
            Total.Text = "Total R$" + Convert.ToString(valorTotal);//8 tabs
        }
    }
}
