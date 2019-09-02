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
                lastly_change_time = st.lastly_change_time,
                delete_time = st.delete_time,
                recovery_time = st.recovery_time,
                human_file_status = st.human_file_status
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
    }
}
