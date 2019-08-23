using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity
{
   public class config_major
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int mak_id { get; set; }
        public string major_kind_id { get; set; }
        public string major_kind_name { get; set; }
        public string Position_Name_id { get; set; }
        public string Position_Name { get; set; }
        public int test_amount { get; set; }
    }
}
