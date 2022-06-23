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
    public partial class Tela_Deletar_Veiculo : Form
    {
        public Tela_Deletar_Veiculo()
        {
            InitializeComponent();
        }

        //deletando veiculo pela placa
        private async void Btn_Deletar_Veiculo_Click(object sender, EventArgs e)
        {
            DialogResult deletar_veiculo_messageBox = MessageBox.Show("Deseja mesmo remover o Veículo?", "Confirmação", MessageBoxButtons.YesNo);
            
            if (deletar_veiculo_messageBox == DialogResult.Yes) {
                Veiculo obj_veiculo = new Veiculo(textBox_Dados_Placa.Text);
                await obj_veiculo.Listar_Veiculo();
                await obj_veiculo.Deletar_Veiculo();
            }
        }
    }
}
