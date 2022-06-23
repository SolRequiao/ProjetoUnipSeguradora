using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Npgsql;

namespace Seguradora_Pim
{
    public class Veiculo
    {
        //Conexao
        public string str_conexao = "Host = localhost; Username = postgres; Password = 12121110; Database = db_seguradora";
        //Atributos
        private int _id_veiculo;
        private int _id_segurado;
        private string _modelo = "";
        private string _marca = "";
        private int _ano;
        private string _categoria = "";
        private string _placa = "";
        private string _renavam = "";
        private int _km;
        private bool _zero_km;
        private string _codigo_fipe = "";
        private string _combustivel = "";
        private string _utilizacao = "";


        //Getters e Setters

        public int Id_Veiculo {
        
            get => _id_veiculo;
            set  { _id_veiculo = value; }
        }

        public int Id_Segurado {

            get => _id_segurado;
            set  { _id_segurado = value; }
        }

        public string Modelo {
        
            get => _modelo;
            set  { _modelo = value; }
        }

        public string Marca {

            get => _marca;
            set  { _marca = value; }
        }

        public int Ano {
        
            get => _ano;
            set  { _ano = value; }
        }

        public string Categoria {

            get => _categoria;
            set  { _categoria = value; }
        }

        public string Placa {
        
            get => _placa;
            set  { _placa = value; }
        }

        public string Renavam {
        
            get => _renavam;
            set  { _renavam = value; }
        }

        public int Km {
        
            get => _km;
            set  { _km = value; }
        }

        public bool Zero_Km {
        
            get => _zero_km;
            set  { _zero_km = value; }
        }

        public string Codigo_Fipe {
        
            get => _codigo_fipe;
            set  { _codigo_fipe = value; }
        }

        public string Combustivel {
       
            get => _combustivel;
            set  { _combustivel = value; }
        }

        public string Utilizacao {
       
            get => _utilizacao;
            set  { _utilizacao = value; }
        }

        //Construtores
        //Para criar veiculo
        public Veiculo (int id_segurado, string codigo_fipe, string modelo, int ano, string marca, string categoria, string placa, string renavam, bool zero_km, int km, string combustivel, string utilizacao) {
            Id_Segurado = id_segurado;
            Codigo_Fipe = codigo_fipe;
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
            Categoria = categoria;
            Placa = placa;
            Renavam = renavam;
            Zero_Km = zero_km;
            Km = km;
            Combustivel = combustivel;
            Utilizacao = utilizacao;
        }
        //Para listar veiculo   
        public Veiculo (string placa) {
            Placa = placa;
        }

        //Metodos
        public async Task Criar_Veiculo () {

            NpgsqlConnection conexao_banco = new NpgsqlConnection(str_conexao);

            try
            {
                await conexao_banco.OpenAsync();
                
                //String query inserir veiculo
                string str_cmd_cadastrar_veiculo =
                "INSERT INTO " +
                "tb_veiculo " +
                "(id_segurado, " +
                "codigo_fipe, " +
                "modelo, " +
                "ano, " +
                "marca, " +
                "categoria, " +
                "placa, " +
                "renavam, " +
                "zero_km, " +
                "km, " +
                "combustivel, " +
                "utilizacao) " +
                "VALUES ('"+Id_Segurado+"', @codigo_fipe, @modelo, '"+Ano.ToString()+"', '"+Marca+"', '"+Categoria+"', @placa, @renavam, '"+Zero_Km+"', '"+Km+"', '"+Combustivel+"', @utilizacao);";

                await using (NpgsqlCommand cmd_cadastrar_veiculo = new NpgsqlCommand(str_cmd_cadastrar_veiculo, conexao_banco)) {
                    //Passando parametros
                    cmd_cadastrar_veiculo.Parameters.AddWithValue("codigo_fipe", Codigo_Fipe);
                    cmd_cadastrar_veiculo.Parameters.AddWithValue("modelo", Modelo);
                    cmd_cadastrar_veiculo.Parameters.AddWithValue("placa", Placa);
                    cmd_cadastrar_veiculo.Parameters.AddWithValue("renavam", Renavam);
                    cmd_cadastrar_veiculo.Parameters.AddWithValue("utilizacao", Utilizacao);

                    Task<int> res_cadastrar_veiculo = cmd_cadastrar_veiculo.ExecuteNonQueryAsync();

                    if ((res_cadastrar_veiculo.Result == 0) || (res_cadastrar_veiculo.Result == 0)) {
                        MessageBox.Show("Não foi possível cadastrar um Veículo.", "Ops...");
                    }

                    if (res_cadastrar_veiculo.Result == 1) {
                        MessageBox.Show("Veículo cadastrado com sucesso!", "Ok!");
                    }
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + exception.StackTrace, "Detalhes do Erro...");
                await conexao_banco.CloseAsync();
            }
            
        }

