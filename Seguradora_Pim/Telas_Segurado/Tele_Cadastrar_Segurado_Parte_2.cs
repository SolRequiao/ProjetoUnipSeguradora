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
    public partial class Tele_Cadastrar_Segurado_Parte_2 : Form
    {

        string Acesso = "Host = localhost; Username = postgres; Password = 12121110; Database = db_seguradora";

        public Tele_Cadastrar_Segurado_Parte_2()
        {
            InitializeComponent();

            Banco_Telas_Segurado banco = new Banco_Telas_Segurado();
            Array array = banco.ArrayFaixaSalarial();

        }

        

        private void Btn_Cadastrar_Segurado_Click(object sender, EventArgs e)
        {
            Banco_Telas_Segurado banco = new Banco_Telas_Segurado();
        }

        


        private void button_Buscar_Id_Click(object sender, EventArgs e)
        {
            string sql = "SELECT id, nome, cpf_cnpj FROM tb_pessoa WHERE cpf_cnpj = '" + textBox_Pesquisar_Pessoa.Text + "';";

            
            NpgsqlConnection conexao = new NpgsqlConnection(Acesso);
            
            NpgsqlCommand comando = new NpgsqlCommand(sql, conexao);


            conexao.Open();

            comando.CommandType = CommandType.Text;
 
            NpgsqlDataAdapter banco = new NpgsqlDataAdapter(comando);


            DataTable pessoa = new DataTable();


            banco.Fill(pessoa);

            dataGridView_Id_Pessoa.DataSource = pessoa;
        }

        private void textBox_Id_Pessoa_TextChanged(object sender, EventArgs e) {

        }

        private void textBox_Profissao_TextChanged(object sender, EventArgs e) {

        }

        private void Tele_Cadastrar_Segurado_Parte_2_Load(object sender, EventArgs e) {

        }

        private void comboBox_Faixa_Salarial_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
