using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdvLab_WebApi.Migrations
{
    /// <inheritdoc />
    public partial class updatewithmultitablewithRowData3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "CrystalReportPaths",
                columns: new[] { "id", "CNL", "CrystalReport", "DefaultClient", "Loc", "Password", "UserName", "db", "server" },
                values: new object[] { 1, "MAIN-LAB", "\\192.168.73.3\\ALAB Reports\\", "SELF", "NKM", "M89.SolutioN", "sa", "AdvancedLab", "AdvancedLab" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrystalReportPaths");
        }
    }
}
