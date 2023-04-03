using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CsharpWebApiDotNetCore.Migrations
{
    public partial class Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LandlordLocation");

            migrationBuilder.AddColumn<int>(
                name: "LandlordId",
                table: "Location",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Location_LandlordId",
                table: "Location",
                column: "LandlordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Landlord_LandlordId",
                table: "Location",
                column: "LandlordId",
                principalTable: "Landlord",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Location_Landlord_LandlordId",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Location_LandlordId",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "LandlordId",
                table: "Location");

            migrationBuilder.CreateTable(
                name: "LandlordLocation",
                columns: table => new
                {
                    LandlordsId = table.Column<int>(type: "int", nullable: false),
                    LocationsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandlordLocation", x => new { x.LandlordsId, x.LocationsId });
                    table.ForeignKey(
                        name: "FK_LandlordLocation_Landlord_LandlordsId",
                        column: x => x.LandlordsId,
                        principalTable: "Landlord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LandlordLocation_Location_LocationsId",
                        column: x => x.LocationsId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LandlordLocation_LocationsId",
                table: "LandlordLocation",
                column: "LocationsId");
        }
    }
}
