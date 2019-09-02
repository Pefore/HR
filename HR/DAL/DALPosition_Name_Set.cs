using EFentity;
using IFDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace DAL
{
    public class DALPosition_Name_Set : DaoBase<Position_Name_Set>, IFDALPosition_Name_Set
    {
        public int AddPosition_Name_Set(Position_Name_Set_Model pn)
        {
            return Add(new Position_Name_Set() { Position_Name_id = pn.Position_Name_id, Position_Name = pn.Position_Name });
        }
        #region 职称名称
        public int DeletePosition_Name_Set(Position_Name_Set_Model pn)
        {
            return Delete(new Position_Name_Set() { Position_Name_Set_id=pn.Position_Name_Set_id});
        }

        public List<Position_Name_Set_Model> list()
        {
            List<Position_Name_Set_Model> list =new List<Position_Name_Set_Model>();
            List<Position_Name_Set> list2 = SelectAll();
            foreach (var item in list2)
            {
                Position_Name_Set_Model p = new Position_Name_Set_Model()
                {
                    Position_Name_id=item.Position_Name_id,
                    Position_Name_Set_id=item.Position_Name_Set_id,
                    Position_Name=item.Position_Name
                };
                list.Add(p);
            }
            return list;
        }
        #endregion
    }
}
