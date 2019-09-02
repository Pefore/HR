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
    public class DALconfig_major : DaoBase<config_major>, IFDALconfig_major
    {
        #region 职位设置
        public int Addconfig_major(config_major_Model cn)
        {
            config_major c = new config_major()
            {
               test_amount=0,
               major_kind_id=cn.major_kind_id,
               major_kind_name=cn.major_kind_name,
               Position_Name=cn.Position_Name,
               Position_Name_id=cn.Position_Name_id

            };
            return Add(c);
        }

        public int Deleteconfig_major(config_major_Model cn)
        {
            int i = Delete(new config_major() { mak_id = cn.mak_id });
            return i;
        }
        public List<config_major_Model> listconfig_major()
        {
            List<config_major_Model> list = new List<config_major_Model>();
            List<config_major> list1 = SelectAll();
            foreach (config_major item in list1)
            {
                config_major_Model CM = new config_major_Model()
                {
                    major_kind_id=item.major_kind_id,
                    major_kind_name=item.major_kind_name,
                    mak_id=item.mak_id,
                    Position_Name_id=item.Position_Name_id,
                    Position_Name=item.Position_Name
                };
                list.Add(CM);
            }
            return list;
        }
        public string SelectMaxconfig_major()
        {
            string sql = "select max([major_kind_id])+1 from [dbo].[config_major_kind]";
            string max = "0" + SqlDBHelper.DGZ(sql).ToString();
            return max;
        }

        public List<config_major_Model> SelectwWhere(string id)
        {
            List<config_major_Model> list = new List<config_major_Model>();
            List<config_major> list1 = SelectBy(e=>e.major_kind_id.Equals(id));
            foreach (config_major item in list1)
            {
                config_major_Model CM = new config_major_Model()
                {
                    major_kind_id = item.major_kind_id,
                    major_kind_name = item.major_kind_name,
                    mak_id = item.mak_id,
                    Position_Name_id = item.Position_Name_id,
                    Position_Name = item.Position_Name
                };
                list.Add(CM);
            }
            return list;
        }

        #endregion
    }
}
