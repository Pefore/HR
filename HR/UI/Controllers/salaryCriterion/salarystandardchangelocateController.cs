using IFBLL;
using IOC;
using Model;
using Model.CaoZuoLei;
using Model.salaryCriterionModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers.salaryCriterion
{
    public class salarystandardchangelocateController : Controller
    {
        IFBLLUser u = UserIOC.CreateStudentBLL();
        IFBLLsalary_standard il = UserIOC.BLLsalary_standard();
        IFBLLsalary_standard_details ssd = UserIOC.BLLsalary_standard_details();
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
            LikeFenYe fy = new LikeFenYe();
            fy.Dq = int.Parse(Request["Dq"]);
            fy.endDate = endDate;
            fy.startDate = startDate;
            fy.PageSize = 1;
            fy.primarKey = primarKey;
            fy.major_kind_id = standardId;
            ArrayList list = il.LikeSelect0(fy);
            list.Add(fy);
            ViewBag.ls = list;
            return View();
        }
        public ActionResult GengGai()
        {
            ViewBag.user = users();
            ViewBag.pub = il.SelectID(Request["id"]);
            ViewBag.pub1 = ssd.Selectsalary_standard_details(Request["id"]);
            return View();
        }
        public ActionResult Update1()
        {
            string standardId = Request["standardId"];
            string attribute_name = Request["attribute_name"];
            double salarySum = double.Parse(Request["salarySum"]);
            string changer = Request["changer"];
            DateTime change_time = DateTime.Parse(Request["change_time"]);
            string [] sdt_id= Request["sdt_id"].ToString().Split(',');
            string[] itemId1 = Request["itemId1"].ToString().Split(',');
            string[] attribute_name1 = Request["attribute_name1"].ToString().Split(',');
            string[] mon1 = Request["mon"].ToString().Split(',');
            for (int i = 0; i < mon1.Length; i++)
            {
                double je = double.Parse(mon1[i]);
                if (je != 0.00)
                {
                    salary_standard_detailsModel ss = new salary_standard_detailsModel()
                    {
                        standard_id = standardId,
                        standard_name = attribute_name,
                        item_id = int.Parse(itemId1[i]),
                        item_name = attribute_name1[i],
                        salary = double.Parse(mon1[i]),
                        sdt_id = int.Parse(sdt_id[i])
                };
                if (ssd.Updatesalary_standard_details(ss) < 0)
                    {
                        return Content("<script>alert('报错')</script>");
                    }
                }
                
        }
            salary_standardModel sm = il.SelectID(standardId);
            sm.salary_sum = salarySum;
            sm.changer = changer;
            sm.change_time = change_time;
            sm.change_status = 1;
            if (il.Update(sm) > 0)
            {
                return Content("<script>alert('更改成功');window.location.href='/salarystandardchangelocate/Index'</script>");
            }
            else
            {
                return Content("<script>alert('更改失败');window.location.href='/salarystandardchangelocate/Index'</script>");
            }
            return View();
        }
        private dynamic users()
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