using IFBLL;
using IOC;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers.Recruitment_M.Job_release_m
{
    public class position_release_searchController : Controller
    {
        IFBLLClient mk = UserIOC.CreateClientBLL();
        IFBLLengage_major_release mr = UserIOC.engage_major_releaseBLL();
        // GET: position_release_search
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(int id)
        {
            ArrayList list = mr.engage_major_releaseSelectFenY(id, 1);
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult Update(int id)
        {
            int mre_id = id;
            engage_major_release_Model em = new engage_major_release_Model()
            {
                mre_id = mre_id
            };
            engage_major_release_Model e = mr.engage_major_releaseSelect(em);
            return View(e);
        }
    }
}