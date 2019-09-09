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
    public class listController : Controller
    {
        IFBLLengage_interview er = UserIOC.BLLengage_interview();
        IFBLLint_engage_resume er1 = UserIOC.engage_resumeBLL();
        // GET: list
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
            ArrayList list = er.engage_resumeYouXianFenYe7(l);
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult Update(int id)
        {
            engage_interview_resume eim = er.Selectengage_interview_resume(id);
            engage_resume_Model erm = er1.SelectId(new engage_resume_Model() { res_id = eim.resume_id });
            ViewBag.eim = eim;
            return View(erm);
        }
    }
}