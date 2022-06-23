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
    public partial class Tela_Cadastrar_Segurado : Form
    {

        Thread Tela;

        public Tela_Cadastrar_Segurado()
        {
            InitializeComponent();

            Banco_Telas_Segurado banco = new Banco_Telas_Segurado();
            Array array_genero = banco.ArrayGenero();
            Array array_faixa_salarial = banco.ArrayFaixaSalarial();

            foreach (var item in array_genero)
            {
                comboBox_Genero.Items.Add(item);
            }

            foreach (var item in array_faixa_salarial) 
            {
                comboBox_Faixa_Salarial.Items.Add(item);
            }
        }

        private void Btn_Cadastrar_Pessoa_Click_1(object sender, EventArgs e)
        {
            try
            {
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
                string valor_profissao = textBox_Profissao.Text;
                Object valor_faixa_salarial = comboBox_Faixa_Salarial.SelectedItem;

                Segurado obj_segurado = new Segurado(valor_nome, valor_cpf_cnpj, valor_cnh, valor_genero.ToString(), valor_data_nascimento, valor_cep, valor_cidade, valor_estado, valor_rua, valor_bairro, valor_numero, valor_complemento, valor_celular, valor_email, valor_profissao, valor_faixa_salarial.ToString());

                var criar_segurado = obj_segurado.Criar_Segurado();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Algo deu errado, por favor tente novamente.", "Ops...");
            }
        }
    }
}
