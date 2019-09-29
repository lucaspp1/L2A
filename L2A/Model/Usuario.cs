using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2A.Model
{
    class Usuario
    {

        public int id { get; set; }
        public string nome { get; set; }
        public string foto { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public Usuario(string nome, string foto, string login, string senha)
        {
            this.nome = nome;
            this.foto = foto;
            this.login = login;
            this.senha = senha;
        }
    }
}
