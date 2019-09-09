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
                user_true_name = u.user_true_name,
                right_id=u.right_id,
            };
            return u1;
        }
        public int Add(users st)
        {
            user est = new user()
            {
                Id = st.Id,
                user_name = st.user_name,
                user_true_name = st.user_true_name,
                user_password = st.user_password,
                right_id = st.right_id
            };
            return Add(est);
        }

        public int Del(users st)
        {
            user est = new user()
            {
                Id = st.Id

            };
            return Delete(est);
        }
        public List<users> Select()
        {
            List<user> list = SelectAll();
            List<users> list2 = new List<users>();
            foreach (user item in list)
            {
                users sm = new users()
                {
                    Id = item.Id,
                    user_name = item.user_name,
                    user_true_name = item.user_true_name,
                    user_password = item.user_password,
                    right_id = item.right_id
                };
                list2.Add(sm);
            }
            return list2;
        }

        public List<users> SelectBy(users st)
        {
            List<user> list = SelectBy(e => e.Id.Equals(st.Id));
            List<users> list2 = new List<users>();
            foreach (var item in list)
            {
                users sd = new users()
                {
                    Id = item.Id,
                    user_name = item.user_name,
                    user_true_name = item.user_true_name,
                    user_password = item.user_password,
                    right_id = item.right_id
                };
                list2.Add(sd);
            }
            return list2;
        }

        public int Update(users st)
        {
            user est = new user()
            {
                Id = st.Id,
                user_name = st.user_name,
                user_true_name = st.user_true_name,
                user_password = st.user_password,
                right_id = st.right_id
            };
            return Update(est);
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <returns></returns>
        public List<users> cxqb()
        {
            var values = db.Database.SqlQuery<users>($"select [Id],[user_name],[user_true_name],(select [right_name] from [dbo].[right] r where (r.[right_id]=u.[right_id]))as name,[user_password] from [dbo].[user] u").ToList();
            return values;
        }
    }
}
