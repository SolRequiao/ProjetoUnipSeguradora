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

namespace Seguradora_Pim.Telas_Apolice
{
    public partial class Tela_Ver_Informacao_Apolice : Form
    {

        string Acesso = "Host = localhost; Username = postgres; Password = 12121110; Database = db_seguradora";

        public Tela_Ver_Informacao_Apolice()
        {
            InitializeComponent();
        }

        private async void Btn_Pesquisar_Apolice_Click(object sender, EventArgs e)
        {
            try
            {
                Apolice obj_apolice = new Apolice(Convert.ToInt32(textBox_Pesquisar_Apolice.Text));
                
                NpgsqlDataAdapter data_adapter_apolice = await obj_apolice.Listar_Apolice();

                DataTable apolice = new DataTable();

                data_adapter_apolice.Fill(apolice);

                dataGridView_Pesquisar_Apolice.DataSource = apolice;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Algo deu errado, por favor tente novamente.", "Ops...");
            }
        }
    }
}
