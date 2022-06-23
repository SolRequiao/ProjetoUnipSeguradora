using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguradora_Pim.Telas_Apolice
{
    public partial class Tela_Deletar_Apolice : Form
    {
        public Tela_Deletar_Apolice()
        {
            InitializeComponent();
        }

        private async void Btn_Deletar_Apolice_Click(object sender, EventArgs e)
        {
            try
            {
                Apolice obj_apolice = new Apolice(Convert.ToInt32(textBox_Deletar_Apolice.Text));
                await obj_apolice.Deletar_Apolice();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Algo deu errado, por favor tente novamente.", "Ops...");
            }

        }

        private void Tela_Deletar_Apolice_Load(object sender, EventArgs e) {

        }
    }
}
