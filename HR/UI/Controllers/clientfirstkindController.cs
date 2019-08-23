using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IFBLL;
using IOC;
using Model;
using Newtonsoft.Json;

namespace UI.Controllers
{
    public class clientfirstkindController : Controller
    {
        IFBLLConfig_file_first_kind ib = UserIOC.CreateConfig_file_first_kindBLL();
        // GET: clientfirstkind
        public ActionResult Index()
        {
            List<config_file_first_kindModel> list = ib.Select();
            return View(list);
        }

        // GET: clientfirstkind/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: clientfirstkind/Create
        [HttpPost]
        public ActionResult Create(config_file_first_kindModel cn)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // TODO: Add insert logic here
                    string a = ib.BH().ToString();
                    cn.first_kind_id = a;
                    int b = ib.Add(cn);
                    if (b > 0)
                    {
                        //return Content("<script>alert('新增成功');window.location.href='index'<script>");
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
            else
            {
                return View();
            }

        }
        /// <summary>
        /// 新增成功显示
        /// </summary>
        /// <returns></returns>
        public ActionResult xzcg()
        {
            return View();
        }

        // GET: clientfirstkind/Edit/5
        public ActionResult Edit(int id)
        {
            config_file_first_kindModel list = ib.XGCX(id);
            return View(list);
        }

        // POST: clientfirstkind/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, config_file_first_kindModel cn)
        {
            try
            {
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
        /// 修改成功显示
        /// </summary>
        /// <returns></returns>
        public ActionResult xgcg()
        {
            return View();
        }

        // GET: clientfirstkind/Delete/5
        public ActionResult Delete(int id)
        {
            config_file_first_kindModel cn = new config_file_first_kindModel()
            {
                Id=id
            };
            int a = ib.Del(cn);
            if (a > 0)
            {
                 return Content("<script>alert('删除成功');window.location.href='/clientfirstkind/Index'</script>");
            }
            return View();
        }

        // POST: clientfirstkind/Delete/5
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
