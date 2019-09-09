using IFBLL;
using IOC;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Model.salaryCriterionModel;

namespace UI.Controllers.salaryCriterion
{
    public class salarystandard_registerController : Controller
    {
        IFBLLsalary_standard ss = UserIOC.BLLsalary_standard();
        IFBLLsalary_standard_details ssd = UserIOC.BLLsalary_standard_details();
        IFBLLUser U = UserIOC.CreateStudentBLL();
        IFBLLClient C = UserIOC.CreateClientBLL();
        // GET: salarystandard_register
        public ActionResult Index()
        {
            ViewBag.user = users();
            ViewBag.pub = C.SelectWhere("薪酬设置");
            ViewBag.pub1 =new List<config_public_charModel>();
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection f)
        {
            string s = Request["checkboxFX"];
            ViewBag.user = users();
            List<config_public_charModel> list = new List<config_public_charModel>();
            List<config_public_charModel> list1 = C.SelectWhere("薪酬设置");
            string[] i1 = s.Split(',');
            foreach (config_public_charModel item in list1)
                {
                for (int i = 0; i < i1.Length; i++)
                {
                    int id = int.Parse(i1[i]);
                    if (item.Id == id)
                    {
                        list.Add(item);
                    }
                }
            }
            ViewBag.pub =list1;
            ViewBag.pub1 = list;
            return View();
        }
        public ActionResult Add(FormCollection f)
        {
            string itemId = Request["itemId"];
            string attribute_name = Request["attribute_name"];
            string mon = Request["mon"];
            string[] itemId1 = itemId.Split(',');
            string[] attribute_name1 = attribute_name.Split(',');
            string[] mon1 = mon.Split(',');
            string standard_id = Request["standardId"];
            string standardName = Request["standardName"];
            double salarySum = double.Parse(Request["salarySum"]);
            string designer = Request["designer"];
            string register = Request["register"];
            DateTime registTime = DateTime.Parse(Request["registTime"]);
            string remark = Request["remark"];
            for (int i = 0; i <mon1.Length; i++)
            {
                double je = double.Parse(mon1[i]);
                if (je != 0.00)
                {
                    salary_standard_detailsModel ssd1 = new salary_standard_detailsModel()
                    {
                        standard_id = standard_id,
                        standard_name = standardName,
                        item_id = int.Parse(itemId1[i]),
                        item_name = attribute_name1[i],
                        salary = double.Parse(mon1[i]),
                    };
                    if (ssd.Addsalary_standard_details(ssd1) < 0)
                    {
                        return Content("<script>alert('报错')</script>");
                    }
                }
            }
            salary_standardModel ssm = new salary_standardModel()
            {
                standard_id = standard_id,
                standard_name = standardName,
                designer = designer,
                register = register,
                regist_time = registTime,
                check_time = DateTime.Parse("2000-01-01"),
                change_time =DateTime.Parse("2000-01-01"),
                salary_sum = salarySum,
                remark = remark,
                check_status = 2,
            };
            if (ss.AddLsalary_standard(ssm) > 0)
            {
                return Content("<script>alert('新增成功');window.location.href='/salarystandard_register/Index'</script>");
            }else
            {
                return Content("<script>alert('新增失败');window.location.href='/salarystandard_register/Index'</script>");
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