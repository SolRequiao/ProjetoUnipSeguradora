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

namespace Seguradora_Pim.Telas_Cotacao
{
    public partial class Tela_Deletar_Cotacao : Form
    {

        string Acesso = "Host = localhost; Username = postgres; Password = 12121110; Database = db_seguradora";

        public Tela_Deletar_Cotacao()
        {
            InitializeComponent();
        }

        private void Btn_Pesquisar_Veiculo_Click(object sender, EventArgs e)
        {
            string sql = "SELECT v.placa, c.id, c.plano_seguro, c.valor_premio_seguro, c.valor_total_premio_seguro, " +
                "c.forma_pagamento, c.status FROM tb_veiculo v, tb_cotacao c WHERE v.placa = '"+textBox_Pesquisar_Veiculo.Text+"';";

            NpgsqlConnection conexao = new NpgsqlConnection(Acesso);

            NpgsqlCommand comando = new NpgsqlCommand(sql, conexao);

            conexao.Open();

            comando.CommandType = CommandType.Text;

            NpgsqlDataAdapter banco = new NpgsqlDataAdapter(comando);

            DataTable pessoa = new DataTable();

            banco.Fill(pessoa);

            dataGridView_Pesquisar_Veiculo.DataSource = pessoa;

            textBox_Pesquisar_Veiculo.Clear();
        }

        private async void Btn_Deletar_Cotacao_Click(object sender, EventArgs e)
        {
            DialogResult deletar_cotacao_messageBox = MessageBox.Show("Deseja mesmo remover a Cotação?", "Confirmação", MessageBoxButtons.YesNo);
            
            if (deletar_cotacao_messageBox == DialogResult.Yes) {
                Cotacao obj_cotacao = new Cotacao(0, Convert.ToInt32(textBox_Deletar_Cotacao.Text));
                await obj_cotacao.Deletar_Cotacao();
            }
        }
    }
}
