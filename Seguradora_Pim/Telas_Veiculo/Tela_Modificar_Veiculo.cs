using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguradora_Pim.Telas_Veiculo
{
    public partial class Tela_Modificar_Veiculo : Form
    {

        Thread? Tela;

        public string Placa {
            get;
            set;
        }

        public Tela_Modificar_Veiculo(string placa)
        {
            Placa = placa;

            InitializeComponent();

            Banco_Telas_Veiculo banco = new Banco_Telas_Veiculo();
            Array array = banco.ArrayCategoriaVeiculo();

            foreach (var item in array) {
                comboBox_Categoria.Items.Add(item);

            }

            Banco_Telas_Veiculo banco1 = new Banco_Telas_Veiculo();
            Array array1 = banco1.ArrayCombustivel();

            foreach (var item in array1) {
                comboBox_Combustivel.Items.Add(item);

            }

            Banco_Telas_Veiculo banco2 = new Banco_Telas_Veiculo();
            Array array2 = banco2.ArrayMarca();

            foreach (var item in array2) {
                comboBox_Marca.Items.Add(item);

            }
        }

        private async void Tela_Modificar_Veiculo_Load(object sender, EventArgs e) {
            
            try
            {
                //Comando para listar
                Veiculo obj_veiculo = new Veiculo(Placa);
                await obj_veiculo.Listar_Veiculo();
                textBox_Codigo_Fipe.Text = obj_veiculo.Codigo_Fipe;
                textBox_Modelo.Text = obj_veiculo.Modelo;
                textBox_Ano.Text = obj_veiculo.Ano.ToString();
                textBox_Placa.Text = obj_veiculo.Placa;
                textBox_Renavam.Text = obj_veiculo.Renavam;
                textBox_Km.Text = obj_veiculo.Km.ToString();
                textBox_Utilizacao.Text = obj_veiculo.Utilizacao;
                comboBox_Combustivel.SelectedItem = obj_veiculo.Combustivel;
                comboBox_Categoria.SelectedItem = obj_veiculo.Categoria;
                comboBox_Marca.SelectedItem = obj_veiculo.Marca;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Algo deu errado, por favor tente novamente.", "Ops...");
            }
        }

        private async void Btn_Modificar_Veiculo_Click(object sender, EventArgs e) {
            try
            {
                Veiculo obj_veiculo = new Veiculo(Placa);
                await obj_veiculo.Listar_Veiculo();
                obj_veiculo.Codigo_Fipe = textBox_Codigo_Fipe.Text;
                obj_veiculo.Modelo = textBox_Modelo.Text;
                obj_veiculo.Ano = Convert.ToInt32(textBox_Ano.Text);
                obj_veiculo.Placa = textBox_Placa.Text;
                obj_veiculo.Renavam = textBox_Renavam.Text;
                obj_veiculo.Km = Convert.ToInt32(textBox_Km.Text);
                obj_veiculo.Utilizacao = textBox_Utilizacao.Text;
                obj_veiculo.Combustivel = comboBox_Combustivel.SelectedItem.ToString();
                obj_veiculo.Categoria = comboBox_Categoria.SelectedItem.ToString();
                obj_veiculo.Marca = comboBox_Marca.SelectedItem.ToString();
                await obj_veiculo.Modificar_Veiculo();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Algo deu errado, por favor tente novamente.", "Ops...");
            }
        }
    }
}
