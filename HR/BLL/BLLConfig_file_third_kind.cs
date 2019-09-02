using IFBLL;
using IFDAL;
using IOC;
using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLConfig_file_third_kind: IFBLLConfig_file_third_kind
    {
        IFDALconfig_file_third_kind ist = UserIOC.CreateConfig_file_third_kindDAO();
        public int Add(config_file_third_kindModel st)
        {
            return ist.Add(st);
        }

        public string BH()
        {
            return ist.BH();
        }

        public List<config_file_third_kindModel> cx(string id)
        {
            return ist.cx(id);
        }

        public int Del(config_file_third_kindModel st)
        {
            return ist.Del(st);
        }

        public List<config_file_third_kindModel> Select()
        {
            return ist.Select();
        }

        public List<config_file_third_kindModel> SelectIII(string id)
        {
            return ist.SelectIII(id);
        }

        public int Update(config_file_third_kindModel st)
        {
            return ist.Update(st);
        }

        public config_file_third_kindModel XGCX(int id)
        {
            return ist.XGCX(id);
        }
    }
}
