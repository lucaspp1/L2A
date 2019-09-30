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
            this.txtLogin = new MetroFramework.Controls.MetroTextBox();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtConfirmarSenha = new MetroFramework.Controls.MetroTextBox();
            this.LabelCS = new MetroFramework.Controls.MetroLabel();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.ForeColor = System.Drawing.Color.Black;
            this.Login.Location = new System.Drawing.Point(43, 103);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(43, 20);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(43, 146);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(665, 28);
            this.txtLogin.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(43, 311);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(665, 28);
            this.txtSenha.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(43, 268);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Senha";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(43, 405);
            this.txtConfirmarSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.PasswordChar = '*';
            this.txtConfirmarSenha.Size = new System.Drawing.Size(665, 28);
            this.txtConfirmarSenha.TabIndex = 5;
            // 
            // LabelCS
            // 
            this.LabelCS.AutoSize = true;
            this.LabelCS.ForeColor = System.Drawing.Color.Black;
            this.LabelCS.Location = new System.Drawing.Point(43, 362);
            this.LabelCS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCS.Name = "LabelCS";
            this.LabelCS.Size = new System.Drawing.Size(112, 20);
            this.LabelCS.TabIndex = 4;
            this.LabelCS.Text = "Confirmar Senha";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(43, 468);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(175, 42);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(43, 234);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(665, 28);
            this.txtNome.TabIndex = 8;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.Black;
            this.metroLabel2.Location = new System.Drawing.Point(43, 191);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 20);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Nome";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 558);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.LabelCS);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.Login);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cadastro";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Login;
        private MetroFramework.Controls.MetroTextBox txtLogin;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtConfirmarSenha;
        private MetroFramework.Controls.MetroLabel LabelCS;
        private MetroFramework.Controls.MetroButton btnCadastrar;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}