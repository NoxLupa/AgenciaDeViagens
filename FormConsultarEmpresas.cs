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
    public partial class FormConsultarEmpresas : Form
    {
        DAO bd;
        public FormConsultarEmpresas()
        {
            InitializeComponent();
            bd = new DAO();

            //Configuração do GRID
            ConfigurarGRID();
            NomeColunas();
            bd.PreencherVetorEmpresa();
            AdicionarLinhas();
        }
        public void NomeColunas()
        {
            DgEmpresas.Columns[0].Name = "Código";
            DgEmpresas.Columns[1].Name = "Nome";
            DgEmpresas.Columns[2].Name = "CNPJ";
            DgEmpresas.Columns[3].Name = "Tipo Transporte";
        }//Fim do NomeColunas
        public void AdicionarLinhas()
        {
            for (int i = 0; i < bd.QuantidadeDados(); i++)
            {
                DgEmpresas.Rows.Add(bd.codigoEmpresa[i], bd.nomeEmpresa[i], bd.CNPJ[i], bd.chaveTipoTransporte[i]);

            }//Fim do For
        }//Fim do Adicionar

        public void ConfigurarGRID()
        {
            DgEmpresas.AllowUserToAddRows = false;
            DgEmpresas.AllowUserToDeleteRows = false;
            DgEmpresas.AllowUserToResizeRows = false;
            DgEmpresas.AllowUserToResizeColumns = false;
            DgEmpresas.ColumnCount = 4;
        }
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
    }
}
