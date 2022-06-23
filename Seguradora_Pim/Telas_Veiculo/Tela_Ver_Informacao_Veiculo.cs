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
    public partial class Tela_Ver_Informacao_Veiculo : Form
    {

        string Acesso = "Host = localhost; Username = postgres; Password = 12121110; Database = db_seguradora";

        public Tela_Ver_Informacao_Veiculo()
        {
            InitializeComponent();
        }

        private async void Btn_Ver_Informacao_Veiculo_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo obj_veiculo = new Veiculo(textBox_Ver_Informacao_Veiculo.Text);
                //Criando data adapter
                NpgsqlDataAdapter data_adapter_veiculo = await obj_veiculo.Listar_Veiculo();
                //Instanciando data tabel
                DataTable veiculo = new DataTable();
                //Preencher data table
                data_adapter_veiculo.Fill(veiculo);

                dataGridView_Ver_Informacao_Veiculo.DataSource = veiculo;
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("Algo deu errado, por favor tente novamente.", "Ops...");
            }
        }
    }
}
