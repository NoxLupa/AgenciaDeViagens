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

        //universal
        public int i;
        public int contador;

        //cliente
        public int[] codigo;
        public long[] cpf;
        public string[] nome;
        public string[] telefone;
        public string[] endereco;
        public string[] email;
        public string[] senha;            
        public bool admLogado;
        public string userLogado;
        public int indexAuxiliar;

        //pacote
        public int[] codigoPacote;
        public string[] destino;
        public int[] valor;
        public int[] dataIda;
        public int[] dataVolta;
        public string[] nomeHotel;
        public string[] descricao;

        //empresa
        public int[] codigoEmpresa;
        public string[] nomeEmpresa;
        public long[] CNPJ;

        //tipoTransporte
        public int[] codigoTransporte;
        public string[] nomeTransporte;

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

    public void PreencherVetorPacote() 
    {
        string selectPacote = "select * from pacoteViagem";

        //instanciar
        this.codigoPacote = new int[100];
        this.destino = new string[100];
        this.valor = new int[100];
        this.dataIda = new int[100];
        this.dataVolta = new int[100];
        this.nomeHotel = new string[100];
        this.descricao = new string[100];

        MySqlCommand sqlPacote = new MySqlCommand(selectPacote, this.conexao);
        MySqlDataReader leitura = sqlPacote.ExecuteReader();

        this.i = 0;
        this.contador = 0;

        while (leitura.Read())
        {
            this.codigoPacote[i] = Convert.ToInt32(leitura["codigo"]);
            this.destino[i] = leitura["destino"] + "";
            this.valor[i] = Convert.ToInt32(leitura["valor"]);
            this.dataIda[i] = Convert.ToInt32(leitura["dataIda"]);
            this.dataVolta[i] = Convert.ToInt32(leitura["dataVolta"]);
            this.nomeHotel[i] = leitura["nomeHotel"] + "";
            this.descricao[i] = leitura["descricao"] + "";

            this.i++;
            this.contador++;
        }//fim while
        leitura.Close();
    }//fim PreencherPacote

    public void PreencherVetorEmpresa() 
    {
        this.codigoEmpresa = new int[50];
        this.nomeEmpresa = new string[50];
        this.CNPJ = new long[50];

    }//fimPreencherEmpresa

    public void PreencherVetorTipoTransporte()
    {

    
    }//fimPreecherTransporte

    //oiiiii
    //helloooo =)

        public int QuantidadeDados()
    {
        return this.contador;
    }//fim QuantidadeDados

    public int ValidarLogin(long cpf, string senha)
    {
        int i;
        i = 0;

        //Procura pelo vetor de cpf's
        while (cpf != this.cpf[i])
        {
            i++;                
        }

        this.userLogado = nome[i];
        this.indexAuxiliar = i; //Para localizar a pessoa no banco
        
        if (cpf == this.cpf[i] && senha == this.senha[i])//Achou o cpf digitado na lista
        {

            if (this.nome[i] == "adm")
            {
                    return 3;
            }              

            return 0;
        }
        else
        {                
            return 1;
        }                           
    }//Fim validarLogin


    public string AtualizarCliente(int codigo, string telefone, string email, string endereco, string senha)//para o p.i adicione (string tabela)
    {
        //utilize o update do sql
        string update = $"update cliente set telefone = '{telefone}', email = '{email}', endereco = '{endereco}', senha = '{senha}' where codigo = '{codigo}'"; //atualizar
        MySqlCommand sql = new MySqlCommand(update, this.conexao);

        string resultado = sql.ExecuteNonQuery() + " Atualizado!";
        return resultado;
    }//fim do AtualizarCliente

    public string ExcluirCliente(int codigo)
    {
            string delete = $"delete from cliente where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(delete, this.conexao);

            string resultado = sql.ExecuteNonQuery() + "Excluído!";
            return resultado;
    }//fim do Excluir Cliente

    public void DebugLogin()
        {          
            MessageBox.Show("DAO: \n\n" + this.indexAuxiliar);
            MessageBox.Show("i" + i);
            MessageBox.Show(cpf + " é igual a " + this.cpf[i]);
            MessageBox.Show(senha + " é igual a " + this.senha[i]);
            MessageBox.Show(this.userLogado);
        }

    }//fim da classe DAO
}//fim Projeto
