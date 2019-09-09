using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFDAL
{
   public interface IFDALUser
    {
        int Login(users s);
        int ADDUser();
        List<users> SelectBy(users st);
        int Add(users st);
        int Del(users st);
        List<users> Select();
        int Update(users st);
        List<users> cxqb();
    }
}
