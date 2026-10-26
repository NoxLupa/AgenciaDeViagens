using System;
using System.Collections.Generic;
using System.Drawing;
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

        public static int codigoPacote1 = 0;
        public static int codigoPacote2 = 0;
        public static int codigoPacote3 = 0;
        public static int codigoPacote4 = 0;

        //cliente
        public int[] codigo;
        public long[] cpf;
        public string[] nome;
        public string[] telefone;
        public string[] endereco;
        public string[] email;
        public string[] senha;
        public static bool admLogado = false;
        public string userLogado;
        public static int indexAuxiliar = 0;        

        //pacote
        public int[] codigoPacote;
        public string[] destino;
        public int[] valor;
        public string[] dataIda;
        public string[] dataVolta;
        public string[] nomeHotel;
        public string[] descricao;
        public int[] chaveCodigoEmpresa;

        //empresa
        public int[] codigoEmpresa;
        public string[] nomeEmpresa;
        public long[] CNPJ;
        public string[] chaveTipoTransporte;

        public DAO()
        {
            this.conexao = new MySqlConnection("server=localhost;Database=agenciaviagens;Uid=root;password=");            

            try
            {
                this.conexao.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n" + erro);
            }
            
        }//fim do Construtor

    
        public bool GetADM()
        {
           return admLogado;
        }//Fim do GetADM

        public void SetPacote1(int codigoPacote)
        {
            codigoPacote1 = codigoPacote;

        }//Fim do Set Pacote 1

        public int GetPacote1()
        {
            return codigoPacote1;

        }//Fim do Get Pacote 1

        public void SetPacote2(int codigoPacote)
        {
            codigoPacote2 = codigoPacote;

        }//Fim do Set Pacote 2

        public int GetPacote2()
        {
            return codigoPacote2;

        }//Fim do Get Pacote 2
        public void SetPacote3(int codigoPacote)
        {
            codigoPacote3 = codigoPacote;

        }//Fim do Set Pacote 3

        public int GetPacote3()
        {
            return codigoPacote3;

        }//Fim do Get Pacote 3

        public void SetPacote4(int codigoPacote)
        {
            codigoPacote4 = codigoPacote;

        }//Fim do Set Pacote 4

        public int GetPacote4()
        {
            return codigoPacote4;

        }//Fim do Get Pacote 4



        public int GetIndexAuxiliar()
        {
            return indexAuxiliar;
        }//Fim do Get Index

        public void SetADM(bool estadoAdm)
        {
            admLogado = estadoAdm;
        }//Fim do SetADM

        public string Cadastrar(long cpf, string nome, string telefone, string email, string endereco, string senha)
        {
            //Comando sql
            string insert = $"insert into cliente(codigo, nome, telefone, email, endereco, cpf, senha)values" +
                            $"('', '{nome}', '{telefone}', '{email}', '{endereco}', '{cpf}', '{senha}')";

             MySqlCommand sql = new MySqlCommand(insert, this.conexao);
             string resultado = sql.ExecuteNonQuery() + " Cadastro realizado com sucesso!";
             return resultado;
        }//fim da Classe Cadastrar

        public string CadastrarEmpresa(string nome, long cnpj, string chaveTipoTransporte)
        {
            //sql
            string insert = $"insert into empresaTransporte(codigo, nome, CNPJ, chaveTipoTransporte) values" +
                            $"('', '{nome}', '{cnpj}', '{chaveTipoTransporte}')";
            MySqlCommand sql = new MySqlCommand(insert, this.conexao);
            string resultado = sql.ExecuteNonQuery() + " Cadastro realizado com sucesso!";
            return resultado;
        }

        public string CadastrarPacote(string destino, decimal valor, string dataIda, string dataVolta, string nomeHotel, string descricao, int codigoEmpresa)
        {
            string insert = $"insert into pacoteViagem(codigo, destino, valor, dataIda, dataVolta, nomeHotel, descricao, codigoEmpresa)values" +
                            $"('', '{destino}', '{valor}', '{dataIda}', '{dataVolta}', '{nomeHotel}', '{descricao}', '{codigoEmpresa}')";
            MySqlCommand sql = new MySqlCommand(insert, this.conexao);
            string resultado = sql.ExecuteNonQuery() + " Cadastro realizado com sucesso!";
            return resultado;

        }

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
            this.dataIda = new string[100];
            this.dataVolta = new string[100];
            this.nomeHotel = new string[100];
            this.descricao = new string[100];
            this.chaveCodigoEmpresa = new int[100];

            MySqlCommand sqlPacote = new MySqlCommand(selectPacote, this.conexao);
            MySqlDataReader leitura = sqlPacote.ExecuteReader();

            this.i = 0;
            this.contador = 0;

            while (leitura.Read())
            {
                this.codigoPacote[i] = Convert.ToInt32(leitura["codigo"]);
                this.destino[i] = leitura["destino"] + "";
                this.valor[i] = Convert.ToInt32(leitura["valor"]);
                this.dataIda[i] = leitura["dataIda"] + "";
                this.dataVolta[i] = leitura["dataVolta"] + "";
                this.nomeHotel[i] = leitura["nomeHotel"] + "";
                this.descricao[i] = leitura["descricao"] + "";
                this.chaveCodigoEmpresa[i] = Convert.ToInt32(leitura["codigoEmpresa"]);

                this.i++;
                this.contador++;
            }//fim while
            leitura.Close();
        }//fim PreencherPacote

        public void PreencherVetorEmpresa() 
        {
            string selectEmpresa = "select * from empresaTransporte";
            //Instanciar
            this.codigoEmpresa = new int[50];
            this.nomeEmpresa = new string[50];
            this.CNPJ = new long[50];
            this.chaveTipoTransporte = new string[50];

        MySqlCommand sqlEmpresa = new MySqlCommand(selectEmpresa, this.conexao);
            MySqlDataReader leitura = sqlEmpresa.ExecuteReader();

            this.i = 0;
            this.contador = 0;

            while (leitura.Read())
            {
                this.codigoEmpresa[i] = Convert.ToInt32(leitura["codigo"]);
                this.nomeEmpresa[i] = leitura["nome"] + "";
                this.CNPJ[i] = Convert.ToInt64(leitura["CNPJ"]);
                this.chaveTipoTransporte[i] = leitura["chaveTipoTransporte"] + "";

                this.i++;
                this.contador++;
            }
            leitura.Close();
            

        }//fimPreencherEmpresa
    
        //oiiiii
        //helloooo =)

        public int QuantidadeDados()
        {
            return this.contador;

        }//fim QuantidadeDados

        public int ProcurarCPF(long cpf)
        {        
            //Procura pelo vetor de cpfs
            for (int i = 0; i < QuantidadeDados(); i++)
            {
                if (cpf == this.cpf[i])
                {
                    return i;
                }                
            }//Fim do For            
            return 101;  //esse 101 é não encontrar o CPF
        }//Fim ProcurarCPF

        public int ProcurarCNPJ(long cnpj)
        {
            //Procura pelo vetor de cnpj
            for (int i = 0; i < QuantidadeDados(); i++)
            {
                if (cnpj == this.CNPJ[i])
                {
                    return i;
                }
            }//Fim do For            
            return 101;  //esse 101 é não encontrar o CPF
        }//Fim ProcurarCNPJ

        public int ValidarLogin(long cpf, string senha)
        {            
            int i = ProcurarCPF(cpf);

            this.userLogado = nome[i];
            
            indexAuxiliar = i; //Para localizar a pessoa no banco

            if (cpf == this.cpf[i] && senha == this.senha[i])//Achou o cpf digitado na lista
            {
                if (this.cpf[i] == 66764262772)
                {
                    SetADM(true);
                }
                else
                {                                     
                    SetADM(false);
                }
                //DEBUG:
                //MessageBox.Show("estado adm DAO: " + GetADM());
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

            string resultado = sql.ExecuteNonQuery() + " Cadastro atualizado com sucesso!";
            return resultado;
        }//fim do AtualizarCliente

        public string AtualizarClienteADM(int codigo, long cpf, string nome, string telefone, string email, string endereco, string senha)
        {
            string update = $"update cliente set cpf = '{cpf}', nome = '{nome}', telefone = '{telefone}', email = '{email}', endereco = '{endereco}', senha = '{senha}' where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(update, this.conexao);
             
            string resultado = sql.ExecuteNonQuery() + " Cadastro atualizado com sucesso!";
            return resultado;
        }

        public string ExcluirCliente(int codigo)
        {
                string delete = $"delete from cliente where codigo = '{codigo}'";
                MySqlCommand sql = new MySqlCommand(delete, this.conexao);

                string resultado = sql.ExecuteNonQuery() + " Cadastro excluído com sucesso!";
                return resultado;
        }//fim do Excluir Cliente

        public int ProcurarCliente(int codigoCliente)
        {
            //Procura pelo vetor de codigos
            for (int i = 0; i < QuantidadeDados(); i++)
            {
               //DEBUG:
               //MessageBox.Show("Index atual: " + i);
                if (codigoCliente == this.codigo[i])
                {
                    return i;                   
                }
            }//Fim do For
            return 101;                 
      
        }//Fim ProcurarCliente

        public int ProcurarPacote(int codigo)
        {
            //Procura pelo vetor de codigos
            for (int i = 0; i < QuantidadeDados(); i++)
            {
                //DEBUG:
                //MessageBox.Show("Index atual: " + i);
                if (codigo == this.codigoPacote[i])
                {
                    //MessageBox.Show("Codigo: " + codigo + "\n" + "index atual: " + i);
                    return i;
                }
            }//Fim do For
            return 101;

        }//Fim ProcurarCliente

        public int ProcurarEmpresa(int codigo)
        {
            //Procura pelo vetor de codigos
            for (int i = 0; i < QuantidadeDados(); i++)
            {                
                if (codigo == this.codigoEmpresa[i])
                {
                    return i;
                }
            }//Fim do For

            return 101;

        }//fim ProcurarCodigo

        public string ExcluirEmpresa(int codigo)
        {
            string delete = $"delete from empresaTransporte where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(delete, this.conexao);

            string resultado = sql.ExecuteNonQuery() + " Empresa excluída com sucesso!";
            return resultado;

        }//fim Excluir Empresa

        public string AtualizarEmpresa(int codigo, string nome, long CNPJ, string chaveTipoTransporte)
        {
            string update = $"update empresaTransporte set nome = '{nome}', CNPJ = '{CNPJ}', chaveTipoTransporte = '{chaveTipoTransporte}' where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(update, this.conexao);

            string resultado = sql.ExecuteNonQuery() + " Empresa atualizada com sucesso!";
            return resultado;

        }//Fim Atualizar Empresa

        public string AtualizarPacote(int codigo, string destino, decimal valor, string dataIda, string dataVolta, string nomeHotel, string descricao, int codigoEmpresa)
        {
            string update = $"update pacoteViagem set destino = '{destino}', valor = '{valor}', dataIda = '{dataIda}', dataVolta = '{dataVolta}', nomeHotel = '{nomeHotel}', descricao = '{descricao}', codigoEmpresa = '{codigoEmpresa}' where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(update, this.conexao);

            string resultado = sql.ExecuteNonQuery() + " Pacote atualizado com sucesso!";
            return resultado;
        }//Fim Atualizar Pacote

        public string ExcluirPacote(int codigo)
        {
            string delete = $"delete from pacoteViagem where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(delete, this.conexao);

            string resultado = sql.ExecuteNonQuery() + " Pacote excluído com sucesso!";
            return resultado;

        }
        public void DebugLogin()
        {
            //MessageBox.Show("DAO: \n\n" + this.indexAuxiliar);
            MessageBox.Show("DAO Index Atual: \n\n" + indexAuxiliar);
            MessageBox.Show("i" + i);
            MessageBox.Show(cpf + " é igual a " + this.cpf[i]);
            MessageBox.Show(senha + " é igual a " + this.senha[i]);
            MessageBox.Show(this.userLogado);
        }


    }//fim da classe DAO
}//fim Projeto
