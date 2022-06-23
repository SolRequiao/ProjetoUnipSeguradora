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
    public partial class Tela_Principal_Apolice : Form
    {

        Thread Tela;

        public Tela_Principal_Apolice()
        {
            InitializeComponent();
        }

        private void Btn_Ver_Informacao_Apolice_Click(object sender, EventArgs e)
        {
            this.Close();
            Tela = new Thread(Abrir_Tela_Ver_Informacao_Apolice);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }


        private void Abrir_Tela_Ver_Informacao_Apolice()
        {
            Application.Run(new Telas_Apolice.Tela_Ver_Informacao_Apolice());
        }

        private void Btn_Cadastrar_Apolice_Click(object sender, EventArgs e)
        {
            this.Close();
            Tela = new Thread(Abrir_Tela_Cadastrar_Apolice);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }
        private void Abrir_Tela_Cadastrar_Apolice()
        {
            Application.Run(new Telas_Apolice.Tela_Cadastrar_Apolice());
        }

        private void Btn_Deletar_Apolice_Click(object sender, EventArgs e)
        {
            this.Close();
            Tela = new Thread(Abrir_Tela_Deletar_Apolice);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }
        private void Abrir_Tela_Deletar_Apolice()
        {
            Application.Run(new Telas_Apolice.Tela_Deletar_Apolice());
        }

        private void Btn_Mudar_Status_Apolice_Click(object sender, EventArgs e)
        {
            this.Close();
            Tela = new Thread(Abrir_Tela_Mudar_Status_Apolice);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }
        private void Abrir_Tela_Mudar_Status_Apolice()
        {
            Application.Run(new Telas_Apolice.Tela_Modificar_Apolice());
        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
