using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2A.Model
{
    class Video
    {
        public int id { get; set; }
        public string Titulo { get; set; }
        public string URL { get; set; }
        public int Usuario { get; set; }
        public int Categoria { get; set; }
        public string Descricao { get; set; }
        public DateTime DataPuplicacao { get; set; }
    }
}
