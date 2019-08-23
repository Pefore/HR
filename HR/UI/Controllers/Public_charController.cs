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
    public class Public_charController : Controller
    {
        // GET: Public_char
        public ActionResult Index()
        {
            IFBLLClient ibc = UserIOC.CreateClientBLL();
            List<config_public_charModel> list = ibc.SELECTClient();
            return View(list);
        }

        // GET: Public_char/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Public_char/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Public_char/Create
        [HttpPost]
        public ActionResult Create(config_public_charModel cm)
        {
            if (ModelState.IsValid)
            {
                IFBLLClient ibc = UserIOC.CreateClientBLL();
                int result = ibc.ADDPublic_char(cm);
                if (result > 0)
                {
                    //return RedirectToAction("Index");

                    return Content("<script>alert('新增成功');window.location.href='/Public_char/index'</script>");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        // GET: Public_char/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Public_char/Edit/5
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

        // GET: Public_char/Delete/5
        //删除
        public ActionResult Public_charDelete(int id)
        {
            IFBLLClient ibc = UserIOC.CreateClientBLL();
            int i = ibc.DELETEClient(new config_public_charModel() { Id = id });
            if (i > 0)
            {
                //return RedirectToAction("Index");
                return Content("<script>alert('删除成功');window.location.href='/Public_char/index'</script>");
            }
            else
            {
                return Content("<script>alert('删除失败');window.location.href='/Public_char/index'</script>");
            }

        }
        // POST: Public_char/Delete/5
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
