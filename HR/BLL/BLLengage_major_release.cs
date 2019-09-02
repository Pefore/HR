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

namespace BLL
{
    public class BLLengage_major_release : IFBLLengage_major_release
    {
        IFDALengage_major_release EM = UserIOC.engage_major_releaseDAO();
        public int engage_major_releaseAdd(engage_major_release_Model e)
        {
            return EM.engage_major_releaseAdd(e);
        }

        public int engage_major_releaseDelete(engage_major_release_Model e)
        {
            return EM.engage_major_releaseDelete(e);
        }

        public engage_major_release_Model engage_major_releaseSelect(engage_major_release_Model e1)
        {
            return EM.engage_major_releaseSelect(e1);
        }

        public ArrayList engage_major_releaseSelectFenY(int Dq, int pageSize)
        {
            return EM.engage_major_releaseSelectFenY(Dq, pageSize);
        }

        public int engage_major_releaseUpdate(engage_major_release_Model r)
        {
            return EM.engage_major_releaseUpdate(r);
        }

        public int engage_resumeAddSelect(engage_major_release_Model r)
        {
            return EM.engage_resumeAddSelect(r);
        }
    }
}
