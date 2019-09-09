using IFBLL;
using IOC;
using Model;
using Model.CaoZuoLei;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers.Recruitment_M.employ
{
    public class registerSPController : Controller
    {
        IFBLLengage_interview er = UserIOC.BLLengage_interview();
        IFBLLint_engage_resume er1 = UserIOC.engage_resumeBLL();
        // GET: registerSP
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(int id)
        {
            LikeFenYe l = new LikeFenYe()
            {
                Dq = id,
                PageSize = 1,
            };
            ArrayList list = er1.engage_resumeYouXianFenYe6(l);
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult Update(int id)
        {
            engage_interview_resume eim = er.Selectengage_interview_resume1(id);
            engage_resume_Model erm = er1.SelectId(new engage_resume_Model() { res_id = eim.resume_id });
            ViewBag.eim = eim;
            return View(erm);
        }
        public ActionResult TG()
        {
            string human_name = Request["human_name"];
            int res_id = int.Parse(Request["res_id"]);
            int ein_id = int.Parse(Request["ein_id"]);
            engage_resume_Model erm = er1.SelectId(new engage_resume_Model() { res_id = res_id });
            erm.interview_status = 7;
            erm.pass_passComment = Request["pass_passComment"];
            if (er1.engage_resumeUpdate(erm) > 0)
            {
                engage_interviewModel eim = er.SelectCunZai(new engage_interviewModel() { human_name = human_name })[0] as engage_interviewModel;
                eim.interview_status =7;
                eim.check_status = 3;
                if (er.engage_interviewUpdate(eim) > 0)
                {
                    return Content("<script>alert('通过');window.location.href='/registerLY/Index'</script>");
                }
                else
                {
                    return Content("<script>alert('失败');window.location.href='/registerLY/Update?id=" + eim.ein_id + "'</script>");
                }
            }
            else
            {
                return Content("<script>alert('失败');window.location.href='/registerLY/Update?id=" + ein_id + "'</script>");
            }
        }
        public ActionResult BTG()
        {
            string human_name = Request["human_name"];
            int res_id = int.Parse(Request["res_id"]);
            int ein_id = int.Parse(Request["ein_id"]);
            engage_resume_Model erm = er1.SelectId(new engage_resume_Model() { res_id = res_id });
            erm.interview_status = 1;
            erm.pass_passComment = Request["pass_passComment"];
            if (er1.engage_resumeUpdate(erm) > 0)
            {
                engage_interviewModel eim = er.SelectCunZai(new engage_interviewModel() { human_name = human_name })[0] as engage_interviewModel;
                eim.interview_status = 1;
                eim.check_status = 1;
                if (er.engage_interviewUpdate(eim) > 0)
                {
                    return Content("<script>alert('等待面试');window.location.href='/registerLY/Index'</script>");
                }
                else
                {
                    return Content("<script>alert('等待面试失败');window.location.href='/registerLY/Update?id=" + eim.ein_id + "'</script>");
                }
            }
            else
            {
                return Content("<script>alert('等待面试失败');window.location.href='/registerLY/Update?id=" + ein_id + "'</script>");
            }
        }
    }
}