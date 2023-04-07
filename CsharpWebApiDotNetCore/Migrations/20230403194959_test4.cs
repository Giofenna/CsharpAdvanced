using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CsharpWebApiDotNetCore.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Location_Image_ImageId",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Location_ImageId",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Location");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Image",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Image_LocationId",
                table: "Image",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Location_LocationId",
                table: "Image",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Location_LocationId",
                table: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Image_LocationId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Image");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Location",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Location_ImageId",
                table: "Location",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Image_ImageId",
                table: "Location",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id");
        }
    }
}
