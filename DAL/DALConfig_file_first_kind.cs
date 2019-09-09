using EFentity;
using IFDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALConfig_file_first_kind:DaoBase<config_file_first_kind>, IFDALconfig_file_first_kind
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public int Add(config_file_first_kindModel st)
        {
            //把DTO转为EO
            config_file_first_kind est = new config_file_first_kind()
            {
                first_kind_id=st.first_kind_id,
                first_kind_name = st.first_kind_name,
                first_kind_salary_id=st.first_kind_salary_id,
                first_kind_sale_id=st.first_kind_sale_id
            };
            return Add(est);
        }
        /// <summary>
        /// 存储过程生成编号
        /// </summary>
        /// <returns></returns>
        public string BH()
        {
            string sql = "proc_BH";
            SqlParameter ps = new SqlParameter()
            {
                ParameterName = "@Cid",
                SqlDbType = System.Data.SqlDbType.VarChar,
                Size = 14,
                Direction = System.Data.ParameterDirection.Output
            };
            SqlDBHelper.SelectFenYe(sql, ps);
            return ps.Value.ToString();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public int Del(config_file_first_kindModel st)
        {
            config_file_first_kind est = new config_file_first_kind()
            {
                Id = st.Id
            };
            return Delete(est);
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public List<config_file_first_kindModel> Select()
        {
            List<config_file_first_kind> list = SelectAll();
            List<config_file_first_kindModel> list2 = new List<config_file_first_kindModel>();
            foreach (config_file_first_kind item in list)
            {
                config_file_first_kindModel sm = new config_file_first_kindModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    first_kind_salary_id = item.first_kind_salary_id,
                    first_kind_sale_id = item.first_kind_sale_id
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
        public int Update(config_file_first_kindModel st)
        {
            config_file_first_kind est = new config_file_first_kind()
            {
                Id = st.Id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                first_kind_salary_id = st.first_kind_salary_id,
                first_kind_sale_id = st.first_kind_sale_id
            };
            return Update(est);
        }
        /// <summary>
        /// 修改显示
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public config_file_first_kindModel XGCX(int id)
        {
            List<config_file_first_kind> list = SelectBy(e=>e.Id.Equals(id));
            config_file_first_kind c = list[0];
            config_file_first_kindModel m = new config_file_first_kindModel()
            {
                Id = c.Id,
                first_kind_id = c.first_kind_id,
                first_kind_name = c.first_kind_name,
                first_kind_salary_id = c.first_kind_salary_id,
                first_kind_sale_id = c.first_kind_sale_id
            };
            //List<config_file_first_kindModel> list2 = new List<config_file_first_kindModel>();
            //foreach (config_file_first_kind item in list)
            //{
            //    config_file_first_kindModel sm = new config_file_first_kindModel()
            //    {
            //        Id = item.Id,
            //        first_kind_id = item.first_kind_id,
            //        first_kind_name = item.first_kind_name,
            //        first_kind_salary_id = item.first_kind_salary_id,
            //        first_kind_sale_id = item.first_kind_sale_id
            //    };
            //    list2.Add(sm);
            //}
            return m;
        }
    }
}
