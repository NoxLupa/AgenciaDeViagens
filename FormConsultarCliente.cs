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
    public partial class FormConsultarCliente : Form
    {
        DAO bd;
        public FormConsultarCliente()
        {
            InitializeComponent();
            bd = new DAO();

            //Configuração do GRID
            ConfigurarGRID();
            NomeColunas();
            bd.PreencherVetor();
            AdicionarLinhas();
        }
        public void NomeColunas()
        {
            DgClientes.Columns[0].Name = "Código";
            DgClientes.Columns[1].Name = "CPF";
            DgClientes.Columns[2].Name = "Nome";
            DgClientes.Columns[3].Name = "Telefone";
            DgClientes.Columns[4].Name = "E-mail";
            DgClientes.Columns[5].Name = "Endereço";
            DgClientes.Columns[6].Name = "Senha";
        }//Fim do NomeColunas
        public void AdicionarLinhas()
        {
            for(int i = 0; i < bd.QuantidadeDados(); i++)
            {
                DgClientes.Rows.Add(bd.codigo[i], bd.cpf[i], bd.nome[i], bd.telefone[i], bd.email[i], bd.endereco[i], bd.senha[i]);

            }//Fim do For
        }//Fim do Adicionar

        public void ConfigurarGRID()
        {
            DgClientes.AllowUserToAddRows = false;
            DgClientes.AllowUserToDeleteRows = false;
            DgClientes.AllowUserToResizeRows = false;
            DgClientes.AllowUserToResizeColumns = false;
            DgClientes.ColumnCount = 7;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
