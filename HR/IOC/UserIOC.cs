using DAL;
using IFBLL;
using IFDAL;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace IOC
{
   public class UserIOC
    {
        public static IFDALUser CreateStudenDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<IFDALUser, DALLogin>();
            return ioc.Resolve<IFDALUser>();
        }

        public static IFBLLUser CreateStudentBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<IFBLLUser>("BLLUser");
        }

        private static UnityContainer GetBLLSeciton()
        {
            UnityContainer ioc = new UnityContainer();
            ExeConfigurationFileMap ecf = new ExeConfigurationFileMap();
            ecf.ExeConfigFilename = @"C:\Users\asus\Source\Repos\HR4\HR\UI\Unity.config";
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ecf, ConfigurationUserLevel.None);
            UnityConfigurationSection cfs = cf.GetSection("unity") as UnityConfigurationSection;
            ioc.LoadConfiguration(cfs, "containerTwo");
            return ioc;
        }
    }
}
