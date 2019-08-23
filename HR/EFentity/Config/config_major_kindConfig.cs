using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity.Config
{
   public class config_major_kindConfig :EntityTypeConfiguration<config_major_kind>
    {
        public config_major_kindConfig()
        {
            this.ToTable(nameof(config_major_kind));
            this.HasKey(e => e.mfk_id);
            this.Property(e => e.major_kind_id).IsRequired().HasMaxLength(2);
            this.Property(e => e.major_kind_name).IsRequired().HasMaxLength(60);
        }
    }
}
