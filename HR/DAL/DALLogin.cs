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

        public List<users> se()
        {
            List<user> list = SelectAll();
            List<users> list1 = new List<users>();
            foreach (user item in list)
            {
                users u = new users()
                {
                    user_true_name = item.user_true_name
                };
                list1.Add(u);
            }
            return list1;
        }

        public users Select(users s)
        {
            List<user> list = SelectBy(e => e.user_name.Equals(s.user_name));
            user u= list[0];
            users u1 = new users()
            {
                user_true_name = u.user_true_name
            };
            return u1;
        }
    }
}
