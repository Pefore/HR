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
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MyDbcontext>());
            b.ADDUser();
            return View();
        }
        public ActionResult login(FormCollection frm)
        {
            string username =frm["userName"];
            string userPassword = frm["userPassword"];
            string trueName = null;
            users u = new users()
            {
                user_name = username,
                user_password = userPassword
            };
            if (b.Login(u) > 0)
            {
                users u1 = b.Select(new users() { user_name = username });
                trueName = u1.user_true_name;
                return Content(trueName);
            }
            else
            {
                return Content("<script>alert('登录失败');window.location.href='/Login/Index'</script>");
            }
        }
    }
}
