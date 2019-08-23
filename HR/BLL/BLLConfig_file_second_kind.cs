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
    public class BLLConfig_file_second_kind: IFBLLConfig_file_second_kind
    {
        IFDALconfig_file_second_kind ist = UserIOC.CreateConfig_file_second_kindDAO();
        public int Add(config_file_second_kindModel st)
        {
            return ist.Add(st);
        }

        public string BH()
        {
            return ist.BH();
        }

        public List<config_file_second_kindModel> cx(string id)
        {
            return ist.cx(id);
        }

        public int Del(config_file_second_kindModel st)
        {
            return ist.Del(st);
        }

        public List<config_file_second_kindModel> Select()
        {
            return ist.Select();
        }

        public int Update(config_file_second_kindModel st)
        {
            return ist.Update(st);
        }

        public config_file_second_kindModel XGCX(int id)
        {
            return ist.XGCX(id);
        }
    }
}
