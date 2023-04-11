using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CsharpWebApiDotNetCore.Migrations
{
    public partial class newtestmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 16, 22, 2, 46, 671, DateTimeKind.Local).AddTicks(5640), new DateTime(2023, 4, 11, 22, 2, 46, 671, DateTimeKind.Local).AddTicks(5606) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 13, 21, 52, 4, 933, DateTimeKind.Local).AddTicks(1528), new DateTime(2023, 4, 11, 21, 52, 4, 933, DateTimeKind.Local).AddTicks(1494) });
        }
    }
}
