using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AdvLab_WebApi.Migrations
{
    /// <inheritdoc />
    public partial class updatewithmultitablewithRowData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Idloc",
                table: "AddConnLabs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CompMac",
                table: "AddConnLabs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "AddDeparts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SID = table.Column<int>(type: "int", nullable: true),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Placement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Depart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UId = table.Column<int>(type: "int", nullable: true),
                    Idloc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompMac = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddDeparts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AddDesignations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SID = table.Column<int>(type: "int", nullable: true),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UId = table.Column<int>(type: "int", nullable: true),
                    Idloc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompMac = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddDesignations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AddPlacements",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SID = table.Column<int>(type: "int", nullable: true),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PlaceCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UId = table.Column<int>(type: "int", nullable: true),
                    Idloc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompMac = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddPlacements", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AddSubDeparts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SID = table.Column<int>(type: "int", nullable: true),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Depart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubDepart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UId = table.Column<int>(type: "int", nullable: true),
                    Idloc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompMac = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddSubDeparts", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "AddConnLabs",
                columns: new[] { "ID", "CompMac", "Idloc", "LocActive", "LocCate", "LocID", "Location", "RegDate", "UId" },
                values: new object[] { 5, null, null, "No", "MAIN-LAB", 1, "MAIN-LAB", new DateTime(2019, 3, 25, 11, 43, 59, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "AddDeparts",
                columns: new[] { "ID", "CompMac", "Depart", "Idloc", "Location", "Placement", "RegDate", "SID", "UId" },
                values: new object[,]
                {
                    { 1, null, "BIOCHEMISTRY", null, "GB", "PATH", new DateTime(2018, 4, 20, 3, 7, 29, 0, DateTimeKind.Unspecified), 1, null },
                    { 2, null, "BLOOD BANK", null, "GB", "PATH", new DateTime(2018, 4, 20, 3, 7, 29, 0, DateTimeKind.Unspecified), 2, null },
                    { 3, null, "HISTOPATHOLOGY", null, "GB", "PATH", new DateTime(2018, 4, 20, 3, 7, 29, 0, DateTimeKind.Unspecified), 3, null },
                    { 4, null, "MICROBIOLOGY", null, "GB", "PATH", new DateTime(2018, 4, 20, 3, 7, 29, 0, DateTimeKind.Unspecified), 4, null },
                    { 5, null, "MOLECULAR PATHOLOGY", null, "GB", "PATH", new DateTime(2018, 4, 20, 3, 7, 29, 0, DateTimeKind.Unspecified), 5, null },
                    { 7, null, "CT SCAN", null, "GB", "RAD", new DateTime(2018, 4, 20, 3, 7, 29, 0, DateTimeKind.Unspecified), 7, null },
                    { 8, null, "ECG", null, "GB", "RAD", new DateTime(2018, 4, 20, 3, 7, 29, 0, DateTimeKind.Unspecified), 8, null },
                    { 10, null, "ECHO", null, "GB", "RAD", new DateTime(2018, 4, 20, 3, 7, 29, 0, DateTimeKind.Unspecified), 10, null },
                    { 11, null, "MRI", null, "GB", "RAD", new DateTime(2018, 4, 20, 3, 7, 29, 0, DateTimeKind.Unspecified), 11, null },
                    { 31, null, "ULTRASOUND", null, "GB", "RAD", new DateTime(2018, 4, 15, 2, 42, 2, 233, DateTimeKind.Unspecified), 13, null },
                    { 32, null, "X-RAY", null, "GB", "RAD", new DateTime(2018, 4, 15, 2, 42, 2, 233, DateTimeKind.Unspecified), 14, null },
                    { 34, null, "ALL", null, "GB", "IT", new DateTime(2020, 1, 13, 22, 25, 6, 0, DateTimeKind.Unspecified), 15, null },
                    { 49, null, "HEMATOLOGY", null, "GB", "PATH", new DateTime(2018, 4, 20, 3, 7, 29, 0, DateTimeKind.Unspecified), 30, null },
                    { 77, null, "IT", null, "GB", "IT", new DateTime(2018, 4, 20, 3, 7, 29, 0, DateTimeKind.Unspecified), 46, null },
                    { 114, null, "Consultancy", null, null, "OPD", new DateTime(2021, 12, 16, 4, 21, 44, 0, DateTimeKind.Unspecified), 75, null },
                    { 115, null, "RMO", null, null, "OPD", new DateTime(2021, 12, 16, 4, 21, 44, 0, DateTimeKind.Unspecified), 76, null },
                    { 116, null, "Gynee", null, null, "IPD", new DateTime(2021, 12, 16, 4, 28, 58, 0, DateTimeKind.Unspecified), 77, null },
                    { 117, null, "NICU", null, null, "IPD", new DateTime(2021, 12, 16, 4, 46, 16, 0, DateTimeKind.Unspecified), 78, null },
                    { 118, null, "Ultrasound", null, null, "OPD", new DateTime(2022, 1, 13, 13, 53, 56, 0, DateTimeKind.Unspecified), 79, null },
                    { 119, null, "Services", null, "GB", "OPD", new DateTime(2021, 12, 16, 4, 21, 44, 0, DateTimeKind.Unspecified), 80, null }
                });

            migrationBuilder.InsertData(
                table: "AddDesignations",
                columns: new[] { "ID", "CompMac", "Designation", "Idloc", "RegDate", "SID", "UId" },
                values: new object[,]
                {
                    { 104, null, "Advisor to The Board", null, null, 1, null },
                    { 105, null, "Laboratory Director", null, null, 2, null },
                    { 106, null, "Pathologist", null, null, 3, null },
                    { 107, null, "Chief Executive Officer", null, null, 4, null },
                    { 108, null, "Head Of PCR Department", null, null, 5, null },
                    { 109, null, "Consultant", null, null, 6, null },
                    { 110, null, "Head Of HR / Admin", null, null, 7, null },
                    { 111, null, "Assistant Manager HR/Admin", null, null, 8, null },
                    { 112, null, "HR Executive", null, null, 9, null },
                    { 113, null, "Chief Financial Officer", null, null, 10, null },
                    { 114, null, "Finance Manager", null, null, 11, null },
                    { 115, null, "Senior Finance Executive", null, null, 12, null },
                    { 116, null, "Billing Executive", null, null, 13, null },
                    { 117, null, "Finance Trainee", null, null, 14, null },
                    { 118, null, "Trainee Finance", null, null, 15, null },
                    { 119, null, "Billing Incharge", null, null, 16, null },
                    { 120, null, "QC Manager /LAB Coordinator", null, null, 17, null },
                    { 121, null, "Head Of Department", null, null, 18, null },
                    { 122, null, "Supply Chain Officer", null, null, 19, null },
                    { 123, null, "Store Officer", null, null, 20, null },
                    { 124, null, "Store Incharge", null, null, 21, null },
                    { 125, null, "Trainee", null, null, 22, null },
                    { 126, null, "IT Incharge", null, null, 23, null },
                    { 127, null, "IT Executive", null, null, 24, null },
                    { 128, null, "IT Officer", null, null, 25, null },
                    { 129, null, "Software Developers", null, null, 26, null },
                    { 130, null, "IT Support Officer", null, null, 27, null },
                    { 131, null, "Manager Infrastructure", null, null, 28, null },
                    { 132, null, "IT Trainee", null, null, 29, null },
                    { 133, null, "Lab Trainee", null, null, 30, null },
                    { 134, null, "Network & Telecom Technician", null, null, 31, null },
                    { 135, null, "Regional Head Of Operations", null, null, 32, null },
                    { 136, null, "Regional Sales Manager", null, null, 33, null },
                    { 137, null, "Business Development Officer", null, null, 34, null },
                    { 138, null, "Business Development Manager", null, null, 35, null },
                    { 139, null, "Trainee", null, null, 36, null },
                    { 140, null, "Assistant Branch Manager", null, null, 37, null },
                    { 141, null, "Regional Sales Manager Retail", null, null, 38, null },
                    { 142, null, "Corporate Sales Head", null, null, 39, null },
                    { 143, null, "Corporate Sales Executive", null, null, 40, null },
                    { 144, null, "Business Development Executive", null, null, 41, null },
                    { 145, null, "Marketing Manager", null, null, 42, null },
                    { 146, null, "Core Graphic Designer", null, null, 43, null },
                    { 147, null, "Digital Media Designer", null, null, 44, null },
                    { 148, null, "Digital Media Coordinator", null, null, 45, null },
                    { 149, null, "Graphic Designer", null, null, 46, null },
                    { 150, null, "Administrator", null, null, 47, null },
                    { 151, null, "Phlebotomist", null, null, 48, null },
                    { 152, null, "Senior Phlebotomist", null, null, 49, null },
                    { 153, null, "Assistant Technician", null, null, 50, null },
                    { 154, null, "Lab Technician", null, null, 51, null },
                    { 155, null, "Receptionist+Phlebotomist", null, null, 52, null },
                    { 156, null, "Team Leader", null, null, 53, null },
                    { 157, null, "Customer Service Executive", null, null, 54, null },
                    { 158, null, "Data Entry Operator", null, null, 55, null },
                    { 159, null, "Incharge", null, null, 56, null },
                    { 160, null, "Lab Technologist", null, null, 57, null },
                    { 161, null, "Junior Lab Technologist", null, null, 58, null },
                    { 162, null, "Lab Manager", null, null, 59, null },
                    { 163, null, "Lab Supervisior", null, null, 60, null },
                    { 164, null, "Lab Incharge", null, null, 61, null },
                    { 165, null, "Senior Technician", null, null, 62, null },
                    { 166, null, "Technologist", null, null, 63, null },
                    { 167, null, "Assistant Lab Technician", null, null, 64, null },
                    { 168, null, "Senior Technologist", null, null, 65, null },
                    { 169, null, "Senior Office Boy", null, null, 66, null },
                    { 170, null, "Office Boy", null, null, 67, null },
                    { 171, null, "Sweeper", null, null, 68, null },
                    { 172, null, "Janitorial Coordinator", null, null, 69, null },
                    { 173, null, "Driver", null, null, 70, null },
                    { 174, null, "Fleet Manager", null, null, 71, null },
                    { 175, null, "Office Assistant", null, null, 72, null },
                    { 176, null, "Dispatch Coordinator", null, null, 73, null },
                    { 177, null, "Rider", null, null, 74, null },
                    { 178, null, "Dispatch Officer", null, null, 75, null },
                    { 179, null, "Branch Manager", null, null, 76, null },
                    { 180, null, "X-Ray Technician", null, null, 77, null },
                    { 181, null, "Technician", null, null, 78, null },
                    { 183, null, "Sonologist", null, null, 80, null },
                    { 184, null, "Ultrasound Coordinator", null, null, 81, null },
                    { 187, null, "Assistant Technician", null, null, 84, null },
                    { 188, null, "Trainee Assistant", null, null, 85, null },
                    { 189, null, "Receptionist", null, null, 86, null },
                    { 190, null, "Staff Nurse", null, null, 87, null },
                    { 191, null, "Recptionist/ Phelbotomist", null, null, 88, null },
                    { 192, null, "Phelbotomist", null, null, 89, null },
                    { 194, null, "Medical Officer", null, null, 91, null },
                    { 196, null, "Medical Officer", null, null, 93, null },
                    { 197, null, "Head Of Nurse", null, null, 94, null },
                    { 198, null, "Critical Care Technician", null, null, 95, null },
                    { 199, null, "Senior Software Developer", null, null, 96, null },
                    { 200, null, "Junior Software Developer", null, null, 97, null },
                    { 201, null, "Accountant", null, null, 98, null },
                    { 203, null, "HR Assistant", null, null, 100, null },
                    { 204, null, "Chief Pathologist", null, null, 101, null },
                    { 205, null, "Labortory Manager", null, null, 102, null },
                    { 206, null, "Pathologist", null, null, 103, null },
                    { 207, null, "Trainee Molecular Technologist", null, null, 104, null },
                    { 208, null, "Vaccinator", null, null, 105, null },
                    { 209, null, "Data Entry Operater", null, null, 106, null },
                    { 210, null, "Electrician", null, null, 107, null },
                    { 211, null, "Regional Head- Corporate Sales", null, null, 108, null },
                    { 212, null, "Nurse", null, null, 109, null },
                    { 213, null, "Technical Incharge", null, null, 110, null },
                    { 214, null, "Accounts Assistant / Computer Operator", null, null, 111, null },
                    { 215, null, "Technologist", null, null, 112, null },
                    { 216, null, "CS Lead", null, null, 113, null },
                    { 217, null, "Aesthetic Treatment Technician", null, null, 114, null },
                    { 218, null, "Corporate Officer", null, null, 115, null },
                    { 219, null, "Maintenance + Office Boy", null, null, 116, null },
                    { 220, null, "Micro Biologist", null, null, 117, null },
                    { 221, null, "Junior Technologist", null, null, 118, null },
                    { 222, null, "CSR TEAM LEAD", null, null, 119, null },
                    { 223, null, "Accounts & Finance Executive", null, null, 120, null },
                    { 224, null, "Phlebotomist + Rider", null, null, 121, null },
                    { 225, null, "Medical Consultant", null, null, 122, null },
                    { 226, null, "SMO", null, null, 123, null },
                    { 227, null, "Branch Supervisor", null, null, 124, null },
                    { 228, null, "Radiologist", null, null, 125, null },
                    { 229, null, "Regional Head Interior", null, null, 126, null },
                    { 230, null, "Area Sales Manager", null, null, 127, null },
                    { 231, null, "Sr. BDO", null, null, 128, null },
                    { 232, null, "Molecular Lab Technologist", null, null, 129, null },
                    { 233, null, "Marketing Coordinator", null, null, 130, null },
                    { 234, null, "Branch Manager + Marketing", null, null, 131, null },
                    { 235, null, "BDO", null, null, 132, null },
                    { 236, null, "Business Develpment Manager", null, null, 133, null },
                    { 237, null, "Pharmacy Incharge", null, null, 134, null },
                    { 238, null, "HR Intern", null, null, 135, null },
                    { 239, null, "Assiatant HR & Finance", null, null, 136, null },
                    { 240, null, "Finance Executive", null, null, 137, null },
                    { 241, null, "Billing/Recovery Incharge", null, null, 138, null },
                    { 242, null, "Internal Audit Executive", null, null, 139, null },
                    { 243, null, "Head of Customer Relation", null, null, 140, null },
                    { 244, null, "Customer Service Team Leader", null, null, 141, null },
                    { 245, null, "Front Desk Officer", null, null, 142, null },
                    { 246, null, "Laboratory Incharge", null, null, 143, null },
                    { 247, null, "Procurement Executive", null, null, 144, null }
                });

            migrationBuilder.InsertData(
                table: "AddLocations",
                columns: new[] { "ID", "CompMac", "Idloc", "LocActive", "LocCate", "LocID", "LocSno", "Location", "Reconsile", "RegDate", "UId" },
                values: new object[] { 1, "FB: Address Contact", "NKM", "No", "Main", 10150121, 0, "Main", "Active", new DateTime(2018, 5, 1, 1, 50, 40, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "AddPlacements",
                columns: new[] { "ID", "CompMac", "Idloc", "PlaceCode", "PlaceName", "RegDate", "SID", "UId" },
                values: new object[,]
                {
                    { 1, "Null", "Null", "PATH", "Pathology", new DateTime(2018, 4, 15, 3, 21, 16, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, "Null", "Null", "RAD", "Radiology", new DateTime(2018, 4, 15, 3, 21, 16, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 3, "Null", "Null", "OPD", "Outpatient Department", new DateTime(2020, 1, 18, 1, 15, 27, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 4, "Null", "Null", "CSR", "Customer Service Representative", new DateTime(2018, 4, 15, 3, 21, 16, 0, DateTimeKind.Unspecified), 4, 4 },
                    { 5, "Null", "Null", "IT", "Information Technology", new DateTime(2021, 2, 28, 12, 10, 7, 0, DateTimeKind.Unspecified), 5, 5 },
                    { 6, "Null", "Null", "HR", "Human Resources", new DateTime(2018, 4, 15, 3, 21, 16, 0, DateTimeKind.Unspecified), 6, 6 },
                    { 7, "Null", "Null", "IPD", "Inpatient Department", new DateTime(2018, 4, 15, 3, 21, 16, 0, DateTimeKind.Unspecified), 7, 7 },
                    { 8, "Null", "Null", "FIN", "Finance", new DateTime(2018, 4, 15, 3, 21, 16, 0, DateTimeKind.Unspecified), 8, 8 },
                    { 9, "Null", "Null", "MKTG", "Marketing", new DateTime(2018, 4, 15, 3, 21, 16, 0, DateTimeKind.Unspecified), 9, 9 },
                    { 10, "Null", "Null", "SCM", "Supply Chain Management", new DateTime(2018, 4, 15, 3, 21, 16, 0, DateTimeKind.Unspecified), 9, 9 },
                    { 11, "Null", "Null", "MED", "Medical", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "AddSubDeparts",
                columns: new[] { "ID", "CompMac", "Depart", "Idloc", "Location", "RegDate", "SID", "SubDepart", "UId" },
                values: new object[,]
                {
                    { 1, null, "BIOCHEMISTRY", null, "Path", new DateTime(2018, 4, 15, 2, 35, 57, 0, DateTimeKind.Unspecified), 1, "SPECIAL CHEMISTRY", null },
                    { 2, null, "BIOCHEMISTRY", null, "Path", new DateTime(2019, 7, 7, 16, 30, 43, 0, DateTimeKind.Unspecified), 2, "ROUTINE CHEMISTRY", null },
                    { 4, null, "HISTOPATHOLOGY", null, "Path", null, 4, "HISTOPATHOLOGY", null },
                    { 5, null, "MICROBIOLOGY", null, "Path", null, 5, "BACTERIOLOGY", null },
                    { 6, null, "MICROBIOLOGY", null, "Path", null, 6, "PARASITOLOGY", null },
                    { 7, null, "MICROBIOLOGY", null, "Path", null, 7, "SEROLOGY", null },
                    { 8, null, "MOLECULAR PATHOLOGY", null, "Path", null, 8, "MOLECULAR PATHOLOGY", null },
                    { 11, null, "COLOR DOPPLER", null, "Rad", null, 9, "COLOR DOPPLER", null },
                    { 12, null, "CT SCAN", null, "Rad", null, 10, "CT SCAN", null },
                    { 13, null, "MRI", null, "Rad", null, 11, "MRI", null },
                    { 16, null, "ULTRASOUND", null, "Rad", new DateTime(2021, 12, 13, 19, 27, 7, 0, DateTimeKind.Unspecified), 14, "ULTRASOUND", null },
                    { 17, null, "X-RAY", null, "Rad", new DateTime(2021, 12, 13, 19, 27, 7, 0, DateTimeKind.Unspecified), 15, "Xray", null },
                    { 18, null, "MICROBIOLOGY", null, "Path", null, 16, "Culture Sensitivity", null },
                    { 22, null, "MOLECULAR PATHOLOGY", null, "Path", null, 20, "NASAL", null },
                    { 23, null, "MOLECULAR PATHOLOGY", null, "Path", null, 21, "BLOOD", null },
                    { 24, null, "BIOCHEMISTRY", null, "Path", new DateTime(2018, 4, 15, 2, 35, 57, 0, DateTimeKind.Unspecified), 22, "SPECIAL CHEMISTRY / IMMUNOLOGY", null },
                    { 25, null, "BIOCHEMISTRY", null, "PATH", new DateTime(2018, 4, 15, 2, 35, 57, 0, DateTimeKind.Unspecified), 23, "SPECIAL CHEMISTRY / OUT SIDE", null },
                    { 26, null, "HISTOPATHOLOGY", null, "PATH", new DateTime(2020, 7, 15, 0, 15, 1, 0, DateTimeKind.Unspecified), 24, "CYTOLOGY", null },
                    { 27, null, "BIOCHEMISTRY", null, "Path", new DateTime(2018, 4, 15, 2, 35, 57, 0, DateTimeKind.Unspecified), 25, "SPECIAL CHEMISTRY / IMMUNOLOGY / OUT SIDE", null },
                    { 28, null, "HEMATOLOGY", null, "Path", null, 26, "HEMATOLOGY", null },
                    { 29, null, "IT", null, "IT", new DateTime(2021, 2, 2, 21, 15, 19, 0, DateTimeKind.Unspecified), 27, "Operation and Maintenance", null },
                    { 31, null, "IT", null, "IT", new DateTime(2021, 5, 11, 12, 31, 38, 0, DateTimeKind.Unspecified), 29, "Infrastructure Department", null },
                    { 34, null, "Sonology", null, "Rad", new DateTime(2021, 5, 12, 14, 21, 14, 0, DateTimeKind.Unspecified), 32, "Sonology", null },
                    { 35, null, "Mancom", null, "Rad", null, 32, "Mancom", null },
                    { 40, null, "IT", null, "IT", new DateTime(2021, 5, 11, 12, 31, 38, 0, DateTimeKind.Unspecified), 37, "Governance", null },
                    { 71, null, "PHYSIOLOGY", null, "Rad", new DateTime(2018, 4, 15, 2, 35, 57, 0, DateTimeKind.Unspecified), 68, "PHYSIOLOGY", null },
                    { 72, null, "IT", null, "IT", new DateTime(2021, 2, 2, 21, 15, 19, 0, DateTimeKind.Unspecified), 69, "Software Development", null },
                    { 75, null, "Distribution", null, "PATH", new DateTime(2021, 12, 27, 19, 39, 29, 0, DateTimeKind.Unspecified), 70, "Routine Dispatch", null },
                    { 76, null, "Distribution", null, "PATH", new DateTime(2021, 12, 27, 19, 39, 29, 0, DateTimeKind.Unspecified), 71, "Bulk Dispatch", null },
                    { 79, null, "Admin", null, "PATH", new DateTime(2021, 5, 10, 16, 13, 47, 0, DateTimeKind.Unspecified), 74, "Transport", null },
                    { 115, null, "Consultancy", null, "OPD", new DateTime(2021, 12, 16, 4, 29, 48, 0, DateTimeKind.Unspecified), 1, "Diabetes", null },
                    { 116, null, "Consultancy", null, "OPD", new DateTime(2021, 12, 16, 4, 29, 48, 0, DateTimeKind.Unspecified), 2, "Cardiology", null },
                    { 117, null, "Consultancy", null, "OPD", new DateTime(2021, 12, 16, 4, 29, 48, 0, DateTimeKind.Unspecified), 3, "ENT", null },
                    { 118, null, "RMO", null, "OPD", new DateTime(2021, 12, 16, 4, 29, 48, 0, DateTimeKind.Unspecified), 4, "General", null },
                    { 119, null, "Services", null, "OPD", new DateTime(2021, 12, 16, 4, 29, 48, 0, DateTimeKind.Unspecified), 5, "Services", null },
                    { 120, null, "Gynee", null, "IPD", new DateTime(2021, 12, 16, 4, 34, 19, 0, DateTimeKind.Unspecified), 6, "Operation", null },
                    { 121, null, "Gynee", null, "IPD", new DateTime(2021, 12, 16, 4, 41, 43, 0, DateTimeKind.Unspecified), 7, "Labour Room", null },
                    { 122, null, "NICU", null, "IPD", new DateTime(2021, 12, 16, 4, 46, 33, 0, DateTimeKind.Unspecified), 8, "Observation", null },
                    { 123, null, "NICU", null, "IPD", new DateTime(2021, 12, 16, 4, 46, 33, 0, DateTimeKind.Unspecified), 9, "Admission", null },
                    { 124, null, "Consultancy", null, "OPD", new DateTime(2021, 12, 16, 4, 46, 33, 0, DateTimeKind.Unspecified), 10, "Gynecology", null },
                    { 125, null, "Consultancy", null, "OPD", new DateTime(2021, 12, 16, 4, 46, 33, 0, DateTimeKind.Unspecified), 11, "Dentist", null },
                    { 126, null, "Consultancy", null, "OPD", new DateTime(2022, 1, 15, 12, 51, 45, 0, DateTimeKind.Unspecified), 12, "General", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddDeparts");

            migrationBuilder.DropTable(
                name: "AddDesignations");

            migrationBuilder.DropTable(
                name: "AddPlacements");

            migrationBuilder.DropTable(
                name: "AddSubDeparts");

            migrationBuilder.DeleteData(
                table: "AddConnLabs",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AddLocations",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Idloc",
                table: "AddConnLabs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompMac",
                table: "AddConnLabs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
