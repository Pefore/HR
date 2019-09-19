using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    ///  薪酬发放详细信息
    /// </summary>
    public class salary_grant_detailsModel
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 薪酬发放编号
        /// </summary>
        public string salary_grant_id { get; set; }
        /// <summary>
        /// 档案编号
        /// </summary>
        public string human_id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string human_name { get; set; }
        /// <summary>
        /// 奖励金额
        /// </summary>
        public string bouns_sum { get; set; }
        /// <summary>
        /// 销售绩效金额 
        /// </summary>
        public string sale_sum { get; set; }
        /// <summary>
        /// 应扣金额
        /// </summary>
        public string deduct_sum { get; set; }
        /// <summary>
        /// 标准薪酬总额
        /// </summary>
        public string salary_standard_sum { get; set; }
        /// <summary>
        /// 实发薪酬总额 
        /// </summary>
        public string salary_paid_sum { get; set; }
    }
}
