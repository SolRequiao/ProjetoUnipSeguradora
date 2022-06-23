using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Seguradora_Pim.Telas_Apolice
{
    public partial class Tela_Cadastrar_Apolice : Form
    {

        string Acesso = "Host = localhost; Username = postgres; Password = 12121110; Database = db_seguradora";

        public Tela_Cadastrar_Apolice()
        {
            InitializeComponent();

            Banco_Telas_Apolice banco = new Banco_Telas_Apolice();
            Array array = banco.ArrayStatusApolice();

            foreach (var item in array)
            {
                comboBox_Status_Apolice.Items.Add(item);

            }
        }

        private void Btn_Pesquisar_Cotacao_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT c.id, c.plano_seguro, c.valor_premio_seguro, c.valor_total_premio_seguro, " +
                "c.forma_pagamento, c.status FROM tb_veiculo v, tb_cotacao c WHERE v.placa = '" + textBox_Pesquisar_Cotacao.Text + "';";

                NpgsqlConnection conexao = new NpgsqlConnection(Acesso);

                NpgsqlCommand comando = new NpgsqlCommand(sql, conexao);

                conexao.Open();

                comando.CommandType = CommandType.Text;

                NpgsqlDataAdapter banco = new NpgsqlDataAdapter(comando);

                DataTable pessoa = new DataTable();

                banco.Fill(pessoa);

                dataGridView_Pesquisar_Cotacao.DataSource = pessoa;

                textBox_Pesquisar_Cotacao.Clear();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Algo deu errado, por favor tente novamente.", "Ops...");
            }
            
        }

        private async void Btn_Cadastrar_Apolice_Click(object sender, EventArgs e)
        {
            try
            {
                Apolice obj_apolice = new Apolice(Convert.ToInt32(textBox_Id_Cotacao.Text), textBox_Produto.Text, textBox_Processo_Susep.Text, textBox_Codigo_Ramo.Text, textBox_Numero_Apolice.Text, textBox_Data_Emissao.Text, textBox_Data_Termino.Text, comboBox_Status_Apolice.SelectedItem.ToString());

                await obj_apolice.Criar_Apolice();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Algo deu errado, por favor tente novamente.", "Ops...");
            }
            
        }
    }
}
