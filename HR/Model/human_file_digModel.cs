using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 人力资源档案
    /// </summary>
    public class human_file_digModel
    {
        public int Id { get; set; }
        /// <summary>
        /// 档案编号   
        /// </summary>
        public string human_id { get; set; }
        /// <summary>
        /// 一级机构编号     
        /// </summary>
        public string first_kind_id { get; set; }
        /// <summary>
        ///  一级机构名称  
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
        /// 姓名  
        /// </summary>
        public string human_name { get; set; }
        /// <summary>
        ///  地址
        /// </summary>
        public string human_address { get; set; }
        /// <summary>
        /// 邮政编码  
        /// </summary>
        public string human_postcode { get; set; }
        /// <summary>
        /// 职称
        /// </summary>
        public string human_pro_designation { get; set; }
        /// <summary>
        /// 职位分类编号   
        /// </summary>
        public string human_major_kind_id { get; set; }
        /// <summary>
        /// 职位分类名称
        /// </summary>
        public string human_major_kind_name { get; set; }
        /// <summary>
        /// 职位编号 
        /// </summary>
        public string human_major_id { get; set; }
        /// <summary>
        /// 职位名称
        /// </summary>
        public string hunma_major_name { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string human_telephone { get; set; }
        /// <summary>
        /// 手机号码  
        /// </summary>
        public string human_mobilephone { get; set; }
        /// <summary>
        /// 开户银行 
        /// </summary>
        public string human_bank { get; set; }
        /// <summary>
        /// 银行帐号 
        /// </summary>
        public string human_account { get; set; }
        /// <summary>
        /// QQ号码   
        /// </summary>
        public string human_qq { get; set; }
        /// <summary>
        /// 电子邮件  
        /// </summary>
        public string human_email { get; set; }
        /// <summary>
        /// 爱好
        /// </summary>
        public string human_hobby { get; set; }
        /// <summary>
        ///  特长    
        /// </summary>
        public string human_speciality { get; set; }
        /// <summary>
        /// 性别   
        /// </summary>
        public string human_sex { get; set; }
        /// <summary>
        /// 宗教信仰
        /// </summary>
        public string human_religion { get; set; }
        /// <summary>
        /// 政治面貌    
        /// </summary>
        public string human_party { get; set; }
        /// <summary>
        /// 国籍    
        /// </summary>
        public string human_nationality { get; set; }
        /// <summary>
        /// 民族  
        /// </summary>
        public string human_race { get; set; }
        /// <summary>
        ///  出生日期
        /// </summary>
        public DateTime human_birthday { get; set; }
        /// <summary>
        /// 出生地
        /// </summary>
        public string human_birthplace { get; set; }
        /// <summary>
        ///  年龄 
        /// </summary>
        public int human_age { get; set; }
        /// <summary>
        /// 学历
        /// </summary>
        public string human_educated_degree { get; set; }
        /// <summary>
        /// 教育年限    
        /// </summary>
        public int human_educated_years { get; set; }
        /// <summary>
        /// 学历专业     
        /// </summary>
        public string human_educated_major { get; set; }
        /// <summary>
        /// 社会保障号 
        /// </summary>
        public string human_society_security_id { get; set; }
        /// <summary>
        /// 身份证号   
        /// </summary>
        public string human_id_card { get; set; }
        /// <summary>
        /// 备注  
        /// </summary>
        public string remark { get; set; }
        /// <summary>
        ///  薪酬标准编号    
        /// </summary>
        public string salary_standard_id { get; set; }
        /// <summary>
        ///  薪酬标准名称  
        /// </summary>
        public string salary_standard_name { get; set; }
        /// <summary>
        /// 基本薪酬总额      
        /// </summary>
        public decimal salary_sum { get; set; }
        /// <summary>
        ///  应发薪酬总额       
        /// </summary>
        public decimal demand_salaray_sum { get; set; }
        /// <summary>
        ///  实发薪酬总额  
        /// </summary>
        public decimal paid_salary_sum { get; set; }
        /// <summary>
        ///  调动次数   
        /// </summary>
        public int major_change_amount { get; set; }
        /// <summary>
        /// 激励累计次数 
        /// </summary>
        public int bonus_amount { get; set; }
        /// <summary>
        /// 培训累计次数 
        /// </summary>
        public int training_amount { get; set; }
        /// <summary>
        /// 档案变更累计次数
        /// </summary>
        public int file_chang_amount { get; set; }
        /// <summary>
        ///  简历
        /// </summary>
        public string human_histroy_records { get; set; }
        /// <summary>
        /// 家庭关系  
        /// </summary>
        public string human_family_membership { get; set; }
        /// <summary>
        /// 相片
        /// </summary>
        public string human_picture { get; set; }
        /// <summary>
        ///  附件名称   
        /// </summary>
        public string attachment_name { get; set; }
        /// <summary>
        /// 复核状态
        /// </summary>
        public int check_status { get; set; }
        /// <summary>
        /// 档案登记人
        /// </summary>
        public string register { get; set; }
        /// <summary>
        ///  档案复核人      
        /// </summary>
        public string checker { get; set; }
        /// <summary>
        /// 档案变更人    
        /// </summary>
        public string changer { get; set; }
        /// <summary>
        /// 档案登记时间    
        /// </summary>
        public DateTime regist_time { get; set; }
        /// <summary>
        /// 档案复核时间          
        /// </summary>
        public DateTime check_time { get; set; }
        /// <summary>
        /// 档案变更时间 
        /// </summary>
        public DateTime change_time { get; set; }
        /// <summary>
        /// 档案最近更改时间 
        /// </summary>
        public DateTime lastly_change_time { get; set; }
        /// <summary>
        /// 档案删除时间 
        /// </summary>
        public DateTime delete_time { get; set; }
        /// <summary>
        /// 档案恢复时间       
        /// </summary>
        public DateTime recovery_time { get; set; }
        /// <summary>
        /// 档案状态
        /// </summary>
        public int human_file_status { get; set; }
    }
}
