using IFBLL;
using IOC;
using Model;
using Model.CaoZuoLei;
using Model.salaryCriterionModel;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers.salaryCriterion
{
    public class salarystandard_check_listController : Controller
    {
        IFBLLsalary_standard fb = UserIOC.BLLsalary_standard();
        IFBLLsalary_standard_details fb1 = UserIOC.BLLsalary_standard_details();
        IFBLLUser U = UserIOC.CreateStudentBLL();
        // GET: salarystandard_check_list
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(int id)
        {
            ArrayList list = fb.Listsalary_standard(new LikeFenYe() { Dq=id,PageSize=1});
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult Update()
        {
            ViewBag.salary_standard = fb.SelectID(Request["id"]);
            ViewBag.salary_standard_details = fb1.Selectsalary_standard_details(Request["id"]);
            ViewBag.user = users();
            return View();
        }
        public ActionResult Update1()
        {
            salary_standardModel ssm = fb.SelectID(Request["standardId"]);
            ssm.check_status = 1;
            ssm.check_comment = Request["check_comment"];
            ssm.check_time = DateTime.Parse(Request["check_time"]);
            ssm.checker = Request["checker"];
            if (fb.Update(ssm) > 0)
            {
                return Content("<script>alert('复核成功');window.location.href='/salarystandard_check_list/index'</script>");
            }else
            {
                return Content("<script>alert('复核失败');window.location.href='/salarystandard_check_list/index?id="+Request["id"]+"'</script>");
            }
        }
        private dynamic users()
        {
            List<users> list = U.se();
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