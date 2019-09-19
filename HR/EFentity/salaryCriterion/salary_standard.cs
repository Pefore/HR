using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity.salaryCriterion
{

   public class salary_standard
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int ssd_id { get; set; }
        /// <summary>
        /// 薪酬标准单编号
        /// </summary>
        public string standard_id { get; set; }
        /// <summary>
        /// 薪酬标准单名称
        /// </summary>
        public string standard_name { get; set; }
        /// <summary>
        /// 制定者名字
        /// </summary>
        public string designer { get; set; }
        /// <summary>
        /// 登记人
        /// </summary>
        public string register { get; set; }
        /// <summary>
        /// 复核人
        /// </summary>
        public string checker { get; set; }
        /// <summary>
        /// 变更人
        /// </summary>
        public string changer { get; set; }
        /// <summary>
        /// 登记时间  
        /// </summary>
        public DateTime regist_time { get; set; }
        /// <summary>
        /// 复核时间    
        /// </summary>
        public DateTime check_time { get; set; }
        /// <summary>
        /// 变更时间
        /// </summary>
        public DateTime change_time { get; set; }
        /// <summary>
        /// 薪酬总额 
        /// </summary>
        public double salary_sum { get; set; }
        /// <summary>
        /// 是否经过复核
        /// </summary>
        public int check_status { get; set; }
        /// <summary>
        /// 更改状态    
        /// </summary>
        public int change_status { get; set; }
        /// <summary>
        /// 复核意见
        /// </summary>
        public string check_comment { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }
    }
}
