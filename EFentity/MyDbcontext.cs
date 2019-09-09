using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection;
using EFentity.Config;

namespace EFentity
{
   public class MyDbcontext:DbContext
    {
        public MyDbcontext():base("name=sql")
        {
           //Database.SetInitializer<MyDbcontext>(null);
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
        public DbSet<major_change> major_change { get; set; }
        public DbSet<right> right { get; set; }
    }
}
