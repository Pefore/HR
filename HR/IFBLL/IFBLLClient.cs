using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFBLL
{
    public interface IFBLLClient
    {
        int ADDClient(config_public_charModel cm);

        int ADDPublic_char(config_public_charModel cm);
        int UPDATEClient(config_public_charModel cm);
        int DELETEClient(config_public_charModel cm);
        List<config_public_charModel> SELECTClient();
        List<config_public_charModel> cx(string id);
    }
}
