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
    [Migration("20240220064914_updatenewdatabase1")]
    partial class updatenewdatabase1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AdvLab_WebApp.Models.AccessRight", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Assigning")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmpID")
                        .HasColumnType("int");

                    b.Property<int?>("SOR")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("AccessRights");
                });

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

            modelBuilder.Entity("AdvLab_WebApp.Models.AddDepart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CompMac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Depart")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Idloc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SID")
                        .HasColumnType("int");

                    b.Property<int?>("UId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("AddDeparts");
                });

            modelBuilder.Entity("AdvLab_WebApp.Models.AddDesignation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CompMac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Idloc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SID")
                        .HasColumnType("int");

                    b.Property<int?>("UId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("AddDesignations");
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

            modelBuilder.Entity("AdvLab_WebApp.Models.AddPlacement", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CompMac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Idloc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SID")
                        .HasColumnType("int");

                    b.Property<int?>("UId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("AddPlacements");
                });

            modelBuilder.Entity("AdvLab_WebApp.Models.AddSubDepart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CompMac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Depart")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Idloc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SID")
                        .HasColumnType("int");

                    b.Property<string>("SubDepart")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("AddSubDeparts");
                });

            modelBuilder.Entity("AdvLab_WebApp.Models.ChangePassword", b =>
                {
                    b.Property<string>("ConfirmNewPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.Property<string>("NewPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("ChangePasswords");
                });

            modelBuilder.Entity("AdvLab_WebApp.Models.CrystalReportPath", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("CNL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CrystalReport")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DefaultClient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Loc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("db")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("server")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("CrystalReportPaths");
                });

            modelBuilder.Entity("AdvLab_WebApp.Models.DescCashier", b =>
                {
                    b.Property<int>("LabNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LabNo"));

                    b.Property<int>("BillNo")
                        .HasColumnType("int");

                    b.Property<double>("BlanceA")
                        .HasColumnType("float");

                    b.Property<string>("CStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConsName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CpName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CpNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreditCardNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CurrentB")
                        .HasColumnType("float");

                    b.Property<double>("DiscPer")
                        .HasColumnType("float");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<string>("DortocSMS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("F_VNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("GrossA")
                        .HasColumnType("float");

                    b.Property<string>("Idloc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvoiceSMS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MRNO")
                        .HasColumnType("int");

                    b.Property<double>("PaidA")
                        .HasColumnType("float");

                    b.Property<string>("PaymentMode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pwd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RIdloc1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RUId1")
                        .HasColumnType("int");

                    b.Property<string>("RV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RV1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("RbalanceA")
                        .HasColumnType("float");

                    b.Property<DateTime>("RbalanceDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RegDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TaxN")
                        .HasColumnType("float");

                    b.Property<string>("TestCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalA")
                        .HasColumnType("float");

                    b.Property<int>("UId")
                        .HasColumnType("int");

                    b.HasKey("LabNo");

                    b.HasIndex("MRNO");

                    b.ToTable("DescCashiers");
                });

            modelBuilder.Entity("AdvLab_WebApp.Models.DescLab", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("BarcodeNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Charges")
                        .HasColumnType("int");

                    b.Property<string>("DStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DescID")
                        .HasColumnType("int");

                    b.Property<int>("LabNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("RepDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StatusDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("LabNo");

                    b.ToTable("DescLabs");
                });

            modelBuilder.Entity("AdvLab_WebApp.Models.DescQ", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime?>("ActionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CpName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CpNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Idloc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LocationNo")
                        .HasColumnType("int");

                    b.Property<int?>("UId")
                        .HasColumnType("int");

                    b.Property<string>("Uname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("DescQs");
                });

            modelBuilder.Entity("AdvLab_WebApp.Models.DuesRecQ", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime?>("ActionDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("AmountRec")
                        .HasColumnType("float");

                    b.Property<string>("Idloc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LabNo")
                        .HasColumnType("int");

                    b.Property<int?>("UId")
                        .HasColumnType("int");

                    b.Property<string>("Uname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("DuesRecQs");
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

            modelBuilder.Entity("AdvLab_WebApp.Models.PatReg", b =>
                {
                    b.Property<int>("MRNO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MRNO"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("AgeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DBO")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Idloc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Initial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhotoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Relation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UId")
                        .HasColumnType("int");

                    b.HasKey("MRNO");

                    b.ToTable("PatRegs");
                });

            modelBuilder.Entity("AdvLab_WebApp.Models.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleID"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("AdvLab_WebApp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClientV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cnl")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CNL");

                    b.Property<string>("CompMac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Depart")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpId")
                        .HasColumnType("int")
                        .HasColumnName("EmpID");

                    b.Property<string>("Idloc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoginStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoginStatusComp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoginStatusIp")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LoginStatusIP");

                    b.Property<string>("Nsend")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NSend");

                    b.Property<string>("PayGenerate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Place")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("RoleID");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubDepart")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Uid")
                        .HasColumnType("int")
                        .HasColumnName("UId");

                    b.Property<string>("Uname")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UName");

                    b.Property<string>("Upassword")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UPassword");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AdvLab_WebApp.Models.DescCashier", b =>
                {
                    b.HasOne("AdvLab_WebApp.Models.PatReg", "PatReg")
                        .WithMany()
                        .HasForeignKey("MRNO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PatReg");
                });

            modelBuilder.Entity("AdvLab_WebApp.Models.DescLab", b =>
                {
                    b.HasOne("AdvLab_WebApp.Models.DescCashier", "DescCashier")
                        .WithMany("DescLabs")
                        .HasForeignKey("LabNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DescCashier");
                });

            modelBuilder.Entity("AdvLab_WebApp.Models.DescCashier", b =>
                {
                    b.Navigation("DescLabs");
                });
#pragma warning restore 612, 618
        }
    }
}
