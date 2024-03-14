using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AdvLab_WebApi.Migrations
{
    /// <inheritdoc />
    public partial class updatedabase3112024111 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccessRights",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SOR = table.Column<int>(type: "int", nullable: true),
                    EmpID = table.Column<int>(type: "int", nullable: true),
                    Assigning = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessRights", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AddClients",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CID = table.Column<int>(type: "int", nullable: false),
                    CName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientActive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PerA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pwd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceChangabletrue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CCont = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inc_Routine = table.Column<double>(type: "float", nullable: false),
                    Inc_Special = table.Column<double>(type: "float", nullable: false),
                    Inc_NoDisc = table.Column<double>(type: "float", nullable: false),
                    Inc_Xray = table.Column<double>(type: "float", nullable: false),
                    Inc_Ultra = table.Column<double>(type: "float", nullable: false),
                    Inc_Ctscan = table.Column<double>(type: "float", nullable: false),
                    Inc_Mri = table.Column<double>(type: "float", nullable: false),
                    Inc_Echo = table.Column<double>(type: "float", nullable: false),
                    Inc_Ecg = table.Column<double>(type: "float", nullable: false),
                    Inc_Cdopler = table.Column<double>(type: "float", nullable: false),
                    UId = table.Column<int>(type: "int", nullable: false),
                    BDO = table.Column<int>(type: "int", nullable: false),
                    BusinessType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientInstraction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PAWC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dsc_Routine = table.Column<double>(type: "float", nullable: false),
                    Dsc_Special = table.Column<double>(type: "float", nullable: false),
                    Dsc_NoDisc = table.Column<double>(type: "float", nullable: false),
                    Dsc_Xray = table.Column<double>(type: "float", nullable: false),
                    Dsc_Ultra = table.Column<double>(type: "float", nullable: false),
                    Dsc_Ctscan = table.Column<double>(type: "float", nullable: false),
                    Dsc_Mri = table.Column<double>(type: "float", nullable: false),
                    Dsc_Echo = table.Column<double>(type: "float", nullable: false),
                    Dsc_Ecg = table.Column<double>(type: "float", nullable: false),
                    Dsc_Cdopler = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddClients", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AddConnLabs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocActive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocID = table.Column<int>(type: "int", nullable: true),
                    LocCate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UId = table.Column<int>(type: "int", nullable: true),
                    Idloc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompMac = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddConnLabs", x => x.ID);
                });

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
                name: "AddLocations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocActive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocID = table.Column<int>(type: "int", nullable: true),
                    LocCate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reconsile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocSno = table.Column<int>(type: "int", nullable: true),
                    UId = table.Column<int>(type: "int", nullable: true),
                    Idloc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompMac = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddLocations", x => x.ID);
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

            migrationBuilder.CreateTable(
                name: "CrystalReportPaths",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrystalReport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    db = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    server = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Loc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultClient = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrystalReportPaths", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DescQs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationNo = table.Column<int>(type: "int", nullable: true),
                    CpNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CpName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UId = table.Column<int>(type: "int", nullable: true),
                    Uname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idloc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescQs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DuesRecQs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LabNo = table.Column<int>(type: "int", nullable: true),
                    AmountRec = table.Column<double>(type: "float", nullable: true),
                    ActionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UId = table.Column<int>(type: "int", nullable: true),
                    Uname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idloc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DuesRecQs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "LoginLogs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    logDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MacAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoginStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginLogs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PatReg_Shortkeys",
                columns: table => new
                {
                    Sno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Initial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Relation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Years = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatReg_Shortkeys", x => x.Sno);
                });

            migrationBuilder.CreateTable(
                name: "PatRegs",
                columns: table => new
                {
                    MRNO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Initial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Relation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    AgeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DBO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UId = table.Column<int>(type: "int", nullable: false),
                    Idloc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatRegs", x => x.MRNO);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginStatusIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginStatusComp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NSend = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmpID = table.Column<int>(type: "int", nullable: true),
                    UName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Depart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubDepart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Placement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UId = table.Column<int>(type: "int", nullable: true),
                    Idloc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompMac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PayGenerate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleID = table.Column<int>(type: "int", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DescCashiers",
                columns: table => new
                {
                    LabNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MRNO = table.Column<int>(type: "int", nullable: false),
                    CpName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CpNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrossA = table.Column<double>(type: "float", nullable: false),
                    DiscPer = table.Column<double>(type: "float", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    TotalA = table.Column<double>(type: "float", nullable: false),
                    PaidA = table.Column<double>(type: "float", nullable: false),
                    BlanceA = table.Column<double>(type: "float", nullable: false),
                    PaymentMode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditCardNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxN = table.Column<double>(type: "float", nullable: false),
                    TestCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UId = table.Column<int>(type: "int", nullable: false),
                    Idloc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RbalanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RbalanceA = table.Column<double>(type: "float", nullable: false),
                    RUId1 = table.Column<int>(type: "int", nullable: false),
                    RIdloc1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentB = table.Column<double>(type: "float", nullable: false),
                    BillNo = table.Column<int>(type: "int", nullable: false),
                    F_VNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RV1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pwd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvoiceSMS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DortocSMS = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescCashiers", x => x.LabNo);
                    table.ForeignKey(
                        name: "FK_DescCashiers_PatRegs_MRNO",
                        column: x => x.MRNO,
                        principalTable: "PatRegs",
                        principalColumn: "MRNO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DescLabs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LabNo = table.Column<int>(type: "int", nullable: false),
                    BarcodeNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescID = table.Column<int>(type: "int", nullable: false),
                    RepDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Charges = table.Column<int>(type: "int", nullable: false),
                    DStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescLabs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DescLabs_DescCashiers_LabNo",
                        column: x => x.LabNo,
                        principalTable: "DescCashiers",
                        principalColumn: "LabNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AccessRights",
                columns: new[] { "ID", "Assigning", "EmpID", "SOR" },
                values: new object[,]
                {
                    { 1, "Deshboard Header Administrator", 1, 1 },
                    { 2, "Deshboard Header Order Booking", 1, 2 },
                    { 3, "Deshboard Header Pathology", 1, 5 },
                    { 4, "Deshboard Header Radiology", 1, 6 },
                    { 5, "Deshboard Header User Information", 1, 7 },
                    { 6, "Deshboard Header Human Resources", 1, 8 },
                    { 7, "Deshboard Header OPD", 1, 12 },
                    { 8, "Deshboard Header SMS", 1, 15 },
                    { 9, "Deshboard Header Loyalti", 1, 19 },
                    { 10, "Deshboard Header Marketing", 1, 21 },
                    { 11, "Deshboard Header CSR", 1, 22 },
                    { 12, "Deshboard Header Company Deshboard", 1, 25 },
                    { 13, "Administrator MenuStrip Employee Information", 1, 51 },
                    { 14, "Administrator MenuStrip Client Registration", 1, 52 },
                    { 15, "Administrator MenuStrip Change Reporting Date", 1, 53 },
                    { 16, "Administrator MenuStrip Panal Dues Received", 1, 54 },
                    { 17, "Administrator MenuStrip Expenses", 1, 55 },
                    { 18, "Administrator MenuStrip Admin LOV", 1, 56 },
                    { 19, "Administrator MenuStrip Department LOV", 1, 57 },
                    { 20, "Administrator MenuStrip Pateint Payment Refund", 1, 58 },
                    { 21, "Administrator MenuStrip Description Cancellation", 1, 59 },
                    { 22, "Administrator MenuStrip My Company Detail", 1, 60 },
                    { 23, "Administrator MenuStrip Check Out List", 1, 61 },
                    { 24, "Administrator MenuStrip Finance Report", 1, 62 },
                    { 25, "Finance Report TextBox Location", 1, 64 },
                    { 26, "Administrator MenuStrip Change to Client", 1, 65 },
                    { 27, "Administrator MenuStrip User Summary", 1, 66 },
                    { 28, "Administrator MenuStrip Pdf Regenerate", 1, 67 },
                    { 29, "Administrator MenuStrip Invoices Update Log", 1, 68 },
                    { 30, "Administrator MenuStrip Report Forword to ERM", 1, 69 },
                    { 31, "Administrator MenuStrip Adjust Sample CNL", 1, 76 },
                    { 32, "Administrator MenuStrip Cancellation Update", 1, 80 },
                    { 33, "Administrator MenuStrip OTP", 1, 82 },
                    { 34, "Administrator MenuStrip Manual Editing", 1, 83 },
                    { 35, "Administrator MenuStrip Add Client Approval", 1, 85 },
                    { 36, "Administrator MenuStrip Add User Approval", 1, 86 },
                    { 37, "Administrator MenuStrip Bulk Sample Transfer", 1, 89 },
                    { 38, "Administrator MenuStrip Franchise Client Registration", 1, 92 },
                    { 39, "Administrator MenuStrip Interlink Management", 1, 93 },
                    { 40, "AdminLOV MenuStrip Add Status", 1, 101 },
                    { 41, "AdminLOV MenuStrip Add Location", 1, 102 },
                    { 42, "AdminLOV MenuStrip Add Description", 1, 103 },
                    { 43, "AdminLOV MenuStrip Add Depart", 1, 104 },
                    { 44, "AdminLOV MenuStrip Add SubDepart", 1, 105 },
                    { 45, "AdminLOV MenuStrip Add Consultant", 1, 106 },
                    { 46, "AdminLOV MenuStrip Add Section", 1, 107 },
                    { 47, "AdminLOV MenuStrip Add Place", 1, 108 },
                    { 48, "AdminLOV MenuStrip Add Place Category", 1, 109 },
                    { 49, "AdminLOV MenuStrip Add Designation", 1, 110 },
                    { 50, "AdminLOV MenuStrip Add Expenser Name", 1, 111 },
                    { 51, "AdminLOV MenuStrip Add Expenses Purpose", 1, 112 },
                    { 52, "AdminLOV MenuStrip Add Connecting Lab", 1, 113 },
                    { 53, "AdminLOV MenuStrip Add Other Lab Send Sample", 1, 114 },
                    { 54, "AdminLOV MenuStrip Add Discount Athorities", 1, 115 },
                    { 55, "AdminLOV MenuStrip Add Editable Athorities", 1, 116 },
                    { 56, "AdminLOV MenuStrip Add Balance Athorities", 1, 117 },
                    { 57, "AdminLOV MenuStrip Invoice Update of New RateList", 1, 118 },
                    { 58, "AdminLOV MenuStrip Add Location Athorities", 1, 120 },
                    { 59, "AdminLOV MenuStrip Add Country", 1, 121 },
                    { 60, "AdminLOV MenuStrip Add City", 1, 122 },
                    { 61, "AdminLOV MenuStrip Add Area", 1, 123 },
                    { 62, "AdminLOV MenuStrip Add DrStamp", 1, 124 },
                    { 63, "Department LOV MenuStrip Add Page LOV", 1, 151 },
                    { 64, "Department LOV MenuStrip Add Culture Short Key", 1, 152 },
                    { 65, "Department LOV MenuStrip Change Description Setting", 1, 155 },
                    { 66, "Order Booking MenuStrip Main Reception", 1, 201 },
                    { 67, "Order Booking MenuStrip Report Status", 1, 203 },
                    { 68, "Order Booking MenuStrip Summary Status", 1, 204 },
                    { 69, "Order Booking MenuStrip Rate Slip", 1, 205 },
                    { 70, "Order Booking MenuStrip OPD Reception", 1, 209 },
                    { 71, "Order Booking MenuStrip Appointment Registration", 1, 210 },
                    { 72, "Order Booking MenuStrip Appointment Status", 1, 211 },
                    { 73, "Order Booking MenuStrip Government Summary For Covid", 1, 212 },
                    { 74, "Order Booking MenuStrip Make Client PDFs", 1, 213 },
                    { 75, "Order Booking MenuStrip Resource Request Form", 1, 216 },
                    { 76, "Order Editing MenuStrip Edit Flight Detail", 1, 225 },
                    { 77, "Order Editing MenuStrip Edit Cash Detail", 1, 226 },
                    { 78, "Order Editing MenuStrip Edit Client Detail", 1, 227 },
                    { 79, "Patient Registration Button Edit", 1, 240 },
                    { 80, "Pathology MenuStrip Phlebotomy Acknowledge", 1, 351 },
                    { 81, "Pathology MenuStrip Section Acknowledge", 1, 352 },
                    { 82, "Pathology MenuStrip Batch Generate", 1, 353 },
                    { 83, "Pathology MenuStrip Batch Received", 1, 354 },
                    { 84, "Pathology MenuStrip Pathology Reporting", 1, 355 },
                    { 85, "Pathology MenuStrip Serological Reporting", 1, 356 },
                    { 86, "Pathology MenuStrip Molecular Pathology", 1, 357 },
                    { 87, "Pathology MenuStrip Send Sample", 1, 358 },
                    { 88, "Pathology MenuStrip True Follow Acknowlegdement", 1, 359 },
                    { 89, "Pathology MenuStrip Select a Change Status", 1, 370 },
                    { 90, "Pathology MenuStrip Lab Number Release", 1, 371 },
                    { 91, "Pathology MenuStrip Average Report", 1, 372 },
                    { 92, "Pathology MenuStrip Home Sample Received", 1, 373 },
                    { 93, "Pathology MenuStrip Sample Tracking System", 1, 376 },
                    { 94, "Pathology MenuStrip Sample Rejection", 1, 379 },
                    { 95, "Radiology MenuStrip Radiology Reporting", 1, 402 },
                    { 96, "Radiology MenuStrip Average Report", 1, 403 },
                    { 97, "User Information MenuStrip User Registration", 1, 451 },
                    { 98, "User Information MenuStrip Again Login", 1, 452 },
                    { 99, "User Information MenuStrip Change Password", 1, 453 },
                    { 100, "Human Resources MenuStrip Attendance Record", 1, 501 },
                    { 101, "Human Resources MenuStrip Add Salary", 1, 502 },
                    { 102, "Human Resources MenuStrip Pay Slip Print", 1, 503 },
                    { 103, "Human Resources MenuStrip Add Loan Deducation", 1, 504 },
                    { 104, "Human Resources MenuStrip Add Holiday", 1, 505 },
                    { 105, "Human Resources MenuStrip Generate Pay Slip", 1, 506 },
                    { 106, "Connectivity MenuStrip Crystal Report Path", 1, 507 },
                    { 107, "Human Resources MenuStrip Add Leave", 1, 510 },
                    { 108, "Attendance Record TextBox Location", 1, 520 },
                    { 109, "Human Resources MenuStrip Thumb Attendance Record", 1, 521 },
                    { 110, "Pateint Cancellation Button Find", 1, 561 },
                    { 111, "Pateint Cancellation Button Update", 1, 562 },
                    { 112, "Pateint Cancellation Button Print", 1, 563 },
                    { 113, "User Summary TextBox User ID Box", 1, 564 },
                    { 114, "Pateint Payment Refund Button Find", 1, 601 },
                    { 115, "Pateint Payment Refund Button Update", 1, 602 },
                    { 116, "Pateint Payment Refund Button Print", 1, 603 },
                    { 117, "Employee Personal Information Button Find", 1, 651 },
                    { 118, "Employee Personal Information Button Save", 1, 652 },
                    { 119, "Employee Personal Information Button Print", 1, 653 },
                    { 120, "Employee Personal Information Button Edit", 1, 654 },
                    { 121, "Client Registration Button Find", 1, 701 },
                    { 122, "Client Registration Button Save", 1, 702 },
                    { 123, "Client Registration Button Print", 1, 703 },
                    { 124, "Client Registration Button Edit", 1, 704 },
                    { 125, "Client Registration Button Desc Link Visiable", 1, 705 },
                    { 126, "Client Registration CheckBox Price Change Visiable", 1, 706 },
                    { 127, "Client Registration TextBox Location", 1, 707 },
                    { 128, "Add Client Description Button Find", 1, 751 },
                    { 129, "Add Client Description Button Save", 1, 752 },
                    { 130, "Add Client Description Button Print", 1, 753 },
                    { 131, "Add Client Description Button Edit", 1, 754 },
                    { 132, "Add Client Description Button Apply", 1, 755 },
                    { 133, "Add Client Description Button Forword", 1, 756 },
                    { 134, "Add Client Description Button Selected All", 1, 757 },
                    { 135, "Add Client Description Button Selected None", 1, 758 },
                    { 136, "Main Reception Button Find", 1, 801 },
                    { 137, "Main Reception Button Save", 1, 802 },
                    { 138, "Main Reception Button Apply", 1, 803 },
                    { 139, "Main Reception Button Edit", 1, 804 },
                    { 140, "Main Reception Button Update", 1, 805 },
                    { 141, "Main Reception Button Print", 1, 806 },
                    { 142, "Main Reception Button Barcode", 1, 807 },
                    { 143, "Main Reception ComboBox DiscBox", 1, 808 },
                    { 144, "Main Reception Button Delete", 1, 810 },
                    { 145, "Blood Bank Reception Button Barcode", 1, 851 },
                    { 146, "Blood Bank Reception Button Save", 1, 852 },
                    { 147, "Blood Bank Reception Button Edit", 1, 853 },
                    { 148, "Blood Bank Reception Button Update", 1, 854 },
                    { 149, "Blood Bank Reception Button Print", 1, 855 },
                    { 150, "Report Status Button Print", 1, 901 },
                    { 151, "Report Status Button PrintView", 1, 902 },
                    { 152, "Summary Status TextBox Location", 1, 951 },
                    { 153, "Summary Status TextBox Department", 1, 952 },
                    { 154, "Summary Status TextBox Placement", 1, 953 },
                    { 155, "Summary Status Button Department DataEntry Sheet", 1, 954 },
                    { 156, "Summary Status TextBox Client Name", 1, 955 },
                    { 157, "Summary Status TextBox User Name", 1, 956 },
                    { 158, "Reporting Procedure Button Save", 1, 1001 },
                    { 159, "Reporting Procedure Button Perform", 1, 1002 },
                    { 160, "Reporting Procedure Button Forword", 1, 1004 },
                    { 161, "Reporting Procedure Button Partially Verification", 1, 1005 },
                    { 162, "Reporting Procedure TextBox Department", 1, 1006 },
                    { 163, "Pharmacy Reception Button Save", 1, 1051 },
                    { 164, "Pharmacy Reception Button Edit", 1, 1052 },
                    { 165, "Pharmacy Reception Button Print", 1, 1053 },
                    { 166, "Serological Reporting Button Perform", 1, 1101 },
                    { 167, "Serological Reporting Button Save", 1, 1102 },
                    { 168, "Serological Reporting Button Forword", 1, 1103 },
                    { 169, "Serological Reporting Button Partially Verification", 1, 1104 },
                    { 170, "Serological Reporting TextBox Department", 1, 1105 },
                    { 171, "Serological Reporting TextBox Location", 1, 1106 },
                    { 172, "Molecular Pathology Button Perform", 1, 1151 },
                    { 173, "Molecular Pathology Button Save", 1, 1152 },
                    { 174, "Molecular Pathology Button Forword", 1, 1153 },
                    { 175, "Molecular Pathology Button Partially Verification", 1, 1154 },
                    { 176, "Molecular Pathology TextBox Department", 1, 1155 },
                    { 177, "Molecular Pathology TextBox Location", 1, 1156 },
                    { 178, "Pathology Reporting Button Perform", 1, 1201 },
                    { 179, "Pathology Reporting Button Final Verification", 1, 1202 },
                    { 180, "Pathology Reporting Button Hold", 1, 1203 },
                    { 181, "Pathology Reporting Button Partially Verification", 1, 1204 },
                    { 182, "Pathology Reporting TextBox Department", 1, 1205 },
                    { 183, "Pathology Reporting TextBox Location", 1, 1206 },
                    { 184, "Pathology Reporting Button Result Delete", 1, 1207 },
                    { 185, "Pathology Reporting Button Save", 1, 1210 },
                    { 186, "Pathology Reporting TextBox CNL", 1, 1212 },
                    { 187, "CultureSensitivity Button Save", 1, 1251 },
                    { 188, "CultureSensitivity Button Perform", 1, 1252 },
                    { 189, "CultureSensitivity Button Forword", 1, 1253 },
                    { 190, "CultureSensitivity Button Partially Verification", 1, 1254 },
                    { 191, "CultureSensitivity Button Delete Gram Stain", 1, 1255 },
                    { 192, "CultureSensitivity Button Delete Orgnasium", 1, 1256 },
                    { 193, "CultureSensitivity Button Delete Medician", 1, 1257 },
                    { 194, "Average Report TextBox Location", 1, 1258 },
                    { 195, "Average Report TextBox Department", 1, 1259 },
                    { 196, "Average Report TextBox Sub Department", 1, 1260 },
                    { 197, "RadiologyReporting Button Final Verification", 1, 1301 },
                    { 198, "RadiologyReporting Button Hold", 1, 1302 },
                    { 199, "RadiologyReporting TextBox Department", 1, 1305 },
                    { 200, "RadiologyReporting TextBox Location", 1, 1306 },
                    { 201, "RadiologyReporting Button Result Delete", 1, 1307 },
                    { 202, "Ultrasound All Button Save", 1, 1351 },
                    { 203, "Ultrasound FWB Button Save", 1, 1401 },
                    { 204, "Xray Button Save", 1, 1451 },
                    { 205, "Chart of Account MenuStrip Vouchers", 1, 1501 },
                    { 206, "Chart of Account MenuStrip Add Head of Account", 1, 1502 },
                    { 207, "Chart of Account MenuStrip Report Summary", 1, 1503 },
                    { 208, "Inventory MenuStrip Delivery", 1, 1550 },
                    { 209, "Inventory MenuStrip Request", 1, 1551 },
                    { 210, "Inventory MenuStrip Status Book", 1, 1552 },
                    { 211, "Inventory MenuStrip General Stock", 1, 1553 },
                    { 212, "Inventory MenuStrip Medical Stock", 1, 1554 },
                    { 213, "Inventory MenuStrip Manual Barcode", 1, 1555 },
                    { 214, "Inventory MenuStrip Accountibility", 1, 1556 },
                    { 215, "Inventory MenuStrip Add Product", 1, 1557 },
                    { 216, "Inventory MenuStrip Opening Balance", 1, 1558 },
                    { 217, "Inventory MenuStrip Activity Report", 1, 1559 },
                    { 218, "Inventory MenuStrip Stock Report", 1, 1560 },
                    { 219, "Setting MenuStrip System Configration", 1, 1600 },
                    { 220, "OPD MenuStrip OPD Reporting", 1, 1650 },
                    { 221, "Expenses Button Edit", 1, 1651 },
                    { 222, "Expenses TextBox Date", 1, 1652 },
                    { 223, "Expenses Button Delete", 1, 1653 },
                    { 224, "HistoPathology Button Perform", 1, 1700 },
                    { 225, "Section Acknowlegde Button Pending", 1, 1750 },
                    { 226, "Section Acknowlegde Button Section Ack", 1, 1751 },
                    { 227, "Phlebotomy Acknowledge Button Pending", 1, 1801 },
                    { 228, "Batch Received Button Pending", 1, 1850 },
                    { 229, "Batch Received Button Batch Received", 1, 1851 },
                    { 230, "Batch Generate Button Pending", 1, 1901 },
                    { 231, "Batch Generate Button Batch Generate", 1, 1902 },
                    { 232, "Check Out TextBox UserID", 1, 1952 },
                    { 233, "Check Out TextBox Location", 1, 1953 },
                    { 234, "SMS MenuStrip Setting", 1, 2001 },
                    { 235, "SMS MenuStrip SMS Sender", 1, 2002 },
                    { 236, "SMS MenuStrip Empolyee SMS", 1, 2003 },
                    { 237, "Purchase MenuStrip Request", 1, 2400 },
                    { 238, "Purchase MenuStrip Order", 1, 2401 },
                    { 239, "Purchase MenuStrip Vendor Registration", 1, 2402 },
                    { 240, "Vendor Registration MenuStrip Add Vendor", 1, 2403 },
                    { 241, "Loyalti MenuStrip Company Setup", 1, 2451 },
                    { 242, "Loyalti MenuStrip Card Setup", 1, 2452 },
                    { 243, "Marketing TextBox User or Location", 1, 2501 }
                });

            migrationBuilder.InsertData(
                table: "AddConnLabs",
                columns: new[] { "ID", "CompMac", "Idloc", "LocActive", "LocCate", "LocID", "Location", "RegDate", "UId" },
                values: new object[] { 5, null, null, "Yes", "MAIN-LAB", 1, "MAIN-LAB", new DateTime(2019, 3, 25, 11, 43, 59, 0, DateTimeKind.Unspecified), null });

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
                values: new object[] { 1, "FB: Address Contact", "NKM", "Yes", "Main", 10150121, 0, "Main", "Active", new DateTime(2018, 5, 1, 1, 50, 40, 0, DateTimeKind.Unspecified), 1 });

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

            migrationBuilder.InsertData(
                table: "CrystalReportPaths",
                columns: new[] { "id", "CNL", "CrystalReport", "DefaultClient", "Loc", "Password", "UserName", "db", "server" },
                values: new object[] { 1, "MAIN-LAB", "\\192.168.73.3\\ALAB Reports\\", "SELF", "Main", "M89.SolutioN", "sa", "AdvancedLab", "AdvancedLab" });

            migrationBuilder.InsertData(
                table: "PatReg_Shortkeys",
                columns: new[] { "Sno", "Gender", "Initial", "Relation", "Years" },
                values: new object[,]
                {
                    { 1, "MALE", "MR", "S/O", "YEARS" },
                    { 2, "FEMALE", "MRS", "W/O", "YEARS" },
                    { 3, "FEMALE", "MISS", "D/O", "YEARS" },
                    { 4, "MALE", "MASTER", "S/O", "" },
                    { 5, "FEMALE", "BABY", "D/O", "" },
                    { 6, "FEMALE", "MS", "D/O", "" },
                    { 7, "", "DR", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "RoleName" },
                values: new object[,]
                {
                    { 1, "Receptionist" },
                    { 2, "Phlebotomist" },
                    { 3, "Receptionist + Phlebotomist" },
                    { 4, "Dispatcher" },
                    { 5, "Medical Technologist" },
                    { 6, "Lab Technician" },
                    { 7, "Lab Manager" },
                    { 8, "Branch Manager" },
                    { 9, "Regional Manager" },
                    { 10, "Pathologist" },
                    { 11, "Human Resource" },
                    { 12, "Accountant" },
                    { 13, "Finance" },
                    { 14, "General Manager" },
                    { 15, "Administrator" },
                    { 16, "CEO" },
                    { 17, "Director" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CNL", "ClientV", "CompMac", "Depart", "Designation", "EmpID", "Idloc", "Location", "LoginStatus", "LoginStatusComp", "LoginStatusIP", "NSend", "PayGenerate", "Place", "PlaceCategory", "Placement", "RegDate", "RoleID", "Status", "SubDepart", "Token", "UId", "UName", "UPassword" },
                values: new object[] { 1, "MAIN-LAB", "Main", "Null", "All", "IT", 1, "Main", "Main", "No", "Null", "Null", "No", "No", "Null", "Null", "Path", null, 17, "Yes", "All", "Null", null, "Admin", "admin@786" });

            migrationBuilder.CreateIndex(
                name: "IX_DescCashiers_MRNO",
                table: "DescCashiers",
                column: "MRNO");

            migrationBuilder.CreateIndex(
                name: "IX_DescLabs_LabNo",
                table: "DescLabs",
                column: "LabNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessRights");

            migrationBuilder.DropTable(
                name: "AddClients");

            migrationBuilder.DropTable(
                name: "AddConnLabs");

            migrationBuilder.DropTable(
                name: "AddDeparts");

            migrationBuilder.DropTable(
                name: "AddDesignations");

            migrationBuilder.DropTable(
                name: "AddLocations");

            migrationBuilder.DropTable(
                name: "AddPlacements");

            migrationBuilder.DropTable(
                name: "AddSubDeparts");

            migrationBuilder.DropTable(
                name: "CrystalReportPaths");

            migrationBuilder.DropTable(
                name: "DescLabs");

            migrationBuilder.DropTable(
                name: "DescQs");

            migrationBuilder.DropTable(
                name: "DuesRecQs");

            migrationBuilder.DropTable(
                name: "LoginLogs");

            migrationBuilder.DropTable(
                name: "PatReg_Shortkeys");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "DescCashiers");

            migrationBuilder.DropTable(
                name: "PatRegs");
        }
    }
}
