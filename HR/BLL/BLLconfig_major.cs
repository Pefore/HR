using IFBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IOC;
using IFDAL;

namespace BLL
{
    public class BLLconfig_major_kind : IFBLLconfig_major_kind
    {
        IFDALconfig_major_kind C = UserIOC.config_major_kindDAO();
        public int Addconfig_major_kind(config_major_kind_Model cn)
        {
            return C.Addconfig_major_kind(cn);
        }

        public int Deleteconfig_major_kind(config_major_kind_Model cn)
        {
            return C.Deleteconfig_major_kind(cn);
        }

        public List<config_major_kind_Model> listconfig_major_kind()
        {
            return C.listconfig_major_kind();
        }

        public string SelectMaxconfig_major_kind()
        {
            return C.SelectMaxconfig_major_kind();
        }
    }
}
