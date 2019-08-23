using IFBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IFDAL;
using IOC;

namespace BLL
{
    public class BLLPosition_Name_Set : IFBLLPosition_Name_Set
    {
        IFDALPosition_Name_Set P = UserIOC.Position_Name_SetDAO();

        public int AddPosition_Name_Set(Position_Name_Set_Model pn)
        {
            return P.AddPosition_Name_Set(pn);
        }

        public int DeletePosition_Name_Set(Position_Name_Set_Model pn)
        {
            return P.DeletePosition_Name_Set(pn);
        }

        public List<Position_Name_Set_Model> list()
        {
            return P.list();
        }
    }
}
