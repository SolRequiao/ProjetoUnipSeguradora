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
    public partial class Tela_Ver_Informacao_Cotacao : Form
    {

        string Acesso = "Host = localhost; Username = postgres; Password = 12121110; Database = db_seguradora";

        public Tela_Ver_Informacao_Cotacao()
        {
            InitializeComponent();
        }

        private async void Btn_Pesquisar_Cotacao_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo obj_veiculo = new Veiculo(textBox_Pesquisar_Cotacao.Text);
                await obj_veiculo.Listar_Veiculo();

                Cotacao obj_cotacao = new Cotacao(obj_veiculo.Id_Veiculo, 0);
                NpgsqlDataAdapter data_adapter_cotacao = await obj_cotacao.Listar_Cotacao();
                DataTable cotacao = new DataTable();
                data_adapter_cotacao.Fill(cotacao);

                dataGridView_Pesquisar_Cotacao.DataSource = cotacao;
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("Algo deu errado, por favor tente novamente.", "Ops...");
            }

        }

        private void textBox_Pesquisar_Cotacao_TextChanged(object sender, EventArgs e) {

        }
    }
}
