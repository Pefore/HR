using EFentity;
using IFDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALhuman_file_dig :DaoBase<human_file_dig>, IFDALhuman_file_dig
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public int Add(human_file_digModel st)
        {
            //把DTO转为EO
            human_file_dig est = new human_file_dig()
            {
                human_id=st.human_id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                second_kind_id = st.second_kind_id,
                second_kind_name = st.second_kind_name,
                third_kind_id=st.third_kind_id,
                third_kind_name=st.third_kind_name,
                human_name=st.human_name,
                human_address=st.human_address,
                human_postcode=st.human_postcode,
                human_pro_designation=st.human_pro_designation,
                human_major_kind_id=st.human_major_kind_id,
                human_major_kind_name=st.human_major_kind_name,
                human_major_id=st.human_major_id,
                hunma_major_name=st.hunma_major_name,
                human_telephone=st.human_telephone,
                human_mobilephone=st.human_mobilephone,
                human_bank=st.human_bank,
                human_account=st.human_account,
                human_qq=st.human_qq,
                human_email=st.human_email,
                human_hobby=st.human_hobby,
                human_speciality=st.human_speciality,
                human_sex=st.human_sex,
                human_religion=st.human_religion,
                human_party=st.human_party,
                human_nationality=st.human_nationality,
                human_race=st.human_race,
                human_birthday=st.human_birthday,
                human_birthplace=st.human_birthplace,
                human_age=st.human_age,
                human_educated_degree=st.human_educated_degree,
                human_educated_years=st.human_educated_years,
                human_educated_major=st.human_educated_major,
                human_society_security_id=st.human_society_security_id,
                human_id_card=st.human_id_card,
                remark=st.remark,
                salary_standard_id=st.salary_standard_id,
                salary_standard_name=st.salary_standard_name,
                salary_sum=st.salary_sum,
                demand_salaray_sum=st.demand_salaray_sum,
                paid_salary_sum=st.paid_salary_sum,
                major_change_amount=st.major_change_amount,
                bonus_amount=st.bonus_amount,
                training_amount=st.training_amount,
                file_chang_amount=st.file_chang_amount,
                human_histroy_records=st.human_histroy_records,
                human_family_membership=st.human_family_membership,
                human_picture = st.human_picture,
                attachment_name=st.attachment_name,
                check_status=st.check_status,
                register=st.register,
                checker=st.checker,
                changer=st.changer,
                regist_time=DateTime.Now,
                check_time=DateTime.Now,
                change_time= DateTime.Now,
                lastly_change_time= DateTime.Now,
                delete_time= DateTime.Now,
                recovery_time= DateTime.Now,
                human_file_status=st.human_file_status
            };
            return Add(est);
        }
        /// <summary>
        /// 按条件查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<human_file_digModel> cx(string id)
        {
            List<human_file_dig> list = SelectBy(e => e.first_kind_id.Equals(id));
            List<human_file_digModel> list2 = new List<human_file_digModel>();
            foreach (human_file_dig st in list)
            {
                human_file_digModel sm = new human_file_digModel()
                {
                    Id = st.Id,
                    human_id = st.human_id,
                    first_kind_id = st.first_kind_id,
                    first_kind_name = st.first_kind_name,
                    second_kind_id = st.second_kind_id,
                    second_kind_name = st.second_kind_name,
                    third_kind_id = st.third_kind_id,
                    third_kind_name = st.third_kind_name,
                    human_name = st.human_name,
                    human_address = st.human_address,
                    human_postcode = st.human_postcode,
                    human_pro_designation = st.human_pro_designation,
                    human_major_kind_id = st.human_major_kind_id,
                    human_major_kind_name = st.human_major_kind_name,
                    human_major_id = st.human_major_id,
                    hunma_major_name = st.hunma_major_name,
                    human_telephone = st.human_telephone,
                    human_mobilephone = st.human_mobilephone,
                    human_bank = st.human_bank,
                    human_account = st.human_account,
                    human_qq = st.human_qq,
                    human_email = st.human_email,
                    human_hobby = st.human_hobby,
                    human_speciality = st.human_speciality,
                    human_sex = st.human_sex,
                    human_religion = st.human_religion,
                    human_party = st.human_party,
                    human_nationality = st.human_nationality,
                    human_race = st.human_race,
                    human_birthday = st.human_birthday,
                    human_birthplace = st.human_birthplace,
                    human_age = st.human_age,
                    human_educated_degree = st.human_educated_degree,
                    human_educated_years = st.human_educated_years,
                    human_educated_major = st.human_educated_major,
                    human_society_security_id = st.human_society_security_id,
                    human_id_card = st.human_id_card,
                    remark = st.remark,
                    salary_standard_id = st.salary_standard_id,
                    salary_standard_name = st.salary_standard_name,
                    salary_sum = st.salary_sum,
                    demand_salaray_sum = st.demand_salaray_sum,
                    paid_salary_sum = st.paid_salary_sum,
                    major_change_amount = st.major_change_amount,
                    bonus_amount = st.bonus_amount,
                    training_amount = st.training_amount,
                    file_chang_amount = st.file_chang_amount,
                    human_histroy_records = st.human_histroy_records,
                    human_family_membership = st.human_family_membership,
                    human_picture = st.human_picture,
                    attachment_name = st.attachment_name,
                    check_status = st.check_status,
                    register = st.register,
                    checker = st.checker,
                    changer = st.changer,
                    regist_time = st.regist_time,
                    check_time = st.check_time,
                    change_time = st.change_time,
                    lastly_change_time = st.lastly_change_time,
                    delete_time = st.delete_time,
                    recovery_time = st.recovery_time,
                    human_file_status = st.human_file_status
                };
                list2.Add(sm);
            }
            return list2;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public int Del(human_file_digModel st)
        {
            human_file_dig est = new human_file_dig()
            {
                Id = st.Id
            };
            return Delete(est);
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public List<human_file_digModel> Select()
        {
            List<human_file_dig> list = SelectAll();
            List<human_file_digModel> list2 = new List<human_file_digModel>();
            foreach (human_file_dig st in list)
            {
                human_file_digModel sm = new human_file_digModel()
                {
                    Id = st.Id,
                    human_id = st.human_id,
                    first_kind_id = st.first_kind_id,
                    first_kind_name = st.first_kind_name,
                    second_kind_id = st.second_kind_id,
                    second_kind_name = st.second_kind_name,
                    third_kind_id = st.third_kind_id,
                    third_kind_name = st.third_kind_name,
                    human_name = st.human_name,
                    human_address = st.human_address,
                    human_postcode = st.human_postcode,
                    human_pro_designation = st.human_pro_designation,
                    human_major_kind_id = st.human_major_kind_id,
                    human_major_kind_name = st.human_major_kind_name,
                    human_major_id = st.human_major_id,
                    hunma_major_name = st.hunma_major_name,
                    human_telephone = st.human_telephone,
                    human_mobilephone = st.human_mobilephone,
                    human_bank = st.human_bank,
                    human_account = st.human_account,
                    human_qq = st.human_qq,
                    human_email = st.human_email,
                    human_hobby = st.human_hobby,
                    human_speciality = st.human_speciality,
                    human_sex = st.human_sex,
                    human_religion = st.human_religion,
                    human_party = st.human_party,
                    human_nationality = st.human_nationality,
                    human_race = st.human_race,
                    human_birthday = st.human_birthday,
                    human_birthplace = st.human_birthplace,
                    human_age = st.human_age,
                    human_educated_degree = st.human_educated_degree,
                    human_educated_years = st.human_educated_years,
                    human_educated_major = st.human_educated_major,
                    human_society_security_id = st.human_society_security_id,
                    human_id_card = st.human_id_card,
                    remark = st.remark,
                    salary_standard_id = st.salary_standard_id,
                    salary_standard_name = st.salary_standard_name,
                    salary_sum = st.salary_sum,
                    demand_salaray_sum = st.demand_salaray_sum,
                    paid_salary_sum = st.paid_salary_sum,
                    major_change_amount = st.major_change_amount,
                    bonus_amount = st.bonus_amount,
                    training_amount = st.training_amount,
                    file_chang_amount = st.file_chang_amount,
                    human_histroy_records = st.human_histroy_records,
                    human_family_membership = st.human_family_membership,
                    human_picture = st.human_picture,
                    attachment_name = st.attachment_name,
                    check_status = st.check_status,
                    register = st.register,
                    checker = st.checker,
                    changer = st.changer,
                    regist_time = st.regist_time,
                    check_time = st.check_time,
                    change_time = st.change_time,
                    lastly_change_time = st.lastly_change_time,
                    delete_time = st.delete_time,
                    recovery_time = st.recovery_time,
                    human_file_status = st.human_file_status
                };
                list2.Add(sm);
            }
            return list2;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public int Update(human_file_digModel st)
        {
            human_file_dig est = new human_file_dig()
            {
                Id = st.Id,
                human_id = st.human_id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                second_kind_id = st.second_kind_id,
                second_kind_name = st.second_kind_name,
                third_kind_id = st.third_kind_id,
                third_kind_name = st.third_kind_name,
                human_name = st.human_name,
                human_address = st.human_address,
                human_postcode = st.human_postcode,
                human_pro_designation = st.human_pro_designation,
                human_major_kind_id = st.human_major_kind_id,
                human_major_kind_name = st.human_major_kind_name,
                human_major_id = st.human_major_id,
                hunma_major_name = st.hunma_major_name,
                human_telephone = st.human_telephone,
                human_mobilephone = st.human_mobilephone,
                human_bank = st.human_bank,
                human_account = st.human_account,
                human_qq = st.human_qq,
                human_email = st.human_email,
                human_hobby = st.human_hobby,
                human_speciality = st.human_speciality,
                human_sex = st.human_sex,
                human_religion = st.human_religion,
                human_party = st.human_party,
                human_nationality = st.human_nationality,
                human_race = st.human_race,
                human_birthday = st.human_birthday,
                human_birthplace = st.human_birthplace,
                human_age = st.human_age,
                human_educated_degree = st.human_educated_degree,
                human_educated_years = st.human_educated_years,
                human_educated_major = st.human_educated_major,
                human_society_security_id = st.human_society_security_id,
                human_id_card = st.human_id_card,
                remark = st.remark,
                salary_standard_id = st.salary_standard_id,
                salary_standard_name = st.salary_standard_name,
                salary_sum = st.salary_sum,
                demand_salaray_sum = st.demand_salaray_sum,
                paid_salary_sum = st.paid_salary_sum,
                major_change_amount = st.major_change_amount,
                bonus_amount = st.bonus_amount,
                training_amount = st.training_amount,
                file_chang_amount = st.file_chang_amount,
                human_histroy_records = st.human_histroy_records,
                human_family_membership = st.human_family_membership,
                human_picture = st.human_picture,
                attachment_name = st.attachment_name,
                check_status = st.check_status,
                register = st.register,
                checker = st.checker,
                changer = st.changer,
                regist_time = st.regist_time,
                check_time = st.check_time,
                change_time = st.change_time,
                lastly_change_time =st.lastly_change_time,
                delete_time = st.delete_time,
                recovery_time = st.recovery_time,
                human_file_status = st.human_file_status
                //  regist_time = DateTime.Now,
                //check_time = DateTime.Now,
                //change_time = DateTime.Now,
                //lastly_change_time = DateTime.Now,
                //delete_time = DateTime.Now,
                //recovery_time = DateTime.Now,
                //human_file_status = st.human_file_status
            };
            return Update(est);
        }
        /// <summary>
        /// 修改显示
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public human_file_digModel XGCX(int id)
        {
            List<human_file_dig> list = SelectBy(e => e.Id.Equals(id));
            human_file_dig st = list[0];
            human_file_digModel m = new human_file_digModel()
            {
                Id = st.Id,
                human_id = st.human_id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                second_kind_id = st.second_kind_id,
                second_kind_name = st.second_kind_name,
                third_kind_id = st.third_kind_id,
                third_kind_name = st.third_kind_name,
                human_name = st.human_name,
                human_address = st.human_address,
                human_postcode = st.human_postcode,
                human_pro_designation = st.human_pro_designation,
                human_major_kind_id = st.human_major_kind_id,
                human_major_kind_name = st.human_major_kind_name,
                human_major_id = st.human_major_id,
                hunma_major_name = st.hunma_major_name,
                human_telephone = st.human_telephone,
                human_mobilephone = st.human_mobilephone,
                human_bank = st.human_bank,
                human_account = st.human_account,
                human_qq = st.human_qq,
                human_email = st.human_email,
                human_hobby = st.human_hobby,
                human_speciality = st.human_speciality,
                human_sex = st.human_sex,
                human_religion = st.human_religion,
                human_party = st.human_party,
                human_nationality = st.human_nationality,
                human_race = st.human_race,
                human_birthday = st.human_birthday,
                human_birthplace = st.human_birthplace,
                human_age = st.human_age,
                human_educated_degree = st.human_educated_degree,
                human_educated_years = st.human_educated_years,
                human_educated_major = st.human_educated_major,
                human_society_security_id = st.human_society_security_id,
                human_id_card = st.human_id_card,
                remark = st.remark,
                salary_standard_id = st.salary_standard_id,
                salary_standard_name = st.salary_standard_name,
                salary_sum = st.salary_sum,
                demand_salaray_sum = st.demand_salaray_sum,
                paid_salary_sum = st.paid_salary_sum,
                major_change_amount = st.major_change_amount,
                bonus_amount = st.bonus_amount,
                training_amount = st.training_amount,
                file_chang_amount = st.file_chang_amount,
                human_histroy_records = st.human_histroy_records,
                human_family_membership = st.human_family_membership,
                human_picture = st.human_picture,
                attachment_name = st.attachment_name,
                check_status = st.check_status,
                register = st.register,
                checker = st.checker,
                changer = st.changer,
                regist_time = st.regist_time,
                check_time = st.check_time,
                change_time = st.change_time,
                lastly_change_time = st.lastly_change_time,
                delete_time = st.delete_time,
                recovery_time = st.recovery_time,
                human_file_status = st.human_file_status
            };
            return m;
        }
        /// <summary>
        /// 查询数据库的主键作为编号依据
        /// </summary>
        /// <returns></returns>
        public string ooo() {
            int zhi = 0;
           
            List<human_file_dig> list = SelectAll();
          
            foreach (var item in list)
            {
                if (item.Id > zhi){
                    zhi = item.Id;
                }
            }
            return zhi.ToString();
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="currentPage"></param>
        /// <returns></returns>
        public Dictionary<string, object> FenYe(int zt,int currentPage)
        {
            //Contains  包含
            DaoBase<human_file_dig> db = new DaoBase<human_file_dig>();
            int rows = 0;
            List<human_file_dig> list = db.FenYe<int>(e => e.Id, e => e.human_file_status.Equals(zt), ref rows, currentPage, 3);
            Dictionary<string, object> di = new Dictionary<string, object>();
            //总页数=(总记录数+每页显示数-1)/每页显示数
            int pages = (rows + 3 - 1) / 3;
            di["dt"] = list;
            //数据数
            di["rows"] = rows;
            //总页数
            di["pages"] = pages;
            //当前页
            di["dqy"] = currentPage;
            return di;
        }
        public Dictionary<string, object> FenYe(int zt,int currentPage,string first_kind_id,string second_kind_id,string third_kind_id,string human_major_kind_id,string human_major_id,string regist_timek,string regist_timej)
        {
            DaoBase<human_file_dig> db = new DaoBase<human_file_dig>();
            int rows = 0;
            List<human_file_dig> list = new List<human_file_dig>();
            if (regist_timek == "" && regist_timej == "")
            {
                list = db.FenYe<int>(e => e.Id, e => e.human_file_status.Equals(zt) && e.first_kind_id.Contains(first_kind_id) && e.second_kind_id.Contains(second_kind_id) && e.third_kind_id.Contains(third_kind_id) && e.human_major_id.Contains(human_major_kind_id) && e.hunma_major_name.Contains(human_major_id), ref rows, currentPage, 3);
            }
            else if (regist_timek == "" && regist_timej != "")
            {
                DateTime timej = DateTime.Parse(regist_timej).AddDays(1);
                list = db.FenYe<int>(e => e.Id, e => e.human_file_status.Equals(zt) && e.first_kind_id.Contains(first_kind_id) && e.second_kind_id.Contains(second_kind_id) && e.third_kind_id.Contains(third_kind_id) && e.human_major_id.Contains(human_major_kind_id) && e.hunma_major_name.Contains(human_major_id) && e.regist_time <= timej, ref rows, currentPage, 3);
            }
            else if (regist_timek != "" && regist_timej == "")
            {
                DateTime timek = DateTime.Parse(regist_timek);
                list = db.FenYe<int>(e => e.Id, e => e.human_file_status.Equals(zt) && e.first_kind_id.Contains(first_kind_id) && e.second_kind_id.Contains(second_kind_id) && e.third_kind_id.Contains(third_kind_id) && e.human_major_id.Contains(human_major_kind_id) && e.hunma_major_name.Contains(human_major_id) && e.regist_time >= timek, ref rows, currentPage, 3);
            }
            else
            {
                DateTime timek = DateTime.Parse(regist_timek);
                DateTime timej = DateTime.Parse(regist_timej).AddDays(1);
                list = db.FenYe<int>(e => e.Id, e => e.human_file_status.Equals(zt) && e.first_kind_id.Contains(first_kind_id) && e.second_kind_id.Contains(second_kind_id) && e.third_kind_id.Contains(third_kind_id) && e.human_major_id.Contains(human_major_kind_id) && e.hunma_major_name.Contains(human_major_id) && e.regist_time >= timek && e.regist_time <= timej, ref rows, currentPage, 3);
            }
            Dictionary<string, object> di = new Dictionary<string, object>();
            //总页数=(总记录数+每页显示数-1)/每页显示数
            int pages = (rows + 3 - 1) / 3;
            di["dt"] = list;
            //数据数
            di["rows"] = rows;
            //总页数
            di["pages"] = pages;
            //当前页
            di["dqy"] = currentPage;
            return di;
        }
        public Dictionary<string, object> FenYe(int zt,int currentPage,string tj)
        {
            //Contains  包含
            DaoBase<human_file_dig> db = new DaoBase<human_file_dig>();
            int rows = 0;
            List<human_file_dig> list = db.FenYe<int>(e => e.Id, e => e.human_file_status.Equals(zt)&& e.first_kind_name.Contains(tj) || e.second_kind_name.Contains(tj) || e.third_kind_name.Contains(tj) || e.human_major_kind_name.Contains(tj) || e.hunma_major_name.Contains(tj)||e.human_name.Contains(tj)|| e.human_id.Contains(tj), ref rows, currentPage, 3);
            Dictionary<string, object> di = new Dictionary<string, object>();
            //总页数=(总记录数+每页显示数-1)/每页显示数
            int pages = (rows + 3 - 1) / 3;
            di["dt"] = list;
            //数据数
            di["rows"] = rows;
            //总页数
            di["pages"] = pages;
            //当前页
            di["dqy"] = currentPage;
            return di;
        }
        public List<human_file_digModel> selectupdate(string id)
        {
            List<human_file_dig> list = SelectBy(e => e.human_id.Equals(id));


            List<human_file_digModel> li = new List<human_file_digModel>();
            foreach (human_file_dig item in list)
            {
                human_file_digModel ko = new human_file_digModel();
                ko.Id = item.Id;
                ko.human_id = item.human_id;
                ko.first_kind_id = item.first_kind_id;
                ko.first_kind_name = item.first_kind_name;
                ko.second_kind_id = item.second_kind_id;
                ko.second_kind_name = item.second_kind_name;
                ko.third_kind_id = item.third_kind_id;
                ko.third_kind_name = item.third_kind_name;
                ko.human_name = item.human_name;
                ko.human_address = item.human_address;
                ko.human_postcode = item.human_postcode;
                ko.human_pro_designation = item.human_pro_designation;
                ko.human_major_kind_id = item.human_major_kind_id;
                ko.human_major_kind_name = item.human_major_kind_name;
                ko.human_major_id = item.human_major_id;
                ko.hunma_major_name = item.hunma_major_name;
                ko.human_telephone = item.human_telephone;
                ko.human_mobilephone = item.human_mobilephone;
                ko.human_bank = item.human_bank;
                ko.human_account = item.human_account;
                ko.human_qq = item.human_qq;
                ko.human_email = item.human_email;
                ko.human_hobby = item.human_hobby;
                ko.human_speciality = item.human_speciality;
                ko.human_sex = item.human_sex;
                ko.human_religion = item.human_religion;
                ko.human_party = item.human_party;
                ko.human_nationality = item.human_nationality;
                ko.human_race = item.human_race;
                ko.human_birthday = item.human_birthday;
                ko.human_birthplace = item.human_birthplace;
                ko.human_age = item.human_age;
                ko.human_educated_degree = item.human_educated_degree;
                ko.human_educated_years = item.human_educated_years;
                ko.human_educated_major = item.human_educated_major;
                ko.human_society_security_id = item.human_society_security_id;
                ko.human_id_card = item.human_id_card;
                ko.remark = item.remark;
                ko.salary_standard_id = item.salary_standard_id;
                ko.salary_standard_name = item.salary_standard_name;
                ko.salary_sum = item.salary_sum;
                ko.demand_salaray_sum = item.demand_salaray_sum;
                ko.paid_salary_sum = item.paid_salary_sum;
                ko.major_change_amount = item.major_change_amount;
                ko.bonus_amount = item.bonus_amount;
                ko.training_amount = item.training_amount;
                ko.file_chang_amount = item.file_chang_amount;
                ko.human_histroy_records = item.human_histroy_records;
                ko.human_family_membership = item.human_family_membership;
                ko.human_picture = item.human_picture;
                ko.attachment_name = item.attachment_name;
                ko.check_status = item.check_status;
                ko.register = item.register;
                ko.checker = item.checker;
                ko.changer = item.changer;
                ko.regist_time = item.regist_time;
                ko.check_time = item.check_time;
                ko.change_time = item.change_time;
                ko.lastly_change_time = item.lastly_change_time;
                ko.delete_time = item.delete_time;
                ko.recovery_time = item.recovery_time;
                ko.human_file_status = item.human_file_status; li.Add(ko);
            }
            return li;
        }

    }
}
