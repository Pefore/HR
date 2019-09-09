using EFentity.position_register;
using IFDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using EFentity;
using System.Collections;
using Model.CaoZuoLei;

namespace DAL
{
    public class DALengage_interview : DaoBase<engage_interview>, IFDALengage_interview
    {
        static MyDbcontext db = CreateDbContext();

        public int engage_interviewAdd(engage_interviewModel ei)
        {
            engage_interview eim = new engage_interview()
            {
                human_name = ei.human_name,
                interview_amount = ei.interview_amount,
                human_major_kind_id = ei.human_major_kind_id,
                human_major_kind_name = ei.human_major_kind_name,
                human_major_id = ei.human_major_id,
                human_major_name = ei.human_major_name,
                image_degree = ei.image_degree,
                native_language_degree = ei.native_language_degree,
                foreign_language_degree = ei.foreign_language_degree,
                response_speed_degree = ei.response_speed_degree,
                EQ_degree = ei.EQ_degree,
                IQ_degree = ei.IQ_degree,
                multi_quality_degree = ei.multi_quality_degree,
                register = ei.register,
                registe_time = ei.registe_time,
                resume_id = ei.resume_id,
                interview_comment = ei.interview_comment,
                interview_status = ei.interview_status,
                check_time=DateTime.Parse("2000-01-01"),
            };
            return Add(eim);
        }

        public int engage_interviewModelDelete(engage_interviewModel ei)
        {
            int i = Delete(new engage_interview() { ein_id = ei.ein_id });
            return i;
        }

        public ArrayList engage_interviewSelectFenY(int Dq, int pageSize)
        {
            int row = 0;
            List<engage_interviewModel> list1 = new List<engage_interviewModel>();
            List<engage_interview> list = new List<engage_interview>();
            list = FenYe<int>(e => e.ein_id, e => e.interview_status==2, ref row, Dq, pageSize);
            foreach (var ei in list)
            {
                engage_interviewModel e = new engage_interviewModel()
                {
                    ein_id = ei.ein_id,
                    human_name = ei.human_name,
                    interview_amount = ei.interview_amount,
                    human_major_kind_id = ei.human_major_kind_id,
                    human_major_kind_name = ei.human_major_kind_name,
                    human_major_id = ei.human_major_id,
                    human_major_name = ei.human_major_name,
                    image_degree = ei.image_degree,
                    native_language_degree = ei.native_language_degree,
                    foreign_language_degree = ei.foreign_language_degree,
                    response_speed_degree = ei.response_speed_degree,
                    EQ_degree = ei.EQ_degree,
                    IQ_degree = ei.IQ_degree,
                    multi_quality_degree = ei.multi_quality_degree,
                    register = ei.register,
                    registe_time = ei.registe_time,
                    resume_id = ei.resume_id,
                    interview_comment = ei.interview_comment,
                    interview_status = ei.interview_status,
                };
                list1.Add(e);
            }
            ArrayList A = new ArrayList();
            A.Add(list1);
            A.Add(row);
            A.Add(Dq);
            A.Add(pageSize);
            A.Add((row - 1) / pageSize + 1);
            return A;
        }

        public int engage_interviewUpdate(engage_interviewModel ei)
        {
            engage_interview eim = new engage_interview()
            {
                ein_id=ei.ein_id,
                human_name = ei.human_name,
                interview_amount = ei.interview_amount,
                human_major_kind_id = ei.human_major_kind_id,
                human_major_kind_name = ei.human_major_kind_name,
                human_major_id = ei.human_major_id,
                human_major_name = ei.human_major_name,
                image_degree = ei.image_degree,
                native_language_degree = ei.native_language_degree,
                foreign_language_degree = ei.foreign_language_degree,
                response_speed_degree = ei.response_speed_degree,
                EQ_degree = ei.EQ_degree,
                IQ_degree = ei.IQ_degree,
                multi_quality_degree = ei.multi_quality_degree,
                register = ei.register,
                registe_time = ei.registe_time,
                resume_id = ei.resume_id,
                interview_comment = ei.interview_comment,
                interview_status = ei.interview_status,
                check_time =ei.check_time,
                checker=ei.checker,
                check_comment=ei.check_comment,
                check_status=ei.check_status,
                result=ei.result,
            };
            return Update(eim);
        }

        public ArrayList engage_resumeYouXianFenYe3(LikeFenYe l)
        {
            ArrayList list2 = new ArrayList();
            int rows = 0;
            List<engage_interview> list = null;
            List<engage_interviewModel> list1 = new List<engage_interviewModel>();
            list = FenYe<int>(e => e.ein_id, e => e.interview_status == 3, ref rows, l.Dq, l.PageSize);
            foreach (var item in list)
            {
                engage_interviewModel erm = new engage_interviewModel()
                {
                    ein_id=item.ein_id,
                    human_name = item.human_name,
                    registe_time=item.registe_time,
                    interview_amount = item.interview_amount,
                    human_major_kind_name = item.human_major_kind_name,
                    human_major_name = item.human_major_name,
                    multi_quality_degree = item.multi_quality_degree,
                    check_comment=item.check_comment,
                    check_status = item.check_status,
                    interview_status = item.interview_status,
                };
                list1.Add(erm);
            }
            list2.Add(list1);
            list2.Add(rows);
            list2.Add(l.Dq);
            list2.Add(l.PageSize);
            list2.Add((rows - 1) / l.PageSize + 1);
            return list2;
        }

