﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Seguradora_Pim.Telas_Segurado {
    public partial class Tela_Pesquisar_Segurado : Form {

        Thread? Tela;

        public Tela_Pesquisar_Segurado() {
            InitializeComponent();
        }

        private void Botao_Cancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Botao_Pesquisar_Click(object sender, EventArgs e) {
            this.Close();
            Tela = new Thread(abrir_tela_modificar);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }

        private void abrir_tela_modificar() {
            MaskedTextBox_Cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Tela_Modificar_Segurado obj_mod_segurado = new Tela_Modificar_Segurado(MaskedTextBox_Cpf.Text);
            Application.Run(obj_mod_segurado);
        }

        private void MaskedTextBox_Cpf_Enter(object sender, EventArgs e) {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                MaskedTextBox_Cpf.Select(0, 0);
            });
        }
    }
}
