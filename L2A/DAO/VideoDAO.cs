using L2A.DAO.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2A.Model
{
    class VideoDAO
    {
      FileHelper<Video> fileHelper = new FileHelper<Video>();
      public List<Video> select()
        {
            return fileHelper.select();
        }

        public bool insert(Video video)
        {
            return fileHelper.Insert(video , out _);
        }

        public bool Update(Video video,int id)
        {
            return fileHelper.Update(video , id);
        }

        public bool Delete(int id)
        {
            return fileHelper.Delete(id);
        }

    }
}
