using IFBLL;
using IOC;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Model;

namespace UI.Controllers.Recruitment_M.Job_release_m
{
    public class position_change_updateController : Controller
    {
        IFBLLClient mk = UserIOC.CreateClientBLL();
        IFBLLengage_major_release mr = UserIOC.engage_major_releaseBLL();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(int id)
        {
            ArrayList list = mr.engage_major_releaseSelectFenY(id, 1);
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult Delete(int id)
        {
            int mre_id = id;
            engage_major_release_Model em = new engage_major_release_Model()
            {
                mre_id = mre_id
            };
            return Content(mr.engage_major_releaseDelete(em).ToString());
        }
        [HttpGet]
       public ActionResult Update(int id)
        {
            int mre_id = id;
            engage_major_release_Model em = new engage_major_release_Model()
            {
                mre_id = mre_id
            };
            engage_major_release_Model e = mr.engage_major_releaseSelect(em);
            ViewBag.major_kind_name = major_kind_name();
            return View(e);
         }
        
        public List<SelectListItem> major_kind_name()
        {
            List<config_public_charModel> list = mk.SelectWhere("招聘分类");
            List<SelectListItem> list1 = new List<SelectListItem>();
            foreach (config_public_charModel item in list)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.attribute_name.ToString(),
                    Value = item.attribute_name.ToString(),
                };
                list1.Add(sl);
            }
            return list1;
        }
        [HttpPost]
        public ActionResult Update1()
        {
            engage_major_release_Model e = new engage_major_release_Model();
            e.first_kind_id = Request["first_kind_id"];
            e.first_kind_name = Request["first_kind_name"];
            e.second_kind_id = Request["second_kind_id"];
            e.second_kind_name = Request["second_kind_name"];
            e.third_kind_id = Request["third_kind_id"];
            e.third_kind_name = Request["third_kind_name"];
            e.engage_type = Request["engageType"];
            e.major_kind_id = Request["major_kind_id"];
            e.major_kind_name = Request["major_kind_name"];
            e.major_id = Request["major_id"];
            e.major_name = Request["major_name"];
            e.human_amount = int.Parse(Request["human_amount"]);
            e.deadline = DateTime.Parse(Request["deadline"]);
            e.register = Request["register"];
            e.regist_time = DateTime.Parse(Request["regist_time"]);
            e.major_describe = Request["major_describe"];
            e.engage_required = Request["engage_required"];
            e.changer = Request["changer"];
            e.mre_id = int.Parse(Request["mre_id"]);
            e.change_time = DateTime.Parse(Request["changeTime"]);
            int i = mr.engage_major_releaseUpdate(e);
            if (i > 0)
            {
                return Content("<script>alert('修改成功');window.location.href ='/position_change_update/Index';</script>");
            }else
            {
                return Content("<script>alert('修改失败');window.location.href ='/position_change_update/Update';</script>");
            }
        }
}
}