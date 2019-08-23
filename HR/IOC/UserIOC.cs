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
        private static UnityContainer GetBLLSeciton()
        {
            UnityContainer ioc = new UnityContainer();
            ExeConfigurationFileMap ecf = new ExeConfigurationFileMap();
            ecf.ExeConfigFilename = @"D:\ASP.NET\项目\HR项目\HR动态\HR\UI\Unity.config";
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ecf, ConfigurationUserLevel.None);
            UnityConfigurationSection cfs = cf.GetSection("unity") as UnityConfigurationSection;
            ioc.LoadConfiguration(cfs, "containerTwo");
            return ioc;
        }
        /// <summary>
        /// User
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// config_file_first_kind
        /// </summary>
        /// <returns></returns>
        public static IFDALconfig_file_first_kind CreateConfig_file_first_kindDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<IFDALconfig_file_first_kind, DALConfig_file_first_kind>();
            return ioc.Resolve<IFDALconfig_file_first_kind>();
        }

        public static IFBLLConfig_file_first_kind CreateConfig_file_first_kindBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<IFBLLConfig_file_first_kind>("BLLconfig_file_first_kind");
        }
        /// <summary>
        /// config_file_second_kind
        /// </summary>
        /// <returns></returns>
        public static IFDALconfig_file_second_kind CreateConfig_file_second_kindDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<IFDALconfig_file_second_kind, DALConfig_file_second_kind>();
            return ioc.Resolve<IFDALconfig_file_second_kind>();
        }

        public static IFBLLConfig_file_second_kind CreateConfig_file_second_kindBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<IFBLLConfig_file_second_kind>("BLLconfig_file_second_kind");
        }
        /// <summary>
        /// config_file_third_kind
        /// </summary>
        /// <returns></returns>
        public static IFDALconfig_file_third_kind CreateConfig_file_third_kindDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<IFDALconfig_file_third_kind, DALConfig_file_third_kind>();
            return ioc.Resolve<IFDALconfig_file_third_kind>();
        }

        public static IFBLLConfig_file_third_kind CreateConfig_file_third_kindBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<IFBLLConfig_file_third_kind>("BLLconfig_file_third_kind");
        }
    }
}
