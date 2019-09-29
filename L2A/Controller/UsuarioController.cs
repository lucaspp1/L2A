using L2A.DAO;
using L2A.DAO.Service;
using L2A.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2A.Controller
{
    class UsuarioController
    {
        UsuarioDao usuarioDao = new UsuarioDao();

        public bool editar(Usuario usuarioEditado)
        {
            bool resultado = usuarioDao.Update(usuarioEditado, usuarioEditado.id);
            return resultado;
        }

        public bool cadastro(Usuario usuarioCadastro)
        {
            List<Usuario> listaUsuario = usuarioDao.select();
            bool existe = false;
            foreach (Usuario user in listaUsuario)
            {
                if (user.login == usuarioCadastro.login)
                {
                    existe = true;
                }
            }
            if (existe)
            {
                return false;
            }
            else
            {
                bool resultado = usuarioDao.insert(usuarioCadastro);
                return resultado;
            }
        }

        public bool comentar(Usuario usuario, Video video, string mensagem)
        {
            Comentario comentario = new Comentario(
                idVideo: video.id,
                mensagem: mensagem,
                idUsuario: usuario.id,
                dataPublicacao: DateTime.Now
                );
            bool resultado = new FileHelper<Comentario>().Insert(comentario, out _);
            return resultado;
        }

        public bool login(string login, string senha)
        {
            List<Usuario> listaUsuario = usuarioDao.select();
            bool existe = false;
            foreach (Usuario item in listaUsuario)
            {
                if (item.senha == senha && item.login == login)
                {
                    existe = true;
                }
            }
            return existe;
        }

    }
}
