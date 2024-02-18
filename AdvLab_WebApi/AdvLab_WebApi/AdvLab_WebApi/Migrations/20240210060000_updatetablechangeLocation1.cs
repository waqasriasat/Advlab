using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdvLab_WebApi.Migrations
{
    /// <inheritdoc />
    public partial class updatetablechangeLocation1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "PatRegs");

            migrationBuilder.DropColumn(
                name: "CINCNo",
                table: "PatRegs");

            migrationBuilder.DropColumn(
                name: "City",
                table: "PatRegs");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "PatRegs");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "PatRegs");

            migrationBuilder.DropColumn(
                name: "MStatus",
                table: "PatRegs");

            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "PatRegs");

            migrationBuilder.DropColumn(
                name: "PPNo",
                table: "PatRegs");

            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "PatRegs");

            migrationBuilder.DropColumn(
                name: "TelNo",
                table: "PatRegs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "PatRegs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CINCNo",
                table: "PatRegs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "PatRegs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "PatRegs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "PatRegs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MStatus",
                table: "PatRegs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "PatRegs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PPNo",
                table: "PatRegs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "PatRegs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelNo",
                table: "PatRegs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
