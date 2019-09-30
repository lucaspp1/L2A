using L2A.Controller;
using L2A.DAO;
using L2A.Model;
using L2A.View.Restrito;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L2A.View
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void MaterialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void MetroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void MaterialFlatButton1_Click(object sender, EventArgs e)
        {
            UsuarioController usuarioController = new UsuarioController();
            if ( string.IsNullOrEmpty(txtLogin.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show(this, "Preencha todos os campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (usuarioController.login(txtLogin.Text, txtSenha.Text))
                {
                    new VideView().ShowDialog(this);
                }
                else
                {
                    MessageBox.Show(this, "Usuario não existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {

        }
    }
}
