using EFentity;
using IFDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class DALLogin : DaoBase<user>, IFDALUser
    {
        public int ADDUser()
        {
            SelectBy(e=>e.Id.Equals(1));
            return 1;
        }

        public int Login(users s)
        {
            string sql = string.Format(@"select count(*) from [user] where [user_name]='{0}' and user_password='{1}'", s.user_name, s.user_password);
            return (int)SqlDBHelper.DGZ(sql);
        }
    }
}
