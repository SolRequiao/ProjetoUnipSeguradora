using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguradora_Pim.Telas_Segurado
{
    public partial class Tela_Modificar_Segurado : Form
    {

        public string Cpf_Cnpj {
            get;
            set;
        }

        public Tela_Modificar_Segurado(string cpf_cnpj)
        {
            Cpf_Cnpj = cpf_cnpj;

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

        private async void Tela_Modificar_Segurado_Load(object sender, EventArgs e) {
            try {
                
                Segurado obj_segurado = new Segurado(Cpf_Cnpj);

                await obj_segurado.Listar_Segurado();

                textBox_Nome.Text = obj_segurado.Nome;
                textBox_Cpf_Cnpj.Text = obj_segurado.Cpf_Cnpj;
                textBox_Cnh.Text = obj_segurado.Cnh;
                comboBox_Genero.SelectedItem = obj_segurado.Genero;
                textBox_Data_Nascimento.Text = obj_segurado.Data_Nascimento;
                textBox_Cep.Text = obj_segurado.Cep;
                textBox_Cidade.Text = obj_segurado.Cidade;
                textBox_Estado.Text = obj_segurado.Estado;
                textBox_Bairro.Text = obj_segurado.Bairro;
                textBox_Rua.Text = obj_segurado.Rua;
                textBox_Numero.Text = obj_segurado.Numero.ToString();
                textBox_Complemento.Text = obj_segurado.Complemento;
                textBox_Celular.Text = obj_segurado.Celular;
                textBox_Email.Text = obj_segurado.Email;
                textBox_Profissao.Text = obj_segurado.Profissao;
                comboBox_Faixa_Salarial.SelectedItem = obj_segurado.Faixa_Salarial;

            } catch (Exception exception) {
                MessageBox.Show("Algo deu errado, por favor tente novamente.", "Ops...");
            }
        }

        private async void Btn_Modificar_Pessoa_Click(object sender, EventArgs e) {
            try
            {

                Segurado obj_segurado = new Segurado(Cpf_Cnpj);

                await obj_segurado.Listar_Segurado();

                obj_segurado.Nome = textBox_Nome.Text;
                obj_segurado.Cpf_Cnpj = textBox_Cpf_Cnpj.Text;
                obj_segurado.Cnh = textBox_Cnh.Text;
                obj_segurado.Genero = comboBox_Genero.SelectedItem.ToString();
                obj_segurado.Data_Nascimento = textBox_Data_Nascimento.Text;
                obj_segurado.Cep = textBox_Cep.Text;
                obj_segurado.Cidade = textBox_Cidade.Text;
                obj_segurado.Estado = textBox_Estado.Text;
                obj_segurado.Bairro = textBox_Bairro.Text;
                obj_segurado.Rua = textBox_Rua.Text;
                obj_segurado.Numero = Int32.Parse(textBox_Numero.Text);
                obj_segurado.Complemento = textBox_Complemento.Text;
                obj_segurado.Celular = textBox_Celular.Text;
                obj_segurado.Email = textBox_Email.Text;
                obj_segurado.Faixa_Salarial = comboBox_Faixa_Salarial.SelectedItem.ToString();
                obj_segurado.Profissao = textBox_Profissao.Text;

                await obj_segurado.Modificar_Segurado();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Algo deu errado, por favor tente novamente.", "Ops...");
            }
        }
    }
}
