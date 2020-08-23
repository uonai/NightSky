﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NightSky;

namespace NightSkyPopulateDatabase.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20200823003204_SampleDB")]
    partial class SampleDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NightSky.Star", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("absmag");

                    b.Property<string>("bayer");

                    b.Property<string>("bf");

                    b.Property<int>("ci");

                    b.Property<int>("comp");

                    b.Property<int>("comp_primary");

                    b.Property<string>("con");

                    b.Property<int>("dec");

                    b.Property<int>("decrad");

                    b.Property<int>("dist");

                    b.Property<string>("flam");

                    b.Property<string>("gl");

                    b.Property<int>("hd");

                    b.Property<int>("hip");

                    b.Property<string>("hr");

                    b.Property<int>("lum");

                    b.Property<int>("mag");

                    b.Property<int>("pmdec");

                    b.Property<int>("pmdecrad");

                    b.Property<int>("pmra");

                    b.Property<int>("pmrarad");

                    b.Property<string>("proper");

                    b.Property<int>("ra");

                    b.Property<int>("rarad");

                    b.Property<int>("rv");

                    b.Property<int>("spect");

                    b.Property<int>("var_max");

                    b.Property<int>("var_min");

                    b.Property<int>("vx");

                    b.Property<int>("vy");

                    b.Property<int>("vz");

                    b.Property<int>("x");

                    b.Property<int>("y");

                    b.Property<int>("z");

                    b.HasKey("id");

                    b.ToTable("Universe");
                });

            modelBuilder.Entity("NightSkyPopulateDatabase.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("emailAddress");

                    b.Property<string>("password");

                    b.Property<int>("role");

                    b.HasKey("id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
