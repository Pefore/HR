using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFBLL
{
   public interface IFBLLUser
    {
        int Login(users s);
        int ADDUser();
        users Select(users s);
        List<users> se();
        List<users> SelectBy(users st);
        int Add(users st);
        int Del(users st);
        List<users> Select();
        int Update(users st);
        List<users> cxqb();
    }
}
