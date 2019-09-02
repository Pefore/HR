using IFBLL;
using IFDAL;
using IOC;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLhuman_file_dig: IFBLLhuman_file_dig
    {
        IFDALhuman_file_dig ist = UserIOC.Createhuman_file_digDAO();
        public int Add(human_file_digModel st)
        {
            return ist.Add(st);
        }

        public List<human_file_digModel> cx(string id)
        {
            return ist.cx(id);
        }

        public int Del(human_file_digModel st)
        {
            return ist.Del(st);
        }

        public string ooo()
        {
            return ist.ooo();
        }

        public List<human_file_digModel> Select()
        {
            return ist.Select();
        }

        public int Update(human_file_digModel st)
        {
            return ist.Update(st);
        }

        public human_file_digModel XGCX(int id)
        {
            return ist.XGCX(id);
        }
    }
}
