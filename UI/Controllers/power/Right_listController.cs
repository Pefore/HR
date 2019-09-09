using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IFBLL;
using IOC;
using Model;
using EFentity;
using Newtonsoft.Json;
using System.Data;
using System.Collections;

namespace UI.Controllers.power
{
    public class Right_listController : Controller
    {
        IFBLLRight ifr = UserIOC.CreateRightBLL();
        // GET: Right_list
        public ActionResult Index()
        {
            //List<rightModel> list = ifr.RightSelect();
            return View();
          
        }
        
        public ActionResult FenYe()
        {
            string currentPage = Request["currentPage"];
            return Content(JsonConvert.SerializeObject(ifr.FenYe(int.Parse(currentPage))));
        }
        // GET: Right_list/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Right_list/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Right_list/Create
        [HttpPost]
        public ActionResult Create(rightModel rm)
        {
            string sfs = Request["sysRole"];
            if (sfs=="false")
            {
                rm.right_usable = "否";
            }
            else if (sfs == "true")
            {
                rm.right_usable = "是";
            }
            rightModel rgh = new rightModel()
            {
                right_id = rm.right_id,
                right_name = rm.right_name,
                right_explain = rm.right_explain,
                right_usable = rm.right_usable
            };
            if (ModelState.IsValid)
            {
                int result = ifr.Add(rgh);
                if (result > 0)
                {
                    return Content("<script>alert('新增成功');window.location.href='/Right_list/index'</script>");
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

        // GET: Right_list/Edit/5
        public ActionResult Edit(int id)
        {
            //List<rightModel> list = ifr.RightSelect();
            //rightModel rm = new rightModel()
            //{
            //    right_id = id
            //};
            //List<rightModel> list2 = ifr.RightSelectBy(rm);
            //ViewBag.sf = xlk();
            //rightModel rd = new rightModel()
            //{
            //    right_id = list2[0].right_id,
            //    right_name = list2[0].right_name,
            //    right_usable = list2[0].right_usable,
            //    right_explain = list2[0].right_explain
            //};
            //ViewData.Model = rd;
            //return View();
            rightModel r = ifr.RightSelectBys(id);
            ViewData.Model = r;
            int right_id = r.right_id;
            ViewData["id"] = right_id;
            ViewData.Model = r;
            return View();

        }

        private List<SelectListItem> xlk()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("否", "否");
            dic.Add("是", "是");
            foreach (var item in dic)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.Value,
                    Value = item.Key.ToString()
                };
                list.Add(sl);
            }
            return list;
        }
       
        // POST: Right_list/Edit/5
        [HttpPost]
        public ActionResult Edit()
        {
            //if (ifr.Update(rm) > 0)
            //{
            //    return Content("<script>alert('修改成功');window.location.href='/Right_list/index'</script>");
            //}
            //else
            //{
            //    return Content("<script>alert('修改失败');window.location.href='/Right_list/index'</script>");
            //}

            string Rolemanager = Request["RoleManager"];
            Dictionary<string, object> di = JsonConvert.DeserializeObject<Dictionary<string, object>>(Rolemanager);
            rightModel mm = new rightModel()
            {
                right_id = int.Parse(di["right_id"].ToString()),
                right_name = di["right_name"].ToString(),
                right_explain = di["right_explain"].ToString(),
                right_usable = di["right_usable"].ToString()
            };
            int i = ifr.Update(mm);
            return Content(JsonConvert.SerializeObject(i));
            

        }
        public ActionResult ShowQX()
        {
            string id = Request["id"];
            string RoleID = Request["right_id"];
            string f = "0";
            DataTable dt;
            if (id != null)
            {
                dt = ifr.selectQX(RoleID, id);
            }
            else
            {
                dt = ifr.selectQX(RoleID, f);
            }
            return Content(JsonConvert.SerializeObject(dt));
        }
        public ActionResult PerADD1()
        {
            string[] qid = (Request["qid"]).Split(',');
            string rid = Request["rid"];
            ArrayList list = new ArrayList();
            foreach (var item in qid)
            {
                list.Add(item);
            }
            int c = ifr.DeletePer(rid);
            foreach (var item in list)
            {
                string sql = string.Format("insert into [dbo].[GuanliPop]  values('{0}','{1}')", rid, item);
                ifr.AddPer(sql);
            }
            //string rid = Request["right_id"];
            //string Aid = Request["dsd"];
            //string sql = string.Format("insert into [dbo].[GuanliPop]  values('{0}','{1}')", rid, Aid);
            //int c = ifr.AddPer(sql);
            return Content(JsonConvert.SerializeObject(c));
        }
        public ActionResult PerPerDelete()
        {
            string rid =Request["right_id"];
            int result = ifr.DeletePer(rid);
            return Content(JsonConvert.SerializeObject(result));
        }

        // GET: Right_list/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Right_list/Delete/5
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
        public ActionResult Right_listDelete(int id)
        {
            rightModel rm = new rightModel()
            {
                right_id = id
            };
            if (ifr.Del(rm) > 0)
            {
                //return RedirectToAction("Index");
                return Content("<script>alert('删除成功');window.location.href='/Right_list/index'</script>");
            }
            else
            {
                return Content("<script>alert('删除失败');window.location.href='/Right_list/index'</script>");
            }
        }
    }
}
