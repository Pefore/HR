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
    public class BLLconfig_major : IFBLLconfig_major
    {
        IFDALconfig_major C = UserIOC.config_majorDAO();
        public int Addconfig_major(config_major_Model cn)
        {
            return C.Addconfig_major(cn);
        }

        public List<config_major_Model> cx(string id)
        {
            return C.cx(id);
        }

        public int Deleteconfig_major(config_major_Model cn)
        {
            return C.Deleteconfig_major(cn);
        }

        public List<config_major_Model> listconfig_major()
        {
            return C.listconfig_major();
        }

        public string SelectMaxconfig_major()
        {
            return C.SelectMaxconfig_major();
        }
    }
}
