﻿// <auto-generated />
using System;
using AdvLab_WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AdvLab_WebApp.Migrations
{
    [DbContext(typeof(SampleEfContext))]
    [Migration("20240128051559_updateuserTable2")]
    partial class updateuserTable2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AdvLab_WebApp.Models.AddConnLab", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CompMac")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Idloc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocActive")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocCate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LocID")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("AddConnLabs");
                });

            modelBuilder.Entity("AdvLab_WebApp.Models.AddLocation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CompMac")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Idloc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocActive")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocCate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LocID")
                        .HasColumnType("int");

                    b.Property<int?>("LocSno")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reconsile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("AddLocations");
                });

            modelBuilder.Entity("AdvLab_WebApp.Models.LoginLog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CompName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoginStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MacAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("logDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("LoginLogs");
                });

            modelBuilder.Entity("AdvLab_WebApp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClientV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cnl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CNL");

                    b.Property<string>("CompMac")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Depart")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpId")
                        .HasColumnType("int")
                        .HasColumnName("EmpID");

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

                    b.Property<string>("LoginStatusIp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LoginStatusIP");

                    b.Property<string>("Nsend")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NSend");

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

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("RoleID");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubDepart")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Uid")
                        .HasColumnType("int")
                        .HasColumnName("UId");

                    b.Property<string>("Uname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UName");

                    b.Property<string>("Upassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UPassword");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
