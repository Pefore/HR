using EFentity.position_register;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity.Config
{
    /// <summary>
    /// 面试
    /// </summary>
  public  class engage_interviewConfig : EntityTypeConfiguration<engage_interview>
    {
       public engage_interviewConfig()
        {
            this.ToTable(nameof(engage_interview));
            this.HasKey(e => e.ein_id);
            this.Property(e => e.interview_amount).IsOptional();
            this.Property(e => e.human_major_kind_id).IsOptional();
            this.Property(e => e.registe_time).IsOptional();
            this.Property(e => e.check_time).IsOptional();
            this.Property(e => e.resume_id).IsOptional();
            this.Property(e => e.interview_status).IsOptional();
            this.Property(e => e.check_status).IsOptional();
        }
    }
}
