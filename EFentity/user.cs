using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity
{
    public class user
    {
        public int Id { get; set; }//主键名
        public string user_name { get; set; }//用户名
        public string user_true_name { get; set; }//真实名字
        public string user_password { get; set; }//密码
        /// <summary>
        /// 角色id
        /// </summary>
        public int right_id { get; set; }
        public virtual ICollection<right> right { get; set; } = new List<right>();
    }
}
