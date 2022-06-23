using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguradora_Pim.Telas_Segurado
{
    public partial class Tela_Principal_Segurado : Form
    {

        Thread? Tela;

        public Tela_Principal_Segurado()
        {
            InitializeComponent();
        }

        //cadastrar
        private void Btn_Tela_Cadastrar_Segurado_Click(object sender, EventArgs e)
        {
            this.Close();
            Tela = new Thread(Abrir_Tela_Cadastrar_Segurado);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }
        private void Abrir_Tela_Cadastrar_Segurado()
        {
            Application.Run(new Telas_Segurado.Tela_Cadastrar_Segurado());
        }

        //ver informacao
        private void Btn_Tela_Ver_Informacao_Segurado_Click(object sender, EventArgs e)
        {
            this.Close();
            Tela = new Thread(Abrir_Tela_Ver_Informacao_Segurado);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }
        private void Abrir_Tela_Ver_Informacao_Segurado()
        {
            Application.Run(new Telas_Segurado.Tela_Ver_Informacao_Segurado());
        }

        //modificar
        private void Btn_Tela_Modificar_Segurado_Click(object sender, EventArgs e)
        {
            this.Close();
            Tela = new Thread(Abrir_Tela_Modificar_Segurado);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }
        private void Abrir_Tela_Modificar_Segurado()
        {
            Application.Run(new Telas_Segurado.Tela_Pesquisar_Segurado());
        }

        //deletar
        private void Btn_Tela_Deletar_Segurado_Click(object sender, EventArgs e)
        {
            this.Close();
            Tela = new Thread(Abrir_Tela_Deletar_Segurado);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }
        private void Abrir_Tela_Deletar_Segurado()
        {
            Application.Run(new Telas_Segurado.Tela_Deletar_Segurado());
        }
    }
}
