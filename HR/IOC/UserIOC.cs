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
        #region 用户ioc
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
        public static IFDALClient CreateClientDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<IFDALClient, DALClient>();
            return ioc.Resolve<IFDALClient>();
        }
        #endregion
        #region 职称名称ioc
        public static IFDALPosition_Name_Set Position_Name_SetDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<IFDALPosition_Name_Set, DALPosition_Name_Set>();
            return ioc.Resolve<IFDALPosition_Name_Set>();
        }

        public static IFBLLPosition_Name_Set Position_Name_SetBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<IFBLLPosition_Name_Set>("BLLPosition_Name_Set");
        }
        #endregion
        #region 职称分类ioc
        public static IFDALconfig_major_kind config_major_kindDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<IFDALconfig_major_kind, DALconfig_major_kind>();
            return ioc.Resolve<IFDALconfig_major_kind>();
        }

        public static IFBLLconfig_major_kind config_major_kindBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<IFBLLconfig_major_kind>("BLLconfig_major_kind");
        }
        #endregion
        #region 职称设置ioc
        public static IFDALconfig_major config_majorDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<IFDALconfig_major, DALconfig_major>();
            return ioc.Resolve<IFDALconfig_major>();
        }

        public static IFBLLconfig_major config_majorBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<IFBLLconfig_major>("BLLconfig_major");
        }
        #endregion
        private static UnityContainer GetBLLSeciton()
        {
            UnityContainer ioc = new UnityContainer();
            ExeConfigurationFileMap ecf = new ExeConfigurationFileMap();
            ecf.ExeConfigFilename = @"E:\y2\HR\HR\UI\Unity.config";
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ecf, ConfigurationUserLevel.None);
            UnityConfigurationSection cfs = cf.GetSection("unity") as UnityConfigurationSection;
            ioc.LoadConfiguration(cfs, "containerTwo");
            return ioc;
        }
    }
}
