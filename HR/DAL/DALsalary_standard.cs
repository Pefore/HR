using EFentity.salaryCriterion;
using IFDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.salaryCriterionModel;
using Model.CaoZuoLei;
using System.Collections;

namespace DAL
{
    public class DALsalary_standard : DaoBase<salary_standard>, IFDALsalary_standard
    {
        public int AddLsalary_standard(salary_standardModel s)
        {
            salary_standard ss = new salary_standard()
            {
                standard_id=s.standard_id,
                standard_name=s.standard_name,
                designer = s.designer,
                register = s.register,
                regist_time = s.regist_time,
                check_time = s.check_time,
                change_time = s.change_time,
                salary_sum = s.salary_sum,
                remark = s.remark,
                check_status = s.check_status,
            };
            return Add(ss);
        }

        public ArrayList LikeSelect(LikeFenYe l)
        {
            ArrayList list2 = new ArrayList();
            int rows = 0;
            List<salary_standard> list = null;
            List<salary_standardModel> list1 = new List<salary_standardModel>();
            list = FenYe<int>(e => e.ssd_id, e => (e.standard_id.Contains(l.major_kind_id) && (e.register.Contains(l.primarKey) || e.designer.Contains(l.primarKey) || e.checker.Contains(l.primarKey)) && e.regist_time > l.startDate && e.regist_time < l.endDate && e.check_status ==1), ref rows, l.Dq, l.PageSize);
            foreach (var s in list)
            {
                salary_standardModel ss = new salary_standardModel()
                {
                    ssd_id=s.ssd_id,
                    standard_id = s.standard_id,
                    standard_name = s.standard_name,
                    designer = s.designer,
                    register = s.register,
                    regist_time = s.regist_time,
                    check_time = s.check_time,
                    change_time = s.change_time,
                    salary_sum = s.salary_sum,
                    remark = s.remark,
                    check_status = s.check_status,
                };
                list1.Add(ss);
            }
            list2.Add(list1);
            list2.Add(rows);
            list2.Add(l.Dq);
            list2.Add(l.PageSize);
            list2.Add((rows - 1) / l.PageSize + 1);
            return list2;
        }

        public ArrayList LikeSelect0(LikeFenYe l)
        {
            ArrayList list2 = new ArrayList();
            int rows = 0;
            List<salary_standard> list = null;
            List<salary_standardModel> list1 = new List<salary_standardModel>();
            list = FenYe<int>(e => e.ssd_id, e => (e.standard_id.Contains(l.major_kind_id) && (e.register.Contains(l.primarKey) || e.designer.Contains(l.primarKey) || e.checker.Contains(l.primarKey)) && e.regist_time > l.startDate && e.regist_time < l.endDate && e.check_status == 1 && e.change_status == 0), ref rows, l.Dq, l.PageSize);
            foreach (var s in list)
            {
                salary_standardModel ss = new salary_standardModel()
                {
                    ssd_id = s.ssd_id,
                    standard_id = s.standard_id,
                    standard_name = s.standard_name,
                    designer = s.designer,
                    register = s.register,
                    regist_time = s.regist_time,
                    check_time = s.check_time,
                    change_time = s.change_time,
                    salary_sum = s.salary_sum,
                    remark = s.remark,
                    check_status = s.check_status,
                };
                list1.Add(ss);
            }
            list2.Add(list1);
            list2.Add(rows);
            list2.Add(l.Dq);
            list2.Add(l.PageSize);
            list2.Add((rows - 1) / l.PageSize + 1);
            return list2;
        }

        public ArrayList Listsalary_standard(LikeFenYe l)
        {
            int row = 0;
            List<salary_standardModel> list1 = new List<salary_standardModel>();
            List<salary_standard> list = new List<salary_standard>();
            list = FenYe<int>(e => e.ssd_id, e => e.check_status==2, ref row, l.Dq, l.PageSize);
            foreach (var item in list)
            {
                salary_standardModel e1 = new salary_standardModel()
                {
                    standard_id = item.standard_id,
                    standard_name = item.standard_name,
                    designer = item.designer,
                    register = item.register,
                    regist_time = item.regist_time,
                    check_time = item.check_time,
                    change_time = item.change_time,
                    salary_sum = item.salary_sum,
                    remark = item.remark,
                    check_status = item.check_status,
                };
                list1.Add(e1);
            }
            ArrayList A = new ArrayList();
            A.Add(list1);
            A.Add(row);
            A.Add(l.Dq);
            A.Add(l.PageSize);
            A.Add((row - 1) / l.PageSize + 1);
            return A;

        }

        public salary_standardModel SelectID(string id)
        {
            salary_standard item = SelectBy(e => e.standard_id.Equals(id)).FirstOrDefault();
            salary_standardModel ss = new salary_standardModel()
            {
                ssd_id = item.ssd_id,
                standard_id = item.standard_id,
                standard_name = item.standard_name,
                designer = item.designer,
                register = item.register,
                regist_time = item.regist_time,
                check_time = item.check_time,
                change_time = item.change_time,
                salary_sum = item.salary_sum,
                remark = item.remark,
                check_status = item.check_status,
                change_status=item.change_status,
                changer=item.changer,
                checker=item.checker,
                check_comment=item.check_comment,
            };
            return ss;
        }

        public int Update(salary_standardModel s)
        {
            salary_standard ss = new salary_standard()
            {
                ssd_id = s.ssd_id,
                standard_id = s.standard_id,
                standard_name = s.standard_name,
                designer = s.designer,
                register = s.register,
                regist_time = s.regist_time,
                check_time = s.check_time,
                change_time = s.change_time,
                salary_sum = s.salary_sum,
                remark = s.remark,
                check_status = s.check_status,
                check_comment=s.check_comment,
                checker=s.checker,
                changer=s.changer,
                change_status=s.change_status,
            };
            return Update(ss);
        }
    }
}
