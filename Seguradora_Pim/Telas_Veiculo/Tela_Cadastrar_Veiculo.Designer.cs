namespace Seguradora_Pim.Telas_Veiculo
{
    partial class Tela_Cadastrar_Veiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Cadastrar_Veiculo));
            this.textBox_Id_Segurado = new System.Windows.Forms.TextBox();
            this.textBox_Codigo_Fipe = new System.Windows.Forms.TextBox();
            this.textBox_Modelo = new System.Windows.Forms.TextBox();
            this.textBox_Ano = new System.Windows.Forms.TextBox();
            this.comboBox_Marca = new System.Windows.Forms.ComboBox();
            this.comboBox_Categoria = new System.Windows.Forms.ComboBox();
            this.textBox_Placa = new System.Windows.Forms.TextBox();
            this.textBox_Renavam = new System.Windows.Forms.TextBox();
            this.textBox_Zero_Km = new System.Windows.Forms.TextBox();
            this.textBox_Km = new System.Windows.Forms.TextBox();
            this.comboBox_Combustivel = new System.Windows.Forms.ComboBox();
            this.textBox_Utilizacao = new System.Windows.Forms.TextBox();
            this.Btn_Cadastrar_Veiculo = new System.Windows.Forms.Button();
            this.dataGridView_Buscar_Segurado = new System.Windows.Forms.DataGridView();
            this.Btn_Buscar_Segurado = new System.Windows.Forms.Button();
            this.textBox_Buscar_Segurado = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Buscar_Segurado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Id_Segurado
            // 
            this.textBox_Id_Segurado.BackColor = System.Drawing.Color.White;
            this.textBox_Id_Segurado.Location = new System.Drawing.Point(506, 529);
            this.textBox_Id_Segurado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Id_Segurado.Name = "textBox_Id_Segurado";
            this.textBox_Id_Segurado.PlaceholderText = "Id Segurado";
            this.textBox_Id_Segurado.Size = new System.Drawing.Size(137, 27);
            this.textBox_Id_Segurado.TabIndex = 5;
            // 
            // textBox_Codigo_Fipe
            // 
            this.textBox_Codigo_Fipe.BackColor = System.Drawing.Color.White;
            this.textBox_Codigo_Fipe.Location = new System.Drawing.Point(153, 529);
            this.textBox_Codigo_Fipe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Codigo_Fipe.Name = "textBox_Codigo_Fipe";
            this.textBox_Codigo_Fipe.PlaceholderText = "Código Fipe";
            this.textBox_Codigo_Fipe.Size = new System.Drawing.Size(137, 27);
            this.textBox_Codigo_Fipe.TabIndex = 3;
            // 
            // textBox_Modelo
            // 
            this.textBox_Modelo.BackColor = System.Drawing.Color.White;
            this.textBox_Modelo.Location = new System.Drawing.Point(331, 529);
            this.textBox_Modelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Modelo.Name = "textBox_Modelo";
            this.textBox_Modelo.PlaceholderText = "Modelo do Veiculo";
            this.textBox_Modelo.Size = new System.Drawing.Size(137, 27);
            this.textBox_Modelo.TabIndex = 4;
            this.textBox_Modelo.TextChanged += new System.EventHandler(this.textBox_Modelo_TextChanged);
            // 
            // textBox_Ano
            // 
            this.textBox_Ano.BackColor = System.Drawing.Color.White;
            this.textBox_Ano.Location = new System.Drawing.Point(682, 529);
            this.textBox_Ano.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Ano.Name = "textBox_Ano";
            this.textBox_Ano.PlaceholderText = "Ano";
            this.textBox_Ano.Size = new System.Drawing.Size(137, 27);
            this.textBox_Ano.TabIndex = 6;
            // 
            // comboBox_Marca
            // 
            this.comboBox_Marca.BackColor = System.Drawing.Color.White;
            this.comboBox_Marca.FormattingEnabled = true;
            this.comboBox_Marca.ItemHeight = 20;
            this.comboBox_Marca.Location = new System.Drawing.Point(153, 595);
            this.comboBox_Marca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_Marca.Name = "comboBox_Marca";
            this.comboBox_Marca.Size = new System.Drawing.Size(137, 28);
            this.comboBox_Marca.TabIndex = 7;
            this.comboBox_Marca.Tag = "";
            this.comboBox_Marca.Text = "Marca";
            // 
            // comboBox_Categoria
            // 
            this.comboBox_Categoria.BackColor = System.Drawing.Color.White;
            this.comboBox_Categoria.FormattingEnabled = true;
            this.comboBox_Categoria.Location = new System.Drawing.Point(331, 595);
            this.comboBox_Categoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_Categoria.Name = "comboBox_Categoria";
            this.comboBox_Categoria.Size = new System.Drawing.Size(137, 28);
            this.comboBox_Categoria.TabIndex = 8;
            this.comboBox_Categoria.Text = "Categoria";
            // 
            // textBox_Placa
            // 
            this.textBox_Placa.BackColor = System.Drawing.Color.White;
            this.textBox_Placa.Location = new System.Drawing.Point(506, 595);
            this.textBox_Placa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Placa.Name = "textBox_Placa";
            this.textBox_Placa.PlaceholderText = "Placa";
            this.textBox_Placa.Size = new System.Drawing.Size(137, 27);
            this.textBox_Placa.TabIndex = 9;
            // 
            // textBox_Renavam
            // 
            this.textBox_Renavam.BackColor = System.Drawing.Color.White;
            this.textBox_Renavam.Location = new System.Drawing.Point(682, 595);
            this.textBox_Renavam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Renavam.Name = "textBox_Renavam";
            this.textBox_Renavam.PlaceholderText = "Renavam";
            this.textBox_Renavam.Size = new System.Drawing.Size(137, 27);
            this.textBox_Renavam.TabIndex = 10;
            // 
            // textBox_Zero_Km
            // 
            this.textBox_Zero_Km.BackColor = System.Drawing.Color.White;
            this.textBox_Zero_Km.Location = new System.Drawing.Point(153, 660);
            this.textBox_Zero_Km.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Zero_Km.Name = "textBox_Zero_Km";
            this.textBox_Zero_Km.PlaceholderText = "Sim/Não";
            this.textBox_Zero_Km.Size = new System.Drawing.Size(137, 27);
            this.textBox_Zero_Km.TabIndex = 11;
            // 
            // textBox_Km
            // 
            this.textBox_Km.BackColor = System.Drawing.Color.White;
            this.textBox_Km.Location = new System.Drawing.Point(331, 660);
            this.textBox_Km.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Km.Name = "textBox_Km";
            this.textBox_Km.PlaceholderText = "Km rodado";
            this.textBox_Km.Size = new System.Drawing.Size(137, 27);
            this.textBox_Km.TabIndex = 12;
            // 
            // comboBox_Combustivel
            // 
            this.comboBox_Combustivel.BackColor = System.Drawing.Color.White;
            this.comboBox_Combustivel.FormattingEnabled = true;
            this.comboBox_Combustivel.Location = new System.Drawing.Point(506, 660);
            this.comboBox_Combustivel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_Combustivel.Name = "comboBox_Combustivel";
            this.comboBox_Combustivel.Size = new System.Drawing.Size(137, 28);
            this.comboBox_Combustivel.TabIndex = 13;
            this.comboBox_Combustivel.Text = "Combustível";
            // 
            // textBox_Utilizacao
            // 
            this.textBox_Utilizacao.BackColor = System.Drawing.Color.White;
            this.textBox_Utilizacao.Location = new System.Drawing.Point(682, 660);
            this.textBox_Utilizacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Utilizacao.Name = "textBox_Utilizacao";
            this.textBox_Utilizacao.PlaceholderText = "Utilização";
            this.textBox_Utilizacao.Size = new System.Drawing.Size(137, 27);
            this.textBox_Utilizacao.TabIndex = 14;
            // 
            // Btn_Cadastrar_Veiculo
            // 
            this.Btn_Cadastrar_Veiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.Btn_Cadastrar_Veiculo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.Btn_Cadastrar_Veiculo.FlatAppearance.BorderSize = 3;
            this.Btn_Cadastrar_Veiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cadastrar_Veiculo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Cadastrar_Veiculo.ForeColor = System.Drawing.Color.White;
            this.Btn_Cadastrar_Veiculo.Location = new System.Drawing.Point(856, 676);
            this.Btn_Cadastrar_Veiculo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Cadastrar_Veiculo.Name = "Btn_Cadastrar_Veiculo";
            this.Btn_Cadastrar_Veiculo.Size = new System.Drawing.Size(117, 48);
            this.Btn_Cadastrar_Veiculo.TabIndex = 15;
            this.Btn_Cadastrar_Veiculo.Text = "Cadastrar";
            this.Btn_Cadastrar_Veiculo.UseVisualStyleBackColor = false;
            this.Btn_Cadastrar_Veiculo.Click += new System.EventHandler(this.Btn_Cadastrar_Veiculo_Click);
            // 
            // dataGridView_Buscar_Segurado
            // 
            this.dataGridView_Buscar_Segurado.AllowUserToAddRows = false;
            this.dataGridView_Buscar_Segurado.AllowUserToDeleteRows = false;
            this.dataGridView_Buscar_Segurado.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Buscar_Segurado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Buscar_Segurado.GridColor = System.Drawing.Color.White;
            this.dataGridView_Buscar_Segurado.Location = new System.Drawing.Point(14, 85);
            this.dataGridView_Buscar_Segurado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_Buscar_Segurado.Name = "dataGridView_Buscar_Segurado";
            this.dataGridView_Buscar_Segurado.ReadOnly = true;
            this.dataGridView_Buscar_Segurado.RowHeadersWidth = 51;
            this.dataGridView_Buscar_Segurado.RowTemplate.Height = 25;
            this.dataGridView_Buscar_Segurado.Size = new System.Drawing.Size(976, 255);
            this.dataGridView_Buscar_Segurado.TabIndex = 13;
            // 
            // Btn_Buscar_Segurado
            // 
            this.Btn_Buscar_Segurado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.Btn_Buscar_Segurado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.Btn_Buscar_Segurado.FlatAppearance.BorderSize = 3;
            this.Btn_Buscar_Segurado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar_Segurado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Buscar_Segurado.ForeColor = System.Drawing.Color.White;
            this.Btn_Buscar_Segurado.Location = new System.Drawing.Point(240, 348);
            this.Btn_Buscar_Segurado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Buscar_Segurado.Name = "Btn_Buscar_Segurado";
            this.Btn_Buscar_Segurado.Size = new System.Drawing.Size(112, 48);
            this.Btn_Buscar_Segurado.TabIndex = 2;
            this.Btn_Buscar_Segurado.Text = "Pesquisar";
            this.Btn_Buscar_Segurado.UseVisualStyleBackColor = false;
            this.Btn_Buscar_Segurado.Click += new System.EventHandler(this.Btn_Buscar_Segurado_Click);
            // 
            // textBox_Buscar_Segurado
            // 
            this.textBox_Buscar_Segurado.BackColor = System.Drawing.Color.White;
            this.textBox_Buscar_Segurado.Location = new System.Drawing.Point(15, 365);
            this.textBox_Buscar_Segurado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Buscar_Segurado.Name = "textBox_Buscar_Segurado";
            this.textBox_Buscar_Segurado.PlaceholderText = "Buscar segurado pelo CPF";
            this.textBox_Buscar_Segurado.Size = new System.Drawing.Size(182, 27);
            this.textBox_Buscar_Segurado.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 77);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(384, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sistema de Gerenciamento de Apólices";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 77);
            this.panel1.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(205, 365);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 31);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // Tela_Cadastrar_Veiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 757);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_Buscar_Segurado);
            this.Controls.Add(this.Btn_Buscar_Segurado);
            this.Controls.Add(this.dataGridView_Buscar_Segurado);
            this.Controls.Add(this.Btn_Cadastrar_Veiculo);
            this.Controls.Add(this.textBox_Utilizacao);
            this.Controls.Add(this.comboBox_Combustivel);
            this.Controls.Add(this.textBox_Km);
            this.Controls.Add(this.textBox_Zero_Km);
            this.Controls.Add(this.textBox_Renavam);
            this.Controls.Add(this.textBox_Placa);
            this.Controls.Add(this.comboBox_Categoria);
            this.Controls.Add(this.comboBox_Marca);
            this.Controls.Add(this.textBox_Ano);
            this.Controls.Add(this.textBox_Modelo);
            this.Controls.Add(this.textBox_Codigo_Fipe);
            this.Controls.Add(this.textBox_Id_Segurado);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Tela_Cadastrar_Veiculo";
            this.Text = "Tela_Cadastrar_Veiculo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Buscar_Segurado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_Id_Segurado;
        private TextBox textBox_Codigo_Fipe;
        private TextBox textBox_Modelo;
        private TextBox textBox_Ano;
        private ComboBox comboBox_Marca;
        private ComboBox comboBox_Categoria;
        private TextBox textBox_Placa;
        private TextBox textBox_Renavam;
        private TextBox textBox_Zero_Km;
        private TextBox textBox_Km;
        private ComboBox comboBox_Combustivel;
        private TextBox textBox_Utilizacao;
        private Button Btn_Cadastrar_Veiculo;
        private DataGridView dataGridView_Buscar_Segurado;
        private Button Btn_Buscar_Segurado;
        private TextBox textBox_Buscar_Segurado;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
    }
}