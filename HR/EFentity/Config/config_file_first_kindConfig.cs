using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EFentity.Config
{
    public class config_file_first_kindConfig:EntityTypeConfiguration<config_file_first_kind>
    {
        /// <summary>
        /// 一级机构设置   
        /// </summary>
        public config_file_first_kindConfig()
        {
            this.ToTable(nameof(config_file_first_kind));
            this.Property(e => e.first_kind_name).HasMaxLength(60);
        }
    }
}
