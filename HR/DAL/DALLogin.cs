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
        public List<users> Select()
        {
            List<user> list = SelectAll();
            List<users> list2 = new List<users>();
            foreach (user st in list)
            {
                users us = new users()
                {
                    Id=st.Id,
                    user_name=st.user_name,
                    user_password=st.user_password,
                    user_true_name=st.user_true_name
                };
                list2.Add(us);
            }
            return list2;
        }
    }
}
