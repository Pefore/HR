using DAL;
using EFentity;
using IFBLL;
using IOC;
using Model;
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
            return View();
        }
        public ActionResult login(FormCollection frm)
        {
            string username = frm["userName"];
            string userPassword = frm["userPassword"];
            users u = new users()
            {
                user_name = username,
                user_password = userPassword

            };
            int aa = b.Login(u);
            if (aa > 0)
            {
                users u1 = b.Select(u);
                return JavaScript("alert('登录成功');localStorage.setItem('b','" +u1.right_id + "');localStorage.setItem('user','" + u1.user_true_name + "');window.location.href='/Mian/Index';");
            }
            else
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
