using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFDAL
{
    public interface IFDALhuman_file_dig
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        int Add(human_file_digModel st);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        int Del(human_file_digModel st);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        int Update(human_file_digModel st);
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        List<human_file_digModel> Select();
        /// <summary>
        /// 修改显示
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        human_file_digModel XGCX(int id);
        /// <summary>
        /// 按条件查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<human_file_digModel> cx(string id);
        /// <summary>
        /// 查询数据库的主键作为编号依据
        /// </summary>
        /// <returns></returns>
        string ooo();
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="currentPage"></param>
        /// <returns></returns>
        Dictionary<string, object> FenYe(int zt, int currentPage);
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
        Dictionary<string, object> FenYe(int zt,int currentPage, string first_kind_id, string second_kind_id, string third_kind_id, string human_major_kind_id, string human_major_id, string regist_timek, string regist_timej);
        Dictionary<string, object> FenYe(int zt, int currentPage, string tj);
        List<human_file_digModel> selectupdate(string id);
    }
}
