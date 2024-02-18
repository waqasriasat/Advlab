using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdvLab_WebApp.Migrations
{
    /// <inheritdoc />
    public partial class addtemptableuserlist2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoleName",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Depart",
                table: "AddSubDeparts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrystalReportPaths");

            migrationBuilder.AddColumn<string>(
                name: "RoleName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Depart",
                table: "AddSubDeparts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
