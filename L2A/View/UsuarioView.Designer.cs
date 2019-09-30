namespace L2A.View
{
    partial class UsuarioView
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.userName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.login = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.videoQtd = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.likesQtd = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(299, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nome do Usuário";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(313, 45);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(69, 19);
            this.userName.TabIndex = 1;
            this.userName.Text = "userName";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(74, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Login";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(61, 131);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(69, 19);
            this.login.TabIndex = 3;
            this.login.Text = "labelLogin";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(483, 94);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(138, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Quantidade de videos";
            // 
            // videoQtd
            // 
            this.videoQtd.AutoSize = true;
            this.videoQtd.Location = new System.Drawing.Point(518, 131);
            this.videoQtd.Name = "videoQtd";
            this.videoQtd.Size = new System.Drawing.Size(64, 19);
            this.videoQtd.TabIndex = 5;
            this.videoQtd.Text = "videoQtd";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(496, 183);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(125, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Quantidade de likes";
            // 
            // likesQtd
            // 
            this.likesQtd.AutoSize = true;
            this.likesQtd.Location = new System.Drawing.Point(526, 215);
            this.likesQtd.Name = "likesQtd";
            this.likesQtd.Size = new System.Drawing.Size(56, 19);
            this.likesQtd.TabIndex = 7;
            this.likesQtd.Text = "likesQtd";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(74, 183);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(36, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Foto";
            // 
            // UsuarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 368);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.likesQtd);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.videoQtd);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.login);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UsuarioView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UsuarioView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel userName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel login;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel videoQtd;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel likesQtd;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}