using EFentity;
using IFBLL;
using IOC;
using Model;
using DAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
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
           //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MyDbcontext>());
            b.ADDUser();
            //users u = new users()
            //{
            //    user_name = "hr",
            //    user_true_name = "su",
            //    user_password = "123456"
            //};
            //b.ADDUser(u);

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
            int aa= b.Login(u);
            if ( aa> 0)
            {
                Session["user"] = u;
                return Content("<script>alert('登录成功');localStorage.setItem('b','" + aa+ "');window.location.href='/Mian/Index';</script>");
            }else
            {
                return Content("<script>alert('登录失败');window.location.href='/Login/Index'</script>");
            }
        }
        public ActionResult show(users u)
        {
            string id = Request["id"];
            string gid = Request["Gid"];
            //object dt =ius.JXMain(gid, id);
            //return Content(JsonConvert.SerializeObject(dt));

            string sql = "";
            if (id != null)
            {
                //查询子集                   
                sql = string.Format(@"select* from 
[dbo].[Pop] q inner join   [dbo].[GuanliPop] rq on
q.id=rq.PopID where rq.GuanliID={0} and q.PID={1}", gid, id);
            }
            else
            {
                //查询父集
                sql = string.Format(@"select id,[text],PAddress,[state] from 
[dbo].[Pop] q inner join   [dbo].[GuanliPop] rq on
q.id=rq.PopID where rq.GuanliID={0} and q.PID=0
", gid);
            }

            DataTable dt = SqlDBHelper.table(sql);
            return Content(JsonConvert.SerializeObject(dt));
        }

    }
}
