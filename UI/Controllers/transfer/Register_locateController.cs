using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IFBLL;
using IOC;
using Model;
using EFentity;
using System.Data;
using Newtonsoft.Json;

namespace UI.Controllers.transfer
{
    public class Register_locateController : Controller
    {
        IFBLLMajor_change ifc = UserIOC.CreateMajor_changeBLL();
        public ActionResult Index()
        {
            List<Major_changeModel> list = ifc.SELECTMajor_change();
            ViewBag.dty = First();
            return View(list);
        }
        //first second third
        private List<SelectListItem> First()
        {
            List<Major_changeModel> list = ifc.SELECTMajor_change();
            List <SelectListItem> list2 = new List<SelectListItem>();
            foreach (Major_changeModel item in list)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.first_kind_name,
                    Value = item.first_kind_id
                };
                list2.Add(sl);
            }
            return list2;
        }
        public ActionResult Second()
        {
            string id = Request["id"];
            List<Major_changeModel> list = ifc.SELECTcx(id);
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult Third()
        {
            string id = Request["id"];
            List<Major_changeModel> list = ifc.SELECTcx(id);
            return Content(JsonConvert.SerializeObject(list));
        }
        /// <summary>
        /// 模糊查询之后的页面
        /// </summary>
        /// <returns></returns>
        public ActionResult zz()
        {
            string id = Request["thirdKindId"];
            return JavaScript("window.location.href = '/Register_locate/register_list?id="+id+"';");
        }
        public ActionResult register_list()
        {
            string id = Request["id"];
            if (id == "0")
            {
                List<Major_changeModel> list = ifc.SELECTMajor_change();
                return View(list);

            }
            else
            {
                List<Major_changeModel> list = ifc.selectcx(id);
                return View(list);
            }
        }
        public ActionResult register_success()
        {
            return View();
        }
        // GET: Register_locate/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Register_locate/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Register_locate/Create
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

        // GET: Register_locate/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Register_locate/Edit/5
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

        // GET: Register_locate/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Register_locate/Delete/5
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
