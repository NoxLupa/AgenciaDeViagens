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

    public void ValidarLogin(long cpf, string senha)
    {
        string consultar = "select count(*) from cliente where cpf = @cpfDigitado and senha = @senhaDigitada";
        
        using (MySqlCommand login = new MySqlCommand(consultar, this.conexao))
        {

            int resultado = Convert.ToInt32(login.ExecuteScalar());
            if(resultado > 0)
            {
                MessageBox.Show("login bem sucedido!");
            }
            else
            {
                MessageBox.Show("erro");
            }
         }


    }

    }//fim da classe DAO
}//fim Projeto
