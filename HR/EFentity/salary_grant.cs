using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity
{
    /// <summary>
    ///  薪酬发放登记表  
    /// </summary>
    public class salary_grant
    {
        /// <summary>
        /// 主键名
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 薪酬发放编号
        /// </summary>
        public string salary_grant_id { get; set; }
        /// <summary>
        /// 薪酬标准单编号
        /// </summary>
        public string salary_standard_id { get; set; }
        /// <summary>
        /// 一级机构编号
        /// </summary>
        public string first_kind_id { get; set; }
        /// <summary>
        /// 一级机构名称
        /// </summary>
        public string first_kind_name { get; set; }
        /// <summary>
        /// 二级机构编号
        /// </summary>
        public string second_kind_id { get; set; }
        /// <summary>
        /// 二级机构名称
        /// </summary>
        public string second_kind_name { get; set; }
        /// <summary>
        /// 三级机构编号
        /// </summary>
        public string third_kind_id { get; set; }
        /// <summary>
        /// 三级机构名称
        /// </summary>
        public string third_kind_name { get; set; }
        /// <summary>
        /// 总人数
        /// </summary>
        public int human_amount { get; set; }
        /// <summary>
        /// 标准薪酬总金额
        /// </summary>
        public string salary_standard_sum { get; set; }
        /// <summary>
        /// 实发总金额
        /// </summary>
        public string salary_paid_sum { get; set; }
        /// <summary>
        /// 登记人
        /// </summary>
        public string register { get; set; }
        /// <summary>
        /// 登记时间
        /// </summary>
        public DateTime regist_time { get; set; }
        /// <summary>
        /// 复核人
        /// </summary>
        public string checker { get; set; }
        /// <summary>
        /// 复核时间
        /// </summary>
        public DateTime check_time { get; set; }
        /// <summary>
        /// 复核状态
        /// </summary>
        public int check_status { get; set; }
    }
}
