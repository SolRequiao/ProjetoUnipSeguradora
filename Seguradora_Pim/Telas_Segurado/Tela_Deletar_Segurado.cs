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

namespace Seguradora_Pim.Telas_Segurado {
    public partial class Tela_Deletar_Segurado : Form {

        Thread? Tela;

        public Tela_Deletar_Segurado() {
            InitializeComponent();
        }

        private void Botao_Cancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private async void Botao_Pesquisar_Click(object sender, EventArgs e) {
            MaskedTextBox_Cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            DialogResult deletar_segurado_messageBox = MessageBox.Show("Deseja mesmo remover o Segurado?", "Confirmação", MessageBoxButtons.YesNo);
            
            if (deletar_segurado_messageBox == DialogResult.Yes) {
                Segurado obj_segurado = new Segurado(MaskedTextBox_Cpf.Text);
                await obj_segurado.Listar_Segurado();
                await obj_segurado.Deletar_Segurado();
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
