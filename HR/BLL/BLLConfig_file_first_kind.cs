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
    public class BLLConfig_file_first_kind: IFBLLConfig_file_first_kind
    {
        IFDALconfig_file_first_kind ist = UserIOC.CreateConfig_file_first_kindDAO();
        public int Add(config_file_first_kindModel st)
        {
            return ist.Add(st);
        }

        public string BH()
        {
            return ist.BH();
        }

        public int Del(config_file_first_kindModel st)
        {
            return ist.Del(st);
        }

        public List<config_file_first_kindModel> Select()
        {
            return ist.Select();
        }

        public int Update(config_file_first_kindModel st)
        {
            return ist.Update(st);
        }

        public config_file_first_kindModel XGCX(int id)
        {
            return ist.XGCX(id);
        }
    }
}
