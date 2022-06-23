namespace Seguradora_Pim.Telas_Cotacao
{
    partial class Tela_Aprovar_Cotacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Aprovar_Cotacao));
            this.textBox_Id_Cotacao = new System.Windows.Forms.TextBox();
            this.Btn_Aprovar_Cotacao = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Id_Cotacao
            // 
            this.textBox_Id_Cotacao.BackColor = System.Drawing.Color.White;
            this.textBox_Id_Cotacao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Id_Cotacao.Location = new System.Drawing.Point(250, 216);
            this.textBox_Id_Cotacao.Name = "textBox_Id_Cotacao";
            this.textBox_Id_Cotacao.PlaceholderText = "Id Cotação";
            this.textBox_Id_Cotacao.Size = new System.Drawing.Size(127, 25);
            this.textBox_Id_Cotacao.TabIndex = 1;
            // 
            // Btn_Aprovar_Cotacao
            // 
            this.Btn_Aprovar_Cotacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.Btn_Aprovar_Cotacao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.Btn_Aprovar_Cotacao.FlatAppearance.BorderSize = 3;
            this.Btn_Aprovar_Cotacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Aprovar_Cotacao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Aprovar_Cotacao.ForeColor = System.Drawing.Color.White;
            this.Btn_Aprovar_Cotacao.Location = new System.Drawing.Point(261, 247);
            this.Btn_Aprovar_Cotacao.Name = "Btn_Aprovar_Cotacao";
            this.Btn_Aprovar_Cotacao.Size = new System.Drawing.Size(104, 36);
            this.Btn_Aprovar_Cotacao.TabIndex = 2;
            this.Btn_Aprovar_Cotacao.Text = "Aprovar";
            this.Btn_Aprovar_Cotacao.UseVisualStyleBackColor = false;
            this.Btn_Aprovar_Cotacao.Click += new System.EventHandler(this.Btn_Aprovar_Cotacao_Click);
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
            this.pictureBox2.Location = new System.Drawing.Point(213, 218);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 23);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Tela_Aprovar_Cotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 453);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Aprovar_Cotacao);
            this.Controls.Add(this.textBox_Id_Cotacao);
            this.Name = "Tela_Aprovar_Cotacao";
            this.Text = "Tela_Aprovar_Cotacao";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_Id_Cotacao;
        private Button Btn_Aprovar_Cotacao;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
    }
}