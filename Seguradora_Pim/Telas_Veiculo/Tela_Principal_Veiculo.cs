using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguradora_Pim.Telas_Veiculo
{
    public partial class Tela_Principal_Veiculo : Form
    {

        Thread Tela;

        public Tela_Principal_Veiculo()
        {
            InitializeComponent();
        }

        //cadastrar
        private void Btn_Tela_Cadastrar_Veiculo_Click(object sender, EventArgs e)
        {
            this.Close();
            Tela = new Thread(Abrir_Tela_Cadastrar_Veiculo);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }
        private void Abrir_Tela_Cadastrar_Veiculo()
        {
            Application.Run(new Telas_Veiculo.Tela_Cadastrar_Veiculo());
        }

        //ver informacao
        private void Btn_Tela_Ver_Informacao_Veiculo_Click(object sender, EventArgs e)
        {
            this.Close();
            Tela = new Thread(Abrir_Tela_Ver_Informacao_Veiculo);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }
        private void Abrir_Tela_Ver_Informacao_Veiculo()
        {
            Application.Run(new Telas_Veiculo.Tela_Ver_Informacao_Veiculo());
        }

        //modificar
        private void Btn_Tela_Modificar_Veiculo_Click(object sender, EventArgs e)
        {
            this.Close();
            Tela = new Thread(Abrir_Tela_Modificar_Veiculo);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }
        private void Abrir_Tela_Modificar_Veiculo()
        {
            Application.Run(new Tela_Pesquisar_Veiculo());
        }

        //deletar
        private void Btn_Tela_Deletar_Veiculo_Click(object sender, EventArgs e)
        {
            this.Close();
            Tela = new Thread(Abrir_Tela_Deletar_Veiculo);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }
        private void Abrir_Tela_Deletar_Veiculo()
        {
            Application.Run(new Telas_Veiculo.Tela_Deletar_Veiculo());
        }
    }
}
