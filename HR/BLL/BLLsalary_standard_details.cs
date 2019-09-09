using IFBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.salaryCriterionModel;
using IFDAL;
using IOC;

namespace BLL
{
    public class BLLsalary_standard_details : IFBLLsalary_standard_details
    {
        IFDALsalary_standard_details DSD = UserIOC.DALsalary_standard_details();
        public int Addsalary_standard_details(salary_standard_detailsModel ASD)
        {
            return DSD.Addsalary_standard_details(ASD);
        }

        public List<salary_standard_detailsModel> Selectsalary_standard_details(string id)
        {
            return DSD.Selectsalary_standard_details(id);
        }

        public int Updatesalary_standard_details(salary_standard_detailsModel ASD)
        {
            return DSD.Updatesalary_standard_details(ASD);
        }
    }
}
