using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using System.Diagnostics;

namespace Seguradora_Pim
{
    public class Funcionario : Pessoa
    {
        //Atributos
        private int _id_funcionario;
        private int _id_pessoa;
        private string _senha_funcionario = "";

        //Getters Setters
        public int Id_Funcionario {
            get => _id_funcionario;
            set { _id_funcionario = value; }
        }

        public string Senha_Funcionario {
            get => _senha_funcionario;
            set { _senha_funcionario = value; }
        }

        //Contrutor Criar Pessoa
        public Funcionario (string nome, string cpf_cnpj, string cnh, string genero, string data_nascimento, string cep, string cidade, string estado, string rua, string bairro, int numero, string complemento, string celular, string email, string senha_funcionario) {
            
            Nome = nome;
            Cpf_Cnpj = cpf_cnpj;
            Cnh = cnh;
            Genero = genero;
            Data_Nascimento = data_nascimento;
            Cep = cep;
            Cidade = cidade;
            Estado = estado;
            Rua = rua;
            Bairro = bairro;
            Numero = numero;
            Complemento = complemento;
            Celular = celular;
            Email = email;
            Senha_Funcionario = senha_funcionario;
        }

        //Construtor Info. Pessoa
        public Funcionario (string cpf_cnpj) {
            Cpf_Cnpj = cpf_cnpj;
        }

        //Metodos
        public async Task Criar_Funcionario () {
            
            //Fazendo conexao
            NpgsqlConnection conexao_banco = new NpgsqlConnection(str_conexao);

            try {

                //String query inserir Pessoa
                string str_cmd_cadastrar_pessoa =
                "INSERT INTO " +
                "tb_pessoa " +
                "(nome, " +
                "cpf_cnpj, " +
                "cnh, " +
                "genero, " +
                "data_nascimento, " +
                "cep, " +
                "estado, " +
                "cidade, " +
                "bairro, " +
                "rua, " +
                "numero, " +
                "complemento, " +
                "celular, " +
                "email) VALUES (@nome, @cpf_cnpj, @cnh, '"+Genero+"', '"+Data_Nascimento+"', @cep, @estado, @cidade, @bairro, @rua, @numero, @complemento, @celular, @email);";

                await conexao_banco.OpenAsync();
                
                await using (NpgsqlCommand cmd_cadastrar_pessoa = new NpgsqlCommand(str_cmd_cadastrar_pessoa, conexao_banco)) {
                    //Passando os parametros @...
                    cmd_cadastrar_pessoa.Parameters.AddWithValue("nome", Nome);
                    cmd_cadastrar_pessoa.Parameters.AddWithValue("cpf_cnpj", Cpf_Cnpj);
                    cmd_cadastrar_pessoa.Parameters.AddWithValue("cnh", Cnh);
                    cmd_cadastrar_pessoa.Parameters.AddWithValue("cep", Cep);
                    cmd_cadastrar_pessoa.Parameters.AddWithValue("estado", Estado);
                    cmd_cadastrar_pessoa.Parameters.AddWithValue("cidade", Cidade);
                    cmd_cadastrar_pessoa.Parameters.AddWithValue("bairro", Bairro);
                    cmd_cadastrar_pessoa.Parameters.AddWithValue("rua", Rua);
                    cmd_cadastrar_pessoa.Parameters.AddWithValue("numero", Numero);
                    cmd_cadastrar_pessoa.Parameters.AddWithValue("complemento", Complemento);
                    cmd_cadastrar_pessoa.Parameters.AddWithValue("celular", Celular);
                    cmd_cadastrar_pessoa.Parameters.AddWithValue("email", Email);

                    //Executando comando
                    Task<int> res_cadastrar_pessoa = cmd_cadastrar_pessoa.ExecuteNonQueryAsync();

                    //Verificando se inseriu
                    if (res_cadastrar_pessoa.Result == 0) {
                        MessageBox.Show("Não foi possível cadastrar uma pessoa.", "Ops...");
                    }
                    
                    //Inseriu
                    if (res_cadastrar_pessoa.Result == 1) {
                        
                        //Recuperando ID
                        string str_cmd_recuperar_id =
                        "SELECT id " +
                        "FROM " +
                        "tb_pessoa " +
                        "where tb_pessoa.cpf_cnpj = @cpf_cnpj";

                        //Comando
                        await using (NpgsqlCommand cmd_recuperar_id = new NpgsqlCommand(str_cmd_recuperar_id, conexao_banco)) {
                            cmd_recuperar_id.Parameters.AddWithValue("cpf_cnpj", Cpf_Cnpj);

                            await using (NpgsqlDataReader reader_recupera_id = await cmd_recuperar_id.ExecuteReaderAsync()) {
                                while (await reader_recupera_id.ReadAsync()) {
                                    Id_Pessoa = reader_recupera_id.GetInt32(0);
                                }
                            }

                        }

                        //Inserindo Funcionario
                        string str_cmd_cadastrar_funcionario =
                        "INSERT INTO " +
                        "tb_funcionario " +
                        "(id_pessoa, " +
                        "senha_funcionario) VALUES ('" + Id_Pessoa + "', @senha_funcionario)";

                        await using (NpgsqlCommand cmd_cadastrar_funcionario = new NpgsqlCommand(str_cmd_cadastrar_funcionario, conexao_banco)) {
                            cmd_cadastrar_funcionario.Parameters.AddWithValue("senha_funcionario", Senha_Funcionario);

                            Task<int> res_cadastrar_funcionario = cmd_cadastrar_funcionario.ExecuteNonQueryAsync();

                            if (res_cadastrar_funcionario.Result == 1) {
                                MessageBox.Show("Funcionário cadastrado com sucesso!", "Ok!");
                            } else {
                                MessageBox.Show("Não foi possível cadastrar o funcionário.", "Ops...");
                            }
                        }

                    }
                    
                }

            } catch (NpgsqlException exception) {

                MessageBox.Show(exception.Message + exception.StackTrace, "Detalhes do Erro...");
                await conexao_banco.CloseAsync();
            }

        }

