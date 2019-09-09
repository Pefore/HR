using IFBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IFDAL;
using IOC;
using System.Collections;
using Model.CaoZuoLei;

namespace BLL
{
    public class BLLint_engage_resume : IFBLLint_engage_resume
    {
        IFDALengage_resume s = UserIOC.engage_resumeDAO();
        public int engage_resumeAdd(engage_resume_Model e)
        {
            return s.engage_resumeAdd(e);
        }

        public int engage_resumeDelete(engage_resume_Model e)
        {
            return s.engage_resumeDelete(e);
        }

        public ArrayList engage_resumeLikeFenYe(LikeFenYe l)
        {
            return s.engage_resumeLikeFenYe(l);
        }

        public int engage_resumeUpdate(engage_resume_Model e)
        {
            return s.engage_resumeUpdate(e);
        }

        public ArrayList engage_resumeYouXianFenYe(LikeFenYe l)
        {
            return s.engage_resumeYouXianFenYe(l);
        }

        public ArrayList engage_resumeYouXianFenYe6(LikeFenYe l)
        {
            return s.engage_resumeYouXianFenYe6(l);
        }

        public engage_interview_resume Selectengage_interview_resume(engage_interview_resume eir)
        {
            return s.Selectengage_interview_resume(eir);
        }

        public engage_resume_Model SelectId(engage_resume_Model e)
        {
            return s.SelectId(e);
        }
    }
}
