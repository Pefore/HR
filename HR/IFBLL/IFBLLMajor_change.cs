using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFBLL
{
    public interface IFBLLMajor_change
    {
        int ADDMajor_change(Major_changeModel mm);
        int UPDATEMajor_change(Major_changeModel mm);
        int DELETEMajor_change(Major_changeModel mm);
        List<Major_changeModel> SELECTMajor_change();
        List<Major_changeModel> SELECTcx(string where);
        List<Major_changeModel> SELECTFirst(string where);
        List<Major_changeModel> SELECTSecond();
        List<Major_changeModel> SELECTThird(string where);
        List<Major_changeModel> selectcx(string where);
    }
}
