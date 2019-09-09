using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFBLL;
using Model;
using IFDAL;
using IOC;
using System.Data;

namespace BLL
{
    public class BLLRight : IFBLLRight
    {
        IFDALRight ifr = UserIOC.CreateRightDAO();

        public int Add(rightModel rm)
        {
            return ifr.Add(rm);
        }

        public int AddPer(string sql)
        {
            return ifr.AddPer(sql);
        }

        public int Del(rightModel rm)
        {
            return ifr.Del(rm);
        }

        public int DeletePer(string rid)
        {
            return ifr.DeletePer(rid);
        }

        public Dictionary<string, object> FenYe(int currentPage)
        {
            return ifr.FenYe(currentPage);
        }

        public List<rightModel> RightSelect()
        {
            return ifr.RightSelect();
        }

        public List<rightModel> RightSelectBy(rightModel rm)
        {
            return ifr.RightSelectBy(rm);
        }

        public rightModel RightSelectBys(int id)
        {
            return ifr.RightSelectBys(id);
        }

        public DataTable selectQX(string rid, string pid)
        {
            return ifr.selectQX(rid, pid);
        }

        public int Update(rightModel rm)
        {
            return ifr.Update(rm);
        }
    }
}
