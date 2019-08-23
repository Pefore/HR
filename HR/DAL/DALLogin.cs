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
        
        public int ADDUser(users s)
        {
            user u = new user()
            {
                user_name = s.user_name,
                user_password = s.user_password,
                user_true_name = s.user_true_name
            };
            return Add(u);
        }
        
        public int Login(users s)
        {
            string sql = string.Format(@"select count(*) from [user] where [user_name]='{0}' and user_password='{1}'", s.user_name, s.user_password);
            return (int)SqlDBHelper.DGZ(sql);
        }
    }
}
