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

namespace Seguradora_Pim.Telas_Funcionario {
    public partial class Tela_Modificar_Funcionario : Form {
        public string Cpf_Funcionario {
            get;
            set;
        }

        public Tela_Modificar_Funcionario(string cpf_cnpj) {
            Cpf_Funcionario = cpf_cnpj;

            InitializeComponent();

            Telas_Funcionario.Banco_Telas_Funcionario banco = new Telas_Funcionario.Banco_Telas_Funcionario();
            Array array = banco.ArrayGenero();

            foreach (var item in array) {
                comboBox_Genero.Items.Add(item);
            }

        }

        private async void Tela_Modificar_Funcionario_Load(object sender, EventArgs e) {
            try {
                Funcionario obj_funcionario = new Funcionario(Cpf_Funcionario);
                await obj_funcionario.Listar_Funcionario();
                textBox_Nome.Text = obj_funcionario.Nome;
                textBox_Cpf_Cnpj.Text = obj_funcionario.Cpf_Cnpj;
                textBox_Cnh.Text = obj_funcionario.Cnh;
                comboBox_Genero.SelectedItem = obj_funcionario.Genero;
                textBox_Data_Nascimento.Text = obj_funcionario.Data_Nascimento;
                textBox_Cep.Text = obj_funcionario.Cep;
                textBox_Cidade.Text = obj_funcionario.Cidade;
                textBox_Estado.Text = obj_funcionario.Estado;
                textBox_Bairro.Text = obj_funcionario.Bairro;
                textBox_Rua.Text = obj_funcionario.Rua;
                textBox_Numero.Text = obj_funcionario.Numero.ToString();
                textBox_Complemento.Text = obj_funcionario.Complemento;
                textBox_Celular.Text = obj_funcionario.Celular;
                textBox_Email.Text = obj_funcionario.Email;

            } catch (Exception exception) {
                MessageBox.Show("Algo deu errado, por favor tente novamente.", "Ops...");
            }

        }

        private void Botao_Voltar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private async void Btn_Modificar_Pessoa_Click(object sender, EventArgs e) {

            try {
                //Variaveis com valores

                Funcionario obj_funcionario = new Funcionario(Cpf_Funcionario);

                await obj_funcionario.Listar_Funcionario();

                obj_funcionario.Nome = textBox_Nome.Text;
                obj_funcionario.Cpf_Cnpj = textBox_Cpf_Cnpj.Text;
                obj_funcionario.Cnh = textBox_Cnh.Text;
                obj_funcionario.Genero = comboBox_Genero.SelectedItem.ToString();
                obj_funcionario.Data_Nascimento = textBox_Data_Nascimento.Text;
                obj_funcionario.Cep = textBox_Cep.Text;
                obj_funcionario.Cidade = textBox_Cidade.Text;
                obj_funcionario.Estado = textBox_Estado.Text;
                obj_funcionario.Bairro = textBox_Bairro.Text;
                obj_funcionario.Rua = textBox_Rua.Text;
                obj_funcionario.Numero = Int32.Parse(textBox_Numero.Text);
                obj_funcionario.Complemento = textBox_Complemento.Text;
                obj_funcionario.Celular = textBox_Celular.Text;
                obj_funcionario.Email = textBox_Email.Text;

                await obj_funcionario.Modificar_Funcionario();

            } catch (Exception exception) {
                MessageBox.Show("Algo deu errado, por favor tente novamente.", "Ops...");
            }
        }
    }
}
