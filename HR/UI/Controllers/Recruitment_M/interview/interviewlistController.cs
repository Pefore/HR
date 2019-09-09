using IFBLL;
using IOC;
using Model;
using Model.CaoZuoLei;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers.Recruitment_M.interview
{
    public class interviewlistController : Controller
    {
        IFBLLClient mk = UserIOC.CreateClientBLL();
        IFBLLint_engage_resume er = UserIOC.engage_resumeBLL();
        IFBLLUser u = UserIOC.CreateStudentBLL();
        IFBLLengage_interview ei = UserIOC.BLLengage_interview();
        // GET: interviewlist
        public ActionResult Index()
        {
            LikeFenYe fy = new LikeFenYe()
            {
                Dq =1,
                endDate = DateTime.Now,
                startDate = DateTime.Parse("1940-01-01"),
                PageSize = 1,
                primarKey ="",
                major_kind_id = "0",
                humanMajorId = "0"
            };
            ArrayList list = er.engage_resumeYouXianFenYe(fy);
            list.Add(fy);
            ViewBag.ls = list;
            return View();
        }
        public ActionResult Like(FormCollection f)
        {
            LikeFenYe fy = new LikeFenYe()
            {
                Dq = int.Parse(Request["Dq"]),
                endDate = DateTime.Now,
                startDate = DateTime.Parse("1940-01-01"),
                PageSize = 1,
                primarKey ="",
                major_kind_id = "0",
                humanMajorId = "0"
            };
            ArrayList list = er.engage_resumeYouXianFenYe(fy);
            list.Add(fy);
            ViewBag.ls = list;
            return View();
        }
        public ActionResult MianShi()
        {
            int res_id = int.Parse(Request["id"]);
            engage_resume_Model erm = er.SelectId(new engage_resume_Model() { res_id = res_id });
            ViewBag.DengJi = Dengji();
            ViewBag.Users = Users();
            ViewBag.interview_amount = ei.SelectCount(new engage_interviewModel() { human_name=erm.human_name});
            return View(erm);
        }
        public ActionResult MianShiDJ(FormCollection f)
        {
            int res_id =int.Parse(Request["res_id"]);
            engage_resume_Model erm = er.SelectId(new engage_resume_Model() { res_id = res_id });
            erm.interview_status = 2;
            List<engage_interviewModel> list = ei.SelectCunZai(new engage_interviewModel() { human_name = Request["human_name"] });
            engage_interviewModel en = new engage_interviewModel();
            en.human_name = Request["human_name"];
            en.human_major_kind_id = Request["human_major_kind_id"];
            en.human_major_kind_name = Request["human_major_kind_name"];
            en.human_major_id = Request["human_major_id"];
            en.human_major_name = Request["human_major_name"];
            en.image_degree = Request["image_degree"];
            en.native_language_degree = Request["native_language_degree"];
            en.foreign_language_degree = Request["foreign_language_degree"];
            en.response_speed_degree = Request["response_speed_degree"];
            en.EQ_degree = Request["EQ_degree"];
            en.IQ_degree = Request["IQ_degree"];
            en.multi_quality_degree = Request["multi_quality_degree"];
            en.register = Request["register1"];
            en.registe_time = DateTime.Parse(Request["registe_time"]);
            en.resume_id = int.Parse(Request["res_id"]);
            en.interview_comment = Request["interview_comment"];
            if (list.Count() == 0)
            {
                //第一次面试新增
                en.interview_status = 2;
                en.interview_amount =2;
                if (ei.engage_interviewAdd(en) > 0)
                {
                    er.engage_resumeUpdate(erm);
                    return Content("<script>alert('面试登记成功');window.location.href='/interviewlist/Index'</script>");
                }else
                {
                    return Content("<script>alert('面试登记失败');window.location.href='/interviewlist/MianShi?id="+ en.resume_id + "'</script>");
                }
            }else
            {
                //多次面试，修改
                engage_interviewModel ena = list[0] as engage_interviewModel;
                en.ein_id = ena.ein_id;
                en.interview_status = 2;
                en.check_time = DateTime.Parse("2000-01-01");
                en.interview_amount =ena.interview_amount+1;
                if (ei.engage_interviewUpdate(en) > 0)
                {
                    er.engage_resumeUpdate(erm);
                    return Content("<script>alert('面试登记成功');window.location.href='/interviewlist/Index'</script>");
                }
                else
                {
                    return Content("<script>alert('面试登记失败');window.location.href='/interviewlist/MianShi?id=" + en.resume_id + "'</script>");
                }
            }
            return View();
        }

        private dynamic Dengji()
        {
            List<config_public_charModel> list = mk.SelectWhere("面试等级");
            List<SelectListItem> list1 = new List<SelectListItem>();
            foreach (config_public_charModel item in list)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.attribute_name.ToString(),
                    Value = item.attribute_name.ToString(),
                };
                list1.Add(sl);
            }
            return list1;
        }
        private dynamic Users()
        {
            List<users> list = u.se();
            List<SelectListItem> list1 = new List<SelectListItem>();
            foreach (users item in list)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.user_true_name.ToString(),
                    Value = item.user_true_name.ToString(),
                };
                list1.Add(sl);
            }
            return list1;
        }
    }
}