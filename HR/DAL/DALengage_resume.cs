using EFentity.position_register;
using IFDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.CaoZuoLei;
using System.Collections;
using System.Linq.Expressions;

namespace DAL
{
    public class DALengage_resume : DaoBase<engage_resume>, IFDALengage_resume
    {
        public int engage_resumeAdd(engage_resume_Model e)
        {
            engage_resume er = new engage_resume();
            er.human_name = e.human_name;
            er.engage_type = e.engage_type;
            er.human_address = e.human_address;
            er.human_postcode = e.human_postcode;
            er.human_major_kind_id = e.human_major_kind_id;
            er.human_major_kind_name = e.human_major_kind_name;
            er.human_major_id = e.human_major_id;
            er.human_major_name = e.human_major_name;
            er.human_telephone = e.human_telephone;
            er.human_homephone = e.human_homephone;
            er.human_mobilephone = e.human_mobilephone;
            er.human_email = e.human_email;
            er.human_hobby = e.human_hobby;
            er.human_specility = e.human_specility;
            er.human_sex = e.human_sex;
            er.human_religion = e.human_religion;
            er.human_party = e.human_party;
            er.human_nationality = e.human_nationality;
            er.human_race = e.human_race;
            er.human_birthday = e.human_birthday;
            er.human_age = e.human_age;
            er.human_educated_years = e.human_educated_years;
            er.human_educated_major = e.human_educated_major;
            er.human_college = e.human_college;
            er.human_idcard = e.human_idcard;
            er.human_birthplace = e.human_birthplace;
            er.demand_salary_standard = e.demand_salary_standard;
            er.human_history_records = e.human_history_records;
            er.remark = e.remark;
            er.regist_time = e.regist_time;
            er.register = e.register;
            er.check_time = Convert.ToDateTime("2000-01-01");
            er.pass_check_time = Convert.ToDateTime("2000-01-01");
            er.pass_regist_time = Convert.ToDateTime("2000-01-01");
            er.test_check_time = Convert.ToDateTime("2000-01-01");
            er.human_educated_degree = e.human_educated_degree;
            er.check_status = e.check_status;
            return Add(er);
        }
        public ArrayList engage_resumeLikeFenYe(LikeFenYe l)
        {
            ArrayList list2 = new ArrayList();
            int rows = 0;
            List<engage_resume> list = null;
            List<engage_resume_Model> list1 = new List<engage_resume_Model>();
            list = FenYe<int>(e => e.res_id, e => (e.human_major_kind_id.Contains(l.major_kind_id) && e.human_major_id.Contains(l.humanMajorId) && e.human_name.Contains(l.primarKey) && e.regist_time > l.startDate && e.regist_time < l.endDate && e.check_status==1), ref rows, l.Dq, l.PageSize);
            if (list.Count() == 0)
            {
                list = FenYe<int>(e => e.res_id, e => (e.human_major_kind_id.Contains(l.major_kind_id) && e.human_major_id.Contains(l.humanMajorId) && e.human_address.Contains(l.primarKey) && e.regist_time > l.startDate && e.regist_time < l.endDate && e.check_status == 1), ref rows, l.Dq, l.PageSize);
                if (list.Count() == 0)
                {
                   
                }
            }
            foreach (var item in list)
            {
                engage_resume_Model erm = new engage_resume_Model()
                {
                    human_name = item.human_name,
                    res_id = item.res_id,
                    human_sex = item.human_sex,
                    human_major_kind_name = item.human_major_kind_name,
                    human_major_name = item.human_major_name,
                    human_telephone = item.human_telephone,
                    check_status = item.check_status,
                    human_age = item.human_age
                };
                if (item.check_status == 1)
                {
                    erm.check_status1 = "待复核";
                }
                list1.Add(erm);
            }
            list2.Add(list1);
            list2.Add(rows);
            list2.Add(l.Dq);
            list2.Add(l.PageSize);
            list2.Add((rows - 1) / l.PageSize + 1);
            return list2;
        }

