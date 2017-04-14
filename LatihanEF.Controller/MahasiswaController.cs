using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LatihanEF.BF;
using LatihanEF.Models;

namespace LatihanEF.Controller
{
    public class MahasiswaController
    {
        public List<MahasiswaModel> RetreieveALL()
        {
            MahasiswaBFC mhsBFC = new MahasiswaBFC();
            return mhsBFC.RetrieveALL();
        }

        public List<MahasiswaModel> RetreieveByNim(string nim)
        {
            MahasiswaBFC mhsBFC = new MahasiswaBFC();
            return mhsBFC.RetrieveByNim(nim);
        }

        public void Save(MahasiswaModel model)
        {
            MahasiswaBFC mhsBFC = new MahasiswaBFC();
            mhsBFC.Save(model);
        }

        public void Update(MahasiswaModel model)
        {
            MahasiswaBFC mhsBFC = new MahasiswaBFC();
            mhsBFC.Update(model);
        }

        public void Delete(MahasiswaModel model)
        {
            MahasiswaBFC mhsBFC = new MahasiswaBFC();
            mhsBFC.Delete(model);
        }
    }
}
