using IFBLL;
using IFDAL;
using IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BLL
{
    public class BLLsalary_grant : IFBLLsalary_grant
    {
        IFDALsalary_grant ist = UserIOC.Createsalary_grantDAO();

        public int Add(salary_grantModel st)
        {
            return ist.Add(st);
        }

        public int Del(salary_grantModel st)
        {
            return ist.Del(st);
        }

        public Dictionary<string, object> FenYe(int zt, int currentPage)
        {
            return ist.FenYe(zt, currentPage);
        }

        public List<salary_grantModel> Select()
        {
            return ist.Select();
        }

        public List<salary_grantModel> selectupdateda(string id)
        {
            return ist.selectupdateda(id);
        }

        public List<salary_grantModel> TJCX(string s)
        {
            return ist.TJCX(s);
        }

        public int Update(salary_grantModel st)
        {
            return ist.Update(st);
        }

        public salary_grantModel XGCX(int id)
        {
            return ist.XGCX(id);
        }

    }
}
