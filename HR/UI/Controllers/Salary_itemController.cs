using IFBLL;
using IOC;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//薪酬项目设置
namespace UI.Controllers
{
    public class Salary_itemController : Controller
    {
        // GET: Salary_item
        public ActionResult Index()
        {
            IFBLLClient ibc = UserIOC.CreateClientBLL();
            List<config_public_charModel> list = ibc.SELECTClient();
            return View(list);
        }

        // GET: Salary_item/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Salary_item/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Salary_item/Create
        [HttpPost]
        public ActionResult Create(config_public_charModel cm)
        {
            if (ModelState.IsValid)
            {
                IFBLLClient ibc = UserIOC.CreateClientBLL();
                int result = ibc.ADDClient(cm);
                if (result > 0)
                {
                    //return RedirectToAction("Index");
                    
                    return Content("<script>alert('新增成功');window.location.href='/Salary_item/index'</script>");
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

        // GET: Salary_item/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Salary_item/Edit/5
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

        // GET: Salary_item/Delete/5
        //删除
        public ActionResult Salary_itemDelete(int id)
        {
            IFBLLClient ibc = UserIOC.CreateClientBLL();
            int i = ibc.DELETEClient(new config_public_charModel() { Id = id });
            if (i > 0)
            {
                //return RedirectToAction("Index");
                return Content("<script>alert('删除成功');window.location.href='/Salary_item/index'</script>");
            }
            else
            {
                return Content("<script>alert('删除失败');window.location.href='/Salary_item/index'</script>");
            }

        }

        // POST: Salary_item/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, config_public_charModel cm)
        {
            IFBLLClient ibc = UserIOC.CreateClientBLL();
            int result = ibc.DELETEClient(cm);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }


    }
}
