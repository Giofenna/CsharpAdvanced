using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CsharpWebApiDotNetCore.Migrations
{
    public partial class test67 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                column: "LandlordId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LandlordId", "PricePerDay" },
                values: new object[] { 1, 30f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                column: "LandlordId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LandlordId", "PricePerDay" },
                values: new object[] { null, 20f });
        }
    }
}
