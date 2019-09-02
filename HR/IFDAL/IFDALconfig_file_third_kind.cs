using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFDAL
{
    public interface IFDALconfig_file_third_kind
    {
        int Add(config_file_third_kindModel st);
        int Del(config_file_third_kindModel st);
        int Update(config_file_third_kindModel st);
        List<config_file_third_kindModel> Select();
        string BH();
        config_file_third_kindModel XGCX(int id);
        List<config_file_third_kindModel> cx(string id);
    }
}
