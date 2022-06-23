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

namespace Seguradora_Pim.Telas_Funcionario
{
    public partial class Tela_Ver_Informacao_Funcionario : Form
    {

        public Tela_Ver_Informacao_Funcionario()
        {
            InitializeComponent();
        }

        private async void Btn_Pesquisar_Funcionario_Click(object sender, EventArgs e) {

            Funcionario obj_funcionario = new Funcionario(textBox_Pesquisar_Funcinario.Text);
            //Criando Data Adapter
            NpgsqlDataAdapter data_adapter_funcionario = await obj_funcionario.Listar_Funcionario();
            //Instancia DataTable
            DataTable funcionario = new DataTable();
            //Preenchendo adapter
            data_adapter_funcionario.Fill(funcionario);

            //Exibindo na DataGrid
            dataGridView_Pesquisar_Funcinario.DataSource = funcionario;
        }
    }
}
