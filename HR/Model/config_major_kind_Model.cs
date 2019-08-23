using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public  class config_major_kind_Model
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int mfk_id { get; set; }
        public string major_kind_id { get; set; }
        [Required(ErrorMessage = "职位分类名称不能为空")]
        [StringLength(maximumLength: 6, ErrorMessage = "名称不能超过6位长度")]
        public string major_kind_name { get; set; }

    }
}
