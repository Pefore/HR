using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFDAL
{
    public interface IFDALsalary_grant_details
    {
        int Add(salary_grant_detailsModel st);
        int Del(salary_grant_detailsModel st);
        int Update(salary_grant_detailsModel st);
        List<salary_grant_detailsModel> Select();
        salary_grant_detailsModel XGCX(int id);
        List<salary_grant_detailsModel> TJCX(string id);
        List<salary_grant_detailsModel> selectsalary_grant_id(string id);
    }
}
