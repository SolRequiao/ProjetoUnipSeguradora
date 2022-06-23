namespace Seguradora_Pim.Telas_Veiculo {
    partial class Tela_Pesquisar_Veiculo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Container_Principal = new System.Windows.Forms.Panel();
            this.Formulario = new System.Windows.Forms.FlowLayoutPanel();
            this.Group_Pesquisa = new System.Windows.Forms.FlowLayoutPanel();
            this.Label_Pesquisa = new System.Windows.Forms.Label();
            this.MaskedTextBox_Placa = new System.Windows.Forms.MaskedTextBox();
            this.Botao_Cancelar = new System.Windows.Forms.Button();
            this.Botao_Pesquisar = new System.Windows.Forms.Button();
            this.Titulo_Tela = new System.Windows.Forms.Label();
            this.Cabecalho = new System.Windows.Forms.Panel();
            this.Titulo_Cabecalho = new System.Windows.Forms.Label();
            this.Container_Principal.SuspendLayout();
            this.Formulario.SuspendLayout();
            this.Group_Pesquisa.SuspendLayout();
            this.Cabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // Container_Principal
            // 
            this.Container_Principal.AutoScroll = true;
            this.Container_Principal.AutoSize = true;
            this.Container_Principal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Container_Principal.Controls.Add(this.Formulario);
            this.Container_Principal.Controls.Add(this.Titulo_Tela);
            this.Container_Principal.Controls.Add(this.Cabecalho);
            this.Container_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container_Principal.Location = new System.Drawing.Point(0, 0);
            this.Container_Principal.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.Container_Principal.Name = "Container_Principal";
            this.Container_Principal.Size = new System.Drawing.Size(827, 698);
            this.Container_Principal.TabIndex = 1;
            // 
            // Formulario
            // 
            this.Formulario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Formulario.Controls.Add(this.Group_Pesquisa);
            this.Formulario.Controls.Add(this.Botao_Cancelar);
            this.Formulario.Controls.Add(this.Botao_Pesquisar);
            this.Formulario.Location = new System.Drawing.Point(163, 260);
            this.Formulario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Formulario.Name = "Formulario";
            this.Formulario.Size = new System.Drawing.Size(509, 179);
            this.Formulario.TabIndex = 8;
            // 
            // Group_Pesquisa
            // 
            this.Group_Pesquisa.Controls.Add(this.Label_Pesquisa);
            this.Group_Pesquisa.Controls.Add(this.MaskedTextBox_Placa);
            this.Group_Pesquisa.Location = new System.Drawing.Point(0, 0);
            this.Group_Pesquisa.Margin = new System.Windows.Forms.Padding(0);
            this.Group_Pesquisa.Name = "Group_Pesquisa";
            this.Group_Pesquisa.Size = new System.Drawing.Size(509, 105);
            this.Group_Pesquisa.TabIndex = 7;
            // 
            // Label_Pesquisa
            // 
            this.Label_Pesquisa.AutoSize = true;
            this.Label_Pesquisa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Pesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.Label_Pesquisa.Location = new System.Drawing.Point(0, 0);
            this.Label_Pesquisa.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Label_Pesquisa.Name = "Label_Pesquisa";
            this.Label_Pesquisa.Size = new System.Drawing.Size(133, 23);
            this.Label_Pesquisa.TabIndex = 0;
            this.Label_Pesquisa.Text = "Placa do veículo";
            this.Label_Pesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MaskedTextBox_Placa
            // 
            this.MaskedTextBox_Placa.AccessibleDescription = "";
            this.MaskedTextBox_Placa.AccessibleName = "";
            this.MaskedTextBox_Placa.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.MaskedTextBox_Placa.Culture = new System.Globalization.CultureInfo("");
            this.MaskedTextBox_Placa.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.MaskedTextBox_Placa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaskedTextBox_Placa.HidePromptOnLeave = true;
            this.MaskedTextBox_Placa.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.MaskedTextBox_Placa.Location = new System.Drawing.Point(3, 37);
            this.MaskedTextBox_Placa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaskedTextBox_Placa.Name = "MaskedTextBox_Placa";
            this.MaskedTextBox_Placa.PromptChar = ' ';
            this.MaskedTextBox_Placa.Size = new System.Drawing.Size(500, 30);
            this.MaskedTextBox_Placa.TabIndex = 2;
            this.MaskedTextBox_Placa.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // Botao_Cancelar
            // 
            this.Botao_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Botao_Cancelar.AutoEllipsis = true;
            this.Botao_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.Botao_Cancelar.FlatAppearance.BorderSize = 0;
            this.Botao_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Cancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Botao_Cancelar.ForeColor = System.Drawing.Color.White;
            this.Botao_Cancelar.Location = new System.Drawing.Point(0, 105);
            this.Botao_Cancelar.Margin = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.Botao_Cancelar.Name = "Botao_Cancelar";
            this.Botao_Cancelar.Size = new System.Drawing.Size(200, 60);
            this.Botao_Cancelar.TabIndex = 12;
            this.Botao_Cancelar.Text = "Cancelar";
            this.Botao_Cancelar.UseVisualStyleBackColor = false;
            this.Botao_Cancelar.Click += new System.EventHandler(this.Botao_Cancelar_Click);
            // 
            // Botao_Pesquisar
            // 
            this.Botao_Pesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Botao_Pesquisar.AutoEllipsis = true;
            this.Botao_Pesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.Botao_Pesquisar.FlatAppearance.BorderSize = 0;
            this.Botao_Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Pesquisar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Botao_Pesquisar.ForeColor = System.Drawing.Color.White;
            this.Botao_Pesquisar.Location = new System.Drawing.Point(300, 105);
            this.Botao_Pesquisar.Margin = new System.Windows.Forms.Padding(0);
            this.Botao_Pesquisar.Name = "Botao_Pesquisar";
            this.Botao_Pesquisar.Size = new System.Drawing.Size(200, 60);
            this.Botao_Pesquisar.TabIndex = 13;
            this.Botao_Pesquisar.Text = "Pesquisar";
            this.Botao_Pesquisar.UseVisualStyleBackColor = false;
            this.Botao_Pesquisar.Click += new System.EventHandler(this.Botao_Pesquisar_Click);
            // 
            // Titulo_Tela
            // 
            this.Titulo_Tela.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Titulo_Tela.AutoSize = true;
            this.Titulo_Tela.BackColor = System.Drawing.Color.Transparent;
            this.Titulo_Tela.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titulo_Tela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.Titulo_Tela.Location = new System.Drawing.Point(343, 150);
            this.Titulo_Tela.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.Titulo_Tela.Name = "Titulo_Tela";
            this.Titulo_Tela.Size = new System.Drawing.Size(141, 23);
            this.Titulo_Tela.TabIndex = 3;
            this.Titulo_Tela.Text = "Modificar Veículo";
            // 
            // Cabecalho
            // 
            this.Cabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.Cabecalho.Controls.Add(this.Titulo_Cabecalho);
            this.Cabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cabecalho.Location = new System.Drawing.Point(0, 0);
            this.Cabecalho.Margin = new System.Windows.Forms.Padding(0, 0, 0, 60);
            this.Cabecalho.Name = "Cabecalho";
            this.Cabecalho.Size = new System.Drawing.Size(827, 90);
            this.Cabecalho.TabIndex = 0;
            // 
            // Titulo_Cabecalho
            // 
            this.Titulo_Cabecalho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Titulo_Cabecalho.AutoSize = true;
            this.Titulo_Cabecalho.BackColor = System.Drawing.Color.Transparent;
            this.Titulo_Cabecalho.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titulo_Cabecalho.ForeColor = System.Drawing.Color.White;
            this.Titulo_Cabecalho.Location = new System.Drawing.Point(260, 31);
            this.Titulo_Cabecalho.Name = "Titulo_Cabecalho";
            this.Titulo_Cabecalho.Size = new System.Drawing.Size(307, 23);
            this.Titulo_Cabecalho.TabIndex = 1;
            this.Titulo_Cabecalho.Text = "Sistema de Gerenciamento de Apólices";
            // 
            // Tela_Pesquisar_Veiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 698);
            this.Controls.Add(this.Container_Principal);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Tela_Pesquisar_Veiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Veículo";
            this.Container_Principal.ResumeLayout(false);
            this.Container_Principal.PerformLayout();
            this.Formulario.ResumeLayout(false);
            this.Group_Pesquisa.ResumeLayout(false);
            this.Group_Pesquisa.PerformLayout();
            this.Cabecalho.ResumeLayout(false);
            this.Cabecalho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Container_Principal;
        private System.Windows.Forms.Label Titulo_Tela;
        private System.Windows.Forms.Panel Cabecalho;
        private System.Windows.Forms.Label Titulo_Cabecalho;
        private System.Windows.Forms.FlowLayoutPanel Group_Pesquisa;
        private System.Windows.Forms.Label Label_Pesquisa;
        private System.Windows.Forms.FlowLayoutPanel Formulario;
        private System.Windows.Forms.Button Botao_Cancelar;
        private System.Windows.Forms.Button Botao_Pesquisar;
        private MaskedTextBox MaskedTextBox_Placa;
    }
}