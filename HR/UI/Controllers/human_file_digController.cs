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
        IFBLLhuman_file_dig ibhf = UserIOC.human_file_digBLL();
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
            List<config_file_third_kindModel> list = ibt.cx(b);
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
            List<config_major_Model> list = ibm.cx(b);
            return Content(JsonConvert.SerializeObject(list));
        }
        /// <summary>
        /// 职称下拉框
        /// </summary>
        /// <returns></returns>
        private List<SelectListItem> ZCXlk()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<config_public_charModel> list2 = ibcl.cx("职称");
            foreach (config_public_charModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.attribute_name.ToString(),
                    Value = item.Id.ToString()
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
            List<config_public_charModel> list2 = ibcl.cx("国籍");
            foreach (config_public_charModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.attribute_name.ToString(),
                    Value = item.Id.ToString()
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
            List<config_public_charModel> list2 = ibcl.cx("民族");
            foreach (config_public_charModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.attribute_name.ToString(),
                    Value = item.Id.ToString()
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
            List<config_public_charModel> list2 = ibcl.cx("宗教信仰");
            foreach (config_public_charModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.attribute_name.ToString(),
                    Value = item.Id.ToString()
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
            List<config_public_charModel> list2 = ibcl.cx("政治面貌");
            foreach (config_public_charModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.attribute_name.ToString(),
                    Value = item.Id.ToString()
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
            List<config_public_charModel> list2 = ibcl.cx("学历");
            foreach (config_public_charModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.attribute_name.ToString(),
                    Value = item.Id.ToString()
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
            List<config_public_charModel> list2 = ibcl.cx("教育年限");
            foreach (config_public_charModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.attribute_name.ToString(),
                    Value = item.Id.ToString()
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
            List<config_public_charModel> list2 = ibcl.cx("专业");
            foreach (config_public_charModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.attribute_name.ToString(),
                    Value = item.Id.ToString()
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
            List<config_public_charModel> list2 = ibcl.cx("薪酬设置");
            foreach (config_public_charModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.attribute_name.ToString(),
                    Value = item.Id.ToString()
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
            List<config_public_charModel> list2 = ibcl.cx("爱好");
            foreach (config_public_charModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.attribute_name.ToString(),
                    Value = item.Id.ToString()
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
            List<config_public_charModel> list2 = ibcl.cx("特长");
            foreach (config_public_charModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.attribute_name.ToString(),
                    Value = item.Id.ToString()
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
                string zwmcbh = form["ZWMC"];
                string zwmcmc = null;
                List<config_major_Model> list5 = ibm.listconfig_major();
                foreach (config_major_Model item in list5)
                {
                    if (zwmcbh.Equals(item.Position_Name_id))
                    {
                        zwmcmc = item.Position_Name;
                    }
                }
                #endregion
                #region 职称
                int zcbh = int.Parse(form["ZC"]);
                string zcmc = null;
                List<config_public_charModel> list6 = ibcl.SELECTClient();
                foreach (config_public_charModel item in list6)
                {
                    if (zcbh.Equals(item.Id))
                    {
                        zcmc = item.attribute_name;
                    }
                }
                #endregion
                #region 性别
                string xb = form["XB"];
                #endregion
                #region 国籍
                int gjbh = int.Parse(form["GJ"]);
                string gjmc = null;
                List<config_public_charModel> list7 = ibcl.SELECTClient();
                foreach (config_public_charModel item in list7)
                {
                    if (gjbh.Equals(item.Id))
                    {
                        gjmc = item.attribute_name;
                    }
                }
                #endregion
                #region 民族
                int mzbh = int.Parse(form["MZ"]);
                string mzmc = null;
                List<config_public_charModel> list8 = ibcl.SELECTClient();
                foreach (config_public_charModel item in list8)
                {
                    if (mzbh.Equals(item.Id))
                    {
                        mzmc = item.attribute_name;
                    }
                }
                #endregion
                #region 宗教信仰
                int zjxybh = int.Parse(form["ZJXY"]);
                string zjxymc = null;
                List<config_public_charModel> list9 = ibcl.SELECTClient();
                foreach (config_public_charModel item in list9)
                {
                    if (zjxybh.Equals(item.Id))
                    {
                        zjxymc = item.attribute_name;
                    }
                }
                #endregion
                #region 政治面貌
                int zzmmbh = int.Parse(form["ZZMM"]);
                string zzmmmc = null;
                List<config_public_charModel> list10 = ibcl.SELECTClient();
                foreach (config_public_charModel item in list10)
                {
                    if (zzmmbh.Equals(item.Id))
                    {
                        zzmmmc = item.attribute_name;
                    }
                }
                #endregion
                #region 学历
                int xlbh = int.Parse(form["XL"]);
                string xlmc = null;
                List<config_public_charModel> list11 = ibcl.SELECTClient();
                foreach (config_public_charModel item in list11)
                {
                    if (xlbh.Equals(item.Id))
                    {
                        xlmc = item.attribute_name;
                    }
                }
                #endregion
                #region 教育年限
                int jynxbh = int.Parse(form["JYNX"]);
                string jynxmc = null;
                List<config_public_charModel> list12 = ibcl.SELECTClient();
            foreach (config_public_charModel item in list12)
            {
                if (jynxbh.Equals(item.Id))
                {
                    jynxmc = item.attribute_name;
                    break;
                }
            }
            #endregion
                #region 学历专业
            int xlzybh = int.Parse(form["XLZY"]);
                string xlzymc = null;
                List<config_public_charModel> list13 = ibcl.SELECTClient();
                foreach (config_public_charModel item in list13)
                {
                    if (xlzybh.Equals(item.Id))
                    {
                        xlzymc = item.attribute_name;
                    }
                }
                #endregion
                #region 薪酬标准
                int xcszbh = int.Parse(form["XCSZ"]);
                string xcszmc = null;
                List<config_public_charModel> list14 = ibcl.SELECTClient();
                foreach (config_public_charModel item in list14)
                {
                    if (xcszbh.Equals(item.Id))
                    {
                        xcszmc = item.attribute_name;
                    }
                }
                #endregion
                #region 特长
                int tcbh = int.Parse(form["TC"]);
                string tcmc = null;
                List<config_public_charModel> list15 = ibcl.SELECTClient();
                foreach (config_public_charModel item in list15)
                {
                    if (tcbh.Equals(item.Id))
                    {
                        tcmc = item.attribute_name;
                    }
                }
                #endregion
                #region 爱好
                int ahbh = int.Parse(form["AH"]);
                string ahmc = null;
                List<config_public_charModel> list16 = ibcl.SELECTClient();
                foreach (config_public_charModel item in list16)
                {
                    if (ahbh.Equals(item.Id))
                    {
                        ahmc = item.attribute_name;
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
            hm.human_major_id = zwmcbh;
            hm.human_major_kind_id = zwflbh;
            hm.human_major_kind_name = zwflmc;
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
                return Content("<script>alert('新增成功');window.location.href='index'</script>");
            }
            else
            {
                return View();
            }
           
        }

        // GET: human_file_dig/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: human_file_dig/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: human_file_dig/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: human_file_dig/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: human_file_dig/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: human_file_dig/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
