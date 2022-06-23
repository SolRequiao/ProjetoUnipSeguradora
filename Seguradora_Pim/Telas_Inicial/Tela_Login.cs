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

namespace Seguradora_Pim.Telas_Inicial
{
    public partial class Tela_Login : Form
    {

        Thread Tela;
        string Acesso = "Host = localhost; Username = postgres; Password = 12121110; Database = db_seguradora";

        public Tela_Login()
        {
            InitializeComponent();
        }

        private void Btn_Logar_Click(object sender, EventArgs e)
        {
            if (textBox_Login.Text == "admin" && textBox_Senha.Text == "admin")
            {
                this.Close();
                Tela = new Thread(Abrir_Tela_Principal);
                Tela.SetApartmentState(ApartmentState.STA);
                Tela.Start();
            }
            else
            {
                MessageBox.Show("Dados Incorretos");
            }
        }

        private void Abrir_Tela_Principal()
        {
            Application.Run(new Telas_Inicial.Tela_Principal());
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

          
        }

        private void textBox_Senha_TextChanged(object sender, EventArgs e) {

        }

        private void pictureBox3_Click(object sender, EventArgs e) {

        }

        private void Tela_Login_Load(object sender, EventArgs e) {

        }
    }
}
