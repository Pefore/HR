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
    }
}
