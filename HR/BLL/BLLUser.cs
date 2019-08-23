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
        
        public int ADDUser(users s)
        {
            return u.ADDUser(s);
        }

        public int Login(users s)
        {
            return u.Login(s);
        }
    }
}
