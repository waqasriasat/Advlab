﻿// <auto-generated />
using System;
using AdvLab_WebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AdvLab_WebApi.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20240122120435_CreateNewdatabase")]
    partial class CreateNewdatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AdvLab_WebApi.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CNL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompMac")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Depart")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmpID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Idloc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoginStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoginStatusComp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoginStatusIP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NSend")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PayGenerate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RoleID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubDepart")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UId")
                        .HasColumnType("int");

                    b.Property<string>("UName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CNL = "MAIN-LAB",
                            ClientV = "Main",
                            CompMac = "Null",
                            Depart = "All",
                            Designation = "IT",
                            EmpID = 1,
                            Idloc = "Main",
                            Location = "Main",
                            LoginStatus = "No",
                            LoginStatusComp = "Null",
                            LoginStatusIP = "Null",
                            NSend = "No",
                            PayGenerate = "No",
                            Place = "Null",
                            PlaceCategory = "Null",
                            Placement = "Path",
                            RoleID = 17,
                            Status = "Yes",
                            SubDepart = "All",
                            UName = "Admin",
                            UPassword = "admin@786"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
