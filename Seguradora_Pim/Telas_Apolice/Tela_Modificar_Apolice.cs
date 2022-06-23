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
    public partial class Tela_Modificar_Apolice : Form
    {
        public Tela_Modificar_Apolice()
        {
            InitializeComponent();
            Banco_Telas_Apolice banco = new Banco_Telas_Apolice();
            Array array = banco.ArrayStatusApolice();

            foreach (var item in array)
            {
                comboBox_Mudar_Status_Apolice.Items.Add(item);

            }
        }

        private async void Btn_Mudar_Status_Apolice_Click(object sender, EventArgs e)
        {
            try
            {
                Apolice obj_apolice = new Apolice(Convert.ToInt32(textBox_Id_Apolice.Text));
                await obj_apolice.Modificar_Apolice(comboBox_Mudar_Status_Apolice.SelectedItem.ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show("Algo deu errado, por favor tente novamente.", "Ops...");
            }
            
        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
