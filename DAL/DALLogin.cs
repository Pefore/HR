using EFentity;
using IFDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.Entity.Infrastructure;
using System.Runtime.Remoting.Messaging;

namespace DAL
{
    public class DALLogin : DaoBase<user>, IFDALUser
    {
        //static MyDBContext db = CreateDbContext();
        //private Boolean RemoveHoldingEntityInContext(users entity)
        //{
        //    var objContext = ((IObjectContextAdapter)db).ObjectContext;
        //    var objSet = objContext.CreateObjectSet<users>();
        //    var entityKey = objContext.CreateEntityKey(objSet.EntitySet.Name, entity);
        //    Object foundEntity;
        //    var exists = objContext.TryGetObjectByKey(entityKey, out foundEntity);

        //    if (exists)
        //    {
        //        objContext.Detach(foundEntity);
        //    }

        //    return (exists);

        //}

        //private static MyDBContext CreateDbContext()
        //{
        //    //从当前请求的线程取值
        //    db = CallContext.GetData("s") as MyDBContext;
        //    if (db == null)
        //    {
        //        db = new MyDBContext();
        //        //把上下文对象存入当前请求的线程中
        //        CallContext.SetData("s", db);
        //    }
        //    return db;
        //}
        public int Add(users st)
        {
            user est = new user()
            {
                Id = st.Id,
                user_name = st.user_name,
                user_true_name = st.user_true_name,
                user_password = st.user_password,
                right_id=st.right_id
            };
            return Add(est);
        }

        public int ADDUser()
        {
            SelectBy(e=>e.Id.Equals(1));
            return 1;
        }

        public int Del(users st)
        {
            user est = new user()
            {
                Id = st.Id

            };
            return Delete(est);
        }

        public int Login(users s)
        {
            string sql = string.Format(@"select right_id from [user] where [user_name]='{0}' and user_password='{1}'", s.user_name, s.user_password);
            return (int)SqlDBHelper.DGZ(sql);
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
                    right_id=item.right_id
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
