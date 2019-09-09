using BLL;
using IFBLL;
using IOC;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class human_file_digController : Controller
    {
        IFBLLConfig_file_first_kind ibf = UserIOC.CreateConfig_file_first_kindBLL();
        IFBLLConfig_file_second_kind ibs = UserIOC.CreateConfig_file_second_kindBLL();
        IFBLLConfig_file_third_kind ibt = UserIOC.CreateConfig_file_third_kindBLL();
        IFBLLconfig_major ibm = UserIOC.config_majorBLL();
        IFBLLconfig_major_kind ibmk = UserIOC.config_major_kindBLL();
        //config_public_char
        IFBLLClient ibcl = UserIOC.CreateClientBLL();
        BLLhuman_file_dig ibhf = new BLLhuman_file_dig();
        // GET: human_file_dig
        public ActionResult Index()
        {
            ViewBag.dty = YJXlk();
            ViewBag.zyfl= ZYFLXlk();
            ViewBag.zc = ZCXlk();
            ViewBag.xb = XBXlk();
            ViewBag.gj = GJXlk();
            ViewBag.mz = MZXlk();
            ViewBag.zjxy = ZJXYXlk();
            ViewBag.zzmm = ZZMMXlk();
            ViewBag.xl =XLXlk();
            ViewBag.jynx =JYNXXlk();
            ViewBag.xlzy =XLZYXlk();
            ViewBag.xcsz = XCSZXlk();
            ViewBag.ah = AHXlk();
            ViewBag.tc = TCXlk();
            return View();
        }

        /// <summary>
        /// 一级下拉框
        /// </summary>
        /// <returns></returns>
        private List<SelectListItem> YJXlk()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<config_file_first_kindModel> list2 = ibf.Select();
            foreach (config_file_first_kindModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.first_kind_name.ToString(),
                    Value = item.first_kind_id.ToString()
                };
                list.Add(sl);
            }
            return list;
        }
        /// <summary>
        /// 二级下拉框
        /// </summary>
        /// <returns></returns>
        public ActionResult EJ()
        {
            string b = Request["id"];
            List<config_file_second_kindModel> list = ibs.cx(b);
            return Content(JsonConvert.SerializeObject(list));
        }
        /// <summary>
        /// 三级下拉框
        /// </summary>
        /// <returns></returns>
        public ActionResult SJ()
        {
            string b = Request["id"];
            List<config_file_third_kindModel> list = ibt.SelectIII(b);
            return Content(JsonConvert.SerializeObject(list));
        }
        /// <summary>
        /// 职业分类下拉框
        /// </summary>
        /// <returns></returns>
        private List<SelectListItem> ZYFLXlk()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<config_major_kind_Model> list2 = ibmk.listconfig_major_kind();
            foreach (config_major_kind_Model item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.major_kind_name.ToString(),
                    Value = item.major_kind_id.ToString()
                };
                list.Add(sl);
            }
            return list;
        }
        /// <summary>
        /// 职业名称下拉框
        /// </summary>
        /// <returns></returns>
        public ActionResult ZWMC()
        {
            string b = Request["id"];
            List<config_major_Model> list = ibm.SelectwWhere(b);
            return Content(JsonConvert.SerializeObject(list));
        }
        /// <summary>
        /// 职称下拉框
        /// </summary>
        /// <returns></returns>
        private List<SelectListItem> ZCXlk()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<config_public_charModel> list2 = ibcl.SelectWhere("职称");
            foreach (config_public_charModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.attribute_name.ToString(),
                    Value = item.attribute_name.ToString()
                };
                list.Add(sl);
            }
            return list;
        }
        /// <summary>
        /// 性别下拉框
        /// </summary>
        /// <returns></returns>
        private List<SelectListItem> XBXlk()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("男", "男");
            dic.Add("女", "女");
            foreach (var item in dic)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.Value,
                    Value = item.Key.ToString()
                };
                list.Add(sl);
            }
            return list;
        }
        /// <summary>
        /// 国籍下拉框
        /// </summary>
        /// <returns></returns>
        private List<SelectListItem> GJXlk()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<config_public_charModel> list2 = ibcl.SelectWhere("国籍");
            foreach (config_public_charModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.attribute_name.ToString(),
                    Value = item.attribute_name.ToString()
                };
                list.Add(sl);
            }
            return list;
        }
        /// <summary>
        /// 民族下拉框
        /// </summary>
        /// <returns></returns>
        private List<SelectListItem> MZXlk()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<config_public_charModel> list2 = ibcl.SelectWhere("民族");
            foreach (config_public_charModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.attribute_name.ToString(),
                    Value = item.attribute_name.ToString()
                };
                list.Add(sl);
            }
            return list;
        }
        /// <summary>
        /// 宗教信仰下拉框
        /// </summary>
        /// <returns></returns>
        private List<SelectListItem> ZJXYXlk()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<config_public_charModel> list2 = ibcl.SelectWhere("宗教信仰");
            foreach (config_public_charModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.attribute_name.ToString(),
                    Value = item.attribute_name.ToString()
                };
                list.Add(sl);
            }
            return list;
        }
        /// <summary>
        /// 政治面貌下拉框
        /// </summary>
        /// <returns></returns>
        private List<SelectListItem> ZZMMXlk()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<config_public_charModel> list2 = ibcl.SelectWhere("政治面貌");
            foreach (config_public_charModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.attribute_name.ToString(),
                    Value = item.attribute_name.ToString()
                };
                list.Add(sl);
            }
            return list;
        }
        /// <summary>
        /// 学历下拉框
        /// </summary>
        /// <returns></returns>
        private List<SelectListItem> XLXlk()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<config_public_charModel> list2 = ibcl.SelectWhere("学历");
            foreach (config_public_charModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.attribute_name.ToString(),
                    Value = item.attribute_name.ToString()
                };
                list.Add(sl);
            }
            return list;
        }
        /// <summary>
        /// 教育年限下拉框
        /// </summary>
        /// <returns></returns>
        private List<SelectListItem> JYNXXlk()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<config_public_charModel> list2 = ibcl.SelectWhere("教育年限");
            foreach (config_public_charModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.attribute_name.ToString(),
                    Value = item.attribute_name.ToString()
                };
                list.Add(sl);
            }
            return list;
        }
        /// <summary>
        /// 学历专业下拉框
        /// </summary>
        /// <returns></returns>
        private List<SelectListItem> XLZYXlk()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<config_public_charModel> list2 = ibcl.SelectWhere("专业");
            foreach (config_public_charModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.attribute_name.ToString(),
                    Value = item.attribute_name.ToString()
                };
                list.Add(sl);
            }
            return list;
        }
        /// <summary>
        /// 薪酬标准下拉框(未有表 salary_standard_details,等有后要进行修改)
        /// </summary>
        /// <returns></returns>
        private List<SelectListItem> XCSZXlk()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<config_public_charModel> list2 = ibcl.SelectWhere("薪酬设置");
            foreach (config_public_charModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.attribute_name.ToString(),
                    Value = item.attribute_name.ToString()
                };
                list.Add(sl);
            }
            return list;
        }
        /// <summary>
        /// 爱好下拉框
        /// </summary>
        /// <returns></returns>
        private List<SelectListItem> AHXlk()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<config_public_charModel> list2 = ibcl.SelectWhere("爱好");
            foreach (config_public_charModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.attribute_name.ToString(),
                    Value = item.attribute_name.ToString()
                };
                list.Add(sl);
            }
            return list;
        }
        /// <summary>
        /// 特长下拉框
        /// </summary>
        /// <returns></returns>
        private List<SelectListItem> TCXlk()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<config_public_charModel> list2 = ibcl.SelectWhere("特长");
            foreach (config_public_charModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.attribute_name.ToString(),
                    Value = item.attribute_name.ToString()
                };
                list.Add(sl);
            }
            return list;
        }
        // GET: human_file_dig/Details/5
        [HttpPost]
        public ActionResult Tj(FormCollection form)
        {
            #region 生成档案编号
            int num = 1000;
            string year = DateTime.Now.Year.ToString();
            string DayOfYear = DateTime.Now.DayOfYear.ToString();
            string sjk = ibhf.ooo();
            int i = 1;
            if (sjk == "0")
            {
                num += i;
            }
            else
            {
                i = int.Parse(sjk)+1;
                num += i;
            }
            string human_id = "bt" + year + DayOfYear + num;
            #endregion
            #region 一级机构
            string yjjgbh = form["YJJG"];
                string yjjgmc = null;
                List<config_file_first_kindModel> list = ibf.Select();
                foreach (config_file_first_kindModel item in list)
                {
                    if (yjjgbh.Equals(item.first_kind_id))
                    {
                        yjjgmc = item.first_kind_name;
                    }
                }
                #endregion
                #region 二级机构
                string ejjgbh = form["EJJG"];
                string ejjgmc = null;
                List<config_file_second_kindModel> list2 = ibs.Select();
                foreach (config_file_second_kindModel item in list2)
                {
                    if (ejjgbh.Equals(item.second_kind_id))
                    {
                        ejjgmc = item.second_kind_name;
                    }
                }
                #endregion
                #region 三级机构
                string sjjgbh = form["SJJG"];
                string sjjgmc = null;
                List<config_file_third_kindModel> list3 = ibt.Select();
                foreach (config_file_third_kindModel item in list3)
                {
                    if (sjjgbh.Equals(item.third_kind_id))
                    {
                        sjjgmc = item.third_kind_name;
                    }
                }
                #endregion
                #region 职位分类
                string zwflbh = form["ZYFL"];
                string zwflmc = null;
                List<config_major_kind_Model> list4 = ibmk.listconfig_major_kind();
                foreach (config_major_kind_Model item in list4)
                {
                    if (zwflbh.Equals(item.major_kind_id))
                    {
                        zwflmc = item.major_kind_name;
                    }
                }
                #endregion
                #region 职位名称
                string zwmcmc = form["ZWMC"];
                string zwmcbh = null;
                List<config_major_Model> list5 = ibm.listconfig_major();
                foreach (config_major_Model item in list5)
                {
                    if (zwmcmc.Equals(item.Position_Name))
                    {
                        zwmcbh = item.Position_Name_id;
                    }
                }
                #endregion
                #region 职称
                string zcmc = form["ZC"];
                string zcbh = null;
                List<config_public_charModel> list6 = ibcl.SELECTClient();
                foreach (config_public_charModel item in list6)
                {
                    if (zcmc.Equals(item.attribute_name))
                    {
                        zcbh = item.Id.ToString();
                    }
                }
                #endregion
                #region 性别
                string xb = form["XB"];
                #endregion
                #region 国籍
                string gjmc = form["GJ"];
                int gjbh = 1;
                List<config_public_charModel> list7 = ibcl.SELECTClient();
                foreach (config_public_charModel item in list7)
                {
                    if (gjmc.Equals(item.attribute_name))
                    {
                        gjbh = item.Id;
                    }
                }
                #endregion
                #region 民族
                string mzmc = form["MZ"];
                int mzbh = 1;
                List<config_public_charModel> list8 = ibcl.SELECTClient();
                foreach (config_public_charModel item in list8)
                {
                    if (mzmc.Equals(item.attribute_name))
                    {
                        mzbh = item.Id;
                    }
                }
                #endregion
                #region 宗教信仰
                string zjxymc = form["ZJXY"];
                int zjxybh = 1;
                List<config_public_charModel> list9 = ibcl.SELECTClient();
                foreach (config_public_charModel item in list9)
                {
                    if (zjxymc.Equals(item.attribute_name))
                    {
                    zjxybh = item.Id;
                    }
                }
                #endregion
                #region 政治面貌
                string zzmmmc = form["ZZMM"];
                int zzmmbh = 1;
                List<config_public_charModel> list10 = ibcl.SELECTClient();
                foreach (config_public_charModel item in list10)
                {
                    if (zzmmmc.Equals(item.attribute_name))
                    {
                    zzmmbh = item.Id;
                    }
                }
                #endregion
                #region 学历
                string xlmc = form["XL"];
                int xlbh = 1;
                List<config_public_charModel> list11 = ibcl.SELECTClient();
                foreach (config_public_charModel item in list11)
                {
                    if (xlmc.Equals(item.attribute_name))
                    {
                        xlbh = item.Id;
                    }
                }
                #endregion
                #region 教育年限
                string jynxmc = form["JYNX"];
                int jynxbh = 1;
                List<config_public_charModel> list12 = ibcl.SELECTClient();
            foreach (config_public_charModel item in list12)
            {
                if (jynxmc.Equals(item.attribute_name))
                {
                    jynxbh = item.Id;
                    break;
                }
            }
            #endregion
                #region 学历专业
            string xlzymc = form["XLZY"];
            int xlzymbh = 1;
            List<config_public_charModel> list13 = ibcl.SELECTClient();
            foreach (config_public_charModel item in list13)
            {
                if (xlzymc.Equals(item.attribute_name))
                {
                    xlzymbh = item.Id;
                }
            }
            #endregion
                #region 薪酬标准
            string xcszmc = form["XCSZ"];
                int xcszbh = 1;
                List<config_public_charModel> list14 = ibcl.SELECTClient();
                foreach (config_public_charModel item in list14)
                {
                    if (xcszmc.Equals(item.attribute_name))
                    {
                    xcszbh = item.Id;
                    }
                }
                #endregion
                #region 特长
                string tcmc = form["TC"];
                int tcbh = 1;
                List<config_public_charModel> list15 = ibcl.SELECTClient();
                foreach (config_public_charModel item in list15)
                {
                    if (tcmc.Equals(item.attribute_name))
                    {
                    tcbh = item.Id;
                    }
                }
                #endregion
                #region 爱好
                string ahmc = form["AH"];
                int ahbh = 1;
                List<config_public_charModel> list16 = ibcl.SELECTClient();
                foreach (config_public_charModel item in list16)
                {
                    if (ahmc.Equals(item.attribute_name))
                    {
                    ahbh = item.Id;
                    }
                }
                #endregion
                human_file_digModel hm = new human_file_digModel()
                { };
          
            hm.human_id = human_id;
            hm.first_kind_id = yjjgbh;
            hm.first_kind_name = yjjgmc;
            hm.second_kind_id = ejjgbh;
            hm.second_kind_name = ejjgmc;
            hm.third_kind_id = sjjgbh;
            hm.third_kind_name = sjjgmc;
            hm.human_major_kind_id = zwflbh;
            hm.human_major_kind_name = zwflmc;
            hm.human_major_id = zwmcbh;
            hm.hunma_major_name = zwmcmc;
            hm.human_pro_designation = zcmc;
            hm.human_name = form["human_name"];
            hm.human_sex = xb;
            hm.human_email = form["human_email"];
            hm.human_telephone = form["human_telephone"];
            hm.human_qq = form["human_qq"];
            hm.human_mobilephone = form["human_mobilephone"];
            hm.human_address = form["human_address"];
            hm.human_postcode = form["human_postcode"];
            hm.human_nationality = gjmc;
            hm.human_birthplace = form["human_birthplace"];
            hm.human_birthday =DateTime.Parse(form["human_birthday"]);
            hm.human_race =mzmc;
            hm.human_religion =zjxymc;
            hm.human_party =zzmmmc;
            hm.human_id_card =form["human_id_card"];
            hm.human_society_security_id =form["human_society_security_id"];
            hm.human_age =int.Parse(form["human_age"]);
            hm.human_educated_degree =xlmc;
            hm.human_educated_years =int.Parse(jynxmc);
            hm.human_educated_major =xlzymc;
            hm.salary_standard_name =xcszmc;
            hm.salary_standard_id =xcszbh.ToString();
            hm.human_bank =form["human_bank"];
            hm.human_account =form["human_account"];
            hm.register =form["register"];
            hm.regist_time =DateTime.Now;
            hm.human_speciality =tcmc;
            hm.human_hobby =ahmc;
            hm.human_histroy_records =form["human_histroy_records"];
            hm.human_family_membership =form["human_family_membership"];
            hm.remark = form["remark"];
            hm.human_file_status = 1;
            int b= ibhf.Add(hm);
            if (b>0)
            {
                //return Content("<script>alert('新增成功');window.location.href='index'</script>");
                return RedirectToAction("xzcg");
            }
            else
            {
                return View();
            }
           
        }
        /// <summary>
        /// 新增成功挑转
        /// </summary>
        /// <returns></returns>
        public ActionResult xzcg()
        {
            return View();
        }
      /// <summary>
      /// 复核查看
      /// </summary>
      /// <returns></returns>
        public ActionResult fhcx()
        {
            return View();
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <returns></returns>
        public ActionResult FY()
        {
            string currentPage = Request["currentPage"];
            int zt = int.Parse(Request["zt"]);
            return Content(JsonConvert.SerializeObject(ibhf.FenYe(zt,int.Parse(currentPage))));
        }
        public ActionResult Edit(int id)
        {
            human_file_digModel list = ibhf.XGCX(id);
            ViewBag.zc = ZCXlk();
            ViewBag.xb = XBXlk();
            ViewBag.gj = GJXlk();
            ViewBag.mz = MZXlk();
            ViewBag.zjxy = ZJXYXlk();
            ViewBag.zzmm = ZZMMXlk();
            ViewBag.xl = XLXlk();
            ViewBag.jynx = JYNXXlk();
            ViewBag.xlzy = XLZYXlk();
            ViewBag.xcsz = XCSZXlk();
            ViewBag.ah = AHXlk();
            ViewBag.tc = TCXlk();
            return View(list);
        }
       
       /// <summary>
       /// 修改提交
       /// </summary>
       /// <param name="collection"></param>
       /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(FormCollection form)
        {
            #region 职称
            string zcmc = form["human_pro_designation"];
            string zcbh = null;
            List<config_public_charModel> list6 = ibcl.SELECTClient();
            foreach (config_public_charModel item in list6)
            {
                if (zcmc.Equals(item.attribute_name))
                {
                    zcbh = item.Id.ToString();
                }
            }
            #endregion
            #region 性别
            string xb = form["human_sex"];
            #endregion
            #region 国籍
            string gjmc = form["human_nationality"];
            int gjbh = 1;
            List<config_public_charModel> list7 = ibcl.SELECTClient();
            foreach (config_public_charModel item in list7)
            {
                if (gjmc.Equals(item.attribute_name))
                {
                    gjbh = item.Id;
                }
            }
            #endregion
            #region 民族
            string mzmc = form["human_race"];
            int mzbh = 1;
            List<config_public_charModel> list8 = ibcl.SELECTClient();
            foreach (config_public_charModel item in list8)
            {
                if (mzmc.Equals(item.attribute_name))
                {
                    mzbh = item.Id;
                }
            }
            #endregion
            #region 宗教信仰
            string zjxymc = form["human_religion"];
            int zjxybh = 1;
            List<config_public_charModel> list9 = ibcl.SELECTClient();
            foreach (config_public_charModel item in list9)
            {
                if (zjxymc.Equals(item.attribute_name))
                {
                    zjxybh = item.Id;
                }
            }
            #endregion
            #region 政治面貌
            string zzmmmc = form["human_party"];
            int zzmmbh = 1;
            List<config_public_charModel> list10 = ibcl.SELECTClient();
            foreach (config_public_charModel item in list10)
            {
                if (zzmmmc.Equals(item.attribute_name))
                {
                    zzmmbh = item.Id;
                }
            }
            #endregion
            #region 学历
            string xlmc = form["human_educated_degree"];
            int xlbh = 1;
            List<config_public_charModel> list11 = ibcl.SELECTClient();
            foreach (config_public_charModel item in list11)
            {
                if (xlmc.Equals(item.attribute_name))
                {
                    xlbh = item.Id;
                }
            }
            #endregion
            #region 教育年限
            string jynxmc = form["human_educated_years"];
            int jynxbh = 1;
            List<config_public_charModel> list12 = ibcl.SELECTClient();
            foreach (config_public_charModel item in list12)
            {
                if (jynxmc.Equals(item.attribute_name))
                {
                    jynxbh = item.Id;
                    break;
                }
            }
            #endregion
            #region 学历专业
            string xlzymc = form["human_educated_major"];
            int xlzymbh = 1;
            List<config_public_charModel> list13 = ibcl.SELECTClient();
            foreach (config_public_charModel item in list13)
            {
                if (xlzymc.Equals(item.attribute_name))
                {
                    xlzymbh = item.Id;
                }
            }
            #endregion
            #region 薪酬标准
            string xcszmc = form["salary_standard_name"];
            int xcszbh = 1;
            List<config_public_charModel> list14 = ibcl.SELECTClient();
            foreach (config_public_charModel item in list14)
            {
                if (xcszmc.Equals(item.attribute_name))
                {
                    xcszbh = item.Id;
                }
            }
            #endregion
            #region 特长
            string tcmc = form["human_speciality"];
            int tcbh = 1;
            List<config_public_charModel> list15 = ibcl.SELECTClient();
            foreach (config_public_charModel item in list15)
            {
                if (tcmc.Equals(item.attribute_name))
                {
                    tcbh = item.Id;
                }
            }
            #endregion
            #region 爱好
            string ahmc = form["human_hobby"];
            int ahbh = 1;
            List<config_public_charModel> list16 = ibcl.SELECTClient();
            foreach (config_public_charModel item in list16)
            {
                if (ahmc.Equals(item.attribute_name))
                {
                    ahbh = item.Id;
                }
            }
            #endregion
            human_file_digModel hm = new human_file_digModel(){ };
            hm.Id = int.Parse(form["Id"]);
            hm.human_id = form["human_id"];
            hm.first_kind_id = form["first_kind_id"];
            hm.first_kind_name = form["first_kind_name"];
            hm.second_kind_id = form["second_kind_id"];
            hm.second_kind_name = form["second_kind_name"];
            hm.third_kind_id = form["third_kind_id"];
            hm.third_kind_name = form["third_kind_name"];
            hm.human_major_kind_id = form["human_major_kind_id"];
            hm.human_major_kind_name = form["human_major_kind_name"];
            hm.human_major_id = form["human_major_id"];
            hm.hunma_major_name = form["hunma_major_name"];
            hm.human_pro_designation = zcmc;
            hm.human_name = form["human_name"];
            hm.human_sex = xb;
            hm.human_email = form["human_email"];
            hm.human_telephone = form["human_telephone"];
            hm.human_qq = form["human_qq"];
            hm.human_mobilephone = form["human_mobilephone"];
            hm.human_address = form["human_address"];
            hm.human_postcode = form["human_postcode"];
            hm.human_nationality = gjmc;
            hm.human_birthplace = form["human_birthplace"];
            hm.human_birthday = DateTime.Parse(form["human_birthday"]);
            hm.human_race = mzmc;
            hm.human_religion = zjxymc;
            hm.human_party = zzmmmc;
            hm.human_id_card = form["human_id_card"];
            hm.human_society_security_id = form["human_society_security_id"];
            hm.human_age = int.Parse(form["human_age"]);
            hm.human_educated_degree = xlmc;
            hm.human_educated_years = int.Parse(jynxmc);
            hm.human_educated_major = xlzymc;
            hm.salary_standard_name = xcszmc;
            hm.salary_standard_id = xcszbh.ToString();
            hm.human_bank = form["human_bank"];
            hm.human_account = form["human_account"];
            hm.register = form["register"];
            hm.regist_time =DateTime.Parse(form["regist_time"]);
            hm.checker =form["checker"];
            hm.change_time = DateTime.Now;
            hm.human_speciality = tcmc;
            hm.human_hobby = ahmc;
            hm.human_histroy_records = form["human_histroy_records"];
            hm.human_family_membership = form["human_family_membership"];
            hm.remark = form["remark"];
            hm.human_file_status = 2;
            hm.check_time = DateTime.Now;
            hm.change_time = DateTime.Now;
            hm.lastly_change_time = DateTime.Now;
            hm.delete_time = DateTime.Now;
            hm.recovery_time = DateTime.Now;
            int b = ibhf.Update(hm);
            if (b > 0)
            {
                return Content("<script>alert('修改成功');window.location.href='/human_file_dig/fhcx'</script>");
                //return RedirectToAction("xzcg");
            }
            else
            {
                return View();
            }
        }
        //2-3查询
        /// <summary>
        /// 人力资源档案查询
        /// </summary>
        /// <returns></returns>
        public ActionResult query_locate()
        {
            ViewBag.zyfl = ZYFLXlk();
            ViewBag.dty = YJXlk();
            return View();
        }
        /// <summary>
        /// 查询的关键字查询页面
        /// </summary>
        /// <returns></returns>
        public ActionResult query_keywords()
        {
            return View();
        }
        /// <summary>
        /// 跳转查询页面
        /// </summary>
        /// <returns></returns>
        public ActionResult change_list()
        {
            string id = Request["id"];
            if (id == "1")
            {
                string ss = Request["ss"];
                human_file_digModel list = new human_file_digModel();
                list.human_hobby = id;
                list.human_speciality = ss;
                return View(list);
            }
            else
            {
                string first_kind_id = Request["first_kind_id"];
                string second_kind_id = Request["second_kind_id"];
                if (second_kind_id == "undefined")
                {
                    second_kind_id = "";
                }
                string third_kind_id = Request["third_kind_id"];
                if (third_kind_id == "undefined")
                {
                    third_kind_id = "";
                }
                string human_major_kind_id = Request["human_major_kind_id"];
                string human_major_id = Request["human_major_id"];
                if (human_major_id == "undefined")
                {
                    human_major_id = "";
                }
                string human_nationality = Request["ks"];
                string human_race = Request["js"];

                human_file_digModel list = new human_file_digModel();
                list.first_kind_id = first_kind_id;
                list.second_kind_id = second_kind_id;
                list.third_kind_id = third_kind_id;
                list.human_major_kind_id = human_major_kind_id;
                list.human_major_id = human_major_id;
                list.human_nationality = human_nationality;
                list.human_race = human_race;

                return View(list);
            }
        }
        public ActionResult FYCX()
        {
            string id = Request["human_hobby"];
            int aaa = int.Parse(Request["aaa"]);
            int currentPage = int.Parse(Request["currentPage"]);
            if (id == "1")
            {
               string human_speciality = Request["human_speciality"];
                return Content(JsonConvert.SerializeObject(ibhf.FenYe(aaa,currentPage, human_speciality)));
            }
            else
            {
                string first_kind_id = Request["first_kind_id"];
                string second_kind_id = Request["second_kind_id"];
                string third_kind_id = Request["third_kind_id"];
                string human_major_kind_id = Request["human_major_kind_id"];
                string human_major_id = Request["human_major_id"];
                string regist_timek = Request["human_nationality"];
                string regist_timej = Request["human_race"];
                return Content(JsonConvert.SerializeObject(ibhf.FenYe(aaa, currentPage, first_kind_id, second_kind_id, third_kind_id, human_major_kind_id, human_major_id, regist_timek, regist_timej)));
            }
            }
        public ActionResult query_list_information(int id)
        {
            human_file_digModel list = ibhf.XGCX(id);
            return View(list);
        }
        //2-4变更
        /// <summary>
        /// 人力资源档案变更查询
        /// </summary>
        /// <returns></returns>
        public ActionResult change_locate()
        {
            ViewBag.zyfl = ZYFLXlk();
            ViewBag.dty = YJXlk();
            return View();
        }
        /// <summary>
        /// 人力资源档案变更查询显示
        /// </summary>
        /// <returns></returns>
        public ActionResult change_listbg()
        {
            string id = Request["id"];
            if (id == "1")
            {
                string ss = Request["ss"];
                human_file_digModel list = new human_file_digModel();
                list.human_hobby = id;
                list.human_speciality = ss;
                return View(list);
            }
            else
            {
                string first_kind_id = Request["first_kind_id"];
                string second_kind_id = Request["second_kind_id"];
                if (second_kind_id == "undefined")
                {
                    second_kind_id = "";
                }
                string third_kind_id = Request["third_kind_id"];
                if (third_kind_id == "undefined")
                {
                    third_kind_id = "";
                }
                string human_major_kind_id = Request["human_major_kind_id"];
                string human_major_id = Request["human_major_id"];
                if (human_major_id == "undefined")
                {
                    human_major_id = "";
                }
                string human_nationality = Request["ks"];
                string human_race = Request["js"];

                human_file_digModel list = new human_file_digModel();
                list.first_kind_id = first_kind_id;
                list.second_kind_id = second_kind_id;
                list.third_kind_id = third_kind_id;
                list.human_major_kind_id = human_major_kind_id;
                list.human_major_id = human_major_id;
                list.human_nationality = human_nationality;
                list.human_race = human_race;

                return View(list);
            }
        }
        /// <summary>
        /// 更改的关键字查询页面
        /// </summary>
        /// <returns></returns>
        public ActionResult query_keywordsbg()
        {
            return View();
        }
        public ActionResult query_list_informationbg(int id)
        {
            human_file_digModel list = ibhf.XGCX(id);
            ViewBag.zc = ZCXlk();
            ViewBag.xb = XBXlk();
            ViewBag.gj = GJXlk();
            ViewBag.mz = MZXlk();
            ViewBag.zjxy = ZJXYXlk();
            ViewBag.zzmm = ZZMMXlk();
            ViewBag.xl = XLXlk();
            ViewBag.jynx = JYNXXlk();
            ViewBag.xlzy = XLZYXlk();
            ViewBag.xcsz = XCSZXlk();
            ViewBag.ah = AHXlk();
            ViewBag.tc = TCXlk();
            return View(list);
        }

        /// <summary>
        /// 变更提交
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult query_list_informationbg(FormCollection form)
        {
            #region 职称
            string zcmc = form["human_pro_designation"];
            string zcbh = null;
            List<config_public_charModel> list6 = ibcl.SELECTClient();
            foreach (config_public_charModel item in list6)
            {
                if (zcmc.Equals(item.attribute_name))
                {
                    zcbh = item.Id.ToString();
                }
            }
            #endregion
            #region 性别
            string xb = form["human_sex"];
            #endregion
            #region 国籍
            string gjmc = form["human_nationality"];
            int gjbh = 1;
            List<config_public_charModel> list7 = ibcl.SELECTClient();
            foreach (config_public_charModel item in list7)
            {
                if (gjmc.Equals(item.attribute_name))
                {
                    gjbh = item.Id;
                }
            }
            #endregion
            #region 民族
            string mzmc = form["human_race"];
            int mzbh = 1;
            List<config_public_charModel> list8 = ibcl.SELECTClient();
            foreach (config_public_charModel item in list8)
            {
                if (mzmc.Equals(item.attribute_name))
                {
                    mzbh = item.Id;
                }
            }
            #endregion
            #region 宗教信仰
            string zjxymc = form["human_religion"];
            int zjxybh = 1;
            List<config_public_charModel> list9 = ibcl.SELECTClient();
            foreach (config_public_charModel item in list9)
            {
                if (zjxymc.Equals(item.attribute_name))
                {
                    zjxybh = item.Id;
                }
            }
            #endregion
            #region 政治面貌
            string zzmmmc = form["human_party"];
            int zzmmbh = 1;
            List<config_public_charModel> list10 = ibcl.SELECTClient();
            foreach (config_public_charModel item in list10)
            {
                if (zzmmmc.Equals(item.attribute_name))
                {
                    zzmmbh = item.Id;
                }
            }
            #endregion
            #region 学历
            string xlmc = form["human_educated_degree"];
            int xlbh = 1;
            List<config_public_charModel> list11 = ibcl.SELECTClient();
            foreach (config_public_charModel item in list11)
            {
                if (xlmc.Equals(item.attribute_name))
                {
                    xlbh = item.Id;
                }
            }
            #endregion
            #region 教育年限
            string jynxmc = form["human_educated_years"];
            int jynxbh = 1;
            List<config_public_charModel> list12 = ibcl.SELECTClient();
            foreach (config_public_charModel item in list12)
            {
                if (jynxmc.Equals(item.attribute_name))
                {
                    jynxbh = item.Id;
                    break;
                }
            }
            #endregion
            #region 学历专业
            string xlzymc = form["human_educated_major"];
            int xlzymbh = 1;
            List<config_public_charModel> list13 = ibcl.SELECTClient();
            foreach (config_public_charModel item in list13)
            {
                if (xlzymc.Equals(item.attribute_name))
                {
                    xlzymbh = item.Id;
                }
            }
            #endregion
            #region 薪酬标准
            string xcszmc = form["salary_standard_name"];
            int xcszbh = 1;
            List<config_public_charModel> list14 = ibcl.SELECTClient();
            foreach (config_public_charModel item in list14)
            {
                if (xcszmc.Equals(item.attribute_name))
                {
                    xcszbh = item.Id;
                }
            }
            #endregion
            #region 特长
            string tcmc = form["human_speciality"];
            int tcbh = 1;
            List<config_public_charModel> list15 = ibcl.SELECTClient();
            foreach (config_public_charModel item in list15)
            {
                if (tcmc.Equals(item.attribute_name))
                {
                    tcbh = item.Id;
                }
            }
            #endregion
            #region 爱好
            string ahmc = form["human_hobby"];
            int ahbh = 1;
            List<config_public_charModel> list16 = ibcl.SELECTClient();
            foreach (config_public_charModel item in list16)
            {
                if (ahmc.Equals(item.attribute_name))
                {
                    ahbh = item.Id;
                }
            }
            #endregion
            human_file_digModel hm = new human_file_digModel() { };
            hm.Id = int.Parse(form["Id"]);
            hm.human_id = form["human_id"];
            hm.first_kind_id = form["first_kind_id"];
            hm.first_kind_name = form["first_kind_name"];
            hm.second_kind_id = form["second_kind_id"];
            hm.second_kind_name = form["second_kind_name"];
            hm.third_kind_id = form["third_kind_id"];
            hm.third_kind_name = form["third_kind_name"];
            hm.human_major_kind_id = form["human_major_kind_id"];
            hm.human_major_kind_name = form["human_major_kind_name"];
            hm.human_major_id = form["human_major_id"];
            hm.hunma_major_name = form["hunma_major_name"];
            hm.human_pro_designation = zcmc;
            hm.human_name = form["human_name"];
            hm.human_sex = xb;
            hm.human_email = form["human_email"];
            hm.human_telephone = form["human_telephone"];
            hm.human_qq = form["human_qq"];
            hm.human_mobilephone = form["human_mobilephone"];
            hm.human_address = form["human_address"];
            hm.human_postcode = form["human_postcode"];
            hm.human_nationality = gjmc;
            hm.human_birthplace = form["human_birthplace"];
            hm.human_birthday = DateTime.Parse(form["human_birthday"]);
            hm.human_race = mzmc;
            hm.human_religion = zjxymc;
            hm.human_party = zzmmmc;
            hm.human_id_card = form["human_id_card"];
            hm.human_society_security_id = form["human_society_security_id"];
            hm.human_age = int.Parse(form["human_age"]);
            hm.human_educated_degree = xlmc;
            hm.human_educated_years = int.Parse(jynxmc);
            hm.human_educated_major = xlzymc;
            hm.salary_standard_name = xcszmc;
            hm.salary_standard_id = xcszbh.ToString();
            hm.human_bank = form["human_bank"];
            hm.human_account = form["human_account"];
            hm.register = form["register"];
            hm.regist_time = DateTime.Parse(form["regist_time"]);
            hm.checker = form["checker"];
            hm.change_time = DateTime.Now;
            hm.human_speciality = tcmc;
            hm.human_hobby = ahmc;
            hm.human_histroy_records = form["human_histroy_records"];
            hm.human_family_membership = form["human_family_membership"];
            hm.remark = form["remark"];
            hm.human_file_status = 2;
            hm.check_time = DateTime.Parse(form["check_time"]);
            hm.change_time = DateTime.Now;
            hm.lastly_change_time = DateTime.Now;
            hm.delete_time = DateTime.Now;
            hm.recovery_time = DateTime.Now;
            int b = ibhf.Update(hm);
            if (b > 0)
            {
                return Content("<script>alert('修改成功');window.location.href='/human_file_dig/change_listbg'</script>");
                //return RedirectToAction("xzcg");
            }
            else
            {
                return View();
            }
        }
        //2-5-1
        /// <summary>
        /// 人力资源档案删除查询
        /// </summary>
        /// <returns></returns>
        public ActionResult delete_locate()
        {
            ViewBag.zyfl = ZYFLXlk();
            ViewBag.dty = YJXlk();
            return View();
        }
        /// <summary>
        /// 人力资源档案删除显示
        /// </summary>
        /// <returns></returns>
        public ActionResult delete_list()
        {
            string id = Request["id"];
            if (id == "1")
            {
                string ss = Request["ss"];
                human_file_digModel list = new human_file_digModel();
                list.human_hobby = id;
                list.human_speciality = ss;
                return View(list);
            }
            else
            {
                string first_kind_id = Request["first_kind_id"];
                string second_kind_id = Request["second_kind_id"];
                if (second_kind_id == "undefined")
                {
                    second_kind_id = "";
                }
                string third_kind_id = Request["third_kind_id"];
                if (third_kind_id == "undefined")
                {
                    third_kind_id = "";
                }
                string human_major_kind_id = Request["human_major_kind_id"];
                string human_major_id = Request["human_major_id"];
                if (human_major_id == "undefined")
                {
                    human_major_id = "";
                }
                string human_nationality = Request["ks"];
                string human_race = Request["js"];

                human_file_digModel list = new human_file_digModel();
                list.first_kind_id = first_kind_id;
                list.second_kind_id = second_kind_id;
                list.third_kind_id = third_kind_id;
                list.human_major_kind_id = human_major_kind_id;
                list.human_major_id = human_major_id;
                list.human_nationality = human_nationality;
                list.human_race = human_race;

                return View(list);
            }
        }
        /// <summary>
        /// 删除的关键字查询页面
        /// </summary>
        /// <returns></returns>
        public ActionResult delete_keywords()
        {
            return View();
        }
        /// <summary>
        /// 详细页面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult delete_list_information(int id)
        {
            human_file_digModel list = ibhf.XGCX(id);
            return View(list);
        }
        /// <summary>
        /// 删除(修改状态)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult SCZT()
        {
            int id = int.Parse(Request["id"]);
            human_file_digModel list = ibhf.XGCX(id);
            list.delete_time = DateTime.Now;
            list.human_file_status = 3;
            ibhf.Update(list);
            return Content("<script>alert('删除成功');window.location.href='/human_file_dig/delete_list'</script>");
        }
        //2-5-2
        /// <summary>
        /// 人力资源档案恢复查询
        /// </summary>
        /// <returns></returns>
        public ActionResult recovery_locate()
        {
            ViewBag.zyfl = ZYFLXlk();
            ViewBag.dty = YJXlk();
            return View();
        }
        /// <summary>
        /// 人力资源档案恢复显示
        /// </summary>
        /// <returns></returns>
        public ActionResult recovery_list()
        {
            string id = Request["id"];
            if (id == "1")
            {
                string ss = Request["ss"];
                human_file_digModel list = new human_file_digModel();
                list.human_hobby = id;
                list.human_speciality = ss;
                return View(list);
            }
            else
            {
                string first_kind_id = Request["first_kind_id"];
                string second_kind_id = Request["second_kind_id"];
                if (second_kind_id == "undefined")
                {
                    second_kind_id = "";
                }
                string third_kind_id = Request["third_kind_id"];
                if (third_kind_id == "undefined")
                {
                    third_kind_id = "";
                }
                string human_major_kind_id = Request["human_major_kind_id"];
                string human_major_id = Request["human_major_id"];
                if (human_major_id == "undefined")
                {
                    human_major_id = "";
                }
                string human_nationality = Request["ks"];
                string human_race = Request["js"];

                human_file_digModel list = new human_file_digModel();
                list.first_kind_id = first_kind_id;
                list.second_kind_id = second_kind_id;
                list.third_kind_id = third_kind_id;
                list.human_major_kind_id = human_major_kind_id;
                list.human_major_id = human_major_id;
                list.human_nationality = human_nationality;
                list.human_race = human_race;

                return View(list);
            }
        }
        /// <summary>
        /// 恢复的关键字查询页面
        /// </summary>
        /// <returns></returns>
        public ActionResult recovery_keywords()
        {
            return View();
        }
        /// <summary>
        /// 详细页面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult recovery_list_information(int id)
        {
            human_file_digModel list = ibhf.XGCX(id);
            return View(list);
        }
        /// <summary>
        /// 恢复状态
        /// </summary>
        /// <returns></returns>
        public ActionResult HFZT()
        {
            int id = int.Parse(Request["id"]);
            human_file_digModel list = ibhf.XGCX(id);
            list.recovery_time = DateTime.Now;
            list.human_file_status = 2;
            ibhf.Update(list);
            return Content("<script>alert('恢复成功');window.location.href='/human_file_dig/recovery_list'</script>");
        }
        public ActionResult delete_forever_list()
        {
            return View();
        }
        /// <summary>
        /// 永久删除
        /// </summary>
        /// <returns></returns>
        public ActionResult YJSC()
        {
            int id = int.Parse(Request["id"]);
            human_file_digModel list = ibhf.XGCX(id);
            ibhf.Del(list);
            return Content("<script>alert('删除成功');window.location.href='/human_file_dig/delete_forever_list'</script>");
        }
    }
}
