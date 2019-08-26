using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class config_file_third_kindModel
    {
        public int Id { get; set; }//主键
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
        /// 三级机构销售责任人编号
        /// </summary>
        public string third_kind_sale_id { get; set; }
        /// <summary>
        /// 三级机构是否为零售店
        /// </summary>
        public string third_kind_is_retail { get; set; }
    }
}
