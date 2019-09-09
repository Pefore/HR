using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EFentity.Config
{
    public class human_file_digConfig:EntityTypeConfiguration<human_file_dig>
    {
        public human_file_digConfig()
        {
            this.ToTable(nameof(human_file_dig));
            this.Property(e => e.human_id).HasMaxLength(30);
            this.Property(e => e.first_kind_name).HasMaxLength(60);
            this.Property(e => e.second_kind_name).HasMaxLength(60);
            this.Property(e => e.third_kind_name).HasMaxLength(60);
            this.Property(e => e.human_name).HasMaxLength(60);
            this.Property(e => e.human_address).HasMaxLength(200);
            this.Property(e => e.human_postcode).HasMaxLength(10);
            this.Property(e => e.human_pro_designation).HasMaxLength(60);
        }
    }
}
