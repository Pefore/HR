using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using EFentity;
using System.Data.Entity.Infrastructure;

namespace DAL
{
   public class DaoBase<T> where T : class
    {

       static MyDbcontext db = CreateDbContext();
        private Boolean RemoveHoldingEntityInContext(T entity)
        {
            var objContext = ((IObjectContextAdapter)db).ObjectContext;
            var objSet = objContext.CreateObjectSet<T>();
            var entityKey = objContext.CreateEntityKey(objSet.EntitySet.Name, entity);

            Object foundEntity;
            var exists = objContext.TryGetObjectByKey(entityKey, out foundEntity);

            if (exists)
            {
                objContext.Detach(foundEntity);
            }

            return (exists);
        }
        private static MyDbcontext CreateDbContext()
        {
            //从当前请求的线程取值
            db = CallContext.GetData("s") as MyDbcontext;
            if (db==null)
            {
                db = new MyDbcontext();
                //把上下文对象存入当前请求的线程中
                CallContext.SetData("s", db);
            }
            return db;
        }

        public int Add(T t)  {          
                //Set<T>()等于Students
                db.Set<T>().Add(t);
               return db.SaveChanges();
        }
        public int Update(T t)
        {
            RemoveHoldingEntityInContext(t);
            db.Entry<T>(t).State = EntityState.Modified;
            return db.SaveChanges();
            
        }
        public int Delete(T t) {
            RemoveHoldingEntityInContext(t);
            db.Entry<T>(t).State = EntityState.Deleted;
            return db.SaveChanges();
          
        }

        public List<T> SelectAll() {
          
            List<T> list = db.Set<T>().Select(e => e).AsNoTracking().ToList();
            return list;

        }

        public List<T> SelectBy(Expression<Func<T,bool>> where) {
           
                List<T> list = db.Set<T>().Select(e => e)
                    .Where(where).AsNoTracking()
                    .ToList();

            return list;
        }

        public List<T> FenYe<K>(Expression<Func<T,K>> order, Expression<Func<T, bool>> where,ref int rows,int currentPage,int pageSize)
        {
                var data = db.Set<T>().OrderBy(order).Where(where).AsNoTracking();
                 rows = data.Count();//获取总行数
               List<T> list = data.Skip((currentPage-1)*pageSize)
                      .Take(pageSize)
                      .ToList();
            return list;

        }
    }
}