        public async Task<NpgsqlDataAdapter> Listar_Funcionario () {

            NpgsqlConnection conexao_banco = new NpgsqlConnection(str_conexao);

            try
            {
                await conexao_banco.OpenAsync();
                //String cmd
                string str_cmd_listar_funcionario =
                "SELECT " +
                "p.id as id_pessoa, " +
                "f.id as id_funcionario, " +
                "p.nome, " +
                "p.cpf_cnpj, " +
                "p.cnh, " +
                "p.genero, " +
                "p.data_nascimento, " +
                "p.cep, " +
                "p.estado, " +
                "p.cidade, " +
                "p.bairro, " +
                "p.rua, " +
                "p.numero, " +
                "p.complemento, " +
                "p.celular, " +
                "p.email " +
                "FROM tb_pessoa p " +
                "INNER JOIN tb_funcionario f ON f.id_pessoa = p.id " +
                "WHERE cpf_cnpj = @cpf_cnpj";

                await using (NpgsqlCommand cmd_listar_funcionario = new NpgsqlCommand(str_cmd_listar_funcionario, conexao_banco)) {
                    cmd_listar_funcionario.Parameters.AddWithValue("cpf_cnpj", Cpf_Cnpj);

                    await using (NpgsqlDataReader reader_listar_funcionario = cmd_listar_funcionario.ExecuteReader()) {
                        //leitura dos dados
                        while (await reader_listar_funcionario.ReadAsync())
                        {
                            Id_Pessoa = Convert.ToInt32(reader_listar_funcionario["id_pessoa"]);
                            Id_Funcionario = Convert.ToInt32(reader_listar_funcionario["id_funcionario"]);
                            Nome = reader_listar_funcionario["nome"].ToString();
                            Cpf_Cnpj = reader_listar_funcionario["cpf_cnpj"].ToString();
                            Cnh = reader_listar_funcionario["cnh"].ToString();
                            Genero = reader_listar_funcionario["genero"].ToString();
                            Data_Nascimento = reader_listar_funcionario["data_nascimento"].ToString();
                            Cep = reader_listar_funcionario["cep"].ToString();
                            Estado = reader_listar_funcionario["estado"].ToString();
                            Cidade = reader_listar_funcionario["cidade"].ToString();
                            Bairro = reader_listar_funcionario["bairro"].ToString();
                            Rua = reader_listar_funcionario["rua"].ToString();
                            Numero = Convert.ToInt32(reader_listar_funcionario["numero"]);
                            Complemento = reader_listar_funcionario["complemento"].ToString();
                            Celular = reader_listar_funcionario["celular"].ToString();
                            Email = reader_listar_funcionario["email"].ToString();
                        }
                    };
                }

                NpgsqlCommand cmd_listar_funcionario_dataAdapter = new NpgsqlCommand(str_cmd_listar_funcionario, conexao_banco);
                cmd_listar_funcionario_dataAdapter.Parameters.AddWithValue("cpf_cnpj", Cpf_Cnpj);

                NpgsqlDataAdapter listar_funcionario_dataAdapter = new NpgsqlDataAdapter(cmd_listar_funcionario_dataAdapter);

                return listar_funcionario_dataAdapter;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show(exception.Message + exception.StackTrace, "Detalhes do Erro...");
                await conexao_banco.CloseAsync();
            }

            return null;
        }

