using Microsoft.EntityFrameworkCore;
using NightSkyPopulateDatabase;
using System;
using System.Collections.Generic;
using System.Text;

namespace NightSky
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(): base()
        {
        }

        public MyDbContext(DbContextOptions options): base(options)
        {
        }

        public virtual DbSet<Star> Universe { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Star>().ToTable("Universe");
            modelBuilder.Entity<User>().ToTable("Users");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=DESKTOP-32N87F3\\MSSQLSERVER01;Database=master;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(builder);
        }
    }
}
