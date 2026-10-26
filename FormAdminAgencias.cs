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
    public partial class FormAdminAgencias : Form
    {
        FormADMIN adminTela;
        public FormAdminAgencias(FormADMIN telaAnterior)
        {
            InitializeComponent();
            this.adminTela = telaAnterior;

            adminTela.Hide();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            FormConsultarEmpresas consultaEmpresa = new FormConsultarEmpresas();
            consultaEmpresa.ShowDialog();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            adminTela.Show();
            this.Close();
        }

        private void BtnGerenciar_Click(object sender, EventArgs e)
        {
            FormGerenciarEmpresa gerenciarEmp = new FormGerenciarEmpresa();
            gerenciarEmp.ShowDialog();
        }

        private void BtnConsultarPacotes_Click(object sender, EventArgs e)
        {
            FormConsultarPacotes consultaPacote = new FormConsultarPacotes();
            consultaPacote.ShowDialog();
        }

        private void BtnGerenciarPacotes_Click(object sender, EventArgs e)
        {
            FormGerenciarPacotes gerenciarPac = new FormGerenciarPacotes();
            gerenciarPac.ShowDialog();
        }
    }
}
