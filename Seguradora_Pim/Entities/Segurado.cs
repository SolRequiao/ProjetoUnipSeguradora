using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace Seguradora_Pim
{
    public class Segurado : Pessoa
    {
        //Atributos
        private int _id_segurado;
        private int _id_pessoa;
        private string _profissao = "";
        private string _faixa_salarial = "";

        //Getters Setters
        public int Id_Segurado {
            get => _id_segurado;
            set { _id_segurado = value; }
        }

        public string Profissao {
            get => _profissao;
            set { _profissao = value; }
        }
        
        public string Faixa_Salarial {
            get => _faixa_salarial;
            set { _faixa_salarial = value; }
        }

        public Segurado (string nome, string cpf_cnpj, string cnh, string genero, string data_nascimento, string cep, string cidade, string estado, string rua, string bairro, int numero, string complemento, string celular, string email, string profissao, string faixa_salarial) {
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
            Profissao = profissao;
            Faixa_Salarial = faixa_salarial;
        }
        
        //Construtor Info. Pessoa
        public Segurado (string cpf_cnpj) {
            Cpf_Cnpj = cpf_cnpj;
        }

        public async Task Criar_Segurado () {
            
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

                        //Inserindo segurado
                        string str_cmd_cadastrar_segurado =
                        "INSERT INTO " +
                        "tb_segurado " +
                        "(id_pessoa, " +
                        "profissao, " +
                        "faixa_salarial) " +
                        "VALUES ('" + Id_Pessoa + "', @profissao, '"+Faixa_Salarial+"')";

                        await using (NpgsqlCommand cmd_cadastrar_segurado = new NpgsqlCommand(str_cmd_cadastrar_segurado, conexao_banco)) {
                            cmd_cadastrar_segurado.Parameters.AddWithValue("profissao", Profissao);

                            Task<int> res_cadastrar_segurado = cmd_cadastrar_segurado.ExecuteNonQueryAsync();

                            if (res_cadastrar_segurado.Result == 1) {
                                MessageBox.Show("Segurado cadastrado com sucesso!", "Ok!");
                            } else {
                                MessageBox.Show("Não foi possível cadastrar o Segurado.", "Ops...");
                            }
                        }
                    }
                }
            } catch (NpgsqlException exception) {

                MessageBox.Show(exception.Message + exception.StackTrace, "Detalhes do Erro...");
                await conexao_banco.CloseAsync();
            }

        }

        public async Task<NpgsqlDataAdapter> Listar_Segurado () {
            NpgsqlConnection conexao_banco = new NpgsqlConnection(str_conexao);

            try
            {
                await conexao_banco.OpenAsync();
                //String cmd
                string str_cmd_listar_segurado =
                "SELECT " +
                "p.id as id_pessoa, " +
                "s.id as id_segurado, " +
                "s.faixa_salarial, " +
                "s.profissao, " +
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
                "INNER JOIN tb_segurado s ON s.id_pessoa = p.id " +
                "WHERE cpf_cnpj = @cpf_cnpj";

                await using (NpgsqlCommand cmd_listar_segurado = new NpgsqlCommand(str_cmd_listar_segurado, conexao_banco)) {
                    cmd_listar_segurado.Parameters.AddWithValue("cpf_cnpj", Cpf_Cnpj);

                    await using (NpgsqlDataReader reader_listar_segurado = cmd_listar_segurado.ExecuteReader()) {
                        //leitura dos dados
                        while (await reader_listar_segurado.ReadAsync())
                        {
                            Id_Pessoa = Convert.ToInt32(reader_listar_segurado["id_pessoa"]);
                            Id_Segurado = Convert.ToInt32(reader_listar_segurado["id_segurado"]);
                            Nome = reader_listar_segurado["nome"].ToString();
                            Cpf_Cnpj = reader_listar_segurado["cpf_cnpj"].ToString();
                            Cnh = reader_listar_segurado["cnh"].ToString();
                            Genero = reader_listar_segurado["genero"].ToString();
                            Data_Nascimento = reader_listar_segurado["data_nascimento"].ToString();
                            Cep = reader_listar_segurado["cep"].ToString();
                            Estado = reader_listar_segurado["estado"].ToString();
                            Cidade = reader_listar_segurado["cidade"].ToString();
                            Bairro = reader_listar_segurado["bairro"].ToString();
                            Rua = reader_listar_segurado["rua"].ToString();
                            Numero = Convert.ToInt32(reader_listar_segurado["numero"]);
                            Complemento = reader_listar_segurado["complemento"].ToString();
                            Celular = reader_listar_segurado["celular"].ToString();
                            Email = reader_listar_segurado["email"].ToString();
                            Profissao = reader_listar_segurado["profissao"].ToString();
                            Faixa_Salarial = reader_listar_segurado["faixa_salarial"].ToString();
                        }
                    };
                }

                NpgsqlCommand cmd_listar_segurado_dataAdapter = new NpgsqlCommand(str_cmd_listar_segurado, conexao_banco);
                cmd_listar_segurado_dataAdapter.Parameters.AddWithValue("cpf_cnpj", Cpf_Cnpj);

                NpgsqlDataAdapter listar_segurado_dataAdapter = new NpgsqlDataAdapter(cmd_listar_segurado_dataAdapter);

                return listar_segurado_dataAdapter;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show(exception.Message + exception.StackTrace, "Detalhes do Erro...");
                await conexao_banco.CloseAsync();
            }

            return null;
        }

        public async Task Modificar_Segurado () {
            NpgsqlConnection conexao_banco = new NpgsqlConnection(str_conexao);

            try
            {
                await conexao_banco.OpenAsync();

                //String query att Pessoa
                string str_cmd_modificar_pessoa =
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

                await using (NpgsqlCommand cmd_modificar_pessoa = new NpgsqlCommand(str_cmd_modificar_pessoa, conexao_banco)) {
                    //Passando os parametros @...
                    cmd_modificar_pessoa.Parameters.AddWithValue("nome", Nome);
                    cmd_modificar_pessoa.Parameters.AddWithValue("cpf_cnpj", Cpf_Cnpj);
                    cmd_modificar_pessoa.Parameters.AddWithValue("cnh", Cnh);
                    cmd_modificar_pessoa.Parameters.AddWithValue("cep", Cep);
                    cmd_modificar_pessoa.Parameters.AddWithValue("estado", Estado);
                    cmd_modificar_pessoa.Parameters.AddWithValue("cidade", Cidade);
                    cmd_modificar_pessoa.Parameters.AddWithValue("bairro", Bairro);
                    cmd_modificar_pessoa.Parameters.AddWithValue("rua", Rua);
                    cmd_modificar_pessoa.Parameters.AddWithValue("numero", Numero);
                    cmd_modificar_pessoa.Parameters.AddWithValue("complemento", Complemento);
                    cmd_modificar_pessoa.Parameters.AddWithValue("celular", Celular);
                    cmd_modificar_pessoa.Parameters.AddWithValue("email", Email);
                    
                    Task<int> res_modificar_pessoa = cmd_modificar_pessoa.ExecuteNonQueryAsync();

                    if (res_modificar_pessoa.Result == 0) {
                        MessageBox.Show("Não foi possível modificar o Segurado (Pessoa).", "Ops...");
                    }

                        string str_cmd_modificar_segurado = 
                        "UPDATE " +
                        "tb_segurado " +
                        "SET " +
                        "profissao = @profissao, " +
                        "faixa_salarial = '"+Faixa_Salarial+"' " +
                        "WHERE id = '"+Id_Segurado+"'";

                        await using (NpgsqlCommand cmd_modificar_segurado = new NpgsqlCommand(str_cmd_modificar_segurado, conexao_banco)) {
                            cmd_modificar_segurado.Parameters.AddWithValue("profissao", Profissao);
                            
                            Task<int> res_modificar_segurado = cmd_modificar_segurado.ExecuteNonQueryAsync();

                            if (res_modificar_segurado.Result == 0) {
                                MessageBox.Show("Não foi possível modificar o Segurado.", "Ops...");
                            }

                            if (res_modificar_segurado.Result == 1) {
                                
                                MessageBox.Show("Segurado modificado com sucesso!", "Ok!");

                            }
                        }
                }
            }

            catch (NpgsqlException exception)
            {
                MessageBox.Show(exception.Message + exception.StackTrace, "Detalhes do Erro...");
                await conexao_banco.CloseAsync();
            }
        }
    
        public async Task Deletar_Segurado () {

            NpgsqlConnection conexao_banco = new NpgsqlConnection(str_conexao);

            try
            {
                await conexao_banco.OpenAsync();

                //String query deletar segurado - Logica diferente por estar faltando a Ação "ON DELETE - CASCADE"
                string str_cmd_deletar_segurado =
                "DELETE FROM " +
                "tb_segurado " +
                "WHERE tb_segurado.id = @id_segurado";

                //Executando comando
                await using (NpgsqlCommand cmd_deletar_segurado = new NpgsqlCommand(str_cmd_deletar_segurado, conexao_banco)) {
                    cmd_deletar_segurado.Parameters.AddWithValue("id_segurado", Id_Segurado);

                    Task<int> res_cmd_deletar_segurado = cmd_deletar_segurado.ExecuteNonQueryAsync();
                    
                    //Erro
                    if (res_cmd_deletar_segurado.Result == 0) {
                        MessageBox.Show("Não foi possível remover o Segurado.", "Ops...");
                    }

                    //Removeu funcionário e pessoa...
                    if (res_cmd_deletar_segurado.Result == 1) {
                        string str_cmd_deletar_pessoa =
                        "DELETE FROM " +
                        "tb_pessoa " +
                        "WHERE tb_pessoa.id = @id_pessoa";

                        await using (NpgsqlCommand cmd_deletar_pessoa = new NpgsqlCommand(str_cmd_deletar_pessoa, conexao_banco)) {
                            cmd_deletar_pessoa.Parameters.AddWithValue("id_pessoa", Id_Pessoa);

                            Task<int> res_cmd_deletar_pessoa = cmd_deletar_pessoa.ExecuteNonQueryAsync();
                            
                            //Erro
                            if (res_cmd_deletar_pessoa.Result == 0) {
                                MessageBox.Show("Não foi possível remover a Pessoa.", "Ops...");
                            }

                            if (res_cmd_deletar_pessoa.Result == 1) {
                                MessageBox.Show("Segurado removido com sucesso!", "Ok!");
                            }
                        }
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