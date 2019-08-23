using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity.Config
{
   public class UsersConfig: EntityTypeConfiguration<user>
    {
        public UsersConfig()
        {
            this.ToTable(nameof(user));
            this.Property(e => e.user_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.user_true_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.user_password).HasMaxLength(60).IsRequired();
        }
    }
}
