using EFentity.position_register;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity.Config
{
  public  class engage_resume_Config : EntityTypeConfiguration<engage_resume>
    {
        public engage_resume_Config()
        {
            this.ToTable(nameof(engage_resume));
            this.HasKey(e => e.res_id);
            this.Property(e => e.human_birthday).IsOptional();
            this.Property(e => e.human_age).IsOptional();
            this.Property(e => e.human_age).IsOptional();
            this.Property(e => e.human_educated_years).IsOptional();
            this.Property(e => e.demand_salary_standard).IsOptional();
            this.Property(e => e.attachment_name).IsOptional();
            this.Property(e => e.check_status).IsOptional();
            this.Property(e => e.regist_time).IsOptional();
            this.Property(e => e.check_time).IsOptional();
            this.Property(e => e.interview_status).IsOptional();
            this.Property(e => e.total_points).IsOptional();
            this.Property(e => e.test_amount).IsOptional();
            this.Property(e => e.test_check_time).IsOptional();
            this.Property(e => e.pass_regist_time).IsOptional();
            this.Property(e => e.pass_check_time).IsOptional();
            this.Property(e => e.pass_check_status).IsOptional();
        }
    }
}
