using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2A.Model
{
    class Comentario
    {
        public int id { get; set; }
        public int idVideo { get; set; }

        public DateTime dataPublicacao { get; set; }

        public string mensagem { get; set; }

        public int idUsuario { get; set; }

        public Comentario(int idVideo, DateTime dataPublicacao, string mensagem, int idUsuario)
        {
            this.dataPublicacao = dataPublicacao;
            this.mensagem = mensagem;
            this.idUsuario = idUsuario;
            this.idVideo = idVideo;
        }
    }
}
