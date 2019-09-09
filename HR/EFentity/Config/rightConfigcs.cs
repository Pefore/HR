using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity.Config
{
    public class rightConfigcs: EntityTypeConfiguration<right>
    {
        public rightConfigcs()
        {
            this.ToTable(nameof(right));
            this.Property(e => e.right_id).IsRequired();
            this.Property(e => e.right_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.right_explain).HasMaxLength(60).IsRequired();
            this.Property(e => e.right_usable).HasMaxLength(2).IsRequired();
            this.HasMany(e => e.user).WithMany(e => e.right).Map(m => m.ToTable("RightUser").MapLeftKey("Userid").MapRightKey("Rightid"));
        }
    }
}
