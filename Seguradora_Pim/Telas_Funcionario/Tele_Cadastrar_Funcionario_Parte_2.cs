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
    public partial class Tele_Cadastrar_Funcionario_Parte_2 : Form
    {

        string Acesso = "Host = localhost; Username = postgres; Password = 12121110; Database = db_seguradora";

        public Tele_Cadastrar_Funcionario_Parte_2()
        {
            InitializeComponent();
        }

        private void Btn_Pesquisar_Pessoa_Click(object sender, EventArgs e)
        {
            string sql = "SELECT id, nome, cpf_cnpj FROM tb_pessoa WHERE cpf_cnpj = '"+textBox_Pesquisar_Pessoa.Text+"';";

            NpgsqlConnection conexao = new NpgsqlConnection(Acesso);

            NpgsqlCommand comando = new NpgsqlCommand(sql, conexao);

            conexao.Open();

            comando.CommandType = CommandType.Text;

            NpgsqlDataAdapter banco = new NpgsqlDataAdapter(comando);

            DataTable pessoa = new DataTable();

            banco.Fill(pessoa);

            dataGridView_Pesquisar_Pessoa.DataSource = pessoa;
        }

        private void Btn_Cadastrar_Funcionario_Click(object sender, EventArgs e)
        {
            Banco_Telas_Funcionario banco = new Banco_Telas_Funcionario();

            banco.Inserir_Dados_Cadastrar_Funcionario(textBox_Id_Pessoa.Text, textBox_Senha.Text);

            MessageBox.Show("Cadastro feito com sucesso!");

            this.Close();
        }
    }
}
