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
    public class DALsalary_grant : DaoBase<salary_grant>, IFDALsalary_grant
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public int Add(salary_grantModel st)
        {
            //把DTO转为EO
            salary_grant est = new salary_grant()
            {
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                second_kind_id = st.second_kind_id,
                second_kind_name = st.second_kind_name,
                third_kind_id=st.third_kind_id,
                third_kind_name=st.third_kind_name,
                salary_grant_id=st.salary_grant_id,
                salary_paid_sum=st.salary_paid_sum,
                salary_standard_id=st.salary_standard_id,
                salary_standard_sum=st.salary_standard_sum,
                check_status=st.check_status,
                checker=st.checker,
                check_time=st.check_time,
                human_amount=st.human_amount,
                register=st.register,
                regist_time=st.regist_time
            };
            return Add(est);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public int Del(salary_grantModel st)
        {
            salary_grant est = new salary_grant()
            {
                Id = st.Id
            };
            return Delete(est);
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public List<salary_grantModel> Select()
        {
            List<salary_grant> list = SelectAll();
            List<salary_grantModel> list2 = new List<salary_grantModel>();
            foreach (salary_grant st in list)
            {
                salary_grantModel sm = new salary_grantModel()
                {
                    Id=st.Id,
                    first_kind_id = st.first_kind_id,
                    first_kind_name = st.first_kind_name,
                    second_kind_id = st.second_kind_id,
                    second_kind_name = st.second_kind_name,
                    third_kind_id = st.third_kind_id,
                    third_kind_name = st.third_kind_name,
                    salary_grant_id = st.salary_grant_id,
                    salary_paid_sum = st.salary_paid_sum,
                    salary_standard_id = st.salary_standard_id,
                    salary_standard_sum = st.salary_standard_sum,
                    check_status = st.check_status,
                    checker = st.checker,
                    check_time = st.check_time,
                    human_amount = st.human_amount,
                    register = st.register,
                    regist_time = st.regist_time
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
        public int Update(salary_grantModel st)
        {
            salary_grant est = new salary_grant()
            {
                Id = st.Id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                second_kind_id = st.second_kind_id,
                second_kind_name = st.second_kind_name,
                third_kind_id = st.third_kind_id,
                third_kind_name = st.third_kind_name,
                salary_grant_id = st.salary_grant_id,
                salary_paid_sum = st.salary_paid_sum,
                salary_standard_id = st.salary_standard_id,
                salary_standard_sum = st.salary_standard_sum,
                check_status = st.check_status,
                checker = st.checker,
                check_time = st.check_time,
                human_amount = st.human_amount,
                register = st.register,
                regist_time = st.regist_time
            };
            return Update(est);
        }
        /// <summary>
        /// 修改显示
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public salary_grantModel XGCX(int id)
        {
            List<salary_grant> list = SelectBy(e => e.Id.Equals(id));
            salary_grant st = list[0];
            salary_grantModel m = new salary_grantModel()
            {
                Id = st.Id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                second_kind_id = st.second_kind_id,
                second_kind_name = st.second_kind_name,
                third_kind_id = st.third_kind_id,
                third_kind_name = st.third_kind_name,
                salary_grant_id = st.salary_grant_id,
                salary_paid_sum = st.salary_paid_sum,
                salary_standard_id = st.salary_standard_id,
                salary_standard_sum = st.salary_standard_sum,
                check_status = st.check_status,
                checker = st.checker,
                check_time = st.check_time,
                human_amount = st.human_amount,
                register = st.register,
                regist_time = st.regist_time
            };
            return m;
        }
        public List<salary_grantModel> TJCX(string s)
        {
            List<salary_grant> list = SelectBy(e => e.third_kind_id.Contains("SJ"));
            List<salary_grantModel> list2 = new List<salary_grantModel>();
            foreach (salary_grant st in list)
            {
                salary_grantModel sm = new salary_grantModel()
                {
                    Id = st.Id,
                    first_kind_id = st.first_kind_id,
                    first_kind_name = st.first_kind_name,
                    second_kind_id = st.second_kind_id,
                    second_kind_name = st.second_kind_name,
                    third_kind_id = st.third_kind_id,
                    third_kind_name = st.third_kind_name,
                    salary_grant_id = st.salary_grant_id,
                    salary_paid_sum = st.salary_paid_sum,
                    salary_standard_id = st.salary_standard_id,
                    salary_standard_sum = st.salary_standard_sum,
                    check_status = st.check_status,
                    checker = st.checker,
                    check_time = st.check_time,
                    human_amount = st.human_amount,
                    register = st.register,
                    regist_time = st.regist_time
                };
                list2.Add(sm);
            }
            return list2;
        }
        public List<salary_grantModel> selectupdateda(string id)
        {
            List<salary_grant> list = SelectBy(e => e.salary_grant_id.Equals(id));


            List<salary_grantModel> li = new List<salary_grantModel>();
            foreach (salary_grant item in list)
            {
                salary_grantModel ko = new salary_grantModel();
                ko.Id = item.Id;
                ko.salary_grant_id = item.salary_grant_id;
                ko.salary_standard_id = item.salary_standard_id;
                ko.first_kind_id = item.first_kind_id;
                ko.first_kind_name = item.first_kind_name;
                ko.second_kind_id = item.second_kind_id;
                ko.second_kind_name = item.second_kind_name;
                ko.third_kind_id = item.third_kind_id;
                ko.third_kind_name = item.third_kind_name;
                ko.human_amount = item.human_amount;
                ko.salary_standard_sum = item.salary_standard_sum;
                ko.salary_paid_sum = item.salary_paid_sum;
                ko.register = item.register;
                ko.regist_time = item.regist_time;
                ko.checker = item.checker;
                ko.check_time = item.check_time;
                ko.check_status = item.check_status; li.Add(ko);

            }
            return li;
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="currentPage"></param>
        /// <returns></returns>
        public Dictionary<string, object> FenYe(int zt, int currentPage)
        {
            //Contains  包含
            DaoBase<salary_grant> db = new DaoBase<salary_grant>();
            int rows = 0;
            List<salary_grant> list = db.FenYe<int>(e => e.Id, e => e.check_status.Equals(zt), ref rows, currentPage, 3);
            Dictionary<string, object> di = new Dictionary<string, object>();
            //总页数=(总记录数+每页显示数-1)/每页显示数
            int pages = (rows + 3 - 1) / 3;
            di["dt"] = list;
            //数据数
            di["rows"] = rows;
            //总页数
            di["pages"] = pages;
            //当前页
            di["dqy"] = currentPage;
            return di;
        }
    }
}
