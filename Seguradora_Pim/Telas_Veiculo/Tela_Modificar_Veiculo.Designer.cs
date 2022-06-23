namespace Seguradora_Pim.Telas_Veiculo
{
    partial class Tela_Modificar_Veiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Modificar_Veiculo));
            this.Cabecalho = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Titulo_Cabecalho = new System.Windows.Forms.Label();
            this.Btn_Modificar_Veiculo = new System.Windows.Forms.Button();
            this.textBox_Utilizacao = new System.Windows.Forms.TextBox();
            this.comboBox_Combustivel = new System.Windows.Forms.ComboBox();
            this.textBox_Km = new System.Windows.Forms.TextBox();
            this.textBox_Renavam = new System.Windows.Forms.TextBox();
            this.textBox_Placa = new System.Windows.Forms.TextBox();
            this.comboBox_Categoria = new System.Windows.Forms.ComboBox();
            this.comboBox_Marca = new System.Windows.Forms.ComboBox();
            this.textBox_Ano = new System.Windows.Forms.TextBox();
            this.textBox_Modelo = new System.Windows.Forms.TextBox();
            this.textBox_Codigo_Fipe = new System.Windows.Forms.TextBox();
            this.Cabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cabecalho
            // 
            this.Cabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.Cabecalho.Controls.Add(this.pictureBox1);
            this.Cabecalho.Controls.Add(this.Titulo_Cabecalho);
            this.Cabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cabecalho.Location = new System.Drawing.Point(0, 0);
            this.Cabecalho.Margin = new System.Windows.Forms.Padding(0, 0, 0, 60);
            this.Cabecalho.Name = "Cabecalho";
            this.Cabecalho.Size = new System.Drawing.Size(829, 91);
            this.Cabecalho.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 51);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Titulo_Cabecalho
            // 
            this.Titulo_Cabecalho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Titulo_Cabecalho.AutoSize = true;
            this.Titulo_Cabecalho.BackColor = System.Drawing.Color.Transparent;
            this.Titulo_Cabecalho.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titulo_Cabecalho.ForeColor = System.Drawing.Color.White;
            this.Titulo_Cabecalho.Location = new System.Drawing.Point(261, 34);
            this.Titulo_Cabecalho.Name = "Titulo_Cabecalho";
            this.Titulo_Cabecalho.Size = new System.Drawing.Size(307, 23);
            this.Titulo_Cabecalho.TabIndex = 1;
            this.Titulo_Cabecalho.Text = "Sistema de Gerenciamento de Apólices";
            // 
            // Btn_Modificar_Veiculo
            // 
            this.Btn_Modificar_Veiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.Btn_Modificar_Veiculo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.Btn_Modificar_Veiculo.FlatAppearance.BorderSize = 3;
            this.Btn_Modificar_Veiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Modificar_Veiculo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Modificar_Veiculo.ForeColor = System.Drawing.Color.White;
            this.Btn_Modificar_Veiculo.Location = new System.Drawing.Point(637, 360);
            this.Btn_Modificar_Veiculo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Modificar_Veiculo.Name = "Btn_Modificar_Veiculo";
            this.Btn_Modificar_Veiculo.Size = new System.Drawing.Size(117, 48);
            this.Btn_Modificar_Veiculo.TabIndex = 28;
            this.Btn_Modificar_Veiculo.Text = "Modificar";
            this.Btn_Modificar_Veiculo.UseVisualStyleBackColor = false;
            this.Btn_Modificar_Veiculo.Click += new System.EventHandler(this.Btn_Modificar_Veiculo_Click);
            // 
            // textBox_Utilizacao
            // 
            this.textBox_Utilizacao.BackColor = System.Drawing.Color.White;
            this.textBox_Utilizacao.Location = new System.Drawing.Point(266, 300);
            this.textBox_Utilizacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Utilizacao.Name = "textBox_Utilizacao";
            this.textBox_Utilizacao.PlaceholderText = "Utilização";
            this.textBox_Utilizacao.Size = new System.Drawing.Size(137, 27);
            this.textBox_Utilizacao.TabIndex = 27;
            // 
            // comboBox_Combustivel
            // 
            this.comboBox_Combustivel.BackColor = System.Drawing.Color.White;
            this.comboBox_Combustivel.FormattingEnabled = true;
            this.comboBox_Combustivel.Location = new System.Drawing.Point(88, 299);
            this.comboBox_Combustivel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_Combustivel.Name = "comboBox_Combustivel";
            this.comboBox_Combustivel.Size = new System.Drawing.Size(137, 28);
            this.comboBox_Combustivel.TabIndex = 26;
            this.comboBox_Combustivel.Text = "Combustível";
            // 
            // textBox_Km
            // 
            this.textBox_Km.BackColor = System.Drawing.Color.White;
            this.textBox_Km.Location = new System.Drawing.Point(617, 233);
            this.textBox_Km.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Km.Name = "textBox_Km";
            this.textBox_Km.PlaceholderText = "Km rodado";
            this.textBox_Km.Size = new System.Drawing.Size(137, 27);
            this.textBox_Km.TabIndex = 25;
            // 
            // textBox_Renavam
            // 
            this.textBox_Renavam.BackColor = System.Drawing.Color.White;
            this.textBox_Renavam.Location = new System.Drawing.Point(441, 234);
            this.textBox_Renavam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Renavam.Name = "textBox_Renavam";
            this.textBox_Renavam.PlaceholderText = "Renavam";
            this.textBox_Renavam.Size = new System.Drawing.Size(137, 27);
            this.textBox_Renavam.TabIndex = 23;
            // 
            // textBox_Placa
            // 
            this.textBox_Placa.BackColor = System.Drawing.Color.White;
            this.textBox_Placa.Location = new System.Drawing.Point(266, 233);
            this.textBox_Placa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Placa.Name = "textBox_Placa";
            this.textBox_Placa.PlaceholderText = "Placa";
            this.textBox_Placa.Size = new System.Drawing.Size(137, 27);
            this.textBox_Placa.TabIndex = 22;
            // 
            // comboBox_Categoria
            // 
            this.comboBox_Categoria.BackColor = System.Drawing.Color.White;
            this.comboBox_Categoria.FormattingEnabled = true;
            this.comboBox_Categoria.Location = new System.Drawing.Point(88, 233);
            this.comboBox_Categoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_Categoria.Name = "comboBox_Categoria";
            this.comboBox_Categoria.Size = new System.Drawing.Size(137, 28);
            this.comboBox_Categoria.TabIndex = 21;
            this.comboBox_Categoria.Text = "Categoria";
            // 
            // comboBox_Marca
            // 
            this.comboBox_Marca.BackColor = System.Drawing.Color.White;
            this.comboBox_Marca.FormattingEnabled = true;
            this.comboBox_Marca.ItemHeight = 20;
            this.comboBox_Marca.Location = new System.Drawing.Point(617, 168);
            this.comboBox_Marca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_Marca.Name = "comboBox_Marca";
            this.comboBox_Marca.Size = new System.Drawing.Size(137, 28);
            this.comboBox_Marca.TabIndex = 20;
            this.comboBox_Marca.Tag = "";
            this.comboBox_Marca.Text = "Marca";
            // 
            // textBox_Ano
            // 
            this.textBox_Ano.BackColor = System.Drawing.Color.White;
            this.textBox_Ano.Location = new System.Drawing.Point(441, 168);
            this.textBox_Ano.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Ano.Name = "textBox_Ano";
            this.textBox_Ano.PlaceholderText = "Ano";
            this.textBox_Ano.Size = new System.Drawing.Size(137, 27);
            this.textBox_Ano.TabIndex = 19;
            // 
            // textBox_Modelo
            // 
            this.textBox_Modelo.BackColor = System.Drawing.Color.White;
            this.textBox_Modelo.Location = new System.Drawing.Point(266, 168);
            this.textBox_Modelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Modelo.Name = "textBox_Modelo";
            this.textBox_Modelo.PlaceholderText = "Modelo do Veiculo";
            this.textBox_Modelo.Size = new System.Drawing.Size(137, 27);
            this.textBox_Modelo.TabIndex = 17;
            // 
            // textBox_Codigo_Fipe
            // 
            this.textBox_Codigo_Fipe.BackColor = System.Drawing.Color.White;
            this.textBox_Codigo_Fipe.Location = new System.Drawing.Point(88, 168);
            this.textBox_Codigo_Fipe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Codigo_Fipe.Name = "textBox_Codigo_Fipe";
            this.textBox_Codigo_Fipe.PlaceholderText = "Código Fipe";
            this.textBox_Codigo_Fipe.Size = new System.Drawing.Size(137, 27);
            this.textBox_Codigo_Fipe.TabIndex = 16;
            // 
            // Tela_Modificar_Veiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 533);
            this.Controls.Add(this.Btn_Modificar_Veiculo);
            this.Controls.Add(this.textBox_Utilizacao);
            this.Controls.Add(this.comboBox_Combustivel);
            this.Controls.Add(this.textBox_Km);
            this.Controls.Add(this.textBox_Renavam);
            this.Controls.Add(this.textBox_Placa);
            this.Controls.Add(this.comboBox_Categoria);
            this.Controls.Add(this.comboBox_Marca);
            this.Controls.Add(this.textBox_Ano);
            this.Controls.Add(this.textBox_Modelo);
            this.Controls.Add(this.textBox_Codigo_Fipe);
            this.Controls.Add(this.Cabecalho);
            this.Name = "Tela_Modificar_Veiculo";
            this.Text = "Tela_Modificar_Veiculo";
            this.Load += new System.EventHandler(this.Tela_Modificar_Veiculo_Load);
            this.Cabecalho.ResumeLayout(false);
            this.Cabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel Cabecalho;
        private PictureBox pictureBox1;
        private Label Titulo_Cabecalho;
        private Button Btn_Modificar_Veiculo;
        private TextBox textBox_Utilizacao;
        private ComboBox comboBox_Combustivel;
        private TextBox textBox_Km;
        private TextBox textBox_Renavam;
        private TextBox textBox_Placa;
        private ComboBox comboBox_Categoria;
        private ComboBox comboBox_Marca;
        private TextBox textBox_Ano;
        private TextBox textBox_Modelo;
        private TextBox textBox_Codigo_Fipe;
    }
}