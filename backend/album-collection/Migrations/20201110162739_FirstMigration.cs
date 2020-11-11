using Microsoft.EntityFrameworkCore.Migrations;

namespace album_collection.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Rating = table.Column<string>(nullable: true),
                    ArtistId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albums_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "", "Dream Theater" },
                    { 2, "", "Nipsey Hussle" },
                    { 3, "", "Big Sean" },
                    { 4, "", "The Band" },
                    { 5, "", "Crosby, Stills, Nash & Young" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "Description", "Image", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, 1, "The fifth studio album and first concept album by American progressive metal band Dream Theater, released on October 26, 1999 through Elektra Records.", "", "Metropolis Pt.2: Scenes from a Memory", "10/10" },
                    { 2, 1, "The fourteenth studio album by American progressive metal band Dream Theater, released on February 22, 2019, and being the band's first release on Inside Out Music.", "", "Distance over Time", "9/10" },
                    { 3, 2, "The debut and only studio album by American rapper Nipsey Hussle.", "", "Victory Lap", "10/10" },
                    { 4, 3, "The fourth studio album by American rapper Big Sean. It was released on February 3, 2017, through GOOD Music and distributed by Def Jam Recordings.", "", "I Decided", "7.5/10" },
                    { 5, 4, "The debut studio album by the Band. Released in 1968, it employs a distinctive blend of country, rock, folk, classical, R&B, blues, and soul.", "", "Music from Big Pink", "10/10" },
                    { 6, 5, "The second album by Crosby, Stills & Nash, and their first as a quartet with Neil Young. It was released in March 1970 by Atlantic Records.", "", "Déjà Vu", "10/10" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ArtistId",
                table: "Albums",
                column: "ArtistId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Artists");
        }
    }
}