        public async Task<NpgsqlDataAdapter> Listar_Veiculo () {
            NpgsqlConnection conexao_banco = new NpgsqlConnection(str_conexao);

            try
            {
                await conexao_banco.OpenAsync();

                string str_cmd_listar_veiculo =
                "SELECT " +
                "v.id as id_veiculo, " +
                "v.id_segurado, " +
                "v.codigo_fipe, " +
                "v.modelo, " +
                "v.ano, " +
                "v.marca, " +
                "v.categoria, " +
                "v.placa, " +
                "v.renavam, " +
                "v.zero_km, " +
                "v.km as quilometragem, " +
                "v.combustivel, " +
                "v.utilizacao " +
                "FROM tb_veiculo v " +
                "WHERE v.placa = @placa";

                await using (NpgsqlCommand cmd_listar_veiculo = new NpgsqlCommand(str_cmd_listar_veiculo, conexao_banco)) {
                    cmd_listar_veiculo.Parameters.AddWithValue("placa", Placa);

                    await using (NpgsqlDataReader reader_listar_veiculo = cmd_listar_veiculo.ExecuteReader()) {
                        //Leitura dos dados
                        while (await reader_listar_veiculo.ReadAsync()) {
                            Id_Veiculo = Convert.ToInt32(reader_listar_veiculo["id_veiculo"]);
                            Id_Segurado = Convert.ToInt32(reader_listar_veiculo["id_segurado"]);
                            Codigo_Fipe = reader_listar_veiculo["codigo_fipe"].ToString();
                            Modelo = reader_listar_veiculo["modelo"].ToString();
                            Ano = Convert.ToInt32(reader_listar_veiculo["ano"]);
                            Marca = reader_listar_veiculo["marca"].ToString();
                            Placa = reader_listar_veiculo["placa"].ToString();
                            Renavam = reader_listar_veiculo["renavam"].ToString();
                            Zero_Km = Convert.ToBoolean(reader_listar_veiculo["zero_km"]);
                            Km = Convert.ToInt32(reader_listar_veiculo["quilometragem"]);
                            Combustivel = reader_listar_veiculo["combustivel"].ToString();
                            Utilizacao = reader_listar_veiculo["utilizacao"].ToString();
                            Categoria = reader_listar_veiculo["categoria"].ToString();
                        }
                    }
                }

                NpgsqlCommand cmd_listar_veiculo_dataAdapter = new NpgsqlCommand(str_cmd_listar_veiculo, conexao_banco);
                cmd_listar_veiculo_dataAdapter.Parameters.AddWithValue("placa", Placa);

                NpgsqlDataAdapter listar_veiculo_dataAdapter = new NpgsqlDataAdapter(cmd_listar_veiculo_dataAdapter);

                return listar_veiculo_dataAdapter;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + exception.StackTrace, "Detalhes do Erro...");
                await conexao_banco.CloseAsync();
            }

            return null;
        }

        public async Task Modificar_Veiculo () {
            NpgsqlConnection conexao_banco = new NpgsqlConnection(str_conexao);

            try
            {
                await conexao_banco.OpenAsync();
                
                //Query mod veiculo
                string str_cmd_modificar_veiculo = 
                "UPDATE " +
                "tb_veiculo " +
                "SET " +
                "codigo_fipe=@codigo_fipe, " +
                "modelo=@modelo, " +
                "ano='"+Ano+"', " +
                "marca='"+Marca+"', " +
                "categoria='"+Categoria+"', " +
                "placa=@placa, " +
                "renavam=@renavam, " +
                "zero_km='"+Zero_Km+"', " +
                "km='"+Km+"', " +
                "combustivel='"+Combustivel+"', " +
                "utilizacao=@utilizacao " +
                "WHERE id = '"+Id_Veiculo+"';";

                await using (NpgsqlCommand cmd_modificar_veiculo = new NpgsqlCommand(str_cmd_modificar_veiculo, conexao_banco)) {
                    //Passando os parametros @...
                    cmd_modificar_veiculo.Parameters.AddWithValue("codigo_fipe", Codigo_Fipe);
                    cmd_modificar_veiculo.Parameters.AddWithValue("modelo", Modelo);
                    cmd_modificar_veiculo.Parameters.AddWithValue("placa", Placa);
                    cmd_modificar_veiculo.Parameters.AddWithValue("renavam", Renavam);
                    cmd_modificar_veiculo.Parameters.AddWithValue("utilizacao", Utilizacao);

                    Task<int> res_modificar_veiculo = cmd_modificar_veiculo.ExecuteNonQueryAsync();

                    if (res_modificar_veiculo.Result == 0) {
                        MessageBox.Show("Não foi possível modificar o Veículo.", "Ops...");
                    }

                    if (res_modificar_veiculo.Result == 1) {
                        MessageBox.Show("Veículo modificado com sucesso!", "Ok!");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + exception.StackTrace, "Detalhes do Erro...");
            }
        }
        
        public async Task Deletar_Veiculo () {
            NpgsqlConnection conexao_banco = new NpgsqlConnection(str_conexao);

            try
            {
                await conexao_banco.OpenAsync();

                string str_cmd_deletar_veiculo =
                "DELETE FROM " +
                "tb_veiculo " +
                "WHERE tb_veiculo.id = @id_veiculo";

                //Executando comando
                await using (NpgsqlCommand cmd_deletar_veiculo = new NpgsqlCommand(str_cmd_deletar_veiculo, conexao_banco)) {
                    cmd_deletar_veiculo.Parameters.AddWithValue("id_veiculo", Id_Veiculo);

                    Task<int> res_cmd_deletar_veiculo = cmd_deletar_veiculo.ExecuteNonQueryAsync();
                    
                    //Erro
                    if (res_cmd_deletar_veiculo.Result == 0) {
                        MessageBox.Show("Não foi possível remover o Veículo.", "Ops...");
                    }

                    if (res_cmd_deletar_veiculo.Result == 1) {
                        MessageBox.Show("Veículo removido com sucesso!", "Ok!");
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