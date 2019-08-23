using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity.Config
{
   public class Position_Name_SetConfig: EntityTypeConfiguration<Position_Name_Set>
    {
        public Position_Name_SetConfig()
        {
            this.ToTable(nameof(Position_Name_Set));
            this.HasKey(e => e.Position_Name_Set_id);
            this.Property(e => e.Position_Name_id).IsRequired().HasMaxLength(2);
            this.Property(e => e.Position_Name).IsRequired().HasMaxLength(60);
        }
    }
}
