using EFentity;
using IFDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALsalary_grant_details : DaoBase<salary_grant_details>, IFDALsalary_grant_details
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public int Add(salary_grant_detailsModel st)
        {
            //把DTO转为EO
            salary_grant_details est = new salary_grant_details()
            {
                salary_grant_id = st.salary_grant_id,
                human_id = st.human_id,
                human_name = st.human_name,
                bouns_sum = st.bouns_sum,
                sale_sum = st.sale_sum,
                deduct_sum = st.deduct_sum,
                salary_standard_sum = st.salary_standard_sum,
                salary_paid_sum = st.salary_paid_sum,
            };
            return Add(est);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public int Del(salary_grant_detailsModel st)
        {
            salary_grant_details est = new salary_grant_details()
            {
                Id = st.Id
            };
            return Delete(est);
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public List<salary_grant_detailsModel> Select()
        {
            List<salary_grant_details> list = SelectAll();
            List<salary_grant_detailsModel> list2 = new List<salary_grant_detailsModel>();
            foreach (salary_grant_details st in list)
            {
                salary_grant_detailsModel sm = new salary_grant_detailsModel()
                {
                    Id=st.Id,
                    salary_grant_id = st.salary_grant_id,
                    human_id = st.human_id,
                    human_name = st.human_name,
                    bouns_sum = st.bouns_sum,
                    sale_sum = st.sale_sum,
                    deduct_sum = st.deduct_sum,
                    salary_standard_sum = st.salary_standard_sum,
                    salary_paid_sum = st.salary_paid_sum,
                };
                list2.Add(sm);
            }
            return list2;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public int Update(salary_grant_detailsModel st)
        {
            salary_grant_details est = new salary_grant_details()
            {
                Id = st.Id,
                salary_grant_id = st.salary_grant_id,
                human_id = st.human_id,
                human_name = st.human_name,
                bouns_sum = st.bouns_sum,
                sale_sum = st.sale_sum,
                deduct_sum = st.deduct_sum,
                salary_standard_sum = st.salary_standard_sum,
                salary_paid_sum = st.salary_paid_sum
            };
            return Update(est);
        }
        /// <summary>
        /// 修改显示
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public salary_grant_detailsModel XGCX(int id)
        {
            List<salary_grant_details> list = SelectBy(e => e.Id.Equals(id));
            salary_grant_details st = list[0];
            salary_grant_detailsModel m = new salary_grant_detailsModel()
            {
                Id = st.Id,
                salary_grant_id = st.salary_grant_id,
                human_id = st.human_id,
                human_name = st.human_name,
                bouns_sum = st.bouns_sum,
                sale_sum = st.sale_sum,
                deduct_sum = st.deduct_sum,
                salary_standard_sum = st.salary_standard_sum,
                salary_paid_sum = st.salary_paid_sum
            };
            return m;
        }
        /// <summary>
        /// 条件查询
        /// </summary>
        /// <returns></returns>
        public List<salary_grant_detailsModel> TJCX(string id)
        {
            List<salary_grant_details> list = SelectBy(e => e.salary_grant_id.Equals(id));
            List<salary_grant_detailsModel> list2 = new List<salary_grant_detailsModel>();
            foreach (salary_grant_details st in list)
            {
                salary_grant_detailsModel sm = new salary_grant_detailsModel()
                {
                    Id = st.Id,
                    salary_grant_id = st.salary_grant_id,
                    human_id = st.human_id,
                    human_name = st.human_name,
                    bouns_sum = st.bouns_sum,
                    sale_sum = st.sale_sum,
                    deduct_sum = st.deduct_sum,
                    salary_standard_sum = st.salary_standard_sum,
                    salary_paid_sum = st.salary_paid_sum,
                };
                list2.Add(sm);
            }
            return list2;
        }
        public List<salary_grant_detailsModel> selectsalary_grant_id(string id)
        {
            List<salary_grant_details> list = SelectBy(e => e.salary_grant_id.Equals(id));


            List<salary_grant_detailsModel> li = new List<salary_grant_detailsModel>();
            foreach (salary_grant_details item in list)
            {
                salary_grant_detailsModel ko = new salary_grant_detailsModel();
                ko.Id = item.Id;
                ko.salary_grant_id = item.salary_grant_id;
                ko.human_id = item.human_id;
                ko.human_name = item.human_name;
                ko.bouns_sum = item.bouns_sum;
                ko.sale_sum = item.sale_sum;

                ko.deduct_sum = item.deduct_sum;
                ko.salary_standard_sum = item.salary_standard_sum;
                ko.salary_paid_sum = item.salary_paid_sum; li.Add(ko);
            }
            return li;

        }
    }
}
