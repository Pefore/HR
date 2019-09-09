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
   public interface IFBLLengage_interview
    {
        int SelectCount(engage_interviewModel e);
        List<engage_interviewModel> SelectCunZai(engage_interviewModel e);
        int engage_interviewAdd(engage_interviewModel e);
        int engage_interviewUpdate(engage_interviewModel e);
        ArrayList engage_interviewSelectFenY(int Dq, int pageSize);
        engage_interview_resume Selectengage_interview_resume(int id);
        int engage_interviewModelDelete(engage_interviewModel eii);
        ArrayList engage_resumeYouXianFenYe3(LikeFenYe l);
        engage_interview_resume Selectengage_interview_resume1(int id);
        ArrayList engage_resumeYouXianFenYe7(LikeFenYe l);
    }
}
