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
    public partial class TelaPerfil : Form
    {
        DAO bd;
        Form4 refTela;
        TelaInicio telInicio;
        int codigoAux;
        long cpf;        
        string telefone;
        string email;
        string endereco;
        string senha;      

        public TelaPerfil(int indexAuxiliar, Form4 telaAnterior, TelaInicio telaInicio)
        {            
            InitializeComponent();
            bd = new DAO();
            bd.PreencherVetor();
            //MessageBox.Show("PERFIL (INDEX): \n\n " + indexAuxiliar);
            this.refTela = telaAnterior;
            this.telInicio = telaInicio;

            codigoAux = bd.codigo[indexAuxiliar];
            //Busca os dados no banco carregado no programa atráves do indexAuxiliar
            mktxt_cpf.Text = Convert.ToString(bd.cpf[indexAuxiliar]);
            mktxt_telefone.Text = bd.telefone[indexAuxiliar];
            txt_nome.Text = bd.nome[indexAuxiliar];
            txt_email.Text = bd.email[indexAuxiliar];
            txt_endereco.Text = bd.endereco[indexAuxiliar];
            txt_senha.Text = bd.senha[indexAuxiliar];
            txt_senhaConfirma.Text = bd.senha[indexAuxiliar];

            //Bloqueia a alteração
            mktxt_cpf.ReadOnly = true;
            txt_nome.ReadOnly = true;
            
            if (bd.GetADM() == true)            
            {
                MessageBox.Show("ADM é " + bd.GetADM());
                btn_excluir.Visible = false;
            }
                        
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do btnVoltar

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Codigo: " + this.codigoAux); //Debug
            try
            {
                //Atualiza os dados existentes                                
                this.telefone = mktxt_telefone.Text;
                this.email = txt_email.Text;
                this.endereco = txt_endereco.Text;
                this.senha = txt_senha.Text;

                if(txt_senha.Text != txt_senhaConfirma.Text)
                {
                    MessageBox.Show("Senhas não conferem!");
                }
                else
                { 
                    //Pega o codigo na DAO e usa pra localizar no banco
                    MessageBox.Show(bd.AtualizarCliente(codigoAux, telefone, email, endereco, senha));
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro!\n\n" + erro);
            }
        }//Fim do btnAlterar  

        private void btn_mostrarSenha_Click(object sender, EventArgs e)
        {
     
            if (txt_senha.UseSystemPasswordChar == true)
            {
                txt_senha.UseSystemPasswordChar = false;
                txt_senhaConfirma.UseSystemPasswordChar = false;                               
                btn_mostrarSenha.BackgroundImage = Properties.Resources.hide_password;
            }
            else
            {
                txt_senha.UseSystemPasswordChar = true;
                txt_senhaConfirma.UseSystemPasswordChar = true;
                btn_mostrarSenha.BackgroundImage = Properties.Resources.show_password2;

            }        
        }//fim do btnMostrarSenha

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(bd.ExcluirCliente(codigoAux));
                this.Close();
                this.refTela.Close();
                this.telInicio.Show();
                

            }catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro! \n\n" + erro);
            }

        }//fim do BtnExcluir
    }
}
