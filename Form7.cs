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
    public partial class Pacote2 : Form
    {
        int indexPassado;
        public Pacote2(int indexAuxiliar)
        {
            InitializeComponent();
            MessageBox.Show("PERFIL (INDEX): \n\n " + indexAuxiliar);
            this.indexPassado = indexAuxiliar;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            Form11 pacote2Compra = new Form11(this.indexPassado);
            pacote2Compra.ShowDialog();

        }
    }
}
