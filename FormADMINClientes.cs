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
    public partial class FormADMINClientes : Form
    {
        FormADMIN adminTela;
        public FormADMINClientes(FormADMIN telaAnterior)
        {
            InitializeComponent();
            this.adminTela = telaAnterior;

            adminTela.Hide();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            adminTela.Show();
            this.Close();
        }

        private void BtnGerenciar_Click(object sender, EventArgs e)
        {
            FormADMINexplodircliente gerenciarCliente = new FormADMINexplodircliente();
            gerenciarCliente.ShowDialog();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            FormConsultarCliente consultaCliente = new FormConsultarCliente();
            consultaCliente.ShowDialog();
        }
    }
}
