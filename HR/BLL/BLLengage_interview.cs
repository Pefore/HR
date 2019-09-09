using IFBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IOC;
using IFDAL;
using System.Collections;
using Model.CaoZuoLei;

namespace BLL
{
    public class BLLengage_interview : IFBLLengage_interview
    {
        IFDALengage_interview ei = UserIOC.DALengage_interview();

        public int engage_interviewAdd(engage_interviewModel e)
        {
            return ei.engage_interviewAdd(e);
        }

        public int engage_interviewModelDelete(engage_interviewModel eii)
        {
            return ei.engage_interviewModelDelete(eii);
        }

        public ArrayList engage_interviewSelectFenY(int Dq, int pageSize)
        {
            return ei.engage_interviewSelectFenY(Dq, pageSize);
        }

        public int engage_interviewUpdate(engage_interviewModel e)
        {
            return ei.engage_interviewUpdate(e);
        }

        public ArrayList engage_resumeYouXianFenYe3(LikeFenYe l)
        {
            return ei.engage_resumeYouXianFenYe3(l);
        }

        public ArrayList engage_resumeYouXianFenYe7(LikeFenYe l)
        {
            return ei.engage_resumeYouXianFenYe7(l);
        }

        public int SelectCount(engage_interviewModel e)
        {
            return ei.SelectCount(e);
        }

        public List<engage_interviewModel> SelectCunZai(engage_interviewModel e)
        {
            return ei.SelectCunZai(e);
        }

        public engage_interview_resume Selectengage_interview_resume(int id)
        {
            return ei.Selectengage_interview_resume(id);
        }

        public engage_interview_resume Selectengage_interview_resume1(int id)
        {
            return ei.Selectengage_interview_resume1(id);
        }
    }
}
