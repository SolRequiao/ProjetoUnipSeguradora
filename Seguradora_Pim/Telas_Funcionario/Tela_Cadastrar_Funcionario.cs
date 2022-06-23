using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Seguradora_Pim.Telas_Funcionario
{
    public partial class Tela_Cadastrar_Funcionario : Form
    {

        public Tela_Cadastrar_Funcionario()
        {
            InitializeComponent();
            
            Banco_Telas_Funcionario banco = new Banco_Telas_Funcionario();
            Array array = banco.ArrayGenero();

            foreach (var item in array)
            {
                comboBox_Genero.Items.Add(item);
            }

        }

        private void Btn_Cadastrar_Pessoa_Click(object sender, EventArgs e)
        {
            try {
                //Variaveis com valores
                string valor_nome = textBox_Nome.Text;
                string valor_cpf_cnpj = textBox_Cpf_Cnpj.Text;
                Object valor_genero = comboBox_Genero.SelectedItem;
                string valor_cep = textBox_Cep.Text;
                string valor_cidade = textBox_Cidade.Text;
                string valor_bairro = textBox_Bairro.Text;
                string valor_celular = textBox_Celular.Text;
                string valor_email = textBox_Email.Text;
                string valor_data_nascimento = textBox_Data_Nascimento.Text;
                string valor_estado = textBox_Estado.Text;
                string valor_cnh = textBox_Cnh.Text;
                string valor_rua = textBox_Rua.Text;
                int valor_numero = Convert.ToInt32(textBox_Numero.Text.ToString());
                string valor_complemento = textBox_Complemento.Text;
                string senha_funcionario = textBox_Senha_Funcionario.Text;

                Funcionario obj_funcionario = new Funcionario(valor_nome, valor_cpf_cnpj, valor_cnh, valor_genero.ToString(), valor_data_nascimento, valor_cep, valor_cidade, valor_estado, valor_rua, valor_bairro, valor_numero, valor_complemento, valor_celular, valor_email, senha_funcionario);

                var criar_funcionario = obj_funcionario.Criar_Funcionario();

            } catch (Exception exception) {
                MessageBox.Show("Algo deu errado, por favor tente novamente.", "Ops...");
            }
        }
    }
}
