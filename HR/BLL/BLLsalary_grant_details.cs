using IFBLL;
using IFDAL;
using IOC;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLsalary_grant_details : IFBLLsalary_grant_details
    {
        IFDALsalary_grant_details ist = UserIOC.Createsalary_grant_detailsDAO();

        public int Add(salary_grant_detailsModel st)
        {
            return ist.Add(st);
        }

        public int Del(salary_grant_detailsModel st)
        {
            return ist.Del(st);
        }

        public List<salary_grant_detailsModel> Select()
        {
            return ist.Select();
        }

        public List<salary_grant_detailsModel> selectsalary_grant_id(string id)
        {
            return ist.selectsalary_grant_id(id);
        }

        public List<salary_grant_detailsModel> TJCX(string id)
        {
            return ist.TJCX(id);
        }

        public int Update(salary_grant_detailsModel st)
        {

            return ist.Update(st);
        }

        public salary_grant_detailsModel XGCX(int id)
        {
            return ist.XGCX(id);
        }
    }
}
