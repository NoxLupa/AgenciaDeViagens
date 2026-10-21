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
    public partial class Form4 : Form
    {
        DAO bd;
        string userLogado;
        int indexAuxiliar;
        TelaPerfil perfil;

        public Form4(string userLogado, int indexAuxiliar)
        {
            InitializeComponent();            
            bd = new DAO();
            bd.PreencherVetor();
            this.userLogado = userLogado;
            this.indexAuxiliar = indexAuxiliar;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lbl_boasvindas.Text = ("Seja Bem-Vindo " + userLogado +"!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            
            perfil = new TelaPerfil(this.indexAuxiliar);
            perfil.ShowDialog();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnVerPacote2_Click(object sender, EventArgs e)
        {
            Pacote2 pacote2 = new Pacote2(this.indexAuxiliar);
            pacote2.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
    /*
      Form6 pacote4 = new Form6();
            pacote4.ShowDialog();
     Form5 pacote3 = new Form5();
            pacote3.ShowDialog();
    */
}
