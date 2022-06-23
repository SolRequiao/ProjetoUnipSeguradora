using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Seguradora_Pim.Telas_Funcionario
{
    internal class Banco_Telas_Funcionario
    {

        string Acesso = "Host = localhost; Username = postgres; Password = 12121110; Database = db_seguradora";

        public Array ArrayGenero()
        {
            var conexao = new NpgsqlConnection(Acesso);

            conexao.Open();

            var comando_Str = "SELECT unnest(enum_range(NULL::genero));";

            var comando = new NpgsqlCommand(comando_Str, conexao);

            var array_comando = comando.ExecuteReader();

            var array = new List<String>();

            while (array_comando.Read())
            {
                array.Add(array_comando.GetValue(0).ToString());
            }

            return array.ToArray();
        }

        public string Inserir_Dados_Cadastrar_Pessoa(string nome, string cpf_cnpj, string genero, string cep, string cidade, string bairro,
           string rua, string numero, string complemento, string celular, string email, string dataNascimento, string estado, string cnh)
        {
            using var conexao = new NpgsqlConnection(Acesso);
            conexao.Open();

            string sql = "INSERT INTO tb_pessoa (nome, cpf_cnpj, genero, cep, cidade, bairro, rua, numero, complemento, celular, email," +
                "data_nascimento, estado, cnh) VALUES ('" + nome + "', '" + cpf_cnpj + "', '" + genero + "', '" + cep + "', '" + cidade + "'," +
                " '" + bairro + "', '" + rua + "', " + numero + ",'" + complemento + "', '" + celular + "', '" + email + "', '" + dataNascimento + "'," +
                " '" + estado + "', '" + cnh + "');";
            using var comando = new NpgsqlCommand(sql);

            comando.Connection = conexao;

            comando.CommandText = sql;
            comando.ExecuteNonQuery();

            string texto = (nome + cpf_cnpj + genero + cep + cidade + bairro + rua + Convert.ToInt32(numero) + complemento + celular +
                email + dataNascimento + estado + cnh);

            return texto;
        }
        public string Inserir_Dados_Cadastrar_Funcionario(string idPessoa, string senha)
        {
            using var conexao = new NpgsqlConnection(Acesso);
            conexao.Open();

            string sql = "INSERT INTO tb_funcionario (id_pessoa, senha_funcionario) VALUES (" + idPessoa + "" +
                ", '" + senha + "');";
            using var comando = new NpgsqlCommand(sql);

            comando.Connection = conexao;

            comando.CommandText = sql;
            comando.ExecuteNonQuery();

            string texto = (Convert.ToInt32(idPessoa) + senha);

            return texto;
        }

        public int Deletar_Dados_Funcionario(int idPessoa)
        {
            using var conexao = new NpgsqlConnection(Acesso);
            conexao.Open();

            string sql = "DELETE FROM tb_funcionario WHERE id_pessoa = " + idPessoa + ";";

            using var comando = new NpgsqlCommand(sql);

            comando.Connection = conexao;

            comando.CommandText = sql;
            comando.ExecuteNonQuery();

            return idPessoa;
        }

        public string Deletar_Dados_Pessoa(string cpfCnpj)
        {
            using var conexao = new NpgsqlConnection(Acesso);
            conexao.Open();

            string sql = "DELETE FROM tb_pessoa WHERE cpf_cnpj = '" + cpfCnpj + "';";

            using var comando = new NpgsqlCommand(sql);

            comando.Connection = conexao;

            comando.CommandText = sql;
            comando.ExecuteNonQuery();

            string text = cpfCnpj;

            return text;
        }

    }
}
