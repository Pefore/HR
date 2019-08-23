using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class MianController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TOP()
        {
            return View();
        }
        public ActionResult LEFT()
        {
            return View();
        }
        public ActionResult Main()
        {
                return View();
        }

        // GET: Mian/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mian/Edit/5
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

        // GET: Mian/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mian/Delete/5
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
