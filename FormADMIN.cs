using Org.BouncyCastle.Pqc.Crypto.Lms;
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
    public partial class FormADMIN : Form
    {
        Form4 TelaCompra;
        public FormADMIN(Form4 telaAnterior)
        {
            InitializeComponent();
            this.TelaCompra = telaAnterior;

            TelaCompra.Hide();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            FormADMINClientes adminClientes = new FormADMINClientes(this);
            adminClientes.ShowDialog();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            TelaCompra.Show();
            this.Close();
        }

        private void BtnAgencias_Click(object sender, EventArgs e)
        {
            FormAdminAgencias adminAgencias = new FormAdminAgencias(this);
            adminAgencias.ShowDialog();
        }
    }
}
