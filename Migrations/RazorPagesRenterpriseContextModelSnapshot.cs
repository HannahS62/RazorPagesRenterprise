﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesRenterprise.Data;

#nullable disable

namespace RazorPagesRenterprise.Migrations
{
    [DbContext(typeof(RazorPagesRenterpriseContext))]
    partial class RazorPagesRenterpriseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("RazorPagesRenterprise.Models.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Customer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("DayRate")
                        .HasColumnType("REAL");

                    b.Property<string>("OutLoc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Reg")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RetLoc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Rental");
                });

            modelBuilder.Entity("RazorPagesRenterprise.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Reg")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("RazorPagesRenterprise.Models.Workshop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CompletionDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fault")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Mechanic")
                        .HasColumnType("TEXT");

                    b.Property<string>("Reg")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Workshop");
                });
#pragma warning restore 612, 618
        }
    }
}
