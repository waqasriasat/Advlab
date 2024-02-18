using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace AdvLab_WebApi.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
       
        public DbSet<User> Users { get; set; }
        public virtual DbSet<LoginLog> LoginLogs { get; set; }
        public virtual DbSet<AddLocation> AddLocations { get; set; }
        public virtual DbSet<AddConnLab> AddConnLabs { get; set; }
        public virtual DbSet<AccessRight> AccessRights { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<AddDepart> AddDeparts { get; set; }
        public virtual DbSet<AddSubDepart> AddSubDeparts { get; set; }
        public virtual DbSet<AddPlacement> AddPlacements { get; set; }
        public virtual DbSet<AddDesignation> AddDesignations { get; set; }

        public virtual DbSet<CrystalReportPath> CrystalReportPaths { get; set; }
        public virtual DbSet<DescCashier> DescCashiers { get; set; }
        public virtual DbSet<DescLab> DescLabs { get; set; }
        public virtual DbSet<DescQ> DescQs { get; set; }
        public virtual DbSet<DuesRecQ> DuesRecQs { get; set; }
        public virtual DbSet<PatReg> PatRegs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CrystalReportPath>().HasData(
            new CrystalReportPath()
            {
                id = 1,
                CrystalReport = "\\192.168.73.3\\ALAB Reports\\",
                UserName = "sa",
                Password = "M89.SolutioN",
                db = "AdvancedLab",
                server = "AdvancedLab",
                Loc = "NKM",
                CNL = "MAIN-LAB",
                DefaultClient = "SELF"
            });
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    ID = 1,
                    EmpID = 1,
                    UName = "Admin",
                    UPassword = "admin@786",
                    Status = "Yes",
                    CNL = "MAIN-LAB",
                    ClientV = "Main",
                    CompMac = "Null",
                    Depart = "All",
                    SubDepart = "All",
                    Placement = "Path",
                    Designation = "IT",
                    Idloc = "Main",
                    RoleID = 17,
                    Location = "Main",
                    LoginStatus = "No",
                    LoginStatusComp = "Null",
                    LoginStatusIP = "Null",
                    NSend = "No",
                    PayGenerate = "No",
                    Place = "Null",
                    PlaceCategory = "Null",
                    Token = "Null"
                });
            modelBuilder.Entity<Role>().HasData(
                    new Role { RoleID = 1, RoleName = "Receptionist" },
                    new Role { RoleID = 2, RoleName = "Phlebotomist" },
                    new Role { RoleID = 3, RoleName = "Receptionist + Phlebotomist" },
                    new Role { RoleID = 4, RoleName = "Dispatcher" },
                    new Role { RoleID = 5, RoleName = "Medical Technologist" },
                    new Role { RoleID = 6, RoleName = "Lab Technician" },
                    new Role { RoleID = 7, RoleName = "Lab Manager" },
                    new Role { RoleID = 8, RoleName = "Branch Manager" },
                    new Role { RoleID = 9, RoleName = "Regional Manager" },
                    new Role { RoleID = 10, RoleName = "Pathologist" },
                    new Role { RoleID = 11, RoleName = "Human Resource" },
                    new Role { RoleID = 12, RoleName = "Accountant" },
                    new Role { RoleID = 13, RoleName = "Finance" },
                    new Role { RoleID = 14, RoleName = "General Manager" },
                    new Role { RoleID = 15, RoleName = "Administrator" },
                    new Role { RoleID = 16, RoleName = "CEO" },
                    new Role { RoleID = 17, RoleName = "Director" }
                );
            modelBuilder.Entity<AddPlacement>().HasData(
     new AddPlacement { ID = 1, SID = 1, RegDate = DateTime.Parse("2018-04-15 03:21:16.000"), PlaceCode = "PATH", PlaceName = "Pathology", UId = 1, Idloc = "Null", CompMac = "Null" },
     new AddPlacement { ID = 2, SID = 2, RegDate = DateTime.Parse("2018-04-15 03:21:16.000"), PlaceCode = "RAD", PlaceName = "Radiology", UId = 2, Idloc = "Null", CompMac = "Null" },
     new AddPlacement { ID = 3, SID = 3, RegDate = DateTime.Parse("2020-01-18 01:15:27.000"), PlaceCode = "OPD", PlaceName = "Outpatient Department", UId = 3, Idloc = "Null", CompMac = "Null" },
     new AddPlacement { ID = 4, SID = 4, RegDate = DateTime.Parse("2018-04-15 03:21:16.000"), PlaceCode = "CSR", PlaceName = "Customer Service Representative", UId = 4, Idloc = "Null", CompMac = "Null" },
     new AddPlacement { ID = 5, SID = 5, RegDate = DateTime.Parse("2021-02-28 12:10:07.000"), PlaceCode = "IT", PlaceName = "Information Technology", UId = 5, Idloc = "Null", CompMac = "Null" },
     new AddPlacement { ID = 6, SID = 6, RegDate = DateTime.Parse("2018-04-15 03:21:16.000"), PlaceCode = "HR", PlaceName = "Human Resources", UId = 6, Idloc = "Null", CompMac = "Null" },
     new AddPlacement { ID = 7, SID = 7, RegDate = DateTime.Parse("2018-04-15 03:21:16.000"), PlaceCode = "IPD", PlaceName = "Inpatient Department", UId = 7, Idloc = "Null", CompMac = "Null" },
     new AddPlacement { ID = 8, SID = 8, RegDate = DateTime.Parse("2018-04-15 03:21:16.000"), PlaceCode = "FIN", PlaceName = "Finance", UId = 8, Idloc = "Null", CompMac = "Null" },
     new AddPlacement { ID = 9, SID = 9, RegDate = DateTime.Parse("2018-04-15 03:21:16.000"), PlaceCode = "MKTG", PlaceName = "Marketing", UId = 9, Idloc = "Null", CompMac = "Null" },
     new AddPlacement { ID = 10, SID = 9, RegDate = DateTime.Parse("2018-04-15 03:21:16.000"), PlaceCode = "SCM", PlaceName = "Supply Chain Management", UId = 9, Idloc = "Null", CompMac = "Null" },
     new AddPlacement { ID = 11, SID = null, RegDate = null, PlaceCode = "MED", PlaceName = "Medical", UId = null, Idloc = "Null", CompMac = "Null" }
 );
            modelBuilder.Entity<AddLocation>().HasData(
    new AddLocation { ID = 1, RegDate = DateTime.Parse("2018-05-01 01:50:40.000"), LocActive = "No", LocID = 10150121, LocCate = "Main", Reconsile = "Active", Location = "Main", LocSno = 0, UId = 1, Idloc = "NKM", CompMac = "FB: Address Contact" }
);
            modelBuilder.Entity<AddConnLab>().HasData(
    new AddConnLab { ID = 5, RegDate = DateTime.Parse("2019-03-25 11:43:59.000"), LocActive = "No", LocID = 1, LocCate = "MAIN-LAB", Location = "MAIN-LAB", UId = null, Idloc = null, CompMac = null }
); modelBuilder.Entity<AddDepart>().HasData(
    new AddDepart { ID = 116, SID = 77, RegDate = DateTime.Parse("2021-12-16 04:28:58.000"), Location = null, Placement = "IPD", Depart = "Gynee", UId = null, Idloc = null, CompMac = null },
    new AddDepart { ID = 117, SID = 78, RegDate = DateTime.Parse("2021-12-16 04:46:16.000"), Location = null, Placement = "IPD", Depart = "NICU", UId = null, Idloc = null, CompMac = null },
    new AddDepart { ID = 34, SID = 15, RegDate = DateTime.Parse("2020-01-13 22:25:06.000"), Location = "GB", Placement = "IT", Depart = "ALL", UId = null, Idloc = null, CompMac = null },
    new AddDepart { ID = 77, SID = 46, RegDate = DateTime.Parse("2018-04-20 03:07:29.000"), Location = "GB", Placement = "IT", Depart = "IT", UId = null, Idloc = null, CompMac = null },
    new AddDepart { ID = 114, SID = 75, RegDate = DateTime.Parse("2021-12-16 04:21:44.000"), Location = null, Placement = "OPD", Depart = "Consultancy", UId = null, Idloc = null, CompMac = null },
    new AddDepart { ID = 115, SID = 76, RegDate = DateTime.Parse("2021-12-16 04:21:44.000"), Location = null, Placement = "OPD", Depart = "RMO", UId = null, Idloc = null, CompMac = null },
    new AddDepart { ID = 119, SID = 80, RegDate = DateTime.Parse("2021-12-16 04:21:44.000"), Location = "GB", Placement = "OPD", Depart = "Services", UId = null, Idloc = null, CompMac = null },
    new AddDepart { ID = 118, SID = 79, RegDate = DateTime.Parse("2022-01-13 13:53:56.000"), Location = null, Placement = "OPD", Depart = "Ultrasound", UId = null, Idloc = null, CompMac = null },
    new AddDepart { ID = 1, SID = 1, RegDate = DateTime.Parse("2018-04-20 03:07:29.000"), Location = "GB", Placement = "PATH", Depart = "BIOCHEMISTRY", UId = null, Idloc = null, CompMac = null },
    new AddDepart { ID = 2, SID = 2, RegDate = DateTime.Parse("2018-04-20 03:07:29.000"), Location = "GB", Placement = "PATH", Depart = "BLOOD BANK", UId = null, Idloc = null, CompMac = null },
    new AddDepart { ID = 49, SID = 30, RegDate = DateTime.Parse("2018-04-20 03:07:29.000"), Location = "GB", Placement = "PATH", Depart = "HEMATOLOGY", UId = null, Idloc = null, CompMac = null },
    new AddDepart { ID = 3, SID = 3, RegDate = DateTime.Parse("2018-04-20 03:07:29.000"), Location = "GB", Placement = "PATH", Depart = "HISTOPATHOLOGY", UId = null, Idloc = null, CompMac = null },
    new AddDepart { ID = 4, SID = 4, RegDate = DateTime.Parse("2018-04-20 03:07:29.000"), Location = "GB", Placement = "PATH", Depart = "MICROBIOLOGY", UId = null, Idloc = null, CompMac = null },
    new AddDepart { ID = 5, SID = 5, RegDate = DateTime.Parse("2018-04-20 03:07:29.000"), Location = "GB", Placement = "PATH", Depart = "MOLECULAR PATHOLOGY", UId = null, Idloc = null, CompMac = null },
    new AddDepart { ID = 7, SID = 7, RegDate = DateTime.Parse("2018-04-20 03:07:29.000"), Location = "GB", Placement = "RAD", Depart = "CT SCAN", UId = null, Idloc = null, CompMac = null },
    new AddDepart { ID = 8, SID = 8, RegDate = DateTime.Parse("2018-04-20 03:07:29.000"), Location = "GB", Placement = "RAD", Depart = "ECG", UId = null, Idloc = null, CompMac = null },
    new AddDepart { ID = 10, SID = 10, RegDate = DateTime.Parse("2018-04-20 03:07:29.000"), Location = "GB", Placement = "RAD", Depart = "ECHO", UId = null, Idloc = null, CompMac = null },
    new AddDepart { ID = 11, SID = 11, RegDate = DateTime.Parse("2018-04-20 03:07:29.000"), Location = "GB", Placement = "RAD", Depart = "MRI", UId = null, Idloc = null, CompMac = null },
    new AddDepart { ID = 31, SID = 13, RegDate = DateTime.Parse("2018-04-15 02:42:02.233"), Location = "GB", Placement = "RAD", Depart = "ULTRASOUND", UId = null, Idloc = null, CompMac = null },
    new AddDepart { ID = 32, SID = 14, RegDate = DateTime.Parse("2018-04-15 02:42:02.233"), Location = "GB", Placement = "RAD", Depart = "X-RAY", UId = null, Idloc = null, CompMac = null }
    // Add other entries as needed...
); modelBuilder.Entity<AddSubDepart>().HasData(
    new AddSubDepart { ID = 121, SID = 7, RegDate = DateTime.Parse("2021-12-16 04:41:43.000"), Location = "IPD", Depart = "Gynee", SubDepart = "Labour Room", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 120, SID = 6, RegDate = DateTime.Parse("2021-12-16 04:34:19.000"), Location = "IPD", Depart = "Gynee", SubDepart = "Operation", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 123, SID = 9, RegDate = DateTime.Parse("2021-12-16 04:46:33.000"), Location = "IPD", Depart = "NICU", SubDepart = "Admission", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 122, SID = 8, RegDate = DateTime.Parse("2021-12-16 04:46:33.000"), Location = "IPD", Depart = "NICU", SubDepart = "Observation", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 40, SID = 37, RegDate = DateTime.Parse("2021-05-11 12:31:38.000"), Location = "IT", Depart = "IT", SubDepart = "Governance", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 31, SID = 29, RegDate = DateTime.Parse("2021-05-11 12:31:38.000"), Location = "IT", Depart = "IT", SubDepart = "Infrastructure Department", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 29, SID = 27, RegDate = DateTime.Parse("2021-02-02 21:15:19.000"), Location = "IT", Depart = "IT", SubDepart = "Operation and Maintenance", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 72, SID = 69, RegDate = DateTime.Parse("2021-02-02 21:15:19.000"), Location = "IT", Depart = "IT", SubDepart = "Software Development", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 116, SID = 2, RegDate = DateTime.Parse("2021-12-16 04:29:48.000"), Location = "OPD", Depart = "Consultancy", SubDepart = "Cardiology", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 125, SID = 11, RegDate = DateTime.Parse("2021-12-16 04:46:33.000"), Location = "OPD", Depart = "Consultancy", SubDepart = "Dentist", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 115, SID = 1, RegDate = DateTime.Parse("2021-12-16 04:29:48.000"), Location = "OPD", Depart = "Consultancy", SubDepart = "Diabetes", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 117, SID = 3, RegDate = DateTime.Parse("2021-12-16 04:29:48.000"), Location = "OPD", Depart = "Consultancy", SubDepart = "ENT", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 126, SID = 12, RegDate = DateTime.Parse("2022-01-15 12:51:45.000"), Location = "OPD", Depart = "Consultancy", SubDepart = "General", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 124, SID = 10, RegDate = DateTime.Parse("2021-12-16 04:46:33.000"), Location = "OPD", Depart = "Consultancy", SubDepart = "Gynecology", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 118, SID = 4, RegDate = DateTime.Parse("2021-12-16 04:29:48.000"), Location = "OPD", Depart = "RMO", SubDepart = "General", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 119, SID = 5, RegDate = DateTime.Parse("2021-12-16 04:29:48.000"), Location = "OPD", Depart = "Services", SubDepart = "Services", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 79, SID = 74, RegDate = DateTime.Parse("2021-05-10 16:13:47.000"), Location = "PATH", Depart = "Admin", SubDepart = "Transport", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 2, SID = 2, RegDate = DateTime.Parse("2019-07-07 16:30:43.000"), Location = "Path", Depart = "BIOCHEMISTRY", SubDepart = "ROUTINE CHEMISTRY", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 1, SID = 1, RegDate = DateTime.Parse("2018-04-15 02:35:57.000"), Location = "Path", Depart = "BIOCHEMISTRY", SubDepart = "SPECIAL CHEMISTRY", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 24, SID = 22, RegDate = DateTime.Parse("2018-04-15 02:35:57.000"), Location = "Path", Depart = "BIOCHEMISTRY", SubDepart = "SPECIAL CHEMISTRY / IMMUNOLOGY", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 27, SID = 25, RegDate = DateTime.Parse("2018-04-15 02:35:57.000"), Location = "Path", Depart = "BIOCHEMISTRY", SubDepart = "SPECIAL CHEMISTRY / IMMUNOLOGY / OUT SIDE", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 25, SID = 23, RegDate = DateTime.Parse("2018-04-15 02:35:57.000"), Location = "PATH", Depart = "BIOCHEMISTRY", SubDepart = "SPECIAL CHEMISTRY / OUT SIDE", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 76, SID = 71, RegDate = DateTime.Parse("2021-12-27 19:39:29.000"), Location = "PATH", Depart = "Distribution", SubDepart = "Bulk Dispatch", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 75, SID = 70, RegDate = DateTime.Parse("2021-12-27 19:39:29.000"), Location = "PATH", Depart = "Distribution", SubDepart = "Routine Dispatch", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 28, SID = 26, RegDate = null, Location = "Path", Depart = "HEMATOLOGY", SubDepart = "HEMATOLOGY", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 26, SID = 24, RegDate = DateTime.Parse("2020-07-15 00:15:01.000"), Location = "PATH", Depart = "HISTOPATHOLOGY", SubDepart = "CYTOLOGY", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 4, SID = 4, RegDate = null, Location = "Path", Depart = "HISTOPATHOLOGY", SubDepart = "HISTOPATHOLOGY", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 5, SID = 5, RegDate = null, Location = "Path", Depart = "MICROBIOLOGY", SubDepart = "BACTERIOLOGY", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 18, SID = 16, RegDate = null, Location = "Path", Depart = "MICROBIOLOGY", SubDepart = "Culture Sensitivity", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 6, SID = 6, RegDate = null, Location = "Path", Depart = "MICROBIOLOGY", SubDepart = "PARASITOLOGY", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 7, SID = 7, RegDate = null, Location = "Path", Depart = "MICROBIOLOGY", SubDepart = "SEROLOGY", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 23, SID = 21, RegDate = null, Location = "Path", Depart = "MOLECULAR PATHOLOGY", SubDepart = "BLOOD", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 8, SID = 8, RegDate = null, Location = "Path", Depart = "MOLECULAR PATHOLOGY", SubDepart = "MOLECULAR PATHOLOGY", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 22, SID = 20, RegDate = null, Location = "Path", Depart = "MOLECULAR PATHOLOGY", SubDepart = "NASAL", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 11, SID = 9, RegDate = null, Location = "Rad", Depart = "COLOR DOPPLER", SubDepart = "COLOR DOPPLER", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 12, SID = 10, RegDate = null, Location = "Rad", Depart = "CT SCAN", SubDepart = "CT SCAN", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 35, SID = 32, RegDate = null, Location = "Rad", Depart = "Mancom", SubDepart = "Mancom", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 13, SID = 11, RegDate = null, Location = "Rad", Depart = "MRI", SubDepart = "MRI", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 71, SID = 68, RegDate = DateTime.Parse("2018-04-15 02:35:57.000"), Location = "Rad", Depart = "PHYSIOLOGY", SubDepart = "PHYSIOLOGY", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 34, SID = 32, RegDate = DateTime.Parse("2021-05-12 14:21:14.000"), Location = "Rad", Depart = "Sonology", SubDepart = "Sonology", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 16, SID = 14, RegDate = DateTime.Parse("2021-12-13 19:27:07.000"), Location = "Rad", Depart = "ULTRASOUND", SubDepart = "ULTRASOUND", UId = null, Idloc = null, CompMac = null },
    new AddSubDepart { ID = 17, SID = 15, RegDate = DateTime.Parse("2021-12-13 19:27:07.000"), Location = "Rad", Depart = "X-RAY", SubDepart = "Xray", UId = null, Idloc = null, CompMac = null }
); modelBuilder.Entity<AddDesignation>().HasData(
    new AddDesignation { ID = 132, SID = 29, RegDate = null, Designation = "IT Trainee", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 201, SID = 98, RegDate = null, Designation = "Accountant", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 150, SID = 47, RegDate = null, Designation = "Administrator", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 140, SID = 37, RegDate = null, Designation = "Assistant Branch Manager", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 167, SID = 64, RegDate = null, Designation = "Assistant Lab Technician", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 153, SID = 50, RegDate = null, Designation = "Assistant Technician", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 119, SID = 16, RegDate = null, Designation = "Billing Incharge", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 179, SID = 76, RegDate = null, Designation = "Branch Manager", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 144, SID = 41, RegDate = null, Designation = "Business Development Executive", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 138, SID = 35, RegDate = null, Designation = "Business Development Manager", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 137, SID = 34, RegDate = null, Designation = "Business Development Officer", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 146, SID = 43, RegDate = null, Designation = "Core Graphic Designer", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 143, SID = 40, RegDate = null, Designation = "Corporate Sales Executive", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 142, SID = 39, RegDate = null, Designation = "Corporate Sales Head", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 198, SID = 95, RegDate = null, Designation = "Critical Care Technician", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 157, SID = 54, RegDate = null, Designation = "Customer Service Executive", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 148, SID = 45, RegDate = null, Designation = "Digital Media Coordinator", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 147, SID = 44, RegDate = null, Designation = "Digital Media Designer", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 176, SID = 73, RegDate = null, Designation = "Dispatch Coordinator", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 178, SID = 75, RegDate = null, Designation = "Dispatch Officer", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 174, SID = 71, RegDate = null, Designation = "Fleet Manager", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 149, SID = 46, RegDate = null, Designation = "Graphic Designer", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 121, SID = 18, RegDate = null, Designation = "Head Of Department", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 197, SID = 94, RegDate = null, Designation = "Head Of Nurse", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 159, SID = 56, RegDate = null, Designation = "Incharge", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 127, SID = 24, RegDate = null, Designation = "IT Executive", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 126, SID = 23, RegDate = null, Designation = "IT Incharge", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 128, SID = 25, RegDate = null, Designation = "IT Officer", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 130, SID = 27, RegDate = null, Designation = "IT Support Officer", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 172, SID = 69, RegDate = null, Designation = "Janitorial Coordinator", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 161, SID = 58, RegDate = null, Designation = "Junior Lab Technologist", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 200, SID = 97, RegDate = null, Designation = "Junior Software Developer", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 164, SID = 61, RegDate = null, Designation = "Lab Incharge", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 162, SID = 59, RegDate = null, Designation = "Lab Manager", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 163, SID = 60, RegDate = null, Designation = "Lab Supervisior", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 154, SID = 51, RegDate = null, Designation = "Lab Technician", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 160, SID = 57, RegDate = null, Designation = "Lab Technologist", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 133, SID = 30, RegDate = null, Designation = "Lab Trainee", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 131, SID = 28, RegDate = null, Designation = "Manager Infrastructure", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 145, SID = 42, RegDate = null, Designation = "Marketing Manager", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 196, SID = 93, RegDate = null, Designation = "Medical Officer", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 170, SID = 67, RegDate = null, Designation = "Office Boy", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 192, SID = 89, RegDate = null, Designation = "Phelbotomist", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 151, SID = 48, RegDate = null, Designation = "Phlebotomist", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 120, SID = 17, RegDate = null, Designation = "QC Manager /LAB Coordinator", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 189, SID = 86, RegDate = null, Designation = "Receptionist", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 155, SID = 52, RegDate = null, Designation = "Receptionist+Phlebotomist", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 191, SID = 88, RegDate = null, Designation = "Recptionist/ Phelbotomist", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 135, SID = 32, RegDate = null, Designation = "Regional Head Of Operations", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 136, SID = 33, RegDate = null, Designation = "Regional Sales Manager", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 177, SID = 74, RegDate = null, Designation = "Rider", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 169, SID = 66, RegDate = null, Designation = "Senior Office Boy", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 152, SID = 49, RegDate = null, Designation = "Senior Phlebotomist", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 199, SID = 96, RegDate = null, Designation = "Senior Software Developer", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 165, SID = 62, RegDate = null, Designation = "Senior Technician", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 168, SID = 65, RegDate = null, Designation = "Senior Technologist", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 129, SID = 26, RegDate = null, Designation = "Software Developers", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 183, SID = 80, RegDate = null, Designation = "Sonologist", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 190, SID = 87, RegDate = null, Designation = "Staff Nurse", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 124, SID = 21, RegDate = null, Designation = "Store Incharge", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 123, SID = 20, RegDate = null, Designation = "Store Officer", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 122, SID = 19, RegDate = null, Designation = "Supply Chain Officer", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 171, SID = 68, RegDate = null, Designation = "Sweeper", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 156, SID = 53, RegDate = null, Designation = "Team Leader", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 181, SID = 78, RegDate = null, Designation = "Technician", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 166, SID = 63, RegDate = null, Designation = "Technologist", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 125, SID = 22, RegDate = null, Designation = "Trainee", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 139, SID = 36, RegDate = null, Designation = "Trainee", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 188, SID = 85, RegDate = null, Designation = "Trainee Assistant", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 118, SID = 15, RegDate = null, Designation = "Trainee Finance", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 184, SID = 81, RegDate = null, Designation = "Ultrasound Coordinator", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 180, SID = 77, RegDate = null, Designation = "X-Ray Technician", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 223, SID = 120, RegDate = null, Designation = "Accounts & Finance Executive", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 214, SID = 111, RegDate = null, Designation = "Accounts Assistant / Computer Operator", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 104, SID = 1, RegDate = null, Designation = "Advisor to The Board", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 217, SID = 114, RegDate = null, Designation = "Aesthetic Treatment Technician", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 230, SID = 127, RegDate = null, Designation = "Area Sales Manager", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 239, SID = 136, RegDate = null, Designation = "Assiatant HR & Finance", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 111, SID = 8, RegDate = null, Designation = "Assistant Manager HR/Admin", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 187, SID = 84, RegDate = null, Designation = "Assistant Technician", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 235, SID = 132, RegDate = null, Designation = "BDO", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 116, SID = 13, RegDate = null, Designation = "Billing Executive", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 241, SID = 138, RegDate = null, Designation = "Billing/Recovery Incharge", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 234, SID = 131, RegDate = null, Designation = "Branch Manager + Marketing", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 227, SID = 124, RegDate = null, Designation = "Branch Supervisor", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 236, SID = 133, RegDate = null, Designation = "Business Develpment Manager", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 107, SID = 4, RegDate = null, Designation = "Chief Executive Officer", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 113, SID = 10, RegDate = null, Designation = "Chief Financial Officer", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 204, SID = 101, RegDate = null, Designation = "Chief Pathologist", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 109, SID = 6, RegDate = null, Designation = "Consultant", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 218, SID = 115, RegDate = null, Designation = "Corporate Officer", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 216, SID = 113, RegDate = null, Designation = "CS Lead", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 222, SID = 119, RegDate = null, Designation = "CSR TEAM LEAD", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 244, SID = 141, RegDate = null, Designation = "Customer Service Team Leader", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 209, SID = 106, RegDate = null, Designation = "Data Entry Operater", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 158, SID = 55, RegDate = null, Designation = "Data Entry Operator", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 173, SID = 70, RegDate = null, Designation = "Driver", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 210, SID = 107, RegDate = null, Designation = "Electrician", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 240, SID = 137, RegDate = null, Designation = "Finance Executive", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 114, SID = 11, RegDate = null, Designation = "Finance Manager", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 117, SID = 14, RegDate = null, Designation = "Finance Trainee", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 245, SID = 142, RegDate = null, Designation = "Front Desk Officer", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 243, SID = 140, RegDate = null, Designation = "Head of Customer Relation", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 110, SID = 7, RegDate = null, Designation = "Head Of HR / Admin", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 108, SID = 5, RegDate = null, Designation = "Head Of PCR Department", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 203, SID = 100, RegDate = null, Designation = "HR Assistant", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 112, SID = 9, RegDate = null, Designation = "HR Executive", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 238, SID = 135, RegDate = null, Designation = "HR Intern", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 242, SID = 139, RegDate = null, Designation = "Internal Audit Executive", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 221, SID = 118, RegDate = null, Designation = "Junior Technologist", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 105, SID = 2, RegDate = null, Designation = "Laboratory Director", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 246, SID = 143, RegDate = null, Designation = "Laboratory Incharge", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 205, SID = 102, RegDate = null, Designation = "Labortory Manager", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 219, SID = 116, RegDate = null, Designation = "Maintenance + Office Boy", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 233, SID = 130, RegDate = null, Designation = "Marketing Coordinator", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 225, SID = 122, RegDate = null, Designation = "Medical Consultant", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 194, SID = 91, RegDate = null, Designation = "Medical Officer", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 220, SID = 117, RegDate = null, Designation = "Micro Biologist", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 232, SID = 129, RegDate = null, Designation = "Molecular Lab Technologist", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 134, SID = 31, RegDate = null, Designation = "Network & Telecom Technician", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 212, SID = 109, RegDate = null, Designation = "Nurse", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 175, SID = 72, RegDate = null, Designation = "Office Assistant", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 106, SID = 3, RegDate = null, Designation = "Pathologist", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 206, SID = 103, RegDate = null, Designation = "Pathologist", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 237, SID = 134, RegDate = null, Designation = "Pharmacy Incharge", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 224, SID = 121, RegDate = null, Designation = "Phlebotomist + Rider", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 247, SID = 144, RegDate = null, Designation = "Procurement Executive", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 228, SID = 125, RegDate = null, Designation = "Radiologist", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 229, SID = 126, RegDate = null, Designation = "Regional Head Interior", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 211, SID = 108, RegDate = null, Designation = "Regional Head- Corporate Sales", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 141, SID = 38, RegDate = null, Designation = "Regional Sales Manager Retail", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 115, SID = 12, RegDate = null, Designation = "Senior Finance Executive", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 226, SID = 123, RegDate = null, Designation = "SMO", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 231, SID = 128, RegDate = null, Designation = "Sr. BDO", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 213, SID = 110, RegDate = null, Designation = "Technical Incharge", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 215, SID = 112, RegDate = null, Designation = "Technologist", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 207, SID = 104, RegDate = null, Designation = "Trainee Molecular Technologist", UId = null, Idloc = null, CompMac = null },
    new AddDesignation { ID = 208, SID = 105, RegDate = null, Designation = "Vaccinator", UId = null, Idloc = null, CompMac = null }
);
        }

    }

}
