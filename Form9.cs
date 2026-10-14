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
        long cpf;        
        string telefone;
        string email;
        string endereco;
        string senha;

        public TelaPerfil(int indexAuxiliar)
        {            
            InitializeComponent();
            bd = new DAO();
            bd.PreencherVetor();
            MessageBox.Show("PERFIL \n\n " + indexAuxiliar);
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
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do btnVoltar

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                //Atualiza os dados existentes                
                this.telefone = mktxt_telefone.Text;
                this.email = txt_email.Text;
                this.endereco = txt_endereco.Text;
                this.senha = txt_senha.Text;

                //Preciso do cpf para localizar no banco
                MessageBox.Show(bd.AtualizarCliente(cpf, telefone, email, endereco, senha));
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
                btn_mostrarSenha.BackColor = Color.Red;
            }
            else
            {
                txt_senha.UseSystemPasswordChar = true;
                txt_senhaConfirma.UseSystemPasswordChar = true;
                btn_mostrarSenha.BackColor = Color.Lime;
            }        
        }//fim do btnMOstrarClick
    }
}
