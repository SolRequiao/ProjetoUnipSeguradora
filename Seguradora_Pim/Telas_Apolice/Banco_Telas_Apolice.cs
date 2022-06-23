using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Seguradora_Pim.Telas_Apolice
{
    internal class Banco_Telas_Apolice
    {

        string Acesso = "Host = localhost; Username = postgres; Password = 12121110; Database = db_seguradora";

        public Array ArrayStatusApolice()
        {
            var conexao = new NpgsqlConnection(Acesso);

            conexao.Open();

            var comando_Str = "SELECT unnest(enum_range(NULL::status_apolice));";

            var comando = new NpgsqlCommand(comando_Str, conexao);

            var array_comando = comando.ExecuteReader();

            var array = new List<String>();

            while (array_comando.Read())
            {
                array.Add(array_comando.GetValue(0).ToString());
            }

            return array.ToArray();
        }
        public string Inserir_Dados_Cadastrar_Apolice(string idCotacao, string produto, string processoSusep,string codigoRamo,
            string numeroApolice, string dataEmissao, string dataTermino, string status)
        {
            using var conexao = new NpgsqlConnection(Acesso);
            conexao.Open();

            string sql = "INSERT INTO tb_apolice (id_cotacao, produto, processo_susep, codigo_ramo, numero_apolice, data_emissao," +
                " data_termino, status) VALUES ("+idCotacao+", '"+produto+"', '"+processoSusep+"','"+codigoRamo+"'," +
                " '"+numeroApolice+"','"+dataEmissao+"', '"+dataTermino+"', '"+status+"');";

            using var comando = new NpgsqlCommand(sql);

            comando.Connection = conexao;

            comando.CommandText = sql;
            comando.ExecuteNonQuery();

            string texto = (Convert.ToInt32(idCotacao) + produto + processoSusep + processoSusep + codigoRamo + numeroApolice + 
                dataEmissao + dataTermino + status);

            return texto;
        }
        public string Deletar_Dados_Apolice(string idApolice)
        {
            using var conexao = new NpgsqlConnection(Acesso);
            conexao.Open();

            string sql = "DELETE FROM tb_apolice WHERE id = " + Convert.ToInt32(idApolice) + ";";

            using var comando = new NpgsqlCommand(sql);

            comando.Connection = conexao;

            comando.CommandText = sql;
            comando.ExecuteNonQuery();


            return idApolice;
        }
        public string Atualizar_Dados_Apolice(string idApolice, string status)
        {
            using var conexao = new NpgsqlConnection(Acesso);
            conexao.Open();

            string sql = "UPDATE tb_apolice set status = '" + status + "' WHERE id = " + idApolice + ";";

            using var comando = new NpgsqlCommand(sql);

            comando.Connection = conexao;

            comando.CommandText = sql;
            comando.ExecuteNonQuery();

            string texto = (status + Convert.ToInt32(idApolice));

            return texto;
        }

    }
}
