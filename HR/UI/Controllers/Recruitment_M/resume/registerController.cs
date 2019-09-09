using IFBLL;
using IOC;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tool;

namespace UI.Controllers.Recruitment_M.resume
{
    public class registerController : Controller
    {
        // GET: register
        IFBLLconfig_major_kind mk = UserIOC.config_major_kindBLL();
        IFBLLconfig_major m = UserIOC.config_majorBLL();
        IFBLLClient bc = UserIOC.CreateClientBLL();
        IFBLLint_engage_resume r = UserIOC.engage_resumeBLL();
        IFBLLengage_major_release mr = UserIOC.engage_major_releaseBLL();
        public ActionResult Index(FormCollection f)
        {
            ViewData["humanmajorkindid"] =Request["major_kind_id"];
            ViewData["humanMajorKindName"] = Request["major_kind_name"];
            ViewData["humanmajorid"] = Request["major_id"];
            ViewData["humanmajorname"] = Request["major_name"];
            ViewData["engageType"]= Request["engage_type"];
            ViewBag.humanNationality = config_public_cha("国籍");
            ViewBag.humanRace = config_public_cha("民族");
            ViewBag.humanReligion = config_public_cha("宗教信仰");
            ViewBag.humanParty= config_public_cha("政治面貌");
            ViewBag.humanEducatedYears= config_public_cha("教育年限");
            ViewBag.humanEducatedMajor = config_public_cha("专业");
            ViewBag.humanSpecility = config_public_cha("特长");
            ViewBag.humanHobby = config_public_cha("爱好");
            ViewBag.humanEducatedDegree= config_public_cha("学历");
            return View();
        }
        //public ActionResult major_kind_nameSelect()
        //{
        //    string id = Request["id"];
        //    return Content(JsonConvert.SerializeObject(m.SelectwWhere(id)));
        //}
        public ActionResult SC()
        {
            engage_resume_Model er = new engage_resume_Model();
            er.human_name = Request["humanname"];
            er.engage_type = Request["engagetype"];
            er.human_address = Request["humanaddress"];
            er.human_postcode = Request["humanpostcode"];
            er.human_major_kind_id = Request["humanmajorkindid"];
            er.human_major_kind_name = Request["humanmajorkindname"];
            er.human_major_id = Request["humanmajorid"];
            er.human_major_name = Request["humanmajorname"];
            er.human_telephone = Request["humantelephone"];
            er.human_homephone = Request["humanhomephone"];
            er.human_mobilephone = Request["humanmobilephone"];
            er.human_email = Request["humanemail"];
            er.human_hobby = Request["humanhobby"];
            er.human_specility = Request["humanspecility"];
            er.human_sex = Request["humansex"];
            er.human_religion = Request["humanreligion"];
            er.human_party = Request["humanparty"];
            er.human_nationality = Request["humannationality"];
            er.human_race = Request["humanrace"];
            er.human_birthday = DateTime.Parse(Request["humanbirthday"]);
            er.human_age = int.Parse(Request["humanage"]);
            er.human_educated_years = int.Parse(Request["humaneducatedyears"]);
            er.human_educated_major = Request["humaneducatedmajor"];
            er.human_college = Request["humancollege"];
            er.human_idcard = Request["humanidcard"];
            er.human_birthplace = Request["humanbirthday"];
            er.demand_salary_standard = double.Parse(Request["demandsalarystandard"]);
            er.human_history_records = Request["humanhistoryrecords"];
            er.remark = Request["remark"];
            er.regist_time = DateTime.Parse(Request["registtime"]);
            er.human_educated_degree = Request["humaneducateddegree"];
            er.register = Request["register"];
            er.check_status = 1;
            return View(er);
        }
        public ActionResult Sc2(HttpPostedFileBase file)
        {
            #region 获取从图片上传的数据
            engage_resume_Model er = new engage_resume_Model();
            er.human_name = Request["human_name"];
            er.engage_type = Request["engage_type"];
            er.human_address = Request["human_address"];
            er.human_postcode = Request["human_postcode"];
            er.human_major_kind_id = Request["human_major_kind_id"];
            er.human_major_kind_name = Request["human_major_kind_name"];
            er.human_major_id = Request["human_major_id"];
            er.human_major_name = Request["human_major_name"];
            er.human_telephone = Request["human_telephone"];
            er.human_homephone = Request["human_homephone"];
            er.human_mobilephone = Request["human_mobilephone"];
            er.human_email = Request["human_email"];
            er.human_hobby = Request["human_hobby"];
            er.human_specility = Request["human_specility"];
            er.human_sex = Request["human_sex"];
            er.human_religion = Request["human_religion"];
            er.human_party = Request["human_party"];
            er.human_nationality = Request["human_nationality"];
            er.human_race = Request["human_race"];
            er.human_birthday = DateTime.Parse(Request["human_birthday"]);
            er.human_age = int.Parse(Request["human_age"]);
            er.human_educated_years = int.Parse(Request["human_educated_years"]);
            er.human_educated_major = Request["human_educated_major"];
            er.human_college = Request["human_college"];
            er.human_idcard = Request["human_idcard"];
            er.human_birthplace = Request["human_birthplace"];
            er.demand_salary_standard = double.Parse(Request["demand_salary_standard"]);
            er.human_history_records = Request["human_history_records"];
            er.remark = Request["remark"];
            er.regist_time = DateTime.Parse(Request["regist_time"]);
            er.human_educated_degree = Request["human_educated_degree"];
            er.register = Request["register"];
            er.check_status = 1;
            #endregion
            string name = Md5String.Md5CreateName(file.InputStream);//文件名
            string ext = Path.GetExtension(file.FileName);//后缀名
            //1 获得上传文件的完整路径
            string path = $"~/Phone/{DateTime.Now.ToString("yyyy/MM/dd")}/" + name + ext;
            string fullPath = Server.MapPath(path);
            new FileInfo(fullPath).Directory.Create();//创建文件夹
            //2 调用file.SaveAs(完整路径)
            file.SaveAs(fullPath);
            er.human_picture =$"/Phone/{ DateTime.Now.ToString("yyyy/MM/dd")}/"+ name + ext;
            //根据uid做表的修改
            if (r.engage_resumeAdd(er) > 0)
            {
                return Content("<script>alert('登记成功');window.location.href ='/position_release_search/Index'</script>");
            }else
            {
                return View(er);
            }
            
        }
        #region 下拉框绑定
        private List<SelectListItem> humanMajorKindName()
        {
            List<config_major_kind_Model> list = mk.listconfig_major_kind();
            List<SelectListItem> list1 = new List<SelectListItem>();
            foreach (config_major_kind_Model item in list)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.major_kind_name.ToString(),
                    Value = item.major_kind_id.ToString()
                };
                list1.Add(sl);
            }
            return list1;
        }
        public List<SelectListItem> config_public_cha(string name)
        {
            List<config_public_charModel> list = bc.SelectWhere(name);
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
        #endregion
    }
}