using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFDAL
{
   public interface IFDALPosition_Name_Set
    {
        #region 职称名称
        List<Position_Name_Set_Model> list();
        int DeletePosition_Name_Set(Position_Name_Set_Model pn);
        int AddPosition_Name_Set(Position_Name_Set_Model pn);
        #endregion
    }
}
