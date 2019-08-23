using EFentity;
using IFBLL;
using IOC;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class LoginController : Controller
    {
        IFBLLUser b = UserIOC.CreateStudentBLL();
        public ActionResult Index()
        {
           // Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MyDbcontext>());
            b.ADDUser();
            return View();
        }
        public ActionResult login(FormCollection frm)
        {
            string username =frm["userName"];
            string userPassword = frm["userPassword"];
            users u = new users()
            {
                user_name = username,
                user_password = userPassword
            };
            if (b.Login(u) > 0)
            {
                return Content("<script>alert('登录成功');window.location.href='/Mian/Index'</script>");
            }else
            {
                return Content("<script>alert('登录失败');window.location.href='/Login/Index'</script>");
            }
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
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

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
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

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
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
