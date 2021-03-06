namespace Seguradora_Pim.Telas_Segurado {
    partial class Tela_Pesquisar_Segurado {
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
            this.MaskedTextBox_Cpf = new System.Windows.Forms.MaskedTextBox();
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
            this.Container_Principal.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.Container_Principal.Name = "Container_Principal";
            this.Container_Principal.Size = new System.Drawing.Size(724, 524);
            this.Container_Principal.TabIndex = 1;
            // 
            // Formulario
            // 
            this.Formulario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Formulario.Controls.Add(this.Group_Pesquisa);
            this.Formulario.Controls.Add(this.Botao_Cancelar);
            this.Formulario.Controls.Add(this.Botao_Pesquisar);
            this.Formulario.Location = new System.Drawing.Point(143, 195);
            this.Formulario.Name = "Formulario";
            this.Formulario.Size = new System.Drawing.Size(445, 134);
            this.Formulario.TabIndex = 8;
            // 
            // Group_Pesquisa
            // 
            this.Group_Pesquisa.Controls.Add(this.Label_Pesquisa);
            this.Group_Pesquisa.Controls.Add(this.MaskedTextBox_Cpf);
            this.Group_Pesquisa.Location = new System.Drawing.Point(0, 0);
            this.Group_Pesquisa.Margin = new System.Windows.Forms.Padding(0);
            this.Group_Pesquisa.Name = "Group_Pesquisa";
            this.Group_Pesquisa.Size = new System.Drawing.Size(445, 79);
            this.Group_Pesquisa.TabIndex = 7;
            // 
            // Label_Pesquisa
            // 
            this.Label_Pesquisa.AutoSize = true;
            this.Label_Pesquisa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Pesquisa.Location = new System.Drawing.Point(0, 0);
            this.Label_Pesquisa.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.Label_Pesquisa.Name = "Label_Pesquisa";
            this.Label_Pesquisa.Size = new System.Drawing.Size(115, 19);
            this.Label_Pesquisa.TabIndex = 0;
            this.Label_Pesquisa.Text = "CPF do Segurado";
            this.Label_Pesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MaskedTextBox_Cpf
            // 
            this.MaskedTextBox_Cpf.AccessibleDescription = "";
            this.MaskedTextBox_Cpf.AccessibleName = "";
            this.MaskedTextBox_Cpf.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.MaskedTextBox_Cpf.Culture = new System.Globalization.CultureInfo("");
            this.MaskedTextBox_Cpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.MaskedTextBox_Cpf.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaskedTextBox_Cpf.HidePromptOnLeave = true;
            this.MaskedTextBox_Cpf.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.MaskedTextBox_Cpf.Location = new System.Drawing.Point(3, 30);
            this.MaskedTextBox_Cpf.Mask = "000.000.000-00";
            this.MaskedTextBox_Cpf.Name = "MaskedTextBox_Cpf";
            this.MaskedTextBox_Cpf.PromptChar = ' ';
            this.MaskedTextBox_Cpf.Size = new System.Drawing.Size(438, 26);
            this.MaskedTextBox_Cpf.TabIndex = 1;
            this.MaskedTextBox_Cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
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
            this.Botao_Cancelar.Location = new System.Drawing.Point(0, 79);
            this.Botao_Cancelar.Margin = new System.Windows.Forms.Padding(0, 0, 88, 0);
            this.Botao_Cancelar.Name = "Botao_Cancelar";
            this.Botao_Cancelar.Size = new System.Drawing.Size(175, 45);
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
            this.Botao_Pesquisar.Location = new System.Drawing.Point(263, 79);
            this.Botao_Pesquisar.Margin = new System.Windows.Forms.Padding(0);
            this.Botao_Pesquisar.Name = "Botao_Pesquisar";
            this.Botao_Pesquisar.Size = new System.Drawing.Size(175, 45);
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
            this.Titulo_Tela.Location = new System.Drawing.Point(285, 112);
            this.Titulo_Tela.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.Titulo_Tela.Name = "Titulo_Tela";
            this.Titulo_Tela.Size = new System.Drawing.Size(128, 19);
            this.Titulo_Tela.TabIndex = 3;
            this.Titulo_Tela.Text = "Modificar Segurado";
            // 
            // Cabecalho
            // 
            this.Cabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.Cabecalho.Controls.Add(this.Titulo_Cabecalho);
            this.Cabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cabecalho.Location = new System.Drawing.Point(0, 0);
            this.Cabecalho.Margin = new System.Windows.Forms.Padding(0, 0, 0, 45);
            this.Cabecalho.Name = "Cabecalho";
            this.Cabecalho.Size = new System.Drawing.Size(724, 68);
            this.Cabecalho.TabIndex = 0;
            // 
            // Titulo_Cabecalho
            // 
            this.Titulo_Cabecalho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Titulo_Cabecalho.AutoSize = true;
            this.Titulo_Cabecalho.BackColor = System.Drawing.Color.Transparent;
            this.Titulo_Cabecalho.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titulo_Cabecalho.ForeColor = System.Drawing.Color.White;
            this.Titulo_Cabecalho.Location = new System.Drawing.Point(228, 23);
            this.Titulo_Cabecalho.Name = "Titulo_Cabecalho";
            this.Titulo_Cabecalho.Size = new System.Drawing.Size(245, 19);
            this.Titulo_Cabecalho.TabIndex = 1;
            this.Titulo_Cabecalho.Text = "Sistema de Gerenciamento de Apólices";
            // 
            // Tela_Pesquisar_Segurado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 524);
            this.Controls.Add(this.Container_Principal);
            this.Name = "Tela_Pesquisar_Segurado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGAP";
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
        private System.Windows.Forms.MaskedTextBox MaskedTextBox_Cpf;
    }
}