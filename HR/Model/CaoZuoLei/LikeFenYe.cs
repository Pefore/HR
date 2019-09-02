using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.CaoZuoLei
{
   public class LikeFenYe
    {
        public string major_kind_id { get; set; }
        public string humanMajorId { get; set; }
        public string primarKey { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int Dq { get; set; }
        public int PageSize { get; set; }
    }
}
