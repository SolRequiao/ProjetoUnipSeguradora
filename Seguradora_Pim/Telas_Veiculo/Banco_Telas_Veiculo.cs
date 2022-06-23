using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Seguradora_Pim.Telas_Veiculo
{
    internal class Banco_Telas_Veiculo
    {

        string Acesso = "Host = localhost; Username = postgres; Password = 12121110; Database = db_seguradora";

        public Array ArrayMarca()
        {
            var conexao = new NpgsqlConnection(Acesso);

            conexao.Open();

            var comando_Str = "SELECT unnest(enum_range(NULL::marca));";

            var comando = new NpgsqlCommand(comando_Str, conexao);

            var array_comando = comando.ExecuteReader();

            var array = new List<String>();

            while (array_comando.Read())
            {
                array.Add(array_comando.GetValue(0).ToString());
            }

            return array.ToArray();
        }

        public Array ArrayCategoriaVeiculo()
        {
            var conexao = new NpgsqlConnection(Acesso);

            conexao.Open();

            var comando_Str = "SELECT unnest(enum_range(NULL::categoria_veiculo));";

            var comando = new NpgsqlCommand(comando_Str, conexao);

            var array_comando = comando.ExecuteReader();

            var array = new List<String>();

            while (array_comando.Read())
            {
                array.Add(array_comando.GetValue(0).ToString());
            }

            return array.ToArray();
        }
        public Array ArrayCombustivel()
        {
            var conexao = new NpgsqlConnection(Acesso);

            conexao.Open();

            var comando_Str = "SELECT unnest(enum_range(NULL::combustivel));";

            var comando = new NpgsqlCommand(comando_Str, conexao);

            var array_comando = comando.ExecuteReader();

            var array = new List<String>();

            while (array_comando.Read())
            {
                array.Add(array_comando.GetValue(0).ToString());
            }

            return array.ToArray();
        }

        public string Inserir_Dados_Cadastrar_Veiculo(string id_segurado, string codigo_fipe, string modelo, string ano, string marca,
            string categoria, string placa, string renavam, string zero_km, string km, string combustivel, string utilizacao)
        {
            using var conexao = new NpgsqlConnection(Acesso);
            conexao.Open();
            
            string sql = "INSERT INTO tb_veiculo (id_segurado, codigo_fipe, modelo, ano, marca, categoria, " +
                "placa, renavam, zero_km, km, combustivel, utilizacao) VALUES ("+id_segurado+", '"+codigo_fipe+"'," +
                " '"+modelo+"', "+ano+", '"+marca+"', '"+categoria+"', '"+placa+"', '"+renavam+"', '"+zero_km+"', "+km+"," +
                " '"+combustivel+"', '"+utilizacao+"');";

            using var comando = new NpgsqlCommand(sql);

            comando.Connection = conexao;

            comando.CommandText = sql;
            comando.ExecuteNonQuery();

            string texto = (Convert.ToInt32(id_segurado)+codigo_fipe+modelo+Convert.ToInt32(ano)+marca+categoria+placa+renavam
                +zero_km+combustivel+utilizacao);

            return texto;
        }

        public string Deletar_Dados_Veiculo(string placa)
        {
            using var conexao = new NpgsqlConnection(Acesso);
            conexao.Open();

            string sql = "DELETE FROM tb_veiculo WHERE placa = '" + placa + "';";

            using var comando = new NpgsqlCommand(sql);

            comando.Connection = conexao;

            comando.CommandText = sql;
            comando.ExecuteNonQuery();

            string texto = placa;

            return texto;
        }
    }
}
