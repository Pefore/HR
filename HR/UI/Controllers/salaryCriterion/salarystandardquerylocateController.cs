using IFBLL;
using IOC;
using Model.CaoZuoLei;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers.salaryCriterion
{
    public class salarystandardquerylocateController : Controller
    {
        IFBLLsalary_standard il = UserIOC.BLLsalary_standard();
        // GET: salarystandardquerylocate
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Select()
        {
            string standardId = Request["standardId"];
            string primarKey = Request["primarKey"];
            DateTime startDate;
            DateTime endDate;
            if (Request["startDate"] == "" && Request["endDate"] == "")
            {
                startDate = DateTime.Parse("1940-01-01");
                endDate = DateTime.Now;
            }
            else
            {
                startDate = DateTime.Parse(Request["startDate"]);
                endDate = DateTime.Parse(Request["endDate"]);
            }
            if (standardId == null)
            {
                standardId = "";
            }
            LikeFenYe fy = new LikeFenYe()
            {
                Dq = int.Parse(Request["Dq"]),
                endDate = endDate,
                startDate = startDate,
                PageSize = 1,
                primarKey = primarKey,
                major_kind_id = standardId,
            };
            ArrayList list = il.LikeSelect(fy);
            list.Add(fy);
            ViewBag.ls = list;
            return View();
        }
    }
}