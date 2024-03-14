using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdvLab_WebApp.Migrations
{
    /// <inheritdoc />
    public partial class updatedabase31120241210 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddClients");
        }
    }
}
