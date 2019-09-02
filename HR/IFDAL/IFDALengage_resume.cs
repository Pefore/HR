using Model;
using Model.CaoZuoLei;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFDAL
{
   public interface IFDALengage_resume
    {
        int engage_resumeAdd(engage_resume_Model e);
        ArrayList engage_resumeLikeFenYe(LikeFenYe l);
        engage_resume_Model SelectId(engage_resume_Model e);
        int engage_resumeUpdate(engage_resume_Model e);
        ArrayList engage_resumeYouXianFenYe(LikeFenYe l);
    }
}
