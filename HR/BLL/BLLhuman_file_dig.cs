using IFBLL;
using IFDAL;
using IOC;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLhuman_file_dig: IFBLLhuman_file_dig
    {
        IFDALhuman_file_dig ist = UserIOC.Createhuman_file_digDAO();
        public int Add(human_file_digModel st)
        {
            return ist.Add(st);
        }

        public List<human_file_digModel> cx(string id)
        {
            return ist.cx(id);
        }

        public int Del(human_file_digModel st)
        {
            return ist.Del(st);
        }

        public Dictionary<string, object> FenYe(int zt, int currentPage)
        {
            return ist.FenYe(zt,currentPage);
        }

        public string ooo()
        {
            return ist.ooo();
        }

        public List<human_file_digModel> Select()
        {
            return ist.Select();
        }

        public int Update(human_file_digModel st)
        {
            return ist.Update(st);
        }

        public human_file_digModel XGCX(int id)
        {
            return ist.XGCX(id);
        }
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="currentPage">当前页</param>
        /// <param name="first_kind_id">一级机构</param>
        /// <param name="second_kind_id">二级结构</param>
        /// <param name="third_kind_id">三级机构</param>
        /// <param name="human_major_kind_id">职位分类编号</param>
        /// <param name="human_major_id">职位编号</param>
        /// <param name="regist_timek">档案开始时间</param>
        /// <param name="regist_timej">档案结束时间</param>
        /// <returns></returns>
        public Dictionary<string, object> FenYe(int zt,int currentPage, string first_kind_id, string second_kind_id, string third_kind_id, string human_major_kind_id, string human_major_id, string regist_timek, string regist_timej)
        {
            return ist.FenYe(zt,currentPage, first_kind_id, second_kind_id, third_kind_id,human_major_kind_id,human_major_id,regist_timek,regist_timej);
        }

        public Dictionary<string, object> FenYe(int zt, int currentPage, string tj)
        {
            return ist.FenYe(zt, currentPage, tj);
        }

        public List<human_file_digModel> selectupdate(string id)
        {
            return ist.selectupdate(id);
        }
    }
}
