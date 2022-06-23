using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguradora_Pim.Telas_Funcionario
{
    public partial class Tela_Principal_Funcionario : Form
    {

        Thread? Tela;

        public Tela_Principal_Funcionario()
        {
            InitializeComponent();
        }

        //cadastrar;
        private void Btn_Tela_Cadastrar_Funcionario_Click(object sender, EventArgs e)
        {
            this.Close();
            Tela = new Thread(Abrir_Tela_Cadastrar_Funcionario);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();

        }
        private void Abrir_Tela_Cadastrar_Funcionario()
        {
            Application.Run(new Telas_Funcionario.Tela_Cadastrar_Funcionario());
        }

        //ver informacao
        private void Btn_Tela_Ver_Informacao_Funcionario_Click(object sender, EventArgs e)
        {
            this.Close();
            Tela = new Thread(Abrir_Tela_Informacao_Funcionario);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }
        private void Abrir_Tela_Informacao_Funcionario()
        {
            Application.Run(new Telas_Funcionario.Tela_Ver_Informacao_Funcionario());
        }

        //modificar
        private void Btn_Tela_Modificar_Funcionario_Click(object sender, EventArgs e) {
            //modificar
            this.Close();
            Tela = new Thread(abrir_tela_pesquisa);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
            
        }

        private void abrir_tela_pesquisa() {
            Application.Run(new Tela_Pesquisar_Funcionario());
        }

        //deletar
        private void Btn_Tela_Deletar_Funcionario_Click(object sender, EventArgs e)
        {
            //Deletar
            this.Close();
            Tela = new Thread(abrir_tela_pesquisa_2);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }

        private void abrir_tela_pesquisa_2() {
            Application.Run(new Tela_Deletar_Funcionario());
        }

    }
}
