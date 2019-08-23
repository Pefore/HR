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
    public class DALconfig_major_kind : DaoBase<config_major_kind>, IFDALconfig_major_kind
    {
        #region 职位分类
        public int Addconfig_major_kind(config_major_kind_Model cn)
        {
            config_major_kind c = new config_major_kind()
            {
                mfk_id=cn.mfk_id,
                major_kind_id=cn.major_kind_id,
                major_kind_name=cn.major_kind_name
            };
            return Add(c);
        }

        public int Deleteconfig_major_kind(config_major_kind_Model cn)
        {
            int i = Delete(new config_major_kind() { mfk_id = cn.mfk_id });
            return i;
        }
        public List<config_major_kind_Model> listconfig_major_kind()
        {
            List<config_major_kind_Model> list = new List<config_major_kind_Model>();
            List<config_major_kind> list1 = SelectAll();
            foreach (config_major_kind item in list1)
            {
                config_major_kind_Model CM = new config_major_kind_Model()
                {
                    major_kind_id=item.major_kind_id,
                    major_kind_name=item.major_kind_name,
                    mfk_id=item.mfk_id
                };
                list.Add(CM);
            }
            return list;
        }
        public string SelectMaxconfig_major_kind()
        {
            string sql = "select max([major_kind_id])+1 from [dbo].[config_major_kind]";
            string max =SqlDBHelper.DGZ(sql).ToString();
            return max;
        }

        #endregion
    }
}
