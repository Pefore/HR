﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFBLL
{
   public interface IFBLLconfig_major
    {
        #region 职位设置
        List<config_major_Model> listconfig_major();
        int Deleteconfig_major(config_major_Model cn);
        int Addconfig_major(config_major_Model cn);
        List<config_major_Model> SelectwWhere(string id);
        #endregion
    }
}
