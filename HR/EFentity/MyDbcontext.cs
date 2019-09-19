using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection;
using EFentity.Config;
using EFentity.position_register;
using EFentity.salaryCriterion;

namespace EFentity
{
   public class MyDbcontext:DbContext
    {
        public MyDbcontext():base("name=sql")
        {
          Database.SetInitializer<MyDbcontext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<user> user { set; get; }
        public DbSet<config_file_first_kind> config_file_first_kind { set; get; }
        public DbSet<config_file_second_kind> config_file_second_kind { set; get; }
        public DbSet<config_file_third_kind> config_file_third_kind { set; get; }
        public DbSet<config_public_char> config_public_char { get; set; }
        public DbSet<config_major_kind> config_major_kind { set; get; }
        public DbSet<config_major> config_major { set; get; }
        public DbSet<Position_Name_Set> Position_Name_Set { set; get; }
        public DbSet<engage_major_release> engage_major_release { set; get; }
        public DbSet<engage_resume> engage_resume { set; get; }
        public DbSet<engage_interview> engage_interview { set; get; }
        public DbSet<salary_standard> salary_standard { set; get; }
        public DbSet<salary_standard_details> salary_standard_details { set; get; }
        public DbSet<human_file_dig> human_file_dig { set; get; }
        public DbSet<right> right { get; set; }
        public DbSet<major_change> major_change { get; set; }
        public DbSet<salary_grant> salary_grant { get; set; }
        public DbSet<salary_grant_details> salary_grant_details { get; set; }
    }
}
