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

namespace Seguradora_Pim.Telas_Cotacao {
    public partial class Tela_Pesquisar_Cotacao : Form {

        Thread? Tela;

        public Tela_Pesquisar_Cotacao() {
            InitializeComponent();
        }

        private void Botao_Cancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Botao_Pesquisar_Click(object sender, EventArgs e) {
            Tela_Modificar_Cotacao obj_mod_veiculo = new Tela_Modificar_Cotacao(MaskedTextBox_Placa.Text);
            obj_mod_veiculo.Show();
        }

        private void abrir_tela_modificar() {
        }

    }
}