        public ArrayList engage_resumeYouXianFenYe7(LikeFenYe l)
        {
            ArrayList list2 = new ArrayList();
            int rows = 0;
            List<engage_interview> list = null;
            List<engage_interviewModel> list1 = new List<engage_interviewModel>();
            list = FenYe<int>(e => e.ein_id, e => e.interview_status == 7, ref rows, l.Dq, l.PageSize);
            foreach (var item in list)
            {
                engage_interviewModel erm = new engage_interviewModel()
                {
                    ein_id = item.ein_id,
                    human_name = item.human_name,
                    registe_time = item.registe_time,
                    interview_amount = item.interview_amount,
                    human_major_kind_name = item.human_major_kind_name,
                    human_major_name = item.human_major_name,
                    multi_quality_degree = item.multi_quality_degree,
                    check_comment = item.check_comment,
                    check_status = item.check_status,
                    interview_status = item.interview_status,
                };
                list1.Add(erm);
            }
            list2.Add(list1);
            list2.Add(rows);
            list2.Add(l.Dq);
            list2.Add(l.PageSize);
            list2.Add((rows - 1) / l.PageSize + 1);
            return list2;
        }

        public int SelectCount(engage_interviewModel e)
        {
            string sql = string.Format(@"select max(interview_amount)  from [dbo].[engage_interview] where [human_name]='{0}'", e.human_name);
            string max = SqlDBHelper.DGZ(sql).ToString();
            if (max =="")
            {
                return 1;
            }
            return int.Parse(max);
        }

        public List<engage_interviewModel> SelectCunZai(engage_interviewModel e)
        {
            List<engage_interview> list = SelectBy(el => el.human_name.Equals(e.human_name));
            List<engage_interviewModel> list1 = new List<engage_interviewModel>();
            if (list.Count() == 0)
            {
              return list1;
            }else
            {
                engage_interview ei= list[0] as engage_interview;
                engage_interviewModel eim = new engage_interviewModel()
                {
                    ein_id=ei.ein_id,
                    human_name = ei.human_name,
                    interview_amount = ei.interview_amount,
                    human_major_kind_id = ei.human_major_kind_id,
                    human_major_kind_name = ei.human_major_kind_name,
                    human_major_id = ei.human_major_id,
                    human_major_name = ei.human_major_name,
                    image_degree = ei.image_degree,
                    native_language_degree = ei.native_language_degree,
                    foreign_language_degree = ei.foreign_language_degree,
                    response_speed_degree = ei.response_speed_degree,
                    EQ_degree = ei.EQ_degree,
                    IQ_degree = ei.IQ_degree,
                    multi_quality_degree = ei.multi_quality_degree,
                    register = ei.register,
                    registe_time = ei.registe_time,
                    resume_id = ei.resume_id,
                    interview_comment = ei.interview_comment,
                    interview_status = ei.interview_status,
                    checker=ei.checker,
                    check_time=ei.check_time,
                    result=ei.result,
                    check_comment=ei.check_comment,
                    check_status=ei.check_status,
                };
                list1.Add(eim);
                return list1;
            }
        }

        public engage_interview_resume Selectengage_interview_resume(int id)
        {
            List<engage_interview> list = SelectBy(e => e.ein_id == id);
            engage_interview ei = list[0] as engage_interview;
            engage_interview_resume eir = new engage_interview_resume()
            {
                ein_id = ei.ein_id,
                human_name = ei.human_name,
                interview_amount = ei.interview_amount,
                human_major_kind_id = ei.human_major_kind_id,
                human_major_kind_name = ei.human_major_kind_name,
                human_major_id = ei.human_major_id,
                human_major_name = ei.human_major_name,
                image_degree = ei.image_degree,
                native_language_degree = ei.native_language_degree,
                foreign_language_degree = ei.foreign_language_degree,
                response_speed_degree = ei.response_speed_degree,
                EQ_degree = ei.EQ_degree,
                IQ_degree = ei.IQ_degree,
                multi_quality_degree = ei.multi_quality_degree,
                registe_time = ei.registe_time,
                resume_id = ei.resume_id,
                interview_comment = ei.interview_comment,
                interview_status = ei.interview_status,
                check_time=ei.check_time,
                checker=ei.checker,
                register1=ei.register,
            };
            return eir;
        }

        public engage_interview_resume Selectengage_interview_resume1(int id)
        {
            List<engage_interview> list = SelectBy(e => e.resume_id == id);
            engage_interview ei = list[0] as engage_interview;
            engage_interview_resume eir = new engage_interview_resume()
            {
                ein_id = ei.ein_id,
                human_name = ei.human_name,
                interview_amount = ei.interview_amount,
                human_major_kind_id = ei.human_major_kind_id,
                human_major_kind_name = ei.human_major_kind_name,
                human_major_id = ei.human_major_id,
                human_major_name = ei.human_major_name,
                image_degree = ei.image_degree,
                native_language_degree = ei.native_language_degree,
                foreign_language_degree = ei.foreign_language_degree,
                response_speed_degree = ei.response_speed_degree,
                EQ_degree = ei.EQ_degree,
                IQ_degree = ei.IQ_degree,
                multi_quality_degree = ei.multi_quality_degree,
                register = ei.register,
                registe_time = ei.registe_time,
                resume_id = ei.resume_id,
                interview_comment = ei.interview_comment,
                interview_status = ei.interview_status,
                check_time = ei.check_time,
                checker = ei.checker,
            };
            return eir;
        }
    }
}
