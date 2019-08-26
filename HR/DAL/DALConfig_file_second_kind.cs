using EFentity;
using IFDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALConfig_file_second_kind : DaoBase<config_file_second_kind>, IFDALconfig_file_second_kind
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public int Add(config_file_second_kindModel st)
        {
            //把DTO转为EO
            config_file_second_kind est = new config_file_second_kind()
            {
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                econd_salary_id = st.econd_salary_id,
                second_kind_id = st.second_kind_id,
                second_kind_name=st.second_kind_name,
                second_sale_id=st.second_sale_id
            };
            return Add(est);
        }
        /// <summary>
        /// 存储过程生成编号
        /// </summary>
        /// <returns></returns>
        public string BH()
        {
            string sql = "proc_EJBH";
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

        public List<config_file_second_kindModel> cx(string id)
        {
            List<config_file_second_kind> list = SelectBy(e => e.first_kind_id.Equals(id));
            List<config_file_second_kindModel> list2 = new List<config_file_second_kindModel>();
            foreach (config_file_second_kind item in list)
            {
                config_file_second_kindModel sm = new config_file_second_kindModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_sale_id = item.second_sale_id,
                    second_kind_name = item.second_kind_name,
                    second_kind_id = item.second_kind_id,
                    econd_salary_id = item.econd_salary_id
                };
                list2.Add(sm);
            }
            return list2;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public int Del(config_file_second_kindModel st)
        {
            config_file_second_kind est = new config_file_second_kind()
            {
                Id = st.Id
            };
            return Delete(est);
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public List<config_file_second_kindModel> Select()
        {
            List<config_file_second_kind> list = SelectAll();
            List<config_file_second_kindModel> list2 = new List<config_file_second_kindModel>();
            foreach (config_file_second_kind item in list)
            {
                config_file_second_kindModel sm = new config_file_second_kindModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_sale_id = item.second_sale_id,
                    second_kind_name = item.second_kind_name,
                    second_kind_id=item.second_kind_id,
                    econd_salary_id=item.econd_salary_id
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
        public int Update(config_file_second_kindModel st)
        {
            config_file_second_kind est = new config_file_second_kind()
            {
                Id = st.Id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                econd_salary_id = st.econd_salary_id,
                second_kind_id = st.second_kind_id,
                second_kind_name = st.second_kind_name,
                second_sale_id = st.second_sale_id
            };
            return Update(est);
        }
        /// <summary>
        /// 修改显示
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public config_file_second_kindModel XGCX(int id)
        {
            List<config_file_second_kind> list = SelectBy(e => e.Id.Equals(id));
            config_file_second_kind c = list[0];
            config_file_second_kindModel m = new config_file_second_kindModel()
            {
                Id = c.Id,
                first_kind_id = c.first_kind_id,
                first_kind_name = c.first_kind_name,
                second_kind_id = c.second_kind_id,
                second_kind_name = c.second_kind_name,
                second_sale_id=c.second_sale_id,
                econd_salary_id=c.econd_salary_id
            };
            return m;
        }

    }
}
