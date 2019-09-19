using IFBLL;
using IOC;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers.salaryGrant
{
    public class query_locateController : Controller
    {
        IFBLLsalary_grant ibs = UserIOC.Createsalary_grantBLL();
        // GET: query_locate
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1()
        {
            return View();
        }
        public ActionResult FY()
        {
            string currentPage = Request["currentPage"];
            return Content(JsonConvert.SerializeObject(ibs.FenYe(3, int.Parse(currentPage))));
        }
        public ActionResult Edit(string id)
        {
            Session["register_commitID"] = id;
            return View();
        }
        public ActionResult sj()
        {
            string ss = Session["register_commitID"].ToString();
            List<salary_grantModel> list = ibs.Select();
            string aa = "";
            foreach (salary_grantModel item in list)
            {
                if (item.salary_grant_id == ss)
                {
                   aa= item.regist_time.ToString();
                }
            }
            return Content(aa);
        }
    }
}
