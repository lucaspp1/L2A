using L2A.DAO.Service;
using L2A.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2A.DAO
{
    class UsuarioDao
    {
        FileHelper<Usuario> fileHelper = new FileHelper<Usuario>();

        public List<Usuario> select()
        {
            return fileHelper.select();
        }

        public bool insert(Usuario usuario)
        {
            return fileHelper.Insert(usuario, out _);
        }
        public bool Update(Usuario usuario, int id)
        {
            return fileHelper.Update(usuario, id);
        }
        public bool Delete(int id)
        {
            return fileHelper.Delete(id);
        }
    }
}
