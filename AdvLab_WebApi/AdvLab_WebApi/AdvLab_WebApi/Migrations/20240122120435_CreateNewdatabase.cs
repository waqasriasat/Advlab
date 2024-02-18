using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdvLab_WebApi.Migrations
{
    /// <inheritdoc />
    public partial class CreateNewdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoginStatusIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoginStatusComp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NSend = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmpID = table.Column<int>(type: "int", nullable: false),
                    UName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Depart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubDepart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Placement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UId = table.Column<int>(type: "int", nullable: true),
                    Idloc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompMac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PayGenerate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CNL", "ClientV", "CompMac", "Depart", "Designation", "EmpID", "Idloc", "Location", "LoginStatus", "LoginStatusComp", "LoginStatusIP", "NSend", "PayGenerate", "Place", "PlaceCategory", "Placement", "RegDate", "RoleID", "Status", "SubDepart", "UId", "UName", "UPassword" },
                values: new object[] { 1, "MAIN-LAB", "Main", "Null", "All", "IT", 1, "Main", "Main", "No", "Null", "Null", "No", "No", "Null", "Null", "Path", null, 17, "Yes", "All", null, "Admin", "admin@786" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
