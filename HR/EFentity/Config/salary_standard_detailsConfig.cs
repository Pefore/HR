using EFentity.salaryCriterion;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity.Config
{
   public class salary_standard_detailsConfig : EntityTypeConfiguration<salary_standard_details>
    {
        public salary_standard_detailsConfig()
        {
            this.ToTable(nameof(salary_standard_details));
            this.HasKey(e => e.sdt_id);
            this.Property(e => e.item_id).IsOptional();
            this.Property(e => e.salary).IsOptional();
        }
    }
}
