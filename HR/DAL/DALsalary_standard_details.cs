using DAL;
using EFentity.salaryCriterion;
using IFDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.salaryCriterionModel;

namespace DAL
{
    public class DALsalary_standard_details : DaoBase<salary_standard_details>, IFDALsalary_standard_details
    {
        public int Addsalary_standard_details(salary_standard_detailsModel ASD)
        {
            salary_standard_details ssd = new salary_standard_details()
            {
                standard_id=ASD.standard_id,
                standard_name = ASD.standard_name,
                item_id = ASD.item_id,
                item_name = ASD.item_name,
                salary = ASD.salary,
            };
            return Add(ssd);
        }

        public List<salary_standard_detailsModel> Selectsalary_standard_details(string id)
        {
            List<salary_standard_detailsModel> list = new List<salary_standard_detailsModel>();
            List<salary_standard_details> list1 = SelectBy(e => e.standard_id.Equals(id));
            foreach (var ASD in list1)
            {
                salary_standard_detailsModel ssd = new salary_standard_detailsModel()
                {
                    standard_id = ASD.standard_id,
                    standard_name = ASD.standard_name,
                    item_id = ASD.item_id,
                    item_name = ASD.item_name,
                    salary = ASD.salary,
                    sdt_id=ASD.sdt_id,
                };
                list.Add(ssd);
            }
            return list;
        }

        public int Updatesalary_standard_details(salary_standard_detailsModel ASD)
        {
            salary_standard_details ssd = new salary_standard_details()
            {
                standard_id = ASD.standard_id,
                standard_name = ASD.standard_name,
                item_id = ASD.item_id,
                item_name = ASD.item_name,
                salary = ASD.salary,
                sdt_id=ASD.sdt_id,
            };
            return Update(ssd);
        }
    }
}
