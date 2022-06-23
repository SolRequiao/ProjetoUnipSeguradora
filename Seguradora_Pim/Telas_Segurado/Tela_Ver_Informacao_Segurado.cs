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

namespace Seguradora_Pim.Telas_Segurado
{
    public partial class Tela_Ver_Informacao_Segurado : Form
    {

        string Acesso = "Host = localhost; Username = postgres; Password = 12121110; Database = db_seguradora";

        public Tela_Ver_Informacao_Segurado()
        {
            InitializeComponent();
        }

        private async void Btn_Pesquisar_Cpf_Cnpj_Click(object sender, EventArgs e)
        {
            Segurado obj_segurado = new Segurado(textBox_Pesquisar_Cpf_Cnpj.Text);
            //Criando Data Adapter
            NpgsqlDataAdapter data_adapter_segurado = await obj_segurado.Listar_Segurado();
            //Instancia DataTable
            DataTable segurado = new DataTable();
            //Preenchendo adapter
            data_adapter_segurado.Fill(segurado);

            //Exibindo na DataGrid
            dataGridView_Pesquisar_Cpf_Cnpj.DataSource = segurado;

        }
    }
}
