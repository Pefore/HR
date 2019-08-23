using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFDAL
{
   public interface IFDALconfig_major_kind
    {
        #region 职位分类
        List<config_major_kind_Model> listconfig_major_kind();
        int Deleteconfig_major_kind(config_major_kind_Model cn);
        int Addconfig_major_kind(config_major_kind_Model cn);
        string SelectMaxconfig_major_kind();
        #endregion
    }
}