        public async Task Modificar_Funcionario () {

            NpgsqlConnection conexao_banco = new NpgsqlConnection(str_conexao);

            try
            {
                await conexao_banco.OpenAsync();

                 //String query att Pessoa
                string str_cmd_modificar_funcionario =
                "UPDATE " +
                "tb_pessoa " +
                "SET " +
                "nome = @nome, " +
                "cpf_cnpj = @cpf_cnpj, " +
                "cnh = @cnh, " +
                "genero = '"+Genero+"', " +
                "data_nascimento = '"+Data_Nascimento+"', " +
                "cep = @cep, " +
                "estado = @estado, " +
                "cidade = @cidade, " +
                "bairro = @bairro, " +
                "rua = @rua, " +
                "numero = @numero, " +
                "complemento = @complemento, " +
                "celular = @celular, " +
                "email = @email " +
                "WHERE id = '"+Id_Pessoa.ToString()+"'";

                await using (NpgsqlCommand cmd_modificar_funcionario = new NpgsqlCommand(str_cmd_modificar_funcionario, conexao_banco)) {
                    //Passando os parametros @...

                    cmd_modificar_funcionario.Parameters.AddWithValue("nome", Nome);
                    cmd_modificar_funcionario.Parameters.AddWithValue("cpf_cnpj", Cpf_Cnpj);
                    cmd_modificar_funcionario.Parameters.AddWithValue("cnh", Cnh);
                    cmd_modificar_funcionario.Parameters.AddWithValue("cep", Cep);
                    cmd_modificar_funcionario.Parameters.AddWithValue("estado", Estado);
                    cmd_modificar_funcionario.Parameters.AddWithValue("cidade", Cidade);
                    cmd_modificar_funcionario.Parameters.AddWithValue("bairro", Bairro);
                    cmd_modificar_funcionario.Parameters.AddWithValue("rua", Rua);
                    cmd_modificar_funcionario.Parameters.AddWithValue("numero", Numero);
                    cmd_modificar_funcionario.Parameters.AddWithValue("complemento", Complemento);
                    cmd_modificar_funcionario.Parameters.AddWithValue("celular", Celular);
                    cmd_modificar_funcionario.Parameters.AddWithValue("email", Email);
                    
                    Task<int> res_modificar_funcionario = cmd_modificar_funcionario.ExecuteNonQueryAsync();

                    if (res_modificar_funcionario.Result == 0) {
                        MessageBox.Show("Não foi possível modificar o funcionário.", "Ops...");
                    }

                    if (res_modificar_funcionario.Result == 1) {
                        MessageBox.Show("Funcionário modificado com sucesso!", "Ok!");

                    }
                }
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show(exception.Message + exception.StackTrace, "Detalhes do Erro...");
                await conexao_banco.CloseAsync();
            }
        }

        public async Task Deletar_Funcionario () {

            NpgsqlConnection conexao_banco = new NpgsqlConnection(str_conexao);

            try
            {
                await conexao_banco.OpenAsync();

                //String query inserir Pessoa
                string str_cmd_deletar_funcionario =
                "DELETE FROM " +
                "tb_pessoa " +
                "WHERE tb_pessoa.id = @id_pessoa";

                //Executando comando
                await using (NpgsqlCommand cmd_deletar_funcionario = new NpgsqlCommand(str_cmd_deletar_funcionario, conexao_banco)) {
                    cmd_deletar_funcionario.Parameters.AddWithValue("id_pessoa", Id_Pessoa);

                    Task<int> res_cmd_deletar_funcionario = cmd_deletar_funcionario.ExecuteNonQueryAsync();
                    
                    //Erro
                    if (res_cmd_deletar_funcionario.Result == 0) {
                        MessageBox.Show("Não foi possível remover o funcionário.");
                    }

                    //Removeu funcionário e pessoa...
                    if (res_cmd_deletar_funcionario.Result == 1) {
                        MessageBox.Show("Funcionário removido com sucesso!", "Ok!");
                    }

                }

            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show(exception.Message + exception.StackTrace, "Detalhes do Erro...");
                await conexao_banco.CloseAsync();
            }
        }
    }

}