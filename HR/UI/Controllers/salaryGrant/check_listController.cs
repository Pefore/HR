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
    public class check_listController : Controller
    {
        IFBLLsalary_grant ibs = UserIOC.Createsalary_grantBLL();
        IFBLLhuman_file_dig hu = UserIOC.human_file_digBLL();
        /// <summary>
        /// 薪酬发放登记表
        /// </summary>
        IFBLLsalary_grant ibsg = UserIOC.Createsalary_grantBLL();
        /// <summary>
        /// 薪酬发放详细信息
        /// </summary>
        IFBLLsalary_grant_details ibsgd = UserIOC.Createsalary_grant_detailsBLL();
        IFBLLsalary_standard ibss = UserIOC.BLLsalary_standard();
        /// <summary>
        /// 工资详情 薪酬标准单详细信息
        /// </summary>
        IFBLLsalary_standard_details ibssd = UserIOC.BLLsalary_standard_details();
        // GET: check_list
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FY()
        {
            string currentPage = Request["currentPage"];
            return Content(JsonConvert.SerializeObject(ibs.FenYe(2, int.Parse(currentPage))));
        }
        public ActionResult Edit(string id)
        {
            Session["register_commitID"] = id;
            return View();
        }
        public ActionResult TiJiao()
        {
            //查询发放详细表
            string ha = Session["register_commitID"].ToString();
            //获取其中详细信息
            List<salary_grant_detailsModel> li = ibsgd.selectsalary_grant_id(ha);
            List<salary_grantModel> item = ibsg.selectupdateda(ha);
            salary_grantModel sala = new salary_grantModel();
            sala.Id = item[0].Id;
            int zrs = 0;
            //基本总额
            decimal jbze = 0m;
            decimal sfze = 0m;
            for (int i = 0; i < li.Count; i++)
            {
                zrs = zrs + 1;
                salary_grant_detailsModel mode = new salary_grant_detailsModel();
                mode.Id = li[i].Id;
                mode.salary_grant_id = li[i].salary_grant_id;
                mode.human_id = li[i].human_id;
                mode.human_name = li[i].human_name;
                jbze = jbze + decimal.Parse(li[i].salary_standard_sum);
                mode.bouns_sum = Request["grantDetails[" + i + "].bounsSum"].ToString();
                mode.sale_sum = Request["grantDetails[" + i + "].saleSum"].ToString();
                mode.deduct_sum = Request["grantDetails[" + i + "].deductSum"].ToString();
                mode.salary_paid_sum = Request["grantDetails[" + i + "].salaryPaidSum"].ToString();
                sfze = sfze + decimal.Parse(Request["grantDetails[" + i + "].salaryPaidSum"].ToString());
                mode.salary_standard_sum = li[i].salary_standard_sum;
                int p = ibsgd.Update(mode);
            }
            sala.salary_grant_id = item[0].salary_grant_id;
            sala.salary_standard_id = item[0].salary_standard_id;
            sala.first_kind_id = item[0].first_kind_id;
            sala.first_kind_name = item[0].first_kind_name;
            sala.second_kind_id = item[0].second_kind_id;
            sala.second_kind_name = item[0].second_kind_name;
            sala.third_kind_id = item[0].third_kind_id;
            sala.third_kind_name = item[0].third_kind_name;
            sala.human_amount = short.Parse(zrs.ToString());
            sala.salary_standard_sum = jbze.ToString();
            sala.salary_paid_sum = sfze.ToString();
            sala.register = Request["salaryGrant.register"];
            sala.checker = Request["salaryGrant.register"];
            sala.regist_time = DateTime.Parse(Request["salaryGrant.registTime"].ToString());
            sala.check_time = DateTime.Now;
            sala.check_status = 3;
            int pd = ibsg.Update(sala);
            if (pd > 0)
            {
                return Content("<script>alert('复核成功');window.location = '/check_list/check_success'</script>");
            }
            else
            {
                return JavaScript("<script>alert('复核失败');</script>");
            }
        }
        public ActionResult check_success()
        {
            return View();
        }
    }
}
