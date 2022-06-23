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
    public partial class Tela_Cadastrar_Cotacao : Form
    {

        string Acesso = "Host = localhost; Username = postgres; Password = 12121110; Database = db_seguradora";

        public Tela_Cadastrar_Cotacao()
        {
            InitializeComponent();

            Banco_Telas_Cotacao banco = new Banco_Telas_Cotacao();
            Array array = banco.ArrayPlanoSeguro();

            foreach (var item in array)
            {
                comboBox_Plano_Segurado.Items.Add(item);
            }

            Banco_Telas_Cotacao banco1 = new Banco_Telas_Cotacao();
            Array array1 = banco1.ArrayFormaPagamento();

            foreach (var item in array1)
            {
                comboBox_Forma_Pagamento.Items.Add(item);

            }

            Banco_Telas_Cotacao banco2 = new Banco_Telas_Cotacao();
            Array array2 = banco2.ArrayStatusCotacao();

            foreach (var item in array2)
            {
                comboBox_Status_Cotacao.Items.Add(item);
                comboBox_Status_Cotacao.SelectedItem = "Negada";
            }
        }

        private async void Btn_Buscar_Veiculo_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo obj_veiculo = new Veiculo(textBox_Buscar_Veiculo.Text);
                //Criando data adapter
                NpgsqlDataAdapter data_adapter_veiculo = await obj_veiculo.Listar_Veiculo();
                //Instanciando data tabel
                DataTable veiculo = new DataTable();
                //Preencher data table
                data_adapter_veiculo.Fill(veiculo);

                dataGridView_Buscar_Veiculo.DataSource = veiculo;
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("Algo deu errado, por favor tente novamente.", "Ops...");
            }

        }

        private async void Btn_Cadastrar_Cotacao_Click(object sender, EventArgs e)
        {
            try
            {
                Cotacao obj_cotacao = new Cotacao(Convert.ToInt32(textBox_Id_Veiculo.Text), comboBox_Plano_Segurado.SelectedItem.ToString(), Convert.ToDecimal(textBox_Valor_Premio_Seguro.Text), Convert.ToDecimal(textBox_Valor_Total_Premio_Seguro.Text), comboBox_Forma_Pagamento.SelectedItem.ToString(), comboBox_Status_Cotacao.SelectedItem.ToString());

                await obj_cotacao.Criar_Cotacao();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Algo deu errado, por favor tente novamente.", "Ops...");
            }
        }
    }
}
