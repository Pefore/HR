using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity
{
    public class users
    {
        public int Id { get; set; }//主键名
        public string user_name { get; set; }//用户名
        public string user_true_name { get; set; }//真实名字
        public string user_password { get; set; }//密码
    }
}
