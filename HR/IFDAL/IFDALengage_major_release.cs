using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFDAL
{
  public  interface IFDALengage_major_release
    {
        int engage_major_releaseAdd(engage_major_release_Model e);
        ArrayList engage_major_releaseSelectFenY(int Dq, int pageSize);
        int engage_major_releaseDelete(engage_major_release_Model e);
        engage_major_release_Model engage_major_releaseSelect(engage_major_release_Model e1);
        int engage_major_releaseUpdate(engage_major_release_Model r);
        int engage_resumeAddSelect(engage_major_release_Model r);
    }
}
