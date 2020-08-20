using Microsoft.EntityFrameworkCore;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Star>().ToTable("Star");
        }
    }
}
