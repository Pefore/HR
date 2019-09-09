using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{ 
    /// <summary>
   /// 一级结构表
   /// </summary>
    public class config_file_first_kindModel
    {
        public int Id { get; set; }//主键名
        public string first_kind_id { get; set; }//一级机构编号
        [Required(ErrorMessage = "名称不能为空")]
        public string first_kind_name { get; set; } //一级机构名称 
        [Required(ErrorMessage = "一级机构薪酬发放责任人编号不能为空")]
        public string first_kind_salary_id { get; set; }//一级机构薪酬发放责任人编号 
        [Required(ErrorMessage = "一级机构销售责任人编号不能为空")]
        public string first_kind_sale_id { get; set; }// 一级机构销售责任人编号    
    }
}
