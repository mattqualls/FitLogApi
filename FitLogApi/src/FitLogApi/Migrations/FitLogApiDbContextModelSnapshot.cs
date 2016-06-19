using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FitLogApi.Models;

namespace FitLogApi.Migrations
{
    [DbContext(typeof(FitLogApiDbContext))]
    partial class FitLogApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20901")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FitLogApi.Models.AppUser", b =>
                {
                    b.Property<int>("AppUserId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Email");

                    b.Property<int>("HeightInInches");

                    b.Property<int>("InitialWeight");

                    b.Property<string>("Username");

                    b.Property<string>("password");

                    b.HasKey("AppUserId");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("FitLogApi.Models.Session", b =>
                {
                    b.Property<int>("SessionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AppUserId");

                    b.Property<int>("ApplUserId");

                    b.Property<int>("CaloriesBurned");

                    b.Property<int>("MilesTraveled");

                    b.Property<int>("MinutesWorked");

                    b.Property<DateTime>("SessionDate");

                    b.Property<int>("SessionWeight");

                    b.HasKey("SessionId");

                    b.HasIndex("AppUserId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("FitLogApi.Models.SessionType", b =>
                {
                    b.Property<int>("SessionTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Bike");

                    b.Property<bool>("Elliptical");

                    b.Property<int>("SessionId");

                    b.Property<bool>("Treadmill");

                    b.HasKey("SessionTypeId");

                    b.HasIndex("SessionId");

                    b.ToTable("SessionTypes");
                });

            modelBuilder.Entity("FitLogApi.Models.Session", b =>
                {
                    b.HasOne("FitLogApi.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");
                });

            modelBuilder.Entity("FitLogApi.Models.SessionType", b =>
                {
                    b.HasOne("FitLogApi.Models.Session")
                        .WithMany()
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
