using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdvLab_WebApp.Migrations
{
    /// <inheritdoc />
    public partial class updatetableMultitableforreception : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DescCashiers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CpName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InvNo = table.Column<int>(type: "int", nullable: true),
                    MRNO = table.Column<int>(type: "int", nullable: true),
                    LabNo = table.Column<int>(type: "int", nullable: true),
                    CpNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientID = table.Column<int>(type: "int", nullable: true),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrossA = table.Column<double>(type: "float", nullable: true),
                    DiscPer = table.Column<double>(type: "float", nullable: true),
                    Discount = table.Column<double>(type: "float", nullable: true),
                    TotalA = table.Column<double>(type: "float", nullable: true),
                    PaidA = table.Column<double>(type: "float", nullable: true),
                    BlanceA = table.Column<double>(type: "float", nullable: true),
                    PaymentMode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditCardNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxN = table.Column<double>(type: "float", nullable: true),
                    TestCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UId = table.Column<int>(type: "int", nullable: true),
                    Uname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idloc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RbalanceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RbalanceA = table.Column<double>(type: "float", nullable: true),
                    RUId1 = table.Column<int>(type: "int", nullable: true),
                    RUname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RIdloc1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentB = table.Column<double>(type: "float", nullable: true),
                    BillNo = table.Column<int>(type: "int", nullable: true),
                    F_VNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RV1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pwd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvoiceSMS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DortocSMS = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescCashiers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DescLabs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CpName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BarcodeNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvNo = table.Column<int>(type: "int", nullable: true),
                    MRNO = table.Column<int>(type: "int", nullable: true),
                    LabNo = table.Column<int>(type: "int", nullable: true),
                    CpNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DescID = table.Column<int>(type: "int", nullable: true),
                    TestCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportHeading = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RepDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Charges = table.Column<int>(type: "int", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Placement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Depart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubDepart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UId = table.Column<int>(type: "int", nullable: true),
                    Uname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idloc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescLabs", x => x.ID);
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
                name: "PatRegs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MrNo = table.Column<int>(type: "int", nullable: true),
                    Initial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Relation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DBO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CINCNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PPNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UId = table.Column<int>(type: "int", nullable: true),
                    Uname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Idloc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompMac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatRegs", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DescCashiers");

            migrationBuilder.DropTable(
                name: "DescLabs");

            migrationBuilder.DropTable(
                name: "DescQs");

            migrationBuilder.DropTable(
                name: "DuesRecQs");

            migrationBuilder.DropTable(
                name: "PatRegs");
        }
    }
}
