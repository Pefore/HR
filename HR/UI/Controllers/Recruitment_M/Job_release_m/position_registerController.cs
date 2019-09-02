using IFBLL;
using IOC;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace UI.Controllers.Recruitment_M.Job_release_m
{
    public class position_registerController : Controller
    {
        IFBLLConfig_file_first_kind cf = UserIOC.CreateConfig_file_first_kindBLL();
        IFBLLConfig_file_second_kind ib = UserIOC.CreateConfig_file_second_kindBLL();
        IFBLLConfig_file_third_kind tk = UserIOC.CreateConfig_file_third_kindBLL();
        IFBLLClient bc = UserIOC.CreateClientBLL();
        IFBLLconfig_major_kind mk = UserIOC.config_major_kindBLL();
        IFBLLconfig_major m = UserIOC.config_majorBLL();
        IFBLLengage_major_release R = UserIOC.engage_major_releaseBLL();
        public ActionResult Index()
        {
            ViewBag.dtI = Config_file_first_kind();
            ViewBag.engagetype = config_public_cha();
            ViewBag.major_kind_name = major_kind_name();
            return View();
        }
        public ActionResult dtII()
        {
            string id = Request["id"];
            return Content(JsonConvert.SerializeObject(ib.cx(id)));
        }
        public ActionResult dtIII()
        {
            string id = Request["id"];
            return Content(JsonConvert.SerializeObject(tk.SelectIII(id)));
        }
        public ActionResult major_kind_nameSelect()
        {
            string id = Request["id"];
            return Content(JsonConvert.SerializeObject(m.SelectwWhere(id)));
        }
        public ActionResult Add()
        {
            engage_major_release_Model e = new engage_major_release_Model()
            {
                first_kind_id = Request["first_kind_id"],
                first_kind_name = Request["first_kind_name"],
                second_kind_id = Request["second_kind_id"],
                second_kind_name = Request["second_kind_name"],
                third_kind_id = Request["third_kind_id"],
                third_kind_name = Request["third_kind_name"],
                engage_type = Request["engage_type"],
                major_kind_id = Request["major_kind_id"],
                major_kind_name = Request["major_kind_name"],
                major_id = Request["major_id"],
                major_name = Request["major_name"],
                human_amount = int.Parse(Request["human_amount"]),
                deadline = DateTime.Parse(Request["deadline"]),
                register = Request["register"],
                regist_time = DateTime.Parse(Request["regist_time"]),
                major_describe = Request["major_describe"],
                engage_required = Request["engage_required"],
                changer = null,
                change_time = DateTime.Parse("2000-01-01 00:00:00")
            };
            if (R.engage_major_releaseAdd(e) > 0)
            {
                return Content("alert('新增成功');window.location.href='/position_register/Index'");
            }else
            {
                return Content("alert('新增失败');window.location.href='/position_register/Index'");
            }
        }
        public List<SelectListItem> Config_file_first_kind()
        {
            List<config_file_first_kindModel> list = cf.Select();
            List<SelectListItem> list1 = new List<SelectListItem>();
            foreach (config_file_first_kindModel item in list)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.first_kind_name.ToString(),
                    Value = item.first_kind_id.ToString()
                };
                list1.Add(sl);
            }
            return list1;
        }
        public List<SelectListItem> config_public_cha()
        {
            List<config_public_charModel> list =bc.SelectWhere("招聘分类");
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
        public List<SelectListItem> major_kind_name()
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