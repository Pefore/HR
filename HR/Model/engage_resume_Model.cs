﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 简历管理
    /// </summary>
    public class engage_resume_Model
    {
        public int res_id { get; set; }
        public string human_name { get; set; }
        public string engage_type { get; set; }
        public string human_address { get; set; }
        public string human_postcode { get; set; }
        public string human_major_kind_id { get; set; }
        public string human_major_kind_name { get; set; }
        public string human_major_id { get; set; }
        public string human_major_name { get; set; }
        public string human_telephone { get; set; }
        public string human_homephone { get; set; }
        public string human_mobilephone { get; set; }
        public string human_email { get; set; }
        public string human_hobby { get; set; }
        public string human_specility { get; set; }
        public string human_sex { get; set; }
        public string human_religion { get; set; }
        public string human_party { get; set; }
        public string human_nationality { get; set; }
        public string human_race { get; set; }
        public DateTime human_birthday { get; set; }
        public int human_age { get; set; }
        public string human_educated_degree { get; set; }
        public int human_educated_years { get; set; }
        public string human_educated_major { get; set; }
        public string human_college { get; set; }
        public string human_idcard { get; set; }
        public string human_birthplace { get; set; }
        public double demand_salary_standard { get; set; }
        public string human_history_records { get; set; }
        public string remark { get; set; }
        public string recomandation { get; set; }
        public string human_picture { get; set; }
        public int attachment_name { get; set; }
        public int check_status { get; set; }
        public string register { get; set; }
        public DateTime regist_time { get; set; }
        public string checker { get; set; }
        public DateTime check_time { get; set; }
        public int interview_status { get; set; }
        public float total_points { get; set; }
        public int test_amount { get; set; }
        public string test_checker { get; set; }
        public DateTime test_check_time { get; set; }
        public string pass_register { get; set; }
        public DateTime pass_regist_time { get; set; }
        public string pass_checker { get; set; }
        public DateTime pass_check_time { get; set; }
        public int pass_check_status { get; set; }
        public string pass_checkComment { get; set; }
        public string pass_passComment { get; set; }
        public string check_status1 { get; set; }
        public string interview_status1 { get; set; }
    }
}
