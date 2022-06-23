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

namespace Seguradora_Pim.Telas_Veiculo
{
    public partial class Tela_Cadastrar_Veiculo : Form
    {

        string Acesso = "Host = localhost; Username = postgres; Password = 12121110; Database = db_seguradora";

        public Tela_Cadastrar_Veiculo()
        {
            InitializeComponent();

            Banco_Telas_Veiculo banco = new Banco_Telas_Veiculo();
            Array array = banco.ArrayCategoriaVeiculo();

            foreach (var item in array)
            {
                comboBox_Categoria.Items.Add(item);

            }
            
            Banco_Telas_Veiculo banco1 = new Banco_Telas_Veiculo();
            Array array1 = banco1.ArrayCombustivel();

            foreach (var item in array1)
            {
                comboBox_Combustivel.Items.Add(item);

            }
            
            Banco_Telas_Veiculo banco2 = new Banco_Telas_Veiculo();
            Array array2 = banco2.ArrayMarca();

            foreach (var item in array2)
            {
                comboBox_Marca.Items.Add(item);

            }
        }

        

        private async void Btn_Buscar_Segurado_Click(object sender, EventArgs e)
        {
            Segurado obj_segurado = new Segurado(textBox_Buscar_Segurado.Text);
            //Criando Data Adapter
            NpgsqlDataAdapter data_adapter_segurado = await obj_segurado.Listar_Segurado();
            //Instancia DataTable
            DataTable segurado = new DataTable();
            //Preenchendo adapter
            data_adapter_segurado.Fill(segurado);
            //Exibindo na DataGrid
            dataGridView_Buscar_Segurado.DataSource = segurado;

            textBox_Buscar_Segurado.Clear();
        }

        private async void Btn_Cadastrar_Veiculo_Click(object sender, EventArgs e)
        {
            try
            {
                int valor_id_segurado = Convert.ToInt32(textBox_Id_Segurado.Text);
                string valor_codigo_fipe = textBox_Codigo_Fipe.Text;
                string valor_modelo = textBox_Modelo.Text;
                int valor_ano = Convert.ToInt32(textBox_Ano.Text);
                object valor_marca = comboBox_Marca.SelectedItem;
                object valor_categoria = comboBox_Categoria.SelectedItem;
                string valor_placa = textBox_Placa.Text.ToUpper();
                string valor_renavam = textBox_Renavam.Text;
                char.ToUpper(textBox_Zero_Km.Text[0]);
                string valor_texto_zero_km = textBox_Zero_Km.Text;
                bool valor_zero_km = valor_texto_zero_km == "Sim" ? true : false;
                int valor_km = Convert.ToInt32(textBox_Km.Text);
                object valor_combustivel = comboBox_Combustivel.SelectedItem;
                string valor_utilizacao = textBox_Utilizacao.Text;

                Veiculo obj_veiculo = new Veiculo(valor_id_segurado, valor_codigo_fipe, valor_modelo, valor_ano, valor_marca.ToString(), valor_categoria.ToString(), valor_placa, valor_renavam, valor_zero_km, valor_km, valor_combustivel.ToString(), valor_utilizacao);
                await obj_veiculo.Criar_Veiculo();    
            }
            catch (Exception exception)
            {
                MessageBox.Show("Algo deu errado, por favor tente novamente.", "Ops...");
            }
            
        }

        private void textBox_Modelo_TextChanged(object sender, EventArgs e) {

        }

    }
}
