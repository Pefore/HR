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
    public class BLLUser : IFBLLUser
    {
        IFDALUser u = UserIOC.CreateStudenDAO();

        public int Add(users st)
        {
            return u.Add(st);
        }

        public int ADDUser()
        {
            return u.ADDUser();
        }

        public List<users> cxqb()
        {
            return u.cxqb();
        }

        public int Del(users st)
        {
            return u.Del(st);
        }
        

        public int Login(users s)
        {
            return u.Login(s);
        }

        public List<users> Select()
        {
            return u.Select();
        }

        public List<users> SelectBy(users st)
        {
            return u.SelectBy(st);
        }

        public int Update(users st)
        {
            return u.Update(st);
        }
    }
}
