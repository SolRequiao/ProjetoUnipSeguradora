namespace Seguradora_Pim.Telas_Inicial
{
    partial class Tela_Login
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
            this.Btn_Logar = new System.Windows.Forms.Button();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Senha = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Logar
            // 
            this.Btn_Logar.FlatAppearance.BorderSize = 3;
            this.Btn_Logar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Logar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Logar.ForeColor = System.Drawing.Color.White;
            this.Btn_Logar.Location = new System.Drawing.Point(674, 404);
            this.Btn_Logar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Logar.Name = "Btn_Logar";
            this.Btn_Logar.Size = new System.Drawing.Size(105, 49);
            this.Btn_Logar.TabIndex = 3;
            this.Btn_Logar.Text = "Entrar";
            this.Btn_Logar.UseVisualStyleBackColor = true;
            this.Btn_Logar.Click += new System.EventHandler(this.Btn_Logar_Click);
            // 
            // textBox_Login
            // 
            this.textBox_Login.BackColor = System.Drawing.Color.White;
            this.textBox_Login.Location = new System.Drawing.Point(605, 255);
            this.textBox_Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.PlaceholderText = "Login";
            this.textBox_Login.Size = new System.Drawing.Size(231, 27);
            this.textBox_Login.TabIndex = 1;
            // 
            // textBox_Senha
            // 
            this.textBox_Senha.BackColor = System.Drawing.Color.White;
            this.textBox_Senha.Location = new System.Drawing.Point(605, 332);
            this.textBox_Senha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Senha.Name = "textBox_Senha";
            this.textBox_Senha.PlaceholderText = "Senha";
            this.textBox_Senha.Size = new System.Drawing.Size(231, 27);
            this.textBox_Senha.TabIndex = 2;
            this.textBox_Senha.UseSystemPasswordChar = true;
            this.textBox_Senha.TextChanged += new System.EventHandler(this.textBox_Senha_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Seguradora_Pim.Properties.Resources._3333333;
            this.pictureBox3.Location = new System.Drawing.Point(241, 273);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(280, 86);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(521, 603);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(651, 113);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 56);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "SGAP";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tela_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBox_Senha);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.Btn_Logar);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Tela_Login";
            this.Text = "Tela_Login";
            this.Load += new System.EventHandler(this.Tela_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn_Logar;
        private TextBox textBox_Login;
        private TextBox textBox_Senha;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}