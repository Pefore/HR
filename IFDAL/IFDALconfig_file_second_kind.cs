using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFDAL
{
    public interface IFDALconfig_file_second_kind
    {
        int Add(config_file_second_kindModel st);
        int Del(config_file_second_kindModel st);
        int Update(config_file_second_kindModel st);
        List<config_file_second_kindModel> Select();
        string BH();
       config_file_second_kindModel XGCX(int id);
        List<config_file_second_kindModel> cx(string id);
    }
}
