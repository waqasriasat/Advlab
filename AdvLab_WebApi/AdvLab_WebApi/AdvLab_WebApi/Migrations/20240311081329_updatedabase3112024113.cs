using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdvLab_WebApi.Migrations
{
    /// <inheritdoc />
    public partial class updatedabase3112024113 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AddClients",
                columns: new[] { "ID", "Address", "BDO", "BusinessType", "CCont", "CEmail", "CID", "CLocation", "CName", "ClientActive", "ClientInstraction", "ComName", "DescType", "Dsc_Cdopler", "Dsc_Ctscan", "Dsc_Ecg", "Dsc_Echo", "Dsc_Mri", "Dsc_NoDisc", "Dsc_Routine", "Dsc_Special", "Dsc_Ultra", "Dsc_Xray", "Inc_Cdopler", "Inc_Ctscan", "Inc_Ecg", "Inc_Echo", "Inc_Mri", "Inc_NoDisc", "Inc_Routine", "Inc_Special", "Inc_Ultra", "Inc_Xray", "Location", "PAWC", "PerA", "PriceChangabletrue", "Pwd", "RegDate", "UId" },
                values: new object[] { 1, "", 1, "Walk-In", "", "", 1, "Main", "SELF", "Active", "", "SELF", "Cash", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, "Main", "No", "Yes", "No", "A123456", new DateTime(2018, 4, 15, 3, 21, 16, 0, DateTimeKind.Unspecified), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddClients",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
