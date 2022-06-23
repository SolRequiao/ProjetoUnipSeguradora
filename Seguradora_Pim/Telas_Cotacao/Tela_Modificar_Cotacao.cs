using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguradora_Pim.Telas_Cotacao
{
    public partial class Tela_Modificar_Cotacao : Form
    {
        Thread? Tela;

        public string Placa {
            get;
            set;
        }

        public Tela_Modificar_Cotacao(string placa) {

            Placa = placa;

            InitializeComponent();

            Banco_Telas_Cotacao banco = new Banco_Telas_Cotacao();
            Array array = banco.ArrayPlanoSeguro();

            foreach (var item in array) {
                comboBox_Plano_Segurado.Items.Add(item);
            }

            Banco_Telas_Cotacao banco1 = new Banco_Telas_Cotacao();
            Array array1 = banco1.ArrayFormaPagamento();

            foreach (var item in array1) {
                comboBox_Forma_Pagamento.Items.Add(item);
            }
        }

        private async void Tela_Modificar_Cotacao_Load(object sender, EventArgs e) {
            try
            {
                //Comando para listar
                Veiculo obj_veiculo = new Veiculo(Placa);
                await obj_veiculo.Listar_Veiculo();

                Cotacao obj_cotacao = new Cotacao(obj_veiculo.Id_Veiculo, 0);
                await obj_cotacao.Listar_Cotacao();

                comboBox_Plano_Segurado.SelectedItem = obj_cotacao.Plano_Seguro;
                textBox_Valor_Premio_Seguro.Text = obj_cotacao.Valor_Premio_Seguro.ToString();
                textBox_Valor_Total_Premio_Seguro.Text = obj_cotacao.Valor_Total_Premio_Seguro.ToString();
                comboBox_Forma_Pagamento.SelectedItem = obj_cotacao.Forma_Pagamento;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Algo deu errado, por favor tente novamente.", "Ops...");
            }
        }

        private async void Btn_Modificar_Cotacao_Click(object sender, EventArgs e) {
            try
            {
                Veiculo obj_veiculo = new Veiculo(Placa);
                await obj_veiculo.Listar_Veiculo();

                Cotacao obj_cotacao = new Cotacao(obj_veiculo.Id_Veiculo);
                await obj_cotacao.Listar_Cotacao();

                obj_cotacao.Plano_Seguro = comboBox_Plano_Segurado.SelectedItem.ToString();
                obj_cotacao.Valor_Premio_Seguro = Convert.ToDecimal(textBox_Valor_Premio_Seguro.Text);
                obj_cotacao.Valor_Total_Premio_Seguro = Convert.ToDecimal(textBox_Valor_Total_Premio_Seguro.Text);
                obj_cotacao.Forma_Pagamento = comboBox_Forma_Pagamento.SelectedItem.ToString();

                await obj_cotacao.Modificar_Cotacao();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Algo deu errado, por favor tente novamente.", "Ops...");
            }
        }
    }
}
