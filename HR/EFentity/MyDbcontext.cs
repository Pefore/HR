﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection;

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
    }
}
