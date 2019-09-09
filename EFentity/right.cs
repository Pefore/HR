using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity
{
    public class right
    {
        /// <summary>
        /// 角色编号 
        /// </summary>
        [Key]
        public int right_id { get; set; }
        /// <summary>
        ///角色名称 
        /// </summary>
        public string right_name { get; set; }
        /// <summary>
        ///角色说明 
        /// </summary>
        public string right_explain { get; set; }
        /// <summary>
        ///是否可用 
        /// </summary>
        public string right_usable { get; set; }
        public virtual ICollection<user> user { get; set; } = new List<user>();
    }
}
