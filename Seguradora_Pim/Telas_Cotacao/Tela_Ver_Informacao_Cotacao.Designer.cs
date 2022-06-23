namespace Seguradora_Pim.Telas_Cotacao
{
    partial class Tela_Ver_Informacao_Cotacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Ver_Informacao_Cotacao));
            this.dataGridView_Pesquisar_Cotacao = new System.Windows.Forms.DataGridView();
            this.Btn_Pesquisar_Cotacao = new System.Windows.Forms.Button();
            this.textBox_Pesquisar_Cotacao = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pesquisar_Cotacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Pesquisar_Cotacao
            // 
            this.dataGridView_Pesquisar_Cotacao.AllowUserToAddRows = false;
            this.dataGridView_Pesquisar_Cotacao.AllowUserToDeleteRows = false;
            this.dataGridView_Pesquisar_Cotacao.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Pesquisar_Cotacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Pesquisar_Cotacao.GridColor = System.Drawing.Color.White;
            this.dataGridView_Pesquisar_Cotacao.Location = new System.Drawing.Point(12, 64);
            this.dataGridView_Pesquisar_Cotacao.Name = "dataGridView_Pesquisar_Cotacao";
            this.dataGridView_Pesquisar_Cotacao.ReadOnly = true;
            this.dataGridView_Pesquisar_Cotacao.RowTemplate.Height = 25;
            this.dataGridView_Pesquisar_Cotacao.Size = new System.Drawing.Size(776, 280);
            this.dataGridView_Pesquisar_Cotacao.TabIndex = 0;
            // 
            // Btn_Pesquisar_Cotacao
            // 
            this.Btn_Pesquisar_Cotacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.Btn_Pesquisar_Cotacao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.Btn_Pesquisar_Cotacao.FlatAppearance.BorderSize = 3;
            this.Btn_Pesquisar_Cotacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Pesquisar_Cotacao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Pesquisar_Cotacao.ForeColor = System.Drawing.Color.White;
            this.Btn_Pesquisar_Cotacao.Location = new System.Drawing.Point(692, 350);
            this.Btn_Pesquisar_Cotacao.Name = "Btn_Pesquisar_Cotacao";
            this.Btn_Pesquisar_Cotacao.Size = new System.Drawing.Size(96, 36);
            this.Btn_Pesquisar_Cotacao.TabIndex = 2;
            this.Btn_Pesquisar_Cotacao.Text = "Pesquisar";
            this.Btn_Pesquisar_Cotacao.UseVisualStyleBackColor = false;
            this.Btn_Pesquisar_Cotacao.Click += new System.EventHandler(this.Btn_Pesquisar_Cotacao_Click);
            // 
            // textBox_Pesquisar_Cotacao
            // 
            this.textBox_Pesquisar_Cotacao.BackColor = System.Drawing.Color.White;
            this.textBox_Pesquisar_Cotacao.Location = new System.Drawing.Point(515, 363);
            this.textBox_Pesquisar_Cotacao.Name = "textBox_Pesquisar_Cotacao";
            this.textBox_Pesquisar_Cotacao.PlaceholderText = "Pesquisar placa";
            this.textBox_Pesquisar_Cotacao.Size = new System.Drawing.Size(130, 23);
            this.textBox_Pesquisar_Cotacao.TabIndex = 1;
            this.textBox_Pesquisar_Cotacao.TextChanged += new System.EventHandler(this.textBox_Pesquisar_Cotacao_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 58);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(269, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sistema de Gerenciamento de Apólices";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 58);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(661, 363);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 23);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // Tela_Ver_Informacao_Cotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_Pesquisar_Cotacao);
            this.Controls.Add(this.Btn_Pesquisar_Cotacao);
            this.Controls.Add(this.dataGridView_Pesquisar_Cotacao);
            this.Name = "Tela_Ver_Informacao_Cotacao";
            this.Text = "Tela_Ver_Informacao_Cotacao";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pesquisar_Cotacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView_Pesquisar_Cotacao;
        private Button Btn_Pesquisar_Cotacao;
        private TextBox textBox_Pesquisar_Cotacao;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
    }
}