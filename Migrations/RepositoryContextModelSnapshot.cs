﻿// <auto-generated />
using CarManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarManagementSystem.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("CarManagementSystem.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BodyType")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("Doors")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Engine")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("VehicleTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Wheels")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("VehicleTypeId");

                    b.ToTable("Car");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BodyType = "sedan",
                            Doors = 4,
                            Engine = "2.0T Petrol 8 sp Automatic RWD",
                            Make = "alfa romeo",
                            Model = "veloce",
                            VehicleTypeId = 1,
                            Wheels = 4
                        },
                        new
                        {
                            Id = 2,
                            BodyType = "suv",
                            Doors = 5,
                            Engine = "2.0DT Diesel 8 sp Automatic 4x4",
                            Make = "hyundai",
                            Model = "active",
                            VehicleTypeId = 1,
                            Wheels = 4
                        },
                        new
                        {
                            Id = 3,
                            BodyType = "hatch",
                            Doors = 5,
                            Engine = "1.0T Petrol 5 sp Manual FWD",
                            Make = "volkswagen",
                            Model = "70tsi trendline",
                            VehicleTypeId = 1,
                            Wheels = 4
                        });
                });

            modelBuilder.Entity("CarManagementSystem.Models.VehicleType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("VehicleType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "car"
                        });
                });

            modelBuilder.Entity("CarManagementSystem.Models.Car", b =>
                {
                    b.HasOne("CarManagementSystem.Models.VehicleType", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
