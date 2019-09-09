using EFentity;
using IFDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.Runtime.Remoting.Messaging;

namespace DAL
{
    public class DALMajor_change : DaoBase<major_change>, IFDALMajor_change
    {
        static MyDbcontext db = CreateDbContext();
        private static MyDbcontext CreateDbContext()
        {
            //从当前请求的线程取值
            db = CallContext.GetData("s") as MyDbcontext;
            if (db == null)
            {
                db = new MyDbcontext();
                //把上下文对象存入当前请求的线程中
                CallContext.SetData("s", db);
            }
            return db;
        }
        public int ADDMajor_change(Major_changeModel mm)
        {
            major_change mc = new major_change()
            {
                human_name = mm.human_name,
                first_kind_name = mm.first_kind_name,
                second_kind_name = mm.second_kind_name,
                third_kind_name = mm.third_kind_name,
                major_kind_name = mm.major_kind_name,
                major_name = mm.major_name,
                salary_standard_name = mm.salary_standard_name,
                salary_sum = mm.salary_sum,
                new_first_kind_name = mm.new_first_kind_name,
                new_second_kind_name = mm.new_second_kind_name,
                new_third_kind_name = mm.new_third_kind_name,
                new_major_kind_name = mm.new_major_kind_name,
                new_major_name = mm.new_major_name,
                new_salary_standard_name = mm.new_salary_standard_name,
                new_salary_sum = mm.new_salary_sum,
                register = mm.register,
                regist_time = mm.regist_time,
                change_reason = mm.change_reason
            };
            return Add(mc);
        }

        public int DELETEMajor_change(Major_changeModel mm)
        {
            major_change mc = new major_change()
            {
                Id = mm.Id,
            };
            return Delete(mc);
        }

        public List<Major_changeModel> SELECTcx(string where)
        {
            List<major_change> list = SelectBy(e=>e.first_kind_id==where);
            List<Major_changeModel> list2 = new List<Major_changeModel>();
            foreach (major_change item in list)
            {
                Major_changeModel md = new Major_changeModel()
                {
                    first_kind_name = item.first_kind_name,
                    second_kind_name = item.second_kind_name,
                    third_kind_name = item.third_kind_name,
                    salary_standard_name = item.salary_standard_name,
                    human_name = item.human_name,
                    first_kind_id = item.first_kind_id,
                    second_kind_id = item.second_kind_id,
                    third_kind_id=item.third_kind_id
                };
                list2.Add(md);
            }
            return list2;
        }
        public List<Major_changeModel> SELECTFirst(string where)
        {
            var sql = string.Format(@"select [first_kind_id],[first_kind_name],second_kind_name,third_kind_name,salary_standard_name,human_name from[dbo].[major_change]where[first_kind_id]='{0}'", where);
            var values = db.Database.SqlQuery<Major_changeModel>(sql).ToList();
            return values;
        }
        public List<Major_changeModel> SELECTSecond()
        {
            var values = db.Database.SqlQuery<Major_changeModel>($"select [second_kind_id],[second_kind_name]from[dbo].[major_change]").ToList();
            return values;
        }
        public List<Major_changeModel> SELECTThird(string where)
        {
            string sql = string.Format(@"select [first_kind_id],[first_kind_name],second_kind_name,third_kind_name,salary_standard_name,human_name from[dbo].[major_change]where[third_kind_id]='{0}'", where);
            return db.Database.SqlQuery<Major_changeModel>(sql).ToList();
        }
        public List<Major_changeModel> selectcx(string where)
        {
            List<major_change> list = SelectBy(e => e.third_kind_id == where);
            List<Major_changeModel> list2 = new List<Major_changeModel>();
            foreach (major_change item in list)
            {
                Major_changeModel md = new Major_changeModel()
                {
                    first_kind_name = item.first_kind_name,
                    second_kind_name = item.second_kind_name,
                    third_kind_name = item.third_kind_name,
                    salary_standard_name = item.salary_standard_name,
                    human_name = item.human_name
                };
                list2.Add(md);
            }
            return list2;
        }
        public List<Major_changeModel> SELECTMajor_change()
        {
            List<major_change> list = SelectAll();
            List<Major_changeModel> list2 = new List<Major_changeModel>();
            foreach (major_change item in list)
            {
                Major_changeModel md = new Major_changeModel()
                {
                     first_kind_name=item.first_kind_name,       
                     second_kind_name=item.second_kind_name,
                     third_kind_name=item.third_kind_name,
                    salary_standard_name=item.salary_standard_name,
                    human_name=item.human_name,
                    first_kind_id=item.first_kind_id
                };
                list2.Add(md);
            }
            return list2;
        }

        public int UPDATEMajor_change(Major_changeModel mm)
        {
            throw new NotImplementedException();
        }
    }
}
