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
    public partial class Tela_Principal_Cotacao : Form
    {

        Thread Tela;

        public Tela_Principal_Cotacao()
        {
            InitializeComponent();
        }

        //cadastrar
        private void Btn_Tela_Cadastrar_Cotacao_Click(object sender, EventArgs e)
        {
            this.Close();
            Tela = new Thread(Abrir_Tela_Cadastrar_Cotacao);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }
        private void Abrir_Tela_Cadastrar_Cotacao()
        {
            Application.Run(new Telas_Cotacao.Tela_Cadastrar_Cotacao());
        }

        //ver informacao
        private void Btn_Tela_Ver_Informacao_Cotacao_Click(object sender, EventArgs e)
        {
            this.Close();
            Tela = new Thread(Abrir_Tela_Ver_Informacao_Cotacao);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }
        private void Abrir_Tela_Ver_Informacao_Cotacao()
        {
            Application.Run(new Telas_Cotacao.Tela_Ver_Informacao_Cotacao());
        }

        //modificar
        private void Btn_Tela_Modificar_Cotacao_Click(object sender, EventArgs e)
        {
            this.Close();
            Tela = new Thread(Abrir_Tela_Modificar_Cotacao);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }
        private void Abrir_Tela_Modificar_Cotacao()
        {
            Application.Run(new Tela_Pesquisar_Cotacao());
        }

        //aprovar
        private void Btn_Tela_Aprovar_Contacao_Click(object sender, EventArgs e)
        {
            this.Close();
            Tela = new Thread(Abrir_Tela_Aprovar_Contacao);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }
        private void Abrir_Tela_Aprovar_Contacao()
        {
            Application.Run(new Telas_Cotacao.Tela_Aprovar_Cotacao());
        }

        //negar
        private void Btn_Tela_Negar_Cotacao_Click(object sender, EventArgs e)
        {
            this.Close();
            Tela = new Thread(Abrir_Tela_Negar_Cotacao);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }
        private void Abrir_Tela_Negar_Cotacao()
        {
            Application.Run(new Telas_Cotacao.Tela_Negar_Cotacao());
        }

        //deletar
        private void Btn_Tela_Deletar_Cotacao_Click(object sender, EventArgs e)
        {
            this.Close();
            Tela = new Thread(Abrir_Tela_Deletar_Cotacao);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }
        private void Abrir_Tela_Deletar_Cotacao()
        {
            Application.Run(new Telas_Cotacao.Tela_Deletar_Cotacao());
        }
    }
}
