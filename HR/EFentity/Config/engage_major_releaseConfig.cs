using EFentity.position_register;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity.Config
{
   public class engage_major_releaseConfig: EntityTypeConfiguration<engage_major_release>
    {
        public engage_major_releaseConfig()
        {
            this.ToTable(nameof(engage_major_release));
            this.HasKey(e => e.mre_id);
            this.Property(e => e.deadline).IsOptional();
            this.Property(e => e.regist_time).IsOptional();
            this.Property(e => e.change_time).IsOptional();
            this.Property(e => e.human_amount).IsOptional();
        }
    }
}
