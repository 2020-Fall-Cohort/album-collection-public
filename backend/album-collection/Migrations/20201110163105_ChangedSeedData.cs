using Microsoft.EntityFrameworkCore.Migrations;

namespace album_collection.Migrations
{
    public partial class ChangedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name", "Rating" },
                values: new object[] { "The 11th studio album by the American rock band the Beach Boys, released May 16, 1966 on Capitol Records.", "Pet Sounds", "11/10" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "The Beach Boys");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name", "Rating" },
                values: new object[] { "The second album by Crosby, Stills & Nash, and their first as a quartet with Neil Young. It was released in March 1970 by Atlantic Records.", "Déjà Vu", "10/10" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Crosby, Stills, Nash & Young");
        }
    }
}
