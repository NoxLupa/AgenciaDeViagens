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
    public partial class FormPacote3 : Form
    {
        DAO bd;
        int indexPassado;
        int codigoP;
        public FormPacote3(int indexAuxiliar, int codigoPacote)
        {
            bd = new DAO();
            InitializeComponent();
            this.indexPassado = indexAuxiliar;
            this.codigoP = codigoPacote;

            if(this.codigoP != 0) 
            { 
                CarregarDados();
            }

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            FormComprarP3 pacote3Compra = new FormComprarP3(this.indexPassado, this, bd.GetPacote3());
            pacote3Compra.ShowDialog();
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
