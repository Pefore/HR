using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using EFentity;
using IFDAL;
using System.Data;

namespace DAL
{
    public class DALRight : DaoBase<right>, IFDALRight
    {
        public List<rightModel> RightSelect()
        {
            List<right> list = SelectAll();
            List<rightModel> list2 = new List<rightModel>();
            foreach (right item in list)
            {
                rightModel cm = new rightModel()
                {
                   right_id=item.right_id,
                   right_name=item.right_name,
                   right_usable=item.right_usable,
                   right_explain=item.right_explain
                };
                list2.Add(cm);
            }
            return list2;
        }
        public List<rightModel> RightSelectBy(rightModel rm)
        {
            List<right> list = SelectBy(e => e.right_id.Equals(rm.right_id));
            List<rightModel> list2 = new List<rightModel>();
            foreach (var item in list)
            {
                rightModel cm = new rightModel()
                {
                    right_id = item.right_id,
                    right_name = item.right_name,
                    right_usable = item.right_usable,
                    right_explain = item.right_explain
                };
                list2.Add(cm);
            }
            return list2;
        }
        public int Add(rightModel rm)
        {
            right rgh = new right()
            {
                right_id=rm.right_id,
                right_name=rm.right_name,
                right_explain=rm.right_explain,
                right_usable=rm.right_usable
            };
            return Add(rgh);
        }

        public int Del(rightModel rm)
        {
            right rgh = new right()
            {
                right_id = rm.right_id

            };
            return Delete(rgh);
        }
        

        public int Update(rightModel rm)
        {
            right rgh = new right()
            {
                right_id = rm.right_id,
                right_name = rm.right_name,
                right_explain = rm.right_explain,
                right_usable = rm.right_usable
            };
            return Update(rgh);
        }
        public Dictionary<string, object> FenYe(int currentPage)
        {
            DaoBase<right> db = new DaoBase<right>();
            int rows = 0;
            List<right> list = db.FenYe<int>(e => e.right_id, e => e.right_id > 0, ref rows, currentPage, 3);
            List<rightModel> dt = new List<rightModel>();
            foreach (right item in list)
            {
                rightModel rgh = new rightModel()
                {
                    right_id = item.right_id,
                    right_name = item.right_name,
                    right_explain = item.right_explain,
                    right_usable = item.right_usable
                };
                dt.Add(rgh);
            }
            Dictionary<string, object> di = new Dictionary<string, object>();
            int pages = (rows + 3 - 1) / 3;
            di["dt"] = list;
            di["rows"] = rows;
            di["pages"] = pages;
            di["dqy"] = currentPage;
            return di;
        }
        /// <summary>
        ///  查询当前角色对应权限
        /// </summary>
        /// <param name="rid"></param>
        /// <param name="pid"></param>
        /// <returns></returns>
        public DataTable selectQX(string rid, string pid)
        {
            string sql = string.Format("select[id],[text],[state], rp.PopID,case when rp.PopID is not null then 1 else 0 end as checked from [dbo].[Pop] p left join (select PopID from GuanliPop where GuanliID = {0}) rp on p.id = rp.PopID where p.PID = {1}", rid, pid);
            
            return SqlDBHelper.table(sql);

        }
        //根据角色id删除角色权限表
        public int DeletePer(string rid)
        {
            string sql = string.Format(@" Delete  from [dbo].[GuanliPop]  where [GuanliID] ='{0}'", rid);
            return SqlDBHelper.InsertDeleteUpdate(sql);

        }
        /// <summary>
        /// 新增角色权限表
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int AddPer(string sql)
        {
            return SqlDBHelper.InsertDeleteUpdate(sql);

        }
        public rightModel RightSelectBys(int id)
        {
            right list = SelectBy(e => e.right_id == (id)).FirstOrDefault();
            
                rightModel cm = new rightModel()
                {
                    right_id = list.right_id,
                    right_name = list.right_name,
                    right_usable = list.right_usable,
                    right_explain = list.right_explain
                };
            return cm;
        }
    }
}
