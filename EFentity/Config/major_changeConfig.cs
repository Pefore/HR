using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity.Config
{
    public class major_changeConfig: EntityTypeConfiguration<major_change>
    {
        public major_changeConfig()
        {
            this.ToTable(nameof(major_change));
            this.Property(e => e.first_kind_id).HasMaxLength(2).IsRequired();
            this.Property(e => e.first_kind_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.second_kind_id).HasMaxLength(2).IsRequired();
            this.Property(e => e.second_kind_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.third_kind_id).HasMaxLength(2).IsRequired();
            this.Property(e => e.third_kind_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.major_kind_id).HasMaxLength(2).IsRequired();
            this.Property(e => e.major_kind_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.major_id).HasMaxLength(2).IsRequired();
            this.Property(e => e.major_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.new_first_kind_id).HasMaxLength(2).IsRequired();
            this.Property(e => e.new_first_kind_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.new_second_kind_id).HasMaxLength(2).IsRequired();
            this.Property(e => e.new_second_kind_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.new_third_kind_id).HasMaxLength(2).IsRequired();
            this.Property(e => e.new_third_kind_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.new_major_kind_id).HasMaxLength(2).IsRequired();
            this.Property(e => e.new_major_kind_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.new_major_id).HasMaxLength(2).IsRequired();
            this.Property(e => e.new_major_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.human_id).HasMaxLength(30).IsRequired();
            this.Property(e => e.human_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.salary_standard_id).HasMaxLength(30).IsRequired();
            this.Property(e => e.salary_standard_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.salary_sum).IsRequired();
            this.Property(e => e.new_salary_standard_id).HasMaxLength(30).IsRequired();
            this.Property(e => e.new_salary_standard_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.new_salary_sum).IsRequired();
            this.Property(e => e.change_reason).IsRequired();
            this.Property(e => e.check_reason).IsRequired();
            this.Property(e => e.check_status).IsRequired();
            this.Property(e => e.register).HasMaxLength(60).IsRequired();
            this.Property(e => e.checker).HasMaxLength(60).IsRequired();
            this.Property(e => e.regist_time).IsRequired();
            this.Property(e => e.check_time).IsRequired();
        }
    }
}
