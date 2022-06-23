namespace Seguradora_Pim.Telas_Veiculo
{
    partial class Tela_Deletar_Veiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Deletar_Veiculo));
            this.textBox_Dados_Placa = new System.Windows.Forms.TextBox();
            this.Btn_Deletar_Veiculo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Dados_Placa
            // 
            this.textBox_Dados_Placa.Location = new System.Drawing.Point(250, 216);
            this.textBox_Dados_Placa.Name = "textBox_Dados_Placa";
            this.textBox_Dados_Placa.PlaceholderText = "Insira o numero da placa";
            this.textBox_Dados_Placa.Size = new System.Drawing.Size(145, 23);
            this.textBox_Dados_Placa.TabIndex = 1;
            // 
            // Btn_Deletar_Veiculo
            // 
            this.Btn_Deletar_Veiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.Btn_Deletar_Veiculo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.Btn_Deletar_Veiculo.FlatAppearance.BorderSize = 3;
            this.Btn_Deletar_Veiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Deletar_Veiculo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Deletar_Veiculo.ForeColor = System.Drawing.Color.White;
            this.Btn_Deletar_Veiculo.Location = new System.Drawing.Point(270, 245);
            this.Btn_Deletar_Veiculo.Name = "Btn_Deletar_Veiculo";
            this.Btn_Deletar_Veiculo.Size = new System.Drawing.Size(104, 36);
            this.Btn_Deletar_Veiculo.TabIndex = 2;
            this.Btn_Deletar_Veiculo.Text = "Deletar";
            this.Btn_Deletar_Veiculo.UseVisualStyleBackColor = false;
            this.Btn_Deletar_Veiculo.Click += new System.EventHandler(this.Btn_Deletar_Veiculo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 58);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(173, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sistema de Gerenciamento de Apólices";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 58);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(213, 216);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 23);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(364, 245);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 36);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // Tela_Deletar_Veiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(620, 453);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Deletar_Veiculo);
            this.Controls.Add(this.textBox_Dados_Placa);
            this.Name = "Tela_Deletar_Veiculo";
            this.Text = "Tela_Deletar_Veiculo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_Dados_Placa;
        private Button Btn_Deletar_Veiculo;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}