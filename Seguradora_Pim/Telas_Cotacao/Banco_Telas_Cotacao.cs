using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Seguradora_Pim.Telas_Cotacao
{
    internal class Banco_Telas_Cotacao
    {
        
        string Acesso = "Host = localhost; Username = postgres; Password = 12121110; Database = db_seguradora";

        public Array ArrayPlanoSeguro()
        {
            var conexao = new NpgsqlConnection(Acesso);

            conexao.Open();

            var comando_Str = "SELECT unnest(enum_range(NULL::plano_seguro));";

            var comando = new NpgsqlCommand(comando_Str, conexao);

            var array_comando = comando.ExecuteReader();

            var array = new List<String>();

            while (array_comando.Read())
            {
                array.Add(array_comando.GetValue(0).ToString());
            }

            return array.ToArray();
        }
        public Array ArrayFormaPagamento()
        {
            var conexao = new NpgsqlConnection(Acesso);

            conexao.Open();

            var comando_Str = "SELECT unnest(enum_range(NULL::forma_pagamento));";

            var comando = new NpgsqlCommand(comando_Str, conexao);

            var array_comando = comando.ExecuteReader();

            var array = new List<String>();

            while (array_comando.Read())
            {
                array.Add(array_comando.GetValue(0).ToString());
            }

            return array.ToArray();
        }
        public Array ArrayStatusCotacao()
        {
            var conexao = new NpgsqlConnection(Acesso);

            conexao.Open();

            var comando_Str = "SELECT unnest(enum_range(NULL::status_cotacao));";

            var comando = new NpgsqlCommand(comando_Str, conexao);

            var array_comando = comando.ExecuteReader();

            var array = new List<String>();

            while (array_comando.Read())
            {
                array.Add(array_comando.GetValue(0).ToString());
            }

            return array.ToArray();
        }
        public string Inserir_Dados_Cadastrar_Cotacao(string idVeiculo, string planoSeguro, string valorPremioSeguro,
            string valorTotalPremiSeguro, string formaPagamento, string statusCotacao)
        {
            using var conexao = new NpgsqlConnection(Acesso);
            conexao.Open();

            string sql = "INSERT INTO tb_cotacao (id_veiculo, plano_seguro, valor_premio_seguro, valor_total_premio_seguro, " +
                "forma_pagamento, status) VALUES ("+idVeiculo+ ", '"+planoSeguro+ "', "+valorPremioSeguro+ ", "+valorTotalPremiSeguro+"," +
                " '"+formaPagamento+ "','"+statusCotacao+"');";

            using var comando = new NpgsqlCommand(sql);

            comando.Connection = conexao;

            comando.CommandText = sql;
            comando.ExecuteNonQuery();

            string texto = (Convert.ToInt32(idVeiculo) + planoSeguro + Convert.ToDouble(valorPremioSeguro) + 
                Convert.ToDouble(valorTotalPremiSeguro) + formaPagamento + statusCotacao);

            return texto;
        }
        public string Deletar_Dados_Cotacao(string idCotacao)
        {
            using var conexao = new NpgsqlConnection(Acesso);
            conexao.Open();

            string sql = "DELETE FROM tb_cotacao WHERE id = "+Convert.ToInt32(idCotacao)+";";

            using var comando = new NpgsqlCommand(sql);

            comando.Connection = conexao;

            comando.CommandText = sql;
            comando.ExecuteNonQuery();


            return idCotacao;
        }
        public string Atualizar_Aprovar_Dados_Cotacao(string idCotacao)
        {
            using var conexao = new NpgsqlConnection(Acesso);
            conexao.Open();

            string sql = "UPDATE tb_cotacao set status = 'Aprovada' WHERE id = "+Convert.ToInt32(idCotacao)+";";

            using var comando = new NpgsqlCommand(sql);

            comando.Connection = conexao;

            comando.CommandText = sql;
            comando.ExecuteNonQuery();


            return idCotacao;
        }
        public string Atualizar_Reprovar_Dados_Cotacao(string idCotacao)
        {
            using var conexao = new NpgsqlConnection(Acesso);
            conexao.Open();

            string sql = "UPDATE tb_cotacao set status = 'Negada' WHERE id = " + Convert.ToInt32(idCotacao) + ";";

            using var comando = new NpgsqlCommand(sql);

            comando.Connection = conexao;

            comando.CommandText = sql;
            comando.ExecuteNonQuery();


            return idCotacao;
        }

    }
}
