using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace Seguradora_Pim
{
    public class Apolice
    {
        //Conexao
        public string str_conexao = "Host = localhost; Username = postgres; Password = 12121110; Database = db_seguradora";
        //Atributos
        public int _id_cotacao;
        public int _id_apolice;
        public string _produto = "";
        public string _numero_apolice = "";
        public string _processo_susep = "";
        public string _codigo_ramo = "";
        public string _data_emissao = "";
        public string _data_termino = "";
        public string _status = "";

        //Getters e Setters

        public int Id_Cotacao {
       
            get => _id_cotacao;
            set { _id_cotacao = value; }
        }

        public int Id_Apolice {
       
            get => _id_apolice;
            set { _id_apolice = value; }
        }
        
        public string Produto {
       
            get => _produto;
            set { _produto = value; }
        }

        public string Numero_Apolice {
       
            get => _numero_apolice; 
            set { _numero_apolice = value; }
        }

        public string Processo_Susep {
       
            get => _processo_susep;
            set { _processo_susep = value; }
        }

        public string Codigo_Ramo {
       
            get => _codigo_ramo;
            set { _codigo_ramo = value; }
        }

        public string Data_Emissao {
       
            get => _data_emissao;
            set { _data_emissao = value; }
        }

        public string Data_Termino {
       
            get => _data_termino;
            set { _data_termino = value; }
        }

        public string Status {
        
            get => _status;
            set { _status = value; }
        }

        public Apolice (int id_cotacao, string produto, string processo_susep, string codigo_ramo, string numero_apolice, string data_emissao, string data_termino, string status) {
            Id_Cotacao = id_cotacao;
            Produto = produto;
            Processo_Susep = processo_susep;
            Codigo_Ramo = codigo_ramo;
            Numero_Apolice = numero_apolice;
            Data_Emissao = data_emissao;
            Data_Termino = data_termino;
            Status = status;
        }

        public Apolice (int id_apolice) {
            Id_Apolice = id_apolice;
        }

        public async Task Criar_Apolice () {
            NpgsqlConnection conexao_banco = new NpgsqlConnection(str_conexao);

            try {
                await conexao_banco.OpenAsync();

                string str_cmd_cadastrar_apolice =
                "INSERT INTO tb_apolice " +
                "(id_cotacao, " +
                "produto, " +
                "processo_susep, " +
                "codigo_ramo, " +
                "numero_apolice, " +
                "data_emissao, " +
                "data_termino, " +
                "status) " +
                "VALUES ('" + Id_Cotacao + "', '" + Produto + "', '" + Processo_Susep + "', '" + Codigo_Ramo + "', '" + Numero_Apolice + "', '" + Data_Emissao + "', '" + Data_Termino + "', '" + Status + "');";

                await using (NpgsqlCommand cmd_cadastrar_apolice = new NpgsqlCommand(str_cmd_cadastrar_apolice, conexao_banco)) {

                    Task<int> res_cadastrar_apolice = cmd_cadastrar_apolice.ExecuteNonQueryAsync();

                    if (res_cadastrar_apolice.Result == 0) {
                        MessageBox.Show("Não foi possível cadastrar uma Apólice.", "Ops...");
                    }

                    if (res_cadastrar_apolice.Result == 1) {
                        MessageBox.Show("Apólice cadastrada com sucesso!", "Ok!");
                    }

                }
            } catch (Exception exception)
            {
                MessageBox.Show(exception.Message + exception.StackTrace, "Ops...");
            }
        }

        public async Task<NpgsqlDataAdapter> Listar_Apolice () {
            NpgsqlConnection conexao_banco = new NpgsqlConnection(str_conexao);
            
            try
            {
                await conexao_banco.OpenAsync();

                string str_cmd_listar_apolice = 
                "SELECT " +
                "id as id_apolice, " +
                "id_cotacao, " +
                "produto, " +
                "processo_susep, " +
                "codigo_ramo, " +
                "numero_apolice, " +
                "data_emissao, " +
                "data_termino, " +
                "status " +
                "FROM tb_apolice " +
                "WHERE tb_apolice.id = '"+Id_Apolice+"'";

                await using (NpgsqlCommand cmd_listar_apolice = new NpgsqlCommand(str_cmd_listar_apolice, conexao_banco)) {
                    await using (NpgsqlDataReader reader_listar_apolice = cmd_listar_apolice.ExecuteReader())
                    {
                        while (await reader_listar_apolice.ReadAsync()) {
                            Id_Apolice = Convert.ToInt32(reader_listar_apolice["id_apolice"]);
                            Id_Cotacao = Convert.ToInt32(reader_listar_apolice["id_cotacao"]);
                            Produto = reader_listar_apolice["produto"].ToString();
                            Processo_Susep = reader_listar_apolice["processo_susep"].ToString();
                            Codigo_Ramo = reader_listar_apolice["codigo_ramo"].ToString();
                            Numero_Apolice = reader_listar_apolice["numero_apolice"].ToString();
                            Data_Emissao = reader_listar_apolice["data_emissao"].ToString();
                            Data_Termino = reader_listar_apolice["data_termino"].ToString();
                            Status = reader_listar_apolice["status"].ToString();
                        }
                    }
                }

                NpgsqlCommand cmd_listar_apolice_dataAdapter = new NpgsqlCommand(str_cmd_listar_apolice, conexao_banco);
                
                NpgsqlDataAdapter listar_apolice_dataAdapter = new NpgsqlDataAdapter(cmd_listar_apolice_dataAdapter);

                return listar_apolice_dataAdapter;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + exception.StackTrace, "Ops...");
            }
            return null;
        }

        public async Task Modificar_Apolice (string status) {
            NpgsqlConnection conexao_banco = new NpgsqlConnection(str_conexao);

            try
            {
                await conexao_banco.OpenAsync();
                
                string str_cmd_deletar_apolice = 
                "UPDATE " +
                "tb_apolice " +
                "SET " +
                "status = '"+status+"' " +
                "WHERE id = '"+Id_Apolice+"'";

                await using (NpgsqlCommand cmd_deletar_apolice = new NpgsqlCommand(str_cmd_deletar_apolice, conexao_banco)) {

                    Task<int> res_deletar_apolice = cmd_deletar_apolice.ExecuteNonQueryAsync();

                    if (res_deletar_apolice.Result == 0) {
                        MessageBox.Show("Não foi possível modificar a apólice.", "Ops...");
                    }

                    if (res_deletar_apolice.Result == 1) {
                        MessageBox.Show("Apólice modificada com sucesso!", "Ok!");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + exception.StackTrace, "Ops...");
            }
        }

        public async Task Deletar_Apolice () {
            NpgsqlConnection conexao_banco = new NpgsqlConnection(str_conexao);

            try
            {
                await conexao_banco.OpenAsync();
                
                string str_cmd_deletar_apolice = 
                "DELETE " +
                "FROM tb_apolice " +
                "WHERE id = '"+Id_Apolice+"'";

                await using (NpgsqlCommand cmd_deletar_apolice = new NpgsqlCommand(str_cmd_deletar_apolice, conexao_banco)) {

                    Task<int> res_deletar_apolice = cmd_deletar_apolice.ExecuteNonQueryAsync();

                    if (res_deletar_apolice.Result == 0) {
                        MessageBox.Show("Não foi possível remover a apólice.", "Ops...");
                    }

                    if (res_deletar_apolice.Result == 1) {
                        MessageBox.Show("Apólice removida com sucesso!", "Ok!");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + exception.StackTrace, "Ops...");
            }
        }
    }
}