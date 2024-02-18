using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdvLab_WebApi.Migrations
{
    /// <inheritdoc />
    public partial class updateuserTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Idloc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompMac = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddConnLabs", x => x.ID);
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddConnLabs");

            migrationBuilder.DropTable(
                name: "AddLocations");

            migrationBuilder.DropTable(
                name: "LoginLogs");
        }
    }
}
