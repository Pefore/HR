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
        public List<salary_standard_detailsModel> Select()
        {
            List<salary_standard_details> list = SelectAll();
            List<salary_standard_detailsModel> list2 = new List<salary_standard_detailsModel>();
            foreach (salary_standard_details st in list)
            {
                salary_standard_detailsModel sm = new salary_standard_detailsModel()
                {
                    sdt_id = st.sdt_id,
                    standard_id = st.standard_id,
                    standard_name = st.standard_name,
                    item_id = st.item_id,
                    item_name = st.item_name,
                    salary = st.salary
                };
                list2.Add(sm);
            }
            return list2;
        }
        public List<salary_standard_detailsModel> cx(string id)
        {
            List<salary_standard_details> list = SelectBy(e => e.standard_id.Equals(id));
            List<salary_standard_detailsModel> list2 = new List<salary_standard_detailsModel>();
            foreach (salary_standard_details st in list)
            {
                salary_standard_detailsModel sm = new salary_standard_detailsModel()
                {
                    sdt_id = st.sdt_id,
                    standard_id = st.standard_id,
                    standard_name = st.standard_name,
                    item_id = st.item_id,
                    item_name = st.item_name,
                    salary = st.salary
                };
                list2.Add(sm);
            }
            return list2;
        }
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
        public List<salary_standard_detailsModel> selectupdate(string id)
        {
            List<salary_standard_details> list = SelectBy(e => e.standard_id.Equals(id));


            List<salary_standard_detailsModel> li = new List<salary_standard_detailsModel>();
            foreach (salary_standard_details item in list)
            {
                salary_standard_detailsModel ko = new salary_standard_detailsModel();
                ko.sdt_id = item.sdt_id;
                ko.standard_id = item.standard_id;
                ko.standard_name = item.standard_name;
                ko.item_id = item.item_id;
                ko.item_name = item.item_name;
                ko.salary = item.salary; li.Add(ko);
            }
            return li;
        }
    }
}
