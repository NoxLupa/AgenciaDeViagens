using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AgenciaDeViagens
{
    class DAO
    {
        public MySqlConnection conexao;
        public int[] codigo;
        public long[] cpf;
        public string[] nome;
        public string[] telefone;
        public string[] endereco;
        public string[] email;
        public string[] senha;
        public int i;
        public int contador;
        public bool admLogado;
        public string userLogado;
        public int indexAuxiliar;

        public DAO()
        {
            this.conexao = new MySqlConnection("server=localhost;Database=agenciaDeViagens;Uid=root;password=");

            try
            {
                this.conexao.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n" + erro);
            }
        }//fim do Construtor

    
    

    public string Cadastrar(long cpf, string nome, string telefone, string email, string endereco, string senha)
    {
        //Comando sql
        string insert = $"insert into cliente(codigo, nome, telefone, email, endereco, cpf, senha)values" +
                        $"('', '{nome}', '{telefone}', '{email}', '{endereco}', '{cpf}', '{senha}')";

            MySqlCommand sql = new MySqlCommand(insert, this.conexao);
            string resultado = sql.ExecuteNonQuery() + " Cadastro realizado com sucesso!";
            return resultado;
    }//fim da Classe Cadastrar

    public void PreencherVetor()
    {
        string select = "select * from cliente";

        //instanciar
        this.codigo = new int[100];
        this.cpf = new long[100];
        this.nome = new string[100];
        this.telefone = new string[100];
        this.endereco = new string[100];
        this.email = new string[100];
        this.senha = new string[100];



        MySqlCommand sql = new MySqlCommand(select, this.conexao);

        MySqlDataReader leitura = sql.ExecuteReader();

        this.i = 0;
        this.contador = 0;
            
        while (leitura.Read())
        {
            this.codigo[i] = Convert.ToInt32(leitura["codigo"]);
            this.cpf[i] = Convert.ToInt64(leitura["cpf"]);
            this.nome[i] = leitura["nome"] + "";
            this.telefone[i] = leitura["telefone"] + "";
            this.endereco[i] = leitura["endereco"] + "";
            this.email[i] = leitura["email"] + "";
            this.senha[i] = leitura["senha"] + "";

            this.i++;
            this.contador++;
        }//fim while

        leitura.Close();
    }//fim Preencher Vetor

    public int QuantidadeDados()
    {
        return this.contador;
    }//fim QuantidadeDados

    public int ValidarLogin(long cpf, string senha)
    {
        int i;
        i = 0;
        while(cpf != this.cpf[i])//Procura pelo vetor de cpf's
        {
            i++;                
        }

        this.userLogado = nome[i];
        this.indexAuxiliar = i; //Para localizar a pessoa no banco
        MessageBox.Show("DAO: \n\n" + this.indexAuxiliar);
        if (cpf == this.cpf[i] && senha == this.senha[i])//Achou o cpf digitado na lista
        {

                /*DEBUG
                MessageBox.Show("i" + i);
                MessageBox.Show(cpf + " é igual a " + this.cpf[i]);
                MessageBox.Show(senha + " é igual a " + this.senha[i]);
                MessageBox.Show(this.userLogado);*/

                return 0;
        }
        else
        {                
            return 1;
        }                           
    }//Fim validarLogin


    public string AtualizarCliente(long cpf, string telefone, string email, string endereco, string senha)//para o pi adicione (string tabela)
    {
        //utilize o update do sql
        string query = $"update cliente set telefone = '{telefone}', email = '{email}, endereco = '{endereco}', senha = {senha} where cpf = {cpf}"; //atualizar
        //string query = $"update cliente set nome = '{nome}' where cpf = '{cpf}'"; ---> inviável
        MySqlCommand sql = new MySqlCommand(query, this.conexao);
        string resultado = sql.ExecuteNonQuery() + " Atualizado!";
        return resultado;
    }//fim do Atualizar


    }//fim da classe DAO
}//fim Projeto
