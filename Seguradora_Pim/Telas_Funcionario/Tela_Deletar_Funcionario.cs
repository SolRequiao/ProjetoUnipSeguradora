using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Seguradora_Pim {
    public partial class Tela_Deletar_Funcionario : Form {

        public Tela_Deletar_Funcionario() {
            InitializeComponent();
        }
        
        private void Botao_Cancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private async void Botao_Pesquisar_Click(object sender, EventArgs e) {
            MaskedTextBox_Cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            DialogResult deletar_funcionario_messageBox = MessageBox.Show("Deseja mesmo remover o funcionário?", "Confirmação", MessageBoxButtons.YesNo);
            if (deletar_funcionario_messageBox == DialogResult.Yes) {
                Funcionario obj_funcionario = new Funcionario(MaskedTextBox_Cpf.Text);
                await obj_funcionario.Listar_Funcionario();
                await obj_funcionario.Deletar_Funcionario();
            }
            
        }

        private void MaskedTextBox_Cpf_Enter(object sender, EventArgs e) {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                MaskedTextBox_Cpf.Select(0, 0);
            });
        }
    }
}
