using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace Seguradora_Pim
{
    public class Cotacao
    {
        //Conexao
        public string str_conexao = "Host = localhost; Username = postgres; Password = 12121110; Database = db_seguradora";
        //Atributos
        private int _id_cotacao;
        private int _id_veiculo;
        private string _plano_seguro = "";
        private decimal _valor_premio_seguro;
        private decimal _valor_total_premio_seguro;
        private string _forma_pagamento = "";
        private string _status = "";

        //Getters setters
        public int Id_Cotacao {
            get => _id_cotacao;
            set { _id_cotacao = value; }
        }

        public int Id_Veiculo {
            get => _id_veiculo;
            set { _id_veiculo = value; }
        }

        public string Plano_Seguro {
            get => _plano_seguro;
            set { _plano_seguro = value; }
        }

        public decimal Valor_Premio_Seguro {
            get => _valor_premio_seguro;
            set { _valor_premio_seguro = value; }
        }
        
        public decimal Valor_Total_Premio_Seguro {
            get => _valor_total_premio_seguro;
            set { _valor_total_premio_seguro = value; }
        }

        public string Forma_Pagamento {
            get => _forma_pagamento;
            set { _forma_pagamento = value; }
        }

        public string Status {
            get => _status;
            set { _status = value; }
        }

        public Cotacao (int id_veiculo, string plano_seguro, decimal valor_premio_seguro, decimal valor_total_premio_seguro, string forma_pagamento, string status) {
            Id_Veiculo = id_veiculo;
            Plano_Seguro = plano_seguro;
            Valor_Premio_Seguro = valor_premio_seguro;
            Valor_Total_Premio_Seguro = valor_total_premio_seguro;
            Forma_Pagamento = forma_pagamento;
            Status = status;
        }

        public Cotacao(int id_veiculo = 0, int id_cotacao = 0) {
            
            if  (id_veiculo != 0) {
                Id_Veiculo = id_veiculo;
            }

            if (id_cotacao != 0) {
                Id_Cotacao = id_cotacao;
            }

        }

        public Cotacao (int id_cotacao) {
            Id_Cotacao = id_cotacao;
        }

        //Metodos
        public async Task Criar_Cotacao () {
            NpgsqlConnection conexao_banco = new NpgsqlConnection(str_conexao);

            try
            {
                await conexao_banco.OpenAsync();

                //Query
                string str_cmd_cadastrar_cotacao =
                "INSERT INTO " +
                "tb_cotacao " +
                "(id_veiculo, " +
                "plano_seguro, " +
                "valor_premio_seguro, " +
                "valor_total_premio_seguro, " +
                "forma_pagamento, " +
                "status) VALUES ('"+Id_Veiculo+"', '"+Plano_Seguro+"', '"+Valor_Premio_Seguro+"', '"+Valor_Total_Premio_Seguro+"', '"+Forma_Pagamento+"', '"+Status+"');";

                await using (NpgsqlCommand cmd_cadastrar_cotacao = new NpgsqlCommand(str_cmd_cadastrar_cotacao, conexao_banco)) {
                    
                    Task<int> res_cadastrar_cotacao = cmd_cadastrar_cotacao.ExecuteNonQueryAsync();

                    if (res_cadastrar_cotacao.Result == 0) {
                        MessageBox.Show("Não foi possível cadastrar a cotaçao", "Ops...");
                    }

                    if (res_cadastrar_cotacao.Result == 1) {
                        MessageBox.Show("Cotação cadastrada com sucesso!", "Ok!");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + exception.StackTrace, "Ops...");
            }

        }

        public async Task<NpgsqlDataAdapter> Listar_Cotacao() {

            NpgsqlConnection conexao_banco = new NpgsqlConnection(str_conexao);

            try {
                await conexao_banco.OpenAsync();

                string str_cmd_listar_cotacao =
                "SELECT " +
                "c.id as id_cotacao, " +
                "c.id_veiculo, " +
                "c.plano_seguro, " +
                "c.valor_premio_seguro, " +
                "c.valor_total_premio_seguro, " +
                "c.forma_pagamento, " +
                "c.status " +
                "FROM tb_cotacao c " +
                "WHERE c.id_veiculo = '" + Id_Veiculo + "'";

                await using (NpgsqlCommand cmd_listar_cotacao = new NpgsqlCommand(str_cmd_listar_cotacao, conexao_banco)) {

                    await using (NpgsqlDataReader reader_listar_cotacao = cmd_listar_cotacao.ExecuteReader()) {
                        //Leitura dos dados
                        while (await reader_listar_cotacao.ReadAsync()) {
                            Id_Cotacao = Convert.ToInt32(reader_listar_cotacao["id_cotacao"]);
                            Id_Veiculo = Convert.ToInt32(reader_listar_cotacao["id_veiculo"]);
                            Plano_Seguro = reader_listar_cotacao["plano_seguro"].ToString();
                            Valor_Premio_Seguro = Convert.ToDecimal(reader_listar_cotacao["valor_premio_seguro"].ToString());
                            Valor_Total_Premio_Seguro = Convert.ToDecimal(reader_listar_cotacao["valor_total_premio_seguro"].ToString());
                            Forma_Pagamento = reader_listar_cotacao["forma_pagamento"].ToString();
                            Status = reader_listar_cotacao["status"].ToString();
                        }
                    }
                }

                NpgsqlCommand cmd_listar_cotacao_dataAdapter = new NpgsqlCommand(str_cmd_listar_cotacao, conexao_banco);

                NpgsqlDataAdapter listar_cotacao_dataAdapter = new NpgsqlDataAdapter(cmd_listar_cotacao_dataAdapter);

                return listar_cotacao_dataAdapter;

            } catch (Exception exception)
            {
                MessageBox.Show(exception.Message + exception.StackTrace, "Ops...");
            }
            return null;
        }

        public async Task Modificar_Cotacao () {
            NpgsqlConnection conexao_banco = new NpgsqlConnection(str_conexao);

            try
            {
                await conexao_banco.OpenAsync();

                //Query mod veiculo
                string str_cmd_negar_cotacao =
                "UPDATE " +
                "tb_cotacao " +
                "SET " +
                "plano_seguro = '"+Plano_Seguro+"', " +
                "valor_premio_seguro = '"+Valor_Premio_Seguro+"', " +
                "valor_total_premio_seguro = '"+Valor_Total_Premio_Seguro+"', " +
                "forma_pagamento = '"+Forma_Pagamento+"' " +
                "WHERE id = '"+Id_Cotacao+"'";

                await using (NpgsqlCommand cmd_negar_cotacao = new NpgsqlCommand(str_cmd_negar_cotacao, conexao_banco)) {

                    Task<int> res_negar_cotacao = cmd_negar_cotacao.ExecuteNonQueryAsync();

                    if (res_negar_cotacao.Result == 0) {
                        MessageBox.Show("Não foi possível modificar a Cotação.", "Ops...");
                    }

                    if (res_negar_cotacao.Result == 1) {
                        MessageBox.Show("Cotação modificada com sucesso!", "Ok!");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + exception.StackTrace, "Detalhes do Erro...");
            }
        }

        public async Task Aprovar_Cotacao () {
            NpgsqlConnection conexao_banco = new NpgsqlConnection(str_conexao);

            try
            {
                await conexao_banco.OpenAsync();

                //Query mod veiculo
                string str_cmd_negar_cotacao =
                "UPDATE " +
                "tb_cotacao " +
                "SET " +
                "status = '"+Status+"' " +
                "WHERE id = '"+Id_Cotacao+"'";

                await using (NpgsqlCommand cmd_negar_cotacao = new NpgsqlCommand(str_cmd_negar_cotacao, conexao_banco)) {

                    Task<int> res_negar_cotacao = cmd_negar_cotacao.ExecuteNonQueryAsync();

                    if (res_negar_cotacao.Result == 0) {
                        MessageBox.Show("Não foi possível aprovar a Cotação.", "Ops...");
                    }

                    if (res_negar_cotacao.Result == 1) {
                        MessageBox.Show("Cotação aprovada com sucesso!", "Ok!");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + exception.StackTrace, "Detalhes do Erro...");
            }
        }

        public async Task Negar_Cotacao () {
            NpgsqlConnection conexao_banco = new NpgsqlConnection(str_conexao);

            try
            {
                await conexao_banco.OpenAsync();

                //Query mod veiculo
                string str_cmd_negar_cotacao =
                "UPDATE " +
                "tb_cotacao " +
                "SET " +
                "status = '"+Status+"' " +
                "WHERE id = '"+Id_Cotacao+"'";

                await using (NpgsqlCommand cmd_negar_cotacao = new NpgsqlCommand(str_cmd_negar_cotacao, conexao_banco)) {

                    Task<int> res_negar_cotacao = cmd_negar_cotacao.ExecuteNonQueryAsync();

                    if (res_negar_cotacao.Result == 0) {
                        MessageBox.Show("Não foi possível reprovar a Cotação.", "Ops...");
                    }

                    if (res_negar_cotacao.Result == 1) {
                        MessageBox.Show("Cotação reprovada com sucesso!", "Ok!");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + exception.StackTrace, "Detalhes do Erro...");
            }
        }

        public async Task Deletar_Cotacao () {
            NpgsqlConnection conexao_banco = new NpgsqlConnection(str_conexao);

            try
            {
                await conexao_banco.OpenAsync();

                string str_cmd_deletar_cotacao =
                "DELETE FROM " +
                "tb_cotacao " +
                "WHERE tb_cotacao.id = '"+Id_Cotacao+"'";

                //Executando comando
                await using (NpgsqlCommand cmd_deletar_cotacao = new NpgsqlCommand(str_cmd_deletar_cotacao, conexao_banco)) {

                    Task<int> res_cmd_deletar_cotacao = cmd_deletar_cotacao.ExecuteNonQueryAsync();
                    
                    //Erro
                    if (res_cmd_deletar_cotacao.Result == 0) {
                        MessageBox.Show("Não foi possível remover a Cotação.", "Ops...");
                    }

                    if (res_cmd_deletar_cotacao.Result == 1) {
                        MessageBox.Show("Cotação removida com sucesso!", "Ok!");
                    }
                }

            } catch (NpgsqlException exception)
            {
                MessageBox.Show(exception.Message + exception.StackTrace, "Detalhes do Erro...");
                await conexao_banco.CloseAsync();
            }
        }
    }
}