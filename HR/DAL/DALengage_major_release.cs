using EFentity.position_register;
using IFDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Collections;

namespace DAL
{
    public class DALengage_major_release : DaoBase<engage_major_release>, IFDALengage_major_release
    {
        public int engage_major_releaseAdd(engage_major_release_Model e)
        {
            engage_major_release E1 = new engage_major_release()
            {
                first_kind_id = e.first_kind_id,
                first_kind_name = e.first_kind_name,
                second_kind_id = e.second_kind_id,
                second_kind_name = e.second_kind_name,
                third_kind_id = e.third_kind_id,
                third_kind_name = e.third_kind_name,
                engage_type = e.engage_type,
                major_kind_id = e.major_kind_id,
                major_kind_name = e.major_kind_name,
                major_name = e.major_name,
                human_amount = e.human_amount,
                deadline = e.deadline,
                register = e.register,
                regist_time = e.regist_time,
                major_describe = e.major_describe,
                engage_required = e.engage_required,
                major_id=e.major_id,
                changer=e.changer,
                change_time=e.change_time
            };
            return Add(E1);
        }

        public int engage_major_releaseDelete(engage_major_release_Model e)
        {
            return Delete(new engage_major_release() { mre_id = e.mre_id });
        }

        public engage_major_release_Model engage_major_releaseSelect(engage_major_release_Model e1)
        {
            List<engage_major_release> list = SelectBy(e => e.mre_id.Equals(e1.mre_id));
            engage_major_release r = list[0];
            engage_major_release_Model m = new engage_major_release_Model()
            {
                first_kind_id = r.first_kind_id,
                first_kind_name = r.first_kind_name,
                second_kind_id = r.second_kind_id,
                second_kind_name = r.second_kind_name,
                third_kind_id = r.third_kind_id,
                third_kind_name = r.third_kind_name,
                engage_type = r.engage_type,
                major_kind_id = r.major_kind_id,
                major_kind_name = r.major_kind_name,
                major_name = r.major_name,
                human_amount = r.human_amount,
                deadline = r.deadline,
                register = r.register,
                regist_time = r.regist_time,
                major_describe = r.major_describe,
                engage_required = r.engage_required,
                major_id = r.major_id,
                mre_id=r.mre_id,
                changer = r.changer,
                change_time = r.change_time
            };
            return m;
        }

        public ArrayList engage_major_releaseSelectFenY(int Dq, int pageSize)
        {
            int row = 0;
            List<engage_major_release_Model> list1 = new List<engage_major_release_Model>();
            List<engage_major_release> list = new List<engage_major_release>();
            list = FenYe<int>(e => e.mre_id, e => e.mre_id>0, ref row, Dq, pageSize);
            foreach (var item in list)
            {
                engage_major_release_Model e = new engage_major_release_Model()
                {
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    engage_type = item.engage_type,
                    major_kind_id = item.major_kind_id,
                    major_kind_name = item.major_kind_name,
                    major_name = item.major_name,
                    human_amount = item.human_amount,
                    deadline = item.deadline,
                    register = item.register,
                    regist_time = item.regist_time,
                    major_describe = item.major_describe,
                    engage_required = item.engage_required,
                    major_id = item.major_id,
                    mre_id = item.mre_id
                };
                list1.Add(e);
            }
            ArrayList A = new ArrayList();
            A.Add(list1);
            A.Add(row);
            A.Add(Dq);
            A.Add(pageSize);
            A.Add((row - 1) / pageSize + 1);
            return A;
        }

        public int engage_major_releaseUpdate(engage_major_release_Model r)
        {
            engage_major_release m = new engage_major_release()
            {
                first_kind_id = r.first_kind_id,
                first_kind_name = r.first_kind_name,
                second_kind_id = r.second_kind_id,
                second_kind_name = r.second_kind_name,
                third_kind_id = r.third_kind_id,
                third_kind_name = r.third_kind_name,
                engage_type = r.engage_type,
                major_kind_id = r.major_kind_id,
                major_kind_name = r.major_kind_name,
                major_name = r.major_name,
                human_amount = r.human_amount,
                deadline = r.deadline,
                register = r.register,
                regist_time = r.regist_time,
                major_describe = r.major_describe,
                engage_required = r.engage_required,
                major_id = r.major_id,
                mre_id = r.mre_id,
                changer = r.changer,
                change_time = r.change_time
            };
            return Update(m);
        }

        public int engage_resumeAddSelect(engage_major_release_Model r)
        {
            string sql = string.Format("select count(*) from engage_major_release where [major_kind_id]={0} and [major_id]={1} and [engage_type]='{2}'", r.major_kind_id, r.major_id, r.engage_type);
            return int.Parse(SqlDBHelper.DGZ(sql).ToString());
        }
    }
}
