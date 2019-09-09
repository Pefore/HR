using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EFentity.Config
{
    public class config_file_third_kindConfig:EntityTypeConfiguration<config_file_third_kind>
    {
        /// <summary>
        /// 三级机构设置       
        /// </summary>
        public config_file_third_kindConfig()
        {
            this.ToTable(nameof(config_file_third_kind));
            this.Property(e => e.second_kind_name).HasMaxLength(60);
            this.Property(e => e.second_kind_name).HasMaxLength(60);
            this.Property(e => e.third_kind_name).HasMaxLength(60);
        }
    }
}
