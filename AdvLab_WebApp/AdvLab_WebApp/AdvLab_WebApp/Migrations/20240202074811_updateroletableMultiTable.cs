using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdvLab_WebApp.Migrations
{
    /// <inheritdoc />
    public partial class updateroletableMultiTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
