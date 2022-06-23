using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguradora_Pim.Telas_Inicial
{
    public partial class Tela_Principal : Form
    {

        Thread Tela;

        public int Heigth { get; private set; }

        public Tela_Principal()
        {
            InitializeComponent();
        }

        //funcionario
        private void Btn_Funcionario_Click(object sender, EventArgs e)
        {
            Tela = new Thread(Abrir_Tela_Principal_Funcionario);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }      
        private void Abrir_Tela_Principal_Funcionario()
        {
            Application.Run(new Telas_Funcionario.Tela_Principal_Funcionario());
        }

        //apolice
        private void Btn_Apolice_Click(object sender, EventArgs e)
        {
            Tela = new Thread(Abrir_Tela_Principal_Apolice);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }
        private void Abrir_Tela_Principal_Apolice()
        {
            Application.Run(new Telas_Apolice.Tela_Principal_Apolice());
        }

        //cotacao
        private void Btn_Cotacao_Click(object sender, EventArgs e)
        {
            Tela = new Thread(Abrir_Tela_Principal_Cotacao);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }
        private void Abrir_Tela_Principal_Cotacao()
        {
            Application.Run(new Telas_Cotacao.Tela_Principal_Cotacao());
        }

        

        //veiculo
        private void Btn_Veiculo_Click(object sender, EventArgs e)
        {
            Tela = new Thread(Abrir_Tela_Principal_Veiculo);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }
        private void Abrir_Tela_Principal_Veiculo()
        {
            Application.Run(new Telas_Veiculo.Tela_Principal_Veiculo());
        }

        //segurado
        private void Btn_Segurado_Click(object sender, EventArgs e)
        {
            Tela = new Thread(Abrir_Tela_Principal_Segurado);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }
        private void Abrir_Tela_Principal_Segurado()
        {
            Application.Run(new Telas_Segurado.Tela_Principal_Segurado());
        }
                       
                
        private void Tela_Principal_Load(object sender, EventArgs e) {
                        
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }
    }
}
