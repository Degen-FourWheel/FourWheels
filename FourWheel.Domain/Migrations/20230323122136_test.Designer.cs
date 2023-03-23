﻿// <auto-generated />
using System;
using FourWheel.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FourWheel.Domain.Migrations
{
    [DbContext(typeof(FourWheelsDBContext))]
    [Migration("20230323122136_test")]
    partial class test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FourWheel.Domain.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarId"));

                    b.Property<string>("CarManufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<double>("KMStanding")
                        .HasColumnType("float");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("FourWheel.Domain.Models.Case", b =>
                {
                    b.Property<int>("CaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CaseId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CaseId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            CaseId = 1,
                            CustomerId = 2,
                            Description = "Service 2",
                            EndTime = new DateTime(2023, 3, 25, 13, 21, 36, 66, DateTimeKind.Local).AddTicks(4066),
                            StartTime = new DateTime(2023, 3, 23, 13, 21, 36, 66, DateTimeKind.Local).AddTicks(3991),
                            Status = "Lukket",
                            Type = "Type B"
                        },
                        new
                        {
                            CaseId = 2,
                            CustomerId = 1,
                            Description = "Service 3",
                            EndTime = new DateTime(2023, 3, 26, 13, 21, 36, 66, DateTimeKind.Local).AddTicks(4075),
                            StartTime = new DateTime(2023, 3, 23, 13, 21, 36, 66, DateTimeKind.Local).AddTicks(4072),
                            Status = "ventende",
                            Type = "Type C"
                        });
                });

            modelBuilder.Entity("FourWheel.Domain.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CaseId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Address = "123 Main St",
                            CaseId = 0,
                            City = "Springfield",
                            CustomerFirstName = "John",
                            CustomerFullName = "John Doe",
                            CustomerLastName = "Doe",
                            PhoneNumber = "555-1234",
                            ZipCode = 12345
                        },
                        new
                        {
                            CustomerId = 2,
                            Address = "456 Elm St",
                            CaseId = 0,
                            City = "Shelbyville",
                            CustomerFirstName = "Jane",
                            CustomerFullName = "Jane Doe",
                            CustomerLastName = "Doe",
                            PhoneNumber = "555-5678",
                            ZipCode = 67890
                        });
                });

            modelBuilder.Entity("FourWheel.Domain.Models.Car", b =>
                {
                    b.HasOne("FourWheel.Domain.Models.Customer", "Customer")
                        .WithMany("Cars")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("FourWheel.Domain.Models.Case", b =>
                {
                    b.HasOne("FourWheel.Domain.Models.Customer", "Customer")
                        .WithMany("Service")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("FourWheel.Domain.Models.Customer", b =>
                {
                    b.Navigation("Cars");

                    b.Navigation("Service");
                });
#pragma warning restore 612, 618
        }
    }
}
