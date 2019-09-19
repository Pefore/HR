using IFBLL;
using IFDAL;
using IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.salaryCriterionModel;
using Model.CaoZuoLei;
using System.Collections;

namespace BLL
{
   public class BLLsalary_standard: IFBLLsalary_standard
    {
        IFDALsalary_standard DS = UserIOC.DALsalary_standard();

        public int AddLsalary_standard(salary_standardModel s)
        {
            return DS.AddLsalary_standard(s);
        }

        public ArrayList LikeSelect(LikeFenYe l)
        {
            return DS.LikeSelect(l);
        }

        public ArrayList LikeSelect0(LikeFenYe l)
        {
            return DS.LikeSelect0(l);
        }

        public ArrayList Listsalary_standard(LikeFenYe l)
        {
            return DS.Listsalary_standard(l);
        }

        public List<salary_standardModel> Select()
        {
            return DS.Select();
        }

        public salary_standardModel SelectID(string id)
        {
            return DS.SelectID(id);
        }

        public int Update(salary_standardModel s)
        {
            return DS.Update(s);
        }
    }
}
