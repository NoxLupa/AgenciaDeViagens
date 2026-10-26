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
    public partial class FormConsultarPacotes : Form
    {
        DAO bd;
        public FormConsultarPacotes()
        {
            InitializeComponent();
            bd = new DAO();

            //Configuração do GRID
            ConfigurarGRID();
            NomeColunas();
            bd.PreencherVetorPacote();
            AdicionarLinhas();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void NomeColunas()
        {
            DgPacotes.Columns[0].Name = "Código";
            DgPacotes.Columns[1].Name = "Destino";
            DgPacotes.Columns[2].Name = "Valor";
            DgPacotes.Columns[3].Name = "Data Ida";
            DgPacotes.Columns[4].Name = "Data Volta";
            DgPacotes.Columns[5].Name = "Nome Hotel";
            DgPacotes.Columns[6].Name = "Descrição";
            DgPacotes.Columns[7].Name = "Código Empresa";
        }//Fim do NomeColunas
        public void AdicionarLinhas()
        {
            for (int i = 0; i < bd.QuantidadeDados(); i++)
            {
                DgPacotes.Rows.Add(bd.codigoPacote[i], bd.destino[i], bd.valor[i], bd.dataIda[i], bd.dataVolta[i], bd.nomeHotel[i], bd.descricao[i], bd.chaveCodigoEmpresa[i]);

            }//Fim do For
        }//Fim do Adicionar

        public void ConfigurarGRID()
        {
            DgPacotes.AllowUserToAddRows = false;
            DgPacotes.AllowUserToDeleteRows = false;
            DgPacotes.AllowUserToResizeRows = false;
            DgPacotes.AllowUserToResizeColumns = false;
            DgPacotes.ColumnCount = 8;
        }
    }
}
