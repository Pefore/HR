using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Major_changeModel
    {
        public int Id { get; set; }
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
        /// 职位分类编号
        /// </summary>
        public string major_kind_id { get; set; }
        /// <summary>
        /// 职位分类名称
        /// </summary>
        public string major_kind_name { get; set; }
        /// <summary>
        /// 职位编号
        /// </summary>
        public string major_id { get; set; }
        /// <summary>
        /// 职位名称
        /// </summary>
        public string major_name { get; set; }
        /// <summary>
        /// 新一级机构编号
        /// </summary>
        public string new_first_kind_id { get; set; }
        /// <summary>
        /// 新一级机构名称
        /// </summary>
        public string new_first_kind_name { get; set; }
        /// <summary>
        /// 新二级机构编号
        /// </summary>
        public string new_second_kind_id { get; set; }
        /// <summary>
        /// 新二级机构名称
        /// </summary>
        public string new_second_kind_name { get; set; }
        /// <summary>
        /// 新三级机构编号
        /// </summary>
        public string new_third_kind_id { get; set; }
        /// <summary>
        /// 新三级机构名称
        /// </summary>
        public string new_third_kind_name { get; set; }
        /// <summary>
        /// 新职位分类编号
        /// </summary>
        public string new_major_kind_id { get; set; }
        /// <summary>
        /// 新职位分类名称
        /// </summary>
        public string new_major_kind_name { get; set; }
        /// <summary>
        /// 新职位编号
        /// </summary>
        public string new_major_id { get; set; }
        /// <summary>
        /// 新职位名称
        /// </summary>
        public string new_major_name { get; set; }
        /// <summary>
        /// 人力资源档案编号
        /// </summary>
        public string human_id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string human_name { get; set; }
        /// <summary>
        /// 薪酬标准编号
        /// </summary>
        public string salary_standard_id { get; set; }
        /// <summary>
        /// 薪酬标准名称
        /// </summary>
        public string salary_standard_name { get; set; }
        /// <summary>
        /// 薪酬总额
        /// </summary>
        public float salary_sum { get; set; }
        /// <summary>
        /// 新薪酬标准编号
        /// </summary>
        public string new_salary_standard_id { get; set; }
        /// <summary>
        /// 新薪酬标准名称
        /// </summary>
        public string new_salary_standard_name { get; set; }
        /// <summary>
        /// 新薪酬总额
        /// </summary>
        public float new_salary_sum { get; set; }
        /// <summary>
        /// 调动原因
        /// </summary>
        public string change_reason { get; set; }
        /// <summary>
        /// 审核通过意见
        /// </summary>
        public string check_reason { get; set; }
        /// <summary>
        /// 复核通过状态
        /// </summary>
        public int check_status { get; set; }
        /// <summary>
        /// 登记人
        /// </summary>
        public string register { get; set; }
        /// <summary>
        /// 复核人
        /// </summary>
        public string checker { get; set; }
        /// <summary>
        /// 登记时间
        /// </summary>
        public DateTime regist_time { get; set; }
        /// <summary>
        /// 复核时间
        /// </summary>
        public DateTime check_time { get; set; }
    }
}
