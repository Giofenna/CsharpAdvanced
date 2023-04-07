using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CsharpWebApiDotNetCore.Migrations
{
    public partial class test69 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Landlord",
                keyColumn: "Id",
                keyValue: 1,
                column: "AvatarId",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Landlord",
                keyColumn: "Id",
                keyValue: 1,
                column: "AvatarId",
                value: null);
        }
    }
}
