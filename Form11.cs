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
    public partial class Form11 : Form
    {
        DAO bd;
        int codigoAux;
        decimal valorPorPessoa;
        int taxa;
        decimal valorTotal;
        decimal totalPessoas;

        public Form11(int indexAuxiliar)
        {

            InitializeComponent();
            comboBox1.Items.Add("1");
            bd = new DAO();
            bd.PreencherVetor();
            MessageBox.Show("PERFIL (INDEX): \n\n " + indexAuxiliar);

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


        }

        private void label9_Click(object sender, EventArgs e)
        {
      

        }

        private void numero_ValueChanged(object sender, EventArgs e)
        {
            //Calculo dos Preços
            this.taxa = 250;
            this.valorPorPessoa = 3499;
            this.totalPessoas = numero.Value;

            taxaPorPessoa.Text = "R$" + this.valorPorPessoa;
            valorTotal = (valorPorPessoa * totalPessoas) + taxa;
            Total.Text = "Total                                                                                           R$" + Convert.ToString(valorTotal);//8 tabs
        }

        private void Total_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
