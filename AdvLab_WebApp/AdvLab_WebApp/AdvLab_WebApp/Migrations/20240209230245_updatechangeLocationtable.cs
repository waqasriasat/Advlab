using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdvLab_WebApp.Migrations
{
    /// <inheritdoc />
    public partial class updatechangeLocationtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChangePasswords",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false),
                    CurrentPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmNewPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChangePasswords");
        }
    }
}
