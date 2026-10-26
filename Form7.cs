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
    public partial class FormPacote2 : Form
    {
        DAO bd;
        int indexPassado;
        int codigoP;
        public FormPacote2(int indexAuxiliar, int codigoPacote)
        {
            InitializeComponent();            
            this.indexPassado = indexAuxiliar;
            bd = new DAO();            
            this.indexPassado = indexAuxiliar;
            this.codigoP = codigoPacote;

            if (this.codigoP != 0)
            {
                CarregarDados();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            FormCompraP2 pacote2Compra = new FormCompraP2(this, this.indexPassado, bd.GetPacote2());
            pacote2Compra.ShowDialog();

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void CarregarDados()
        {
            bd.PreencherVetorPacote();
            int indexPesquisa = bd.ProcurarPacote(this.codigoP);
            LbDestino.Text = bd.destino[indexPesquisa];
            LbDataIda.Text = "Data da Ida: " + bd.dataIda[indexPesquisa];
            LbDataVolta.Text = "Data da Volta: " + bd.dataVolta[indexPesquisa];
            LbHotel.Text = bd.nomeHotel[indexPesquisa];
            LbDescricao.Text = bd.descricao[indexPesquisa];
        }
    }
}
