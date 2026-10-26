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
    public partial class FormComprarP3 : Form
    {
        DAO bd;
        int codigoAux;
        decimal valorPorPessoa;
        int taxa;
        decimal valorTotal;
        decimal totalPessoas;
        int codigoP;
        FormPacote3 pacote3;

        public FormComprarP3(int indexAuxiliar, FormPacote3 pacoteTela, int codigoPacote)
        {

            InitializeComponent();
            pacote3 = pacoteTela;
            this.codigoP = codigoPacote;

            bd = new DAO();
            bd.PreencherVetor();
            bd.PreencherVetorEmpresa();


            if (bd.GetPacote3() != 0)
            {
                CarregarDados();
            }

            //Preenchimento automático dos Dados Cliente
            codigoAux = bd.codigo[indexAuxiliar];
            //Busca os dados no banco carregado no programa atráves do indexAuxiliar
            textNome.Text = bd.nome[indexAuxiliar];
            textCPF.Text = Convert.ToString(bd.cpf[indexAuxiliar]);
            textemail.Text = bd.email[indexAuxiliar];
            texttelefone.Text = bd.telefone[indexAuxiliar];

           //Bloqueia alteração para o cliente
           textNome.ReadOnly = true;
           textCPF.ReadOnly = true;
           textemail.ReadOnly = true;
           texttelefone.ReadOnly = true;

            this.taxa = 250;
            this.valorPorPessoa = 3499;
            taxaPorPessoa.Text = "R$" + this.valorPorPessoa;

        }//Fim Construtor

        private void numero_ValueChanged(object sender, EventArgs e)
        {
            //Calculo dos Preços
           
            this.totalPessoas = numero.Value;
            valorTotal = (valorPorPessoa * totalPessoas) + taxa;
            Total.Text = "Total R$" + Convert.ToString(valorTotal);//8 tabs
        }

        private void Total_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            this.pacote3.Close();
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
            if(indiceE == 101)
            {
                MessageBox.Show("Empresa inexistente!");
            }
            else
            {
                LbEmpresa.Text = bd.nomeEmpresa[indiceE];
                LbTransporte.Text = bd.chaveTipoTransporte[indiceE];
            }
        }//Fim Carregar Dados
    }
}
