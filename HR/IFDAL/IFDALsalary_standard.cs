using Model.CaoZuoLei;
using Model.salaryCriterionModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFDAL
{
   public interface IFDALsalary_standard
    {
        int AddLsalary_standard(salary_standardModel s);
        ArrayList Listsalary_standard(LikeFenYe l);
        salary_standardModel SelectID(string id);
        int Update(salary_standardModel s);
        ArrayList LikeSelect(LikeFenYe l);
        ArrayList LikeSelect0(LikeFenYe l);
    }
}
