﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity
{
    /// <summary>
    /// 二级机构设置 (表)
    /// </summary>
    public class config_file_second_kind
    {    
        public int Id { get; set; }//主键
        public string first_kind_id { get; set; }//一级机构编号   
        public string first_kind_name { get; set; }//一级机构名称 
        public string second_kind_id { get; set; }//二级机构编号
        public string second_kind_name { get; set; }//二级机构名称 
        public string econd_salary_id { get; set; }//二级机构薪酬发放责任人编号
        public string second_sale_id { get; set; }// 二级机构销售责任人编号 
    }
}
