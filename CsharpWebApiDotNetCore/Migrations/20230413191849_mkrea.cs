using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CsharpWebApiDotNetCore.Migrations
{
    public partial class mkrea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Location_LocationId",
                table: "Image");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Image",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsCover", "LocationId", "Url" },
                values: new object[] { false, 1, "https://th.bing.com/th/id/R.7a5b8b8f2c06d86438fa0ca1d1a6e81e?rik=6mW1IbIQA718KQ&pid=ImgRaw&r=0" });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "IsCover", "LocationId", "Url" },
                values: new object[,]
                {
                    { 3, true, 2, "https://th.bing.com/th/id/OIP.rt-pujAJJlfsYntGE4rRAgHaE7?pid=ImgDet&rs=1" },
                    { 4, false, 2, "https://th.bing.com/th/id/R.1ac8616cc26c5ffa5d4a124e068c447d?rik=Q3ad8plACqWAMQ&riu=http%3a%2f%2flovelyfotos.l.o.pic.centerblog.net%2fo%2f98a8ed98.jpg&ehk=oMZ4%2bUZ%2b2P7UvBelRgLJi%2fXMGMrpqfqtm%2bTC58Gqtbg%3d&risl=&pid=ImgRaw&r=0" },
                    { 21, false, null, "https://www.pixelstalk.net/wp-content/uploads/2016/06/Free-Download-HD-Country-Image.jpg" },
                    { 22, false, null, "https://i.ytimg.com/vi/xS-gJydZXuM/maxresdefault.jpg" },
                    { 23, false, null, "https://www.wallpapertip.com/wmimgs/8-82164_soothing-background.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Features", "SubTitle", "Title", "Type" },
                values: new object[] { "Description1", 1, "SubTitle1", "House1", 0 });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Features", "SubTitle", "Title", "Type" },
                values: new object[] { "Description2", 2, "SubTitle2", "House2", 2 });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "Description", "Features", "LandlordId", "NumberOfGuests", "PricePerDay", "Rooms", "SubTitle", "Title", "Type" },
                values: new object[,]
                {
                    { 3, "Description3", 3, 1, 4, 31f, 2, "SubTitle3", "House3", 5 },
                    { 4, "Description4", 4, 1, 4, 32f, 2, "SubTitle4", "House4", 3 },
                    { 5, "Description5", 5, 1, 4, 33f, 2, "SubTitle5", "House5", 4 },
                    { 6, "Description6", 6, 1, 4, 34f, 2, "SubTitle6", "House6", 0 },
                    { 7, "Description7", 7, 1, 4, 35f, 2, "SubTitle7", "House7", 1 },
                    { 8, "Description8", 8, 1, 4, 36f, 2, "SubTitle8", "House8", 3 },
                    { 9, "Description9", 9, 1, 4, 37f, 2, "SubTitle9", "House9", 4 },
                    { 10, "Description10", 10, 1, 4, 38f, 2, "SubTitle10", "House10", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 18, 21, 18, 49, 577, DateTimeKind.Local).AddTicks(4884), new DateTime(2023, 4, 13, 21, 18, 49, 577, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "IsCover", "LocationId", "Url" },
                values: new object[,]
                {
                    { 5, true, 3, "https://miro.medium.com/v2/resize:fit:3840/1*xMuIOwjliGUPjkzukeWKfw.jpeg" },
                    { 6, false, 3, "https://th.bing.com/th/id/OIP.L51qzGCLtslIZn42Q0BFhgHaE7?pid=ImgDet&rs=1" },
                    { 7, true, 4, "https://pixy.org/src/21/219269.jpg" },
                    { 8, false, 4, "https://th.bing.com/th/id/R.551cf68432c7dd0c1ddfebb77c484b16?rik=4BRITn7IBb7E5A&riu=http%3a%2f%2fthewowstyle.com%2fwp-content%2fuploads%2f2015%2f07%2f3d-only-natural-backgrounds-wallpapers.jpg&ehk=PKY8ZDTMjVdIJyFK3s1z1hshGDDLPv3Igu1kxcN3yH8%3d&risl=&pid=ImgRaw&r=0" },
                    { 9, true, 5, "https://images.toucharger.com/img/graphiques/fonds-d-ecran/nature--paysages/coucher-de-soleil/polynesie.72440.jpg" },
                    { 10, false, 5, "https://www.freepsdbazaar.com/wp-content/uploads/2020/06/sky-night/night-sky-049.jpg" },
                    { 11, true, 6, "https://th.bing.com/th/id/R.35b7cf10203ae316c59e65b9f0c6d60d?rik=PEZxCxVcGh5lEw&riu=http%3a%2f%2fs1.picswalls.com%2fwallpapers%2f2017%2f12%2f11%2fnature-desktop-background_123026895_313.jpg&ehk=rvr98svQL12hNeYouWPK7AvyXVnHaRJWDvovllsJxRs%3d&risl=1&pid=ImgRaw&r=0" },
                    { 12, false, 6, "https://images.toucharger.com/img/graphiques/fonds-d-ecran/nature-paysages/coucher-de-soleil/coucher-de-soleil.74120.jpg" },
                    { 13, true, 7, "https://th.bing.com/th/id/R.0d045617037f9cef063d1a9dfe2646b7?rik=EswZh150nqhxsg&riu=http%3a%2f%2fwww.snut.fr%2fwp-content%2fuploads%2f2015%2f07%2fimage-de-fleur-6.jpg&ehk=M9uLBYMHQgtcByG2fGYQSKyylapb%2bfCApnNYShcBdfE%3d&risl=&pid=ImgRaw&r=0" },
                    { 14, false, 7, "https://th.bing.com/th/id/R.3bcb9885029ffb81f58fb4a46c6d854f?rik=caTmTHH%2bNuWv1w&riu=http%3a%2f%2fgetwallpapers.com%2fwallpaper%2ffull%2f8%2fd%2f1%2f798741-download-free-awesome-nature-backgrounds-1920x1080-for-tablet.jpg&ehk=%2fu8xawhlqhlABfauhjBvJm3YUpEq5Vjqj2FfHAGm%2bj8%3d&risl=&pid=ImgRaw&r=0" },
                    { 15, true, 8, "https://cdn.wallpapersafari.com/43/42/IwWBH3.jpg" },
                    { 16, false, 8, "https://www.esa.int/var/esa/storage/images/esa_multimedia/images/2017/11/autumn_fireball/17255671-1-eng-GB/Autumn_fireball.jpg" },
                    { 17, true, 9, "https://goldwallpapers.com/uploads/posts/jpeg-wallpapers/jpeg_wallpapers_026.jpg" },
                    { 18, false, 9, "https://images4.alphacoders.com/115/thumb-1920-115716.jpg" },
                    { 19, true, 10, "https://th.bing.com/th/id/OIP.4XB8NF1awQyApnQDDmBmQwHaEo?pid=ImgDet&rs=1" },
                    { 20, false, 10, "https://www.imagelighteditor.com/img/bg-after.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "Landlord",
                keyColumn: "Id",
                keyValue: 1,
                column: "AvatarId",
                value: 21);

            migrationBuilder.InsertData(
                table: "Landlord",
                columns: new[] { "Id", "Age", "AvatarId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 2, 1, 22, "Deffry", "Dahmer" },
                    { 3, 1, 23, "Teffry", "Tahmer" }
                });

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

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Landlord",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Landlord",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Image",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsCover", "LocationId", "Url" },
                values: new object[] { true, 2, "https://th.bing.com/th/id/OIP.4XB8NF1awQyApnQDDmBmQwHaEo?pid=ImgDet&rs=1" });

            migrationBuilder.UpdateData(
                table: "Landlord",
                keyColumn: "Id",
                keyValue: 1,
                column: "AvatarId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Features", "SubTitle", "Title", "Type" },
                values: new object[] { "Description", 10, "SubTitle", "Title", 1 });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Features", "SubTitle", "Title", "Type" },
                values: new object[] { "Description", 1, "SubTitle", "Title", 1 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 16, 22, 16, 45, 143, DateTimeKind.Local).AddTicks(7162), new DateTime(2023, 4, 11, 22, 16, 45, 143, DateTimeKind.Local).AddTicks(7128) });

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Location_LocationId",
                table: "Image",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
