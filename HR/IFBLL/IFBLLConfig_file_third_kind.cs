using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFBLL
{
    public interface IFBLLConfig_file_third_kind
    {
        int Add(config_file_third_kindModel st);
        int Del(config_file_third_kindModel st);
        int Update(config_file_third_kindModel st);
        List<config_file_third_kindModel> Select();
        config_file_third_kindModel XGCX(int id);
        string BH();
        List<config_file_third_kindModel> SelectIII(string id);
    }
}
