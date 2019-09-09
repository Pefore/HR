using IFBLL;
using IOC;
using Model.CaoZuoLei;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace API.Controllers
{
    public class ValuesController : ApiController
    {
        IFBLLint_engage_resume er = UserIOC.engage_resumeBLL();
        // GET api/values
        public string  Getengage_resume(int id)
        {
            LikeFenYe l = new LikeFenYe()
            {
                Dq =id,
                PageSize = 1
            };
            return JsonConvert.SerializeObject(er.engage_resumeYouXianFenYe3(l));
        }
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
