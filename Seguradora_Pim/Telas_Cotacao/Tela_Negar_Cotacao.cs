using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguradora_Pim.Telas_Cotacao
{
    public partial class Tela_Negar_Cotacao : Form
    {
        public Tela_Negar_Cotacao()
        {
            InitializeComponent();
        }

        private async void Btn_Reprovar_Cotacao_Click(object sender, EventArgs e)
        {
            Cotacao obj_cotacao = new Cotacao(0, Convert.ToInt32(textBox_Id_Cotacao.Text));
            obj_cotacao.Status = "Negada";
            await obj_cotacao.Negar_Cotacao();
        }
    }
}
