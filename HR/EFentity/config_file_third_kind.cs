﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity
{
    /// <summary>
    /// 三级结构表
    /// </summary>
    public class config_file_third_kind
    {
        public int Id { get; set; }//主键
        public string first_kind_id { get; set; }//一级机构编号
        public string first_kind_name { get; set; }//一级机构名称
        public string second_kind_id { get; set; }//二级机构编号
        public string second_kind_name { get; set; }//二级机构名称
        public string third_kind_id { get; set; }//三级机构编号
        public string third_kind_name { get; set; }//三级机构名称
        public string third_kind_sale_id { get; set; }//三级机构销售责任人编号
        public string third_kind_is_retail { get; set; }//三级机构是否为零售店
    }
}
