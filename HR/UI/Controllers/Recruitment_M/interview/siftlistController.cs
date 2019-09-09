using IFBLL;
using IOC;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers.Recruitment_M.interview
{
    public class siftlistController : Controller
    {
        IFBLLengage_interview iei = UserIOC.BLLengage_interview();
        IFBLLint_engage_resume ers = UserIOC.engage_resumeBLL();
        IFBLLUser u = UserIOC.CreateStudentBLL();
        // GET: siftlist
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(int id)
        {
            ArrayList list = iei.engage_interviewSelectFenY(id, 1);
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult Update(int id)
        {
            int ein_id= id;
            engage_interview_resume eir = iei.Selectengage_interview_resume(ein_id);
            engage_interview_resume ei = ers.Selectengage_interview_resume(eir);
            ViewBag.Users = Users();
            return View(ei);
        }
        /// <summary>
        /// 建议面试
        /// </summary>
        /// <returns></returns>
        public ActionResult JYMS()
        {
            string human_name =Request["human_name"];
            int res_id= int.Parse(Request["resume_id"]);
            int ein_id= int.Parse(Request["ein_id"]);
            engage_resume_Model erm = ers.SelectId(new engage_resume_Model() { res_id = res_id });
            erm.interview_status = 1;
            if (ers.engage_resumeUpdate(erm) > 0)
            {
                engage_interviewModel eim = iei.SelectCunZai(new engage_interviewModel() { human_name = human_name })[0] as engage_interviewModel;
                eim.interview_status = 1;
                eim.checker = Request["register2"];
                eim.check_time = DateTime.Parse(Request["check_time1"]);
                eim.result = Request["check_comment"];
                eim.check_comment= Request["check_comment"];
                eim.check_status = 1;
                if (iei.engage_interviewUpdate(eim) > 0)
                {
                    return Content("<script>alert('筛选成功');window.location.href='/siftlist/Index'</script>");
                }
                else
                {
                    return Content("<script>alert('筛选失败');window.location.href='/siftlist/Update?id=" + eim.ein_id+"'</script>");
                }
            }else
            {
                return Content("<script>alert('筛选失败');window.location.href='/siftlist/Update?id=" +ein_id + "'</script>");
            }
        }
        /// <summary>
        /// 建议笔试
        /// </summary>
        /// <returns></returns>
        public ActionResult JYBS()
        {
            string human_name = Request["human_name"];
            int res_id = int.Parse(Request["resume_id"]);
            int ein_id = int.Parse(Request["ein_id"]);
            engage_resume_Model erm = ers.SelectId(new engage_resume_Model() { res_id = res_id });
            erm.interview_status =5;
            if (ers.engage_resumeUpdate(erm) > 0)
            {
                engage_interviewModel eim = iei.SelectCunZai(new engage_interviewModel() { human_name = human_name })[0] as engage_interviewModel;
                eim.interview_status =5;
                eim.checker = Request["register2"];
                eim.check_time = DateTime.Parse(Request["check_time1"]);
                eim.result = Request["check_comment"];
                eim.check_comment = Request["check_comment"];
                eim.check_status = 2;
                if (iei.engage_interviewUpdate(eim) > 0)
                {
                    return Content("<script>alert('筛选成功');window.location.href='/siftlist/Index'</script>");
                }
                else
                {
                    return Content("<script>alert('筛选失败');window.location.href='/siftlist/Update?id=" + eim.ein_id + "'</script>");
                }
            }
            else
            {
                return Content("<script>alert('筛选失败');window.location.href='/siftlist/Update?id=" + ein_id + "'</script>");
            }
        }
        /// <summary>
        /// 建议录用
        /// </summary>
        /// <returns></returns>
        public ActionResult JTLY()
        {
            string human_name = Request["human_name"];
            int res_id = int.Parse(Request["resume_id"]);
            int ein_id = int.Parse(Request["ein_id"]);
            engage_resume_Model erm = ers.SelectId(new engage_resume_Model() { res_id = res_id });
            erm.interview_status =3;
            if (ers.engage_resumeUpdate(erm) > 0)
            {
                engage_interviewModel eim = iei.SelectCunZai(new engage_interviewModel() { human_name = human_name })[0] as engage_interviewModel;
                eim.interview_status = 3;
                eim.checker = Request["register2"];
                eim.check_time = DateTime.Parse(Request["check_time1"]);
                eim.result = Request["check_comment"];
                eim.check_comment = Request["check_comment"];
                eim.check_status =3;
                if (iei.engage_interviewUpdate(eim) > 0)
                {
                    return Content("<script>alert('筛选成功');window.location.href='/siftlist/Index'</script>");
                }
                else
                {
                    return Content("<script>alert('筛选失败');window.location.href='/siftlist/Update?id=" + eim.ein_id + "'</script>");
                }
            }
            else
            {
                return Content("<script>alert('筛选失败');window.location.href='/siftlist/Update?id=" + ein_id + "'</script>");
            }
        }
        /// <summary>
        /// 删除简历
        /// </summary>
        /// <returns></returns>
        public ActionResult DeleteJL()
        {
            int res_id = int.Parse(Request["resume_id"]);
            int ein_id = int.Parse(Request["ein_id"]);
            if(ers.engage_resumeDelete(new engage_resume_Model() { res_id = res_id }) > 0)
            {
                if (iei.engage_interviewModelDelete(new engage_interviewModel() { ein_id = ein_id }) > 0)
                {
                    return Content("<script>alert('筛选成功');window.location.href='/siftlist/Index'</script>");
                }
                else
                {
                    return Content("<script>alert('筛选失败');window.location.href='/siftlist/Update?id=" + ein_id + "'</script>");
                }
            }else
            {
                return Content("<script>alert('筛选失败');window.location.href='/siftlist/Update?id=" + ein_id + "'</script>");
            }
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