        public int engage_resumeUpdate(engage_resume_Model e)
        {
            engage_resume er = new engage_resume();
            er.human_name = e.human_name;
            er.engage_type = e.engage_type;
            er.human_address = e.human_address;
            er.human_postcode = e.human_postcode;
            er.human_major_kind_id = e.human_major_kind_id;
            er.human_major_kind_name = e.human_major_kind_name;
            er.human_major_id = e.human_major_id;
            er.human_major_name = e.human_major_name;
            er.human_telephone = e.human_telephone;
            er.human_homephone = e.human_homephone;
            er.human_mobilephone = e.human_mobilephone;
            er.human_email = e.human_email;
            er.human_hobby = e.human_hobby;
            er.human_specility = e.human_specility;
            er.human_sex = e.human_sex;
            er.human_religion = e.human_religion;
            er.human_party = e.human_party;
            er.human_nationality = e.human_nationality;
            er.human_race = e.human_race;
            er.human_birthday = e.human_birthday;
            er.human_age = e.human_age;
            er.human_educated_years = e.human_educated_years;
            er.human_educated_major = e.human_educated_major;
            er.human_college = e.human_college;
            er.human_idcard = e.human_idcard;
            er.human_birthplace = e.human_birthplace;
            er.demand_salary_standard = e.demand_salary_standard;
            er.human_history_records = e.human_history_records;
            er.remark = e.remark;
            er.regist_time = e.regist_time;
            er.register = e.register;
            er.checker = e.checker;
            er.check_time =e.check_time;
            er.pass_check_time = Convert.ToDateTime("2000-01-01");
            er.pass_regist_time = Convert.ToDateTime("2000-01-01");
            er.test_check_time = Convert.ToDateTime("2000-01-01");
            er.human_educated_degree = e.human_educated_degree;
            er.check_status = e.check_status;
            er.recomandation = e.recomandation;
            er.res_id = e.res_id;
            er.interview_status = 1;
            return Update(er);
        }

        public engage_resume_Model SelectId(engage_resume_Model em)
        {
            engage_resume e = SelectBy(el => el.res_id == em.res_id).FirstOrDefault();
            engage_resume_Model er = new engage_resume_Model();
            er.human_name = e.human_name;
            er.engage_type = e.engage_type;
            er.human_address = e.human_address;
            er.human_postcode = e.human_postcode;
            er.human_major_kind_id = e.human_major_kind_id;
            er.human_major_kind_name = e.human_major_kind_name;
            er.human_major_id = e.human_major_id;
            er.human_major_name = e.human_major_name;
            er.human_telephone = e.human_telephone;
            er.human_homephone = e.human_homephone;
            er.human_mobilephone = e.human_mobilephone;
            er.human_email = e.human_email;
            er.human_hobby = e.human_hobby;
            er.human_specility = e.human_specility;
            er.human_sex = e.human_sex;
            er.human_religion = e.human_religion;
            er.human_party = e.human_party;
            er.human_nationality = e.human_nationality;
            er.human_race = e.human_race;
            er.human_birthday = e.human_birthday;
            er.human_age = e.human_age;
            er.human_educated_years = e.human_educated_years;
            er.human_educated_major = e.human_educated_major;
            er.human_college = e.human_college;
            er.human_idcard = e.human_idcard;
            er.human_birthplace = e.human_birthplace;
            er.demand_salary_standard = e.demand_salary_standard;
            er.human_history_records = e.human_history_records;
            er.remark = e.remark;
            er.regist_time = e.regist_time;
            er.register = e.register;
            er.check_time =e.check_time;
            er.pass_check_time = Convert.ToDateTime("2000-01-01");
            er.pass_regist_time = Convert.ToDateTime("2000-01-01");
            er.test_check_time = Convert.ToDateTime("2000-01-01");
            er.human_educated_degree = e.human_educated_degree;
            er.check_status = e.check_status;
            er.checker = e.checker;
            er.recomandation = e.recomandation;
            er.res_id = e.res_id;
            return er;
        }
        public ArrayList engage_resumeYouXianFenYe(LikeFenYe l)
        {
            ArrayList list2 = new ArrayList();
            int rows = 0;
            List<engage_resume> list = null;
            List<engage_resume_Model> list1 = new List<engage_resume_Model>();
            list = FenYe<int>(e => e.res_id, e => (e.human_major_kind_id.Contains(l.major_kind_id) && e.human_major_id.Contains(l.humanMajorId) && e.human_name.Contains(l.primarKey) && e.regist_time > l.startDate && e.regist_time < l.endDate && e.interview_status == 1), ref rows, l.Dq, l.PageSize);
            if (list.Count() == 0)
            {
                list = FenYe<int>(e => e.res_id, e => (e.human_major_kind_id.Contains(l.major_kind_id) && e.human_major_id.Contains(l.humanMajorId) && e.human_address.Contains(l.primarKey) && e.regist_time > l.startDate && e.regist_time < l.endDate && e.interview_status == 1), ref rows, l.Dq, l.PageSize);
            }
            foreach (var item in list)
            {
                engage_resume_Model erm = new engage_resume_Model()
                {
                    human_name = item.human_name,
                    res_id = item.res_id,
                    human_sex = item.human_sex,
                    human_major_kind_name = item.human_major_kind_name,
                    human_major_name = item.human_major_name,
                    human_telephone = item.human_telephone,
                    check_status = item.check_status,
                    human_age = item.human_age,
                    interview_status=item.interview_status
                };
                if (item.check_status == 2)
                {
                    erm.check_status1 = "通过";
                }
                if (item.interview_status == 1)
                {
                    erm.interview_status1 = "待面试";
                }
                list1.Add(erm);
            }
            list2.Add(list1);
            list2.Add(rows);
            list2.Add(l.Dq);
            list2.Add(l.PageSize);
            list2.Add((rows - 1) / l.PageSize + 1);
            return list2;
        }
    }
}
