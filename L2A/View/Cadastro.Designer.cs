namespace L2A.View
{
    partial class Cadastro
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
            this.Login = new MetroFramework.Controls.MetroLabel();
            this.btnLogin2 = new MetroFramework.Controls.MetroTextBox();
            this.btnSenha = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.LabelCS = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.ForeColor = System.Drawing.Color.Black;
            this.Login.Location = new System.Drawing.Point(32, 84);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(41, 19);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // btnLogin2
            // 
            this.btnLogin2.Location = new System.Drawing.Point(32, 119);
            this.btnLogin2.Name = "btnLogin2";
            this.btnLogin2.Size = new System.Drawing.Size(499, 23);
            this.btnLogin2.TabIndex = 1;
            // 
            // btnSenha
            // 
            this.btnSenha.Location = new System.Drawing.Point(32, 202);
            this.btnSenha.Name = "btnSenha";
            this.btnSenha.PasswordChar = '*';
            this.btnSenha.Size = new System.Drawing.Size(499, 23);
            this.btnSenha.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(32, 167);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Senha";
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.Location = new System.Drawing.Point(32, 279);
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '*';
            this.metroTextBox3.Size = new System.Drawing.Size(499, 23);
            this.metroTextBox3.TabIndex = 5;
            // 
            // LabelCS
            // 
            this.LabelCS.AutoSize = true;
            this.LabelCS.ForeColor = System.Drawing.Color.Black;
            this.LabelCS.Location = new System.Drawing.Point(32, 244);
            this.LabelCS.Name = "LabelCS";
            this.LabelCS.Size = new System.Drawing.Size(108, 19);
            this.LabelCS.TabIndex = 4;
            this.LabelCS.Text = "Confirmar Senha";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(32, 322);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(131, 34);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Confirmar";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.LabelCS);
            this.Controls.Add(this.btnSenha);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnLogin2);
            this.Controls.Add(this.Login);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Cadastro";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Login;
        private MetroFramework.Controls.MetroTextBox btnLogin2;
        private MetroFramework.Controls.MetroTextBox btnSenha;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroLabel LabelCS;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}