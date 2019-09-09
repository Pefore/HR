using Model.salaryCriterionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFDAL
{
   public interface IFDALsalary_standard_details
    {
        int Addsalary_standard_details(salary_standard_detailsModel ASD);
        List<salary_standard_detailsModel> Selectsalary_standard_details(string id);
        int Updatesalary_standard_details(salary_standard_detailsModel ASD);
    }
}
