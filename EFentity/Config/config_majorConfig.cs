using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity.Config
{
  public  class config_majorConfig:EntityTypeConfiguration<config_major>
    {
        public config_majorConfig()
        {
            this.ToTable(nameof(config_major));
            this.HasKey(e => e.mak_id);
            this.Property(e => e.major_kind_id).IsRequired().HasMaxLength(2);
            this.Property(e => e.major_kind_name).IsRequired().HasMaxLength(60);
            this.Property(e => e.Position_Name_id).IsRequired().HasMaxLength(2);
            this.Property(e => e.Position_Name).IsRequired().HasMaxLength(60);
        }
    }
}
