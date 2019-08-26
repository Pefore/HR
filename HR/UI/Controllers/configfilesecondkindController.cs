using IFBLL;
using IOC;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class configfilesecondkindController : Controller
    {
        IFBLLConfig_file_first_kind iba = UserIOC.CreateConfig_file_first_kindBLL();
        IFBLLConfig_file_second_kind ib = UserIOC.CreateConfig_file_second_kindBLL();
        // GET: configfilesecondkind
        public ActionResult Index()
        {
            List<config_file_second_kindModel> list = ib.Select();
            return View(list);
        }

        // GET: configfilesecondkind/Create
        public ActionResult Create()
        {
          ViewBag.dt= Xlk();
            return View();
        }

        private List<SelectListItem> Xlk()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<config_file_first_kindModel> list2 = iba.Select();
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

        // POST: configfilesecondkind/Create
        [HttpPost]
        public ActionResult Create(FormCollection from)
        {
                try
                {
                    // TODO: Add insert logic here
                    string id = from["first_kind_id"];
                    List<config_file_first_kindModel> list = iba.Select();
                    string Yname = null;
                    foreach (config_file_first_kindModel item in list)
                    {
                        if (id.Equals(item.first_kind_id))
                        {
                            Yname = item.first_kind_name;
                        }
                    }
                    string bh = ib.BH().ToString();
                    config_file_second_kindModel cn = new config_file_second_kindModel()
                    {
                        first_kind_id = id,
                        first_kind_name = Yname,
                        second_kind_id = bh,
                        second_kind_name = from["second_kind_name"],
                        econd_salary_id = from["econd_salary_id"],
                        second_sale_id = from["second_sale_id"]
                    };
                    int b = ib.Add(cn);
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
        // GET: configfilesecondkind/Edit/5
        public ActionResult Edit(int id)
        {
            config_file_second_kindModel list = ib.XGCX(id);
             ViewBag.dt= Xlk();
            return View(list);
        }

        // POST: configfilesecondkind/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection from)
        {
            try
            {
                int p = id;
                string kid = from["first_kind_id"];
                List<config_file_first_kindModel> list = iba.Select();
                string Yname = null;
                foreach (config_file_first_kindModel item in list)
                {
                    if (kid.Equals(item.first_kind_id))
                    {
                        Yname = item.first_kind_name;
                    }
                }
                config_file_second_kindModel cn = new config_file_second_kindModel()
                {
                    Id=id,
                    first_kind_id = kid,
                    first_kind_name = Yname,
                    second_kind_id = from["second_kind_id"],
                    second_kind_name = from["second_kind_name"],
                    econd_salary_id = from["econd_salary_id"],
                    second_sale_id = from["second_sale_id"]
                };
                int a = ib.Update(cn);
                if (a > 0)
                {
                    return RedirectToAction("xgcg");
                    // return Content("<script>alert('修改成功');window.location.href='/clientfirstkind/Index'</script>");
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

        // GET: configfilesecondkind/Delete/5
        public ActionResult Delete(int id)
        {
            config_file_second_kindModel cn = new config_file_second_kindModel()
            {
                Id = id
            };
            int a = ib.Del(cn);
            if (a > 0)
            {
                return Content("<script>alert('删除成功');window.location.href='/configfilesecondkind/Index'</script>");
            }
            return View();
        }

        // POST: configfilesecondkind/Delete/5
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
