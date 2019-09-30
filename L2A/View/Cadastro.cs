using L2A.Controller;
using L2A.Model;
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
    public partial class Cadastro : MetroFramework.Forms.MetroForm
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string login = txtLogin.Text;
            string senha = txtSenha.Text;
            string confirmarSenha = txtConfirmarSenha.Text;
            string[] todosCampos = new string[] { confirmarSenha, senha, login, nome };
            if (senha == confirmarSenha)
            {
                bool camposVazio = false;
                foreach (string item in todosCampos)
                {
                    if (string.IsNullOrEmpty(item))
                        camposVazio = true;
                }
                if (camposVazio)
                {
                    MessageBox.Show("Preencha todos os campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UsuarioController usuarioController = new UsuarioController();
                    Usuario user = new Usuario(nome, "", login, senha);
                    if (usuarioController.cadastro(user))
                    {
                        MessageBox.Show("Cadastro com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Senha inválidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
