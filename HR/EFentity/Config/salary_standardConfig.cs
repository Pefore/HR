using EFentity.salaryCriterion;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity.Config
{
   public class salary_standardConfig: EntityTypeConfiguration<salary_standard>
    {
        public salary_standardConfig()
        {
            this.ToTable(nameof(salary_standard));
            this.HasKey(e => e.ssd_id);
            this.Property(e => e.regist_time).IsOptional();
            this.Property(e => e.check_time).IsOptional();
            this.Property(e => e.change_time).IsOptional();
            this.Property(e => e.salary_sum).IsOptional();
            this.Property(e => e.check_status).IsOptional();
            this.Property(e => e.change_status).IsOptional();
        }
    }
}
