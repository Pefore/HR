using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IFBLL;
using IOC;
using Newtonsoft.Json;

namespace UI.Controllers.power
{
    public class User_listController : Controller
    {
        IFBLLUser ifu = UserIOC.CreateStudentBLL();
        IFBLLRight irb = UserIOC.CreateRightBLL();
        // GET: User_list
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            List<users> list = ifu.cxqb();
            return Content(JsonConvert.SerializeObject(list));
            
        }
        // GET: User_list/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User_list/Create
        public ActionResult Create()
        {
            users u = new users();
            ViewData.Model = u;
            FillDrop();
            return View();
        }
        private List<SelectListItem> FillDrop()
        {
            List<rightModel> list2 = irb.RightSelect();
            List<SelectListItem> list = new List<SelectListItem>();
            foreach (rightModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.right_name,
                    Value = item.right_id.ToString()
                };
                list.Add(sl);
            }
            ViewBag.dt = list;
            return list;
        }
        [HttpPost]
        public ActionResult Create(users u)
        {
            if (ModelState.IsValid)//后台验证
            {
                //新增操作
                if (ifu.Add(u) > 0)
                {
                    return Content("<script>alert('添加成功');window.location.href='/user_list/Index'</script>");
                }
                else
                {
                    return Content("<script>alert('添加失败');window.location.href='/user_list/Index'</script>");
                }
            }
            else
            {
                List<SelectListItem> list = FillDrop();

                ViewData["s"] = list;
                return View(u);
            }
        }

        // GET: User_list/Edit/5
        public ActionResult Edit(int id)
        {
            List<SelectListItem> list = FillDrop();
            ViewData["s"] = list;
            users u = new users()
            {
                Id = id
            };
            List<users> list2 = ifu.SelectBy(u);
            users us = new users()
            {
                Id=list2[0].Id,
                right_id = list2[0].right_id,
                user_name = list2[0].user_name,
                user_password = list2[0].user_password,
                user_true_name = list2[0].user_true_name
            };
            ViewData.Model = us;
            return View();
        }

        // POST: User_list/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, users u)
        {
            if (ifu.Update(u) > 0)
            {
                return Content("<script>alert('修改成功');window.location.href='/User_list/index'</script>");
            }
            else
            {
                return Content("<script>alert('修改失败');window.location.href='/User_list/index'</script>");
            }
        }

        // GET: User_list/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User_list/Delete/5
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
        public ActionResult User_listDelete(int id)
        {
            users u = new users()
            {
                Id = id
            };
            if (ifu.Del(u) > 0)
            {
                //return RedirectToAction("Index");
                return Content("<script>alert('删除成功');window.location.href='/User_list/index'</script>");
            }
            else
            {
                return Content("<script>alert('删除失败');window.location.href='/User_list/index'</script>");
            }
        }

    }
}
