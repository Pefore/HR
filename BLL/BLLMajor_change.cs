using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFBLL;
using Model;
using IFDAL;
using IOC;
using System.Data;

namespace BLL
{
    public class BLLMajor_change : IFBLLMajor_change
    {
        IFDALMajor_change ifm = UserIOC.CreateMajor_changeDAO();
        public int ADDMajor_change(Major_changeModel mm)
        {
            return ifm.ADDMajor_change(mm);
        }

        public int DELETEMajor_change(Major_changeModel mm)
        {
            return ifm.DELETEMajor_change(mm);
        }

        public List<Major_changeModel> SELECTcx(string where)
        {
            return ifm.SELECTcx(where);
        }
        public List<Major_changeModel> SELECTMajor_change()
        {
            return ifm.SELECTMajor_change();
        }
        public List<Major_changeModel> SELECTFirst(string where)
        {
            return ifm.SELECTFirst(where);
        }
        public List<Major_changeModel> SELECTSecond()
        {
            return ifm.SELECTSecond();
        }

        public List<Major_changeModel> SELECTThird(string where)
        {
            return ifm.SELECTThird(where);
        }

        public int UPDATEMajor_change(Major_changeModel mm)
        {
            throw new NotImplementedException();
        }

        public List<Major_changeModel> selectcx(string where)
        {
            return ifm.selectcx(where);
        }
    }
}
