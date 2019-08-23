using IFBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IFDAL;
using IOC;

namespace BLL
{
    public class BLLClient : IFBLLClient
    {
        IFDALClient ifc = UserIOC.CreateClientDAO();
        public int ADDClient(config_public_charModel cm)
        {
            return ifc.ADDClient(cm);
        }
        public int ADDPublic_char(config_public_charModel cm)
        {
            return ifc.ADDPublic_char(cm);
        }
        public int DELETEClient(config_public_charModel cm)
        {
            return ifc.DELETEClient(cm);
        }

        public List<config_public_charModel> SELECTClient()
        {
            return ifc.SELECTClient();
        }

        public int UPDATEClient(config_public_charModel cm)
        {
            return ifc.UPDATEClient(cm);
        }
    }
}
