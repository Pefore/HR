﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.salaryCriterionModel
{
   public class salary_standard_detailsModel
    {
        public int sdt_id { get; set; }
        public string standard_id { get; set; }
        public string standard_name { get; set; }
        public int item_id { get; set; }
        public string item_name { get; set; }
        public double salary { get; set; }
    }
}
