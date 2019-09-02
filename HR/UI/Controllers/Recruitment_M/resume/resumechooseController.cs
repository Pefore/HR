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

namespace UI.Controllers.Recruitment_M.resume
{
    public class resumechooseController : Controller
    {
        IFBLLconfig_major_kind mk = UserIOC.config_major_kindBLL();
        IFBLLint_engage_resume er = UserIOC.engage_resumeBLL();
        // GET: resumechoose
        public ActionResult Index()
        {
            ViewBag.major_kind_name = major_kind_name();
            return View();
        }
        [HttpGet]
        public ActionResult Like()
        {
            string major_kind_id;
            string humanMajorId;
            DateTime startDate ;
            DateTime endDate;
            string primarKey =null;
            #region 判断空值
            if (Request["startDate"] == ""&& Request["endDate"] == "")
            {
                startDate = DateTime.Parse("1940-01-01");
                endDate = DateTime.Now;
            }else
            {
                startDate = DateTime.Parse(Request["startDate"]);
                endDate = DateTime.Parse(Request["endDate"]);
            }
            if (Request["primarKey"]!=null || Request["primarKey"] != "")
            {
                primarKey = Request["primarKey"];
            }
            if (Request["major_kind_id"] == null)
            {
                major_kind_id = "0";
            }else
            {
                major_kind_id = Request["major_kind_id"];
            }
            if (Request["humanMajorId"] == null)
            {
                humanMajorId = "0";
            }
            else
            {
                humanMajorId = Request["humanMajorId"];
            }
            #endregion
            LikeFenYe fy = new LikeFenYe()
            {
                Dq=int.Parse(Request["Dq"]),
                endDate=endDate,
                startDate=startDate,
                PageSize=1,
                primarKey=primarKey,
                major_kind_id=major_kind_id,
                humanMajorId=humanMajorId
            };
            ArrayList list = er.engage_resumeLikeFenYe(fy);
            list.Add(fy);
            ViewBag.ls = list;
            return View();
        }
        public ActionResult XianXi()
        {
            int res_id = int.Parse(Request["id"]);
            engage_resume_Model erm= er.SelectId(new engage_resume_Model() { res_id = res_id });
            return View(erm);
        }
        public ActionResult TuiJian()
        {
            engage_resume_Model erm = er.SelectId(new engage_resume_Model() { res_id = int.Parse(Request["res_id"]) });
            erm.recomandation = Request["recomandation"];
            erm.check_status = 2;
            erm.checker = Request["checker"];
            erm.check_time = DateTime.Now;
            int i = er.engage_resumeUpdate(erm);
            if (i > 0)
            {
                return Content("<script>alert('推荐成功--跳转筛选页面'); window.location.href ='/resumechoose/Index';< script>");
            }else
            {
                return Content("<script>alert('推荐失败--请重试'); window.location.href ='/resumechoose/XianXi？id="+erm.res_id+"';< script>");
            }
        }
        private dynamic major_kind_name()
        {
            List<config_major_kind_Model> list = mk.listconfig_major_kind();
            List<SelectListItem> list1 = new List<SelectListItem>();
            foreach (config_major_kind_Model item in list)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.major_kind_name.ToString(),
                    Value = item.major_kind_id.ToString(),
                };
                list1.Add(sl);
            }
            return list1;
        }
    }
}