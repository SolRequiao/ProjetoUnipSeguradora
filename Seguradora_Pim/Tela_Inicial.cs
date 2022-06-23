using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguradora_Pim
{
    public partial class Tela_Inicial : Form
    {
        
        Thread Tela;

        public Tela_Inicial()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            this.Close();
            Tela = new Thread(Abrir_Tela_Login);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }
        private void Abrir_Tela_Login()
        {
            Application.Run(new Telas_Inicial.Tela_Login());
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }
    }
}
