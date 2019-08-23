using EFentity;
using IFBLL;
using IOC;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers.Position
{
    public class PositionController : Controller
    {
        IFBLLPosition_Name_Set p = UserIOC.Position_Name_SetBLL();
        IFBLLconfig_major j = UserIOC.config_majorBLL();
        IFBLLconfig_major_kind k = UserIOC.config_major_kindBLL();
        #region 职位名称
        public ActionResult profession_design()
        {
            ViewBag.list = p.list();
            return View();
        }
        public ActionResult Position_Name_Set_Delete(int id)
        {
            List<config_major_Model> list = j.listconfig_major();
            List<Position_Name_Set_Model> list1 = p.list();
            string Position_Name_id = null;
            int makid = 0;
            foreach (Position_Name_Set_Model item in list1)
            {
                if (id == item.Position_Name_Set_id)
                {
                    Position_Name_id = item.Position_Name_id;
                }
            }
            foreach (config_major_Model item in list)
            {
                if (Position_Name_id.Equals(item.Position_Name_id))
                {
                    makid = item.mak_id;
                }
            }
            int i = p.DeletePosition_Name_Set(new Position_Name_Set_Model() { Position_Name_Set_id = id });
            if (i > 0)
            {
                if(j.Deleteconfig_major(new config_major_Model() { mak_id = makid }) > 0)
                {
                    return Content("<script>alert('删除成功');window.location.href='/Position/profession_design'</script>");
                }            }else
            {
                return Content("<script>alert('删除失败');window.location.href='/Position/profession_design'</script>");
            }
            return View();
        }
        #endregion
        #region 职位分类
        
        public ActionResult config_major_kind()
        {
            List<config_major_kind_Model> list = k.listconfig_major_kind();
            ViewBag.list = list;
            return View();
        }
        public ActionResult config_major_kindDelete(int id)
        {
            
                //删除Position_Name_Set中包含了config_major_kind数据的列
                string major_kind_id = null;
                foreach (config_major_kind_Model item in k.listconfig_major_kind())
                {
                    if (id == item.mfk_id)
                    {
                        major_kind_id = item.major_kind_id;
                    }
                }
                List<config_major_Model> list1 = j.listconfig_major();
                foreach (config_major_Model item in list1)
                {
                    if (major_kind_id.Equals(item.major_kind_id))
                    {
                        foreach (Position_Name_Set_Model item1 in p.list())
                        {
                            if (item.Position_Name_id.Equals(item1.Position_Name_id))
                            {
                                int id1 = item1.Position_Name_Set_id;
                                if (p.DeletePosition_Name_Set(new Position_Name_Set_Model() { Position_Name_Set_id = id1 }) <= 0)
                                {
                                    return Content("<script>alert('删除失败');window.location.href='/Position/config_major_kind'</script>");
                                }
                            }
                        }
                    }
                }
                foreach (config_major_Model item in list1)
                {
                    if (major_kind_id.Equals(item.major_kind_id))
                    {
                        j.Deleteconfig_major(new config_major_Model() { mak_id = item.mak_id });
                    }
                }
            int i = k.Deleteconfig_major_kind(new config_major_kind_Model() { mfk_id = id });
            if (i > 0)
            {
                return Content("<script>alert('删除成功');window.location.href='/Position/config_major_kind'</script>");
            }else
            {
                return Content("<script>alert('删除失败');window.location.href='/Position/config_major_kind'</script>");
            }
        }
        [HttpGet]
        public ActionResult config_major_kindAdd()
        {
            return View(new config_major_kind_Model());
        }
        [HttpPost]
        public ActionResult config_major_kindAdd(config_major_kind_Model from)
        {
            string max = k.SelectMaxconfig_major_kind();
            string i =from.major_kind_name;
            config_major_kind_Model c = new config_major_kind_Model()
            {
                major_kind_id = max,
                major_kind_name = i
            };
            if (k.Addconfig_major_kind(c) > 0)
            {
                return JavaScript("alert('新增成功');window.location.href='/Position/config_major_kind'");
            }else
            {
                return Content("<script>alert('新增失败');window.location.href='/Position/config_major_kind'</script>");
            }
        }
        #endregion
        #region 职位分类
        
        public ActionResult config_major()
        {
            List<config_major_Model> list = j.listconfig_major();
            ViewBag.list = list;
            return View();
        }
        public ActionResult config_majorDelete(int id)
        {
            List<config_major_Model> list = j.listconfig_major();
            string Position_Name_id1 =null;
            foreach (config_major_Model item in list)
            {
                if (id.Equals(item.mak_id))
                {
                    Position_Name_id1 =item.Position_Name_id;
                }
            }
            int Position_Name_id2 = 0;
            foreach (Position_Name_Set_Model item in p.list())
            {
                if (Position_Name_id1.Equals(item.Position_Name_id))
                {
                    Position_Name_id2 = Convert.ToInt32(item.Position_Name_Set_id);
                }
            }
            int i = j.Deleteconfig_major(new config_major_Model() { mak_id = id });
            if (i > 0)
            {
                if(p.DeletePosition_Name_Set(new Position_Name_Set_Model() { Position_Name_Set_id = Position_Name_id2 }) > 0)
                {
                    return Content("<script>alert('删除成功');window.location.href='/Position/config_major'</script>");
                }
            }
            else
            {
                return Content("<script>alert('删除失败');window.location.href='/Position/config_major'</script>");
            }
            return View();
        }
        [HttpGet]
        public ActionResult config_major_Add()
        {
            NewMethod();
            return View(new config_major_Model());
        }
        [HttpPost]
        public ActionResult config_major_Add(FormCollection from)
        {
            string max = k.SelectMaxconfig_major_kind();
            string id =from["major_kind_name"];
            List<config_major_kind_Model> list = k.listconfig_major_kind();
            string major_kind_name = null;
            foreach (config_major_kind_Model item in list)
            {
                if (id.Equals(item.major_kind_id))
                {
                    major_kind_name= item.major_kind_name;
                }
            }
             config_major_Model c = new config_major_Model()
            {
                major_kind_id = id,
                major_kind_name=major_kind_name,
                test_amount=0,
                Position_Name=from["Position_Name"],
                Position_Name_id=max
            };
            if (j.Addconfig_major(c) > 0)
            {
                if(p.AddPosition_Name_Set(new Position_Name_Set_Model() { Position_Name_id=max,Position_Name=from["Position_Name"] }) > 0)
                {
                    return Content("<script>alert('新增成功');window.location.href='/Position/config_major'</script>");
                }else
                {
                    return Content("<script>alert('新增失败');window.location.href='/Position/config_major'</script>");
                }
            }
            else
            {
                return Content("<script>alert('新增失败');window.location.href='/Position/config_major'</script>");
            }
        }
        private void NewMethod()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            foreach (config_major_kind_Model item in k.listconfig_major_kind())
            {
                SelectListItem s = new SelectListItem();
                s.Text = item.major_kind_name.ToString();
                s.Value = item.major_kind_id.ToString();
                list.Add(s);
            }
            ViewBag.dt = list;
        }
        #endregion
    }
}
