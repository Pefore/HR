using IFBLL;
using IOC;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class configfilethirdkindController : Controller
    {
        IFBLLConfig_file_first_kind ibf = UserIOC.CreateConfig_file_first_kindBLL();
        IFBLLConfig_file_second_kind ibs = UserIOC.CreateConfig_file_second_kindBLL();
        IFBLLConfig_file_third_kind ibt = UserIOC.CreateConfig_file_third_kindBLL();
        // GET: configfilethirdkind
        public ActionResult Index()
        {
            List<config_file_third_kindModel> list = ibt.Select();
            return View(list);
        }
        string aaa = "";
        // GET: configfilethirdkind/Details/5

        // GET: configfilethirdkind/Create
        public ActionResult Create()
        {
            aaa = Request["id"];
            ViewBag.dt = YJXlk();
            ViewBag.dt1 = SFXlk();
            ViewBag.dt2 = EJXlk();
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
        private List<SelectListItem> EJXlk()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            if (aaa == null)
            {
                Dictionary<int, string> dic = new Dictionary<int, string>();
                dic.Add(1, "请先选择第一级");
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
            else
            {
            return list;
            }
        }

        public ActionResult quz()
        {
            string b = Request["id"];
             List<config_file_second_kindModel> list = ibs.cx(b);
            return Content(JsonConvert.SerializeObject(list));
        }
        private List<SelectListItem> SFXlk()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            //List<string> list2 = new List<string>();
            //list2.Add("是");
            //list2.Add("否");
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("是", "是");
            dic.Add("否", "否");
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
        // POST: configfilethirdkind/Create
        [HttpPost]
        public ActionResult Create(FormCollection from)
        {
            try
            {
                string yi = from["first_kind_id"];
                List<config_file_first_kindModel> list = ibf.Select();
                string Yname = null;
                foreach (config_file_first_kindModel item in list)
                {
                    if (yi.Equals(item.first_kind_id))
                    {
                        Yname = item.first_kind_name;
                    }
                }
                string er = from["EJJG"];
                List<config_file_second_kindModel> list2 = ibs.Select();
                string Ename = null;
                foreach (config_file_second_kindModel item in list2)
                {
                    if (er.Equals(item.second_kind_id))
                    {
                        Ename = item.second_kind_name;
                    }
                }
                string bh = ibt.BH().ToString();
                config_file_third_kindModel cn = new config_file_third_kindModel()
                {
                    first_kind_id=yi,
                    first_kind_name=Yname,
                    second_kind_id=er,
                    second_kind_name=Ename,
                    third_kind_id=bh,
                    third_kind_is_retail=from["SF"],
                    third_kind_name=from["third_kind_name"],
                    third_kind_sale_id=from["third_kind_sale_id"]
                };
                int b = ibt.Add(cn);
                if (b > 0)
                {
                    //return Content("<script>alert('新增成功');window.location.href='index'</script>");
                    return RedirectToAction("xzcg");
                }
                else
                {
                    return View();
                }
            }
            catch
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

        // GET: configfilethirdkind/Edit/5
        public ActionResult Edit(int id)
        {
            config_file_third_kindModel list = ibt.XGCX(id);
            ViewBag.dt = YJXlk();
            ViewBag.dt1 = SFXlk();
            return View(list);
        }

        // POST: configfilethirdkind/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection from)
        {
            try
            {
                string yi = from["first_kind_id"];
                List<config_file_first_kindModel> list = ibf.Select();
                string Yname = null;
                foreach (config_file_first_kindModel item in list)
                {
                    if (yi.Equals(item.first_kind_id))
                    {
                        Yname = item.first_kind_name;
                    }
                }
                string er = from["EJJG"];
                List<config_file_second_kindModel> list2 = ibs.Select();
                string Ename = null;
                foreach (config_file_second_kindModel item in list2)
                {
                    if (er.Equals(item.second_kind_id))
                    {
                        Ename = item.second_kind_name;
                    }
                }
                string bh = ibt.BH().ToString();
                config_file_third_kindModel cn = new config_file_third_kindModel()
                {
                    Id=id,
                    first_kind_id = yi,
                    first_kind_name = Yname,
                    second_kind_id = er,
                    second_kind_name = Ename,
                    third_kind_id = bh,
                    third_kind_is_retail = from["SF"],
                    third_kind_name = from["third_kind_name"],
                    third_kind_sale_id = from["third_kind_sale_id"]
                };
                int b = ibt.Update(cn);
                if (b > 0)
                {
                    //return Content("<script>alert('新增成功');window.location.href='index'</script>");
                    return RedirectToAction("xgcg");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }
        /// <summary>
        /// 修改成功后显示
        /// </summary>
        /// <returns></returns>
        public ActionResult xgcg()
        {
            return View();
        }


        // GET: configfilethirdkind/Delete/5
        public ActionResult Delete(int id)
        {
            config_file_third_kindModel cn = new config_file_third_kindModel()
            {
                Id = id
            };
            int a = ibt.Del(cn);
            if (a > 0)
            {
                return Content("<script>alert('删除成功');window.location.href='/configfilethirdkind/Index'</script>");
            }
            return View();
        }

        // POST: configfilethirdkind/Delete/5
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
