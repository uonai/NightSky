using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NightSkyPopulateDatabase;
using System;
using System.Collections.Generic;
using System.Configuration;
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
        public IConfiguration Configuration { get; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            //var connection = Startup.Configuration.GetConnectionString("DefaultConnection") ?? "testingconnection";
            //services.AddDbContext<MyDbContext>(options => options.UseSqlServer(connection));
            var connection = Configuration.GetConnectionString("DefaultConnection") ?? "testingconnection";
            builder.UseSqlServer("Server=DESKTOP-32N87F3\\MSSQLSERVER01;Database=master;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(builder);
        }
    }
}
