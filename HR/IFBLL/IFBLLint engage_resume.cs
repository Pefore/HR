using Model;
using Model.CaoZuoLei;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFBLL
{
   public interface IFBLLint_engage_resume
    {
        int engage_resumeAdd(engage_resume_Model e);
        ArrayList engage_resumeLikeFenYe(LikeFenYe l);
        engage_resume_Model SelectId(engage_resume_Model e);
        int engage_resumeUpdate(engage_resume_Model e);
        ArrayList engage_resumeYouXianFenYe(LikeFenYe l);
        engage_interview_resume Selectengage_interview_resume(engage_interview_resume eir);
        int engage_resumeDelete(engage_resume_Model e);
        ArrayList engage_resumeYouXianFenYe6(LikeFenYe l);
    }
}
