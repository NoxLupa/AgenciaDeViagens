using Org.BouncyCastle.Asn1.Mozilla;
using Org.BouncyCastle.Tls.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        TelaLogin TelaLogin;
        TelaInicio TelaInicio;

        public Form4(string userLogado, int indexAuxiliar, TelaLogin telaAnterior, TelaInicio telaInicio)
        {
            InitializeComponent();            
            bd = new DAO();
            bd.PreencherVetor();
            bd.PreencherVetorPacote();
            this.userLogado = userLogado;
            this.indexAuxiliar = indexAuxiliar;
            this.TelaLogin = telaAnterior;
            this.TelaLogin.Close();
            this.TelaInicio = telaInicio;
            telaInicio.Hide();           
            
            InicializarPacotes();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
            lbl_boasvindas.Text = ("Seja Bem-Vindo, " + userLogado +"!");
           
            //DEBUG: MessageBox.Show("Estado adm Form 4: " + bd.GetADM());            
            if (bd.GetADM() == true)
            {
                BtnAdm.Visible = true;
                btnPerfil.Visible = false;
                TxtPacote1.Visible = true;
                TxtPacote2.Visible = true;
                TxtPacote3.Visible = true;
                TxtPacote4.Visible = true;
                BtnEditarPacote1.Visible = true;
                BtnEditarPacote2.Visible = true;
                BtnEditaPacote3.Visible = true;
                BtnEditarPacote4.Visible = true;                
            }

            
        }//Fim Form4 Load

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            
            perfil = new TelaPerfil(this.indexAuxiliar, this, this.TelaInicio);
            perfil.ShowDialog();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {            
            TelaInicio.Show();
            this.Close();
        }
        
        private void BtnVerPacote2_Click(object sender, EventArgs e)
        {
            FormPacote2 pacote2 = new FormPacote2(this.indexAuxiliar, bd.GetPacote2());
            pacote2.ShowDialog();
        }


        private void BtnVerPacote1_Click(object sender, EventArgs e)
        {
            FormPacote1 pacote1 = new FormPacote1(this.indexAuxiliar, bd.GetPacote1());
            pacote1.ShowDialog(); //Form Pacote1 --> // fomr 10

        }

        private void BtnAdm_Click(object sender, EventArgs e)
        {
            FormADMIN admin = new FormADMIN(this);
            admin.Show();
        }

        private void BtnVerPacote4_Click(object sender, EventArgs e)
        {
            FormPacote4 pacote4 = new FormPacote4(this.indexAuxiliar, bd.GetPacote4());
            pacote4.ShowDialog(); //Abre o form6 -> abre o form9
        }

        private void BtnVerPacote3_Click(object sender, EventArgs e)
        {
            FormPacote3 pacote3 = new FormPacote3(this.indexAuxiliar, bd.GetPacote3());
            pacote3.ShowDialog(); //form5 -> abre o from 8
        }

        private void BtnEditarPacote1_Click(object sender, EventArgs e)
        {
            if (TxtPacote1.Text == "")
            {
                MessageBox.Show("Digite um valor!");
                
            }
            else {
                bd.SetPacote1(Convert.ToInt32(TxtPacote1.Text));
                //DEBUG: MessageBox.Show("GET PACOTE: " + bd.GetPacote1().ToString());
                
                //int indexPesquisa = bd.ProcurarPacote(bd.GetPacote1());
                int indexPesquisa = bd.ProcurarPacote(Convert.ToInt32(TxtPacote1.Text));

                TxtPacote1.Text = bd.codigoPacote[indexPesquisa].ToString();
                LbDestino.Text = bd.destino[indexPesquisa];
                LbDataIda.Text = "Ida: " + bd.dataIda[indexPesquisa].ToString();
                LbDataVolta.Text = "Volta: " + bd.dataVolta[indexPesquisa].ToString();
                LbHotel.Text = bd.nomeHotel[indexPesquisa];
                LbValor.Text = "Valor: R$" + bd.valor[indexPesquisa].ToString();
            }            
        }//Fim EditarPacote1

        public void InicializarPacotes()
        {
            if(bd.GetPacote1() != 0)
            {                            
                TxtPacote1.Text = bd.GetPacote1().ToString();
                int indexPesquisa = bd.ProcurarPacote(Convert.ToInt32(TxtPacote1.Text));                
                LbDestino.Text = bd.destino[indexPesquisa];
                LbDataIda.Text = "Ida: " + bd.dataIda[indexPesquisa];
                LbDataVolta.Text = "Volta: " + bd.dataVolta[indexPesquisa];
                LbHotel.Text = bd.nomeHotel[indexPesquisa];
                LbValor.Text = "Valor: R$" + bd.valor[indexPesquisa].ToString();
            }

            if (bd.GetPacote2() != 0)
            {
                TxtPacote2.Text = bd.GetPacote2().ToString();
                int indexPesquisa = bd.ProcurarPacote(Convert.ToInt32(TxtPacote2.Text));
                LbDestino2.Text = bd.destino[indexPesquisa];
                LbDataIda2.Text = "Ida: " + bd.dataIda[indexPesquisa];
                LbDataVolta2.Text = "Volta: " + bd.dataVolta[indexPesquisa];
                LbHotel2.Text = bd.nomeHotel[indexPesquisa];
                LbValor2.Text = "Valor: R$" + bd.valor[indexPesquisa].ToString();
            }

            if (bd.GetPacote3() != 0)
            {
                TxtPacote3.Text = bd.GetPacote3().ToString();
                int indexPesquisa = bd.ProcurarPacote(Convert.ToInt32(TxtPacote3.Text));
                LbDestino3.Text = bd.destino[indexPesquisa];
                LbDataIda3.Text = "Ida: " + bd.dataIda[indexPesquisa];
                LbDataVolta3.Text = "Volta: " + bd.dataVolta[indexPesquisa];
                LbHotel3.Text = bd.nomeHotel[indexPesquisa];
                LbValor3.Text = "Valor: R$" + bd.valor[indexPesquisa].ToString();
            }

            if (bd.GetPacote4() != 0)
            {
                TxtPacote4.Text = bd.GetPacote4().ToString();
                int indexPesquisa = bd.ProcurarPacote(Convert.ToInt32(TxtPacote4.Text));
                LbDestino4.Text = bd.destino[indexPesquisa];
                LbDataIda4.Text = "Ida: " + bd.dataIda[indexPesquisa];
                LbDataVolta4.Text = "Volta: " + bd.dataVolta[indexPesquisa];
                LbHotel4.Text = bd.nomeHotel[indexPesquisa];
                LbValor4.Text = "Valor: R$" + bd.valor[indexPesquisa].ToString();
            }

        }//Fim InicializarPacotes

        private void BtnEditarPacote2_Click(object sender, EventArgs e)
        {
            if (TxtPacote2.Text == "")
            {
                MessageBox.Show("Digite um valor!");
            }
            else
            {
                bd.SetPacote2(Convert.ToInt32(TxtPacote2.Text));
                                
                int indexPesquisa = bd.ProcurarPacote(Convert.ToInt32(TxtPacote2.Text));

                TxtPacote2.Text = bd.codigoPacote[indexPesquisa].ToString();
                LbDestino2.Text = bd.destino[indexPesquisa];
                LbDataIda2.Text = "Ida: " + bd.dataIda[indexPesquisa].ToString();
                LbDataVolta2.Text = "Volta: " + bd.dataVolta[indexPesquisa].ToString();
                LbHotel2.Text = bd.nomeHotel[indexPesquisa];
                LbValor2.Text = "Valor: R$" + bd.valor[indexPesquisa].ToString();
            }

        }//Fim Editar Pacote 2

        private void BtnEditaPacote3_Click(object sender, EventArgs e)
        {
            if (TxtPacote3.Text == "")
            {
                MessageBox.Show("Digite um valor!");
            }
            else
            {
                bd.SetPacote3(Convert.ToInt32(TxtPacote3.Text));                
                
                int indexPesquisa = bd.ProcurarPacote(Convert.ToInt32(TxtPacote3.Text));

                TxtPacote3.Text = bd.codigoPacote[indexPesquisa].ToString();
                LbDestino3.Text = bd.destino[indexPesquisa];
                LbDataIda3.Text = "Ida: " + bd.dataIda[indexPesquisa].ToString();
                LbDataVolta3.Text = "Volta: " + bd.dataVolta[indexPesquisa].ToString();
                LbHotel3.Text = bd.nomeHotel[indexPesquisa];
                LbValor3.Text = "Valor: R$" + bd.valor[indexPesquisa].ToString();
            }

        }//Fim Editar Pacote 3

        private void BtnEditarPacote4_Click(object sender, EventArgs e)
        {
            if (TxtPacote4.Text == "")
            {
                MessageBox.Show("Digite um valor!");

            }
            else
            {
                bd.SetPacote4(Convert.ToInt32(TxtPacote4.Text));
                
                int indexPesquisa = bd.ProcurarPacote(Convert.ToInt32(TxtPacote4.Text));

                TxtPacote4.Text = bd.codigoPacote[indexPesquisa].ToString();
                LbDestino4.Text = bd.destino[indexPesquisa];
                LbDataIda4.Text = "Ida: " + bd.dataIda[indexPesquisa].ToString();
                LbDataVolta4.Text = "Volta: " + bd.dataVolta[indexPesquisa].ToString();
                LbHotel4.Text = bd.nomeHotel[indexPesquisa];
                LbValor4.Text = "Valor: R$" + bd.valor[indexPesquisa].ToString();
            }

        }//Fim Editar Pacote 4
    }
}
