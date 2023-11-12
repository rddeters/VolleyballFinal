using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VolleyballFinal.Migrations
{
    public partial class SeedTeamsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Category", "Gender", "LeagueType", "Location", "TeamName" },
                values: new object[,]
                {
                    { 1, "Indoor", "Men", "2020 Olympics", "Argentina", "Argentina" },
                    { 2, "Indoor", "Men", "2020 Olympics", "Brazil", "Brazil" },
                    { 3, "Indoor", "Men", "2020 Olympics", "Canada", "Canada" },
                    { 4, "Indoor", "Men", "2020 Olympics", "France", "France" },
                    { 5, "Indoor", "Men", "2020 Olympics", "Iran", "Iran" },
                    { 6, "Indoor", "Men", "2020 Olympics", "Italy", "Italy" },
                    { 7, "Indoor", "Men", "2020 Olympics", "Japan", "Japan" },
                    { 8, "Indoor", "Men", "2020 Olympics", "Poland", "Poland" },
                    { 9, "Indoor", "Men", "2020 Olympics", "Russia", "ROC" },
                    { 10, "Indoor", "Men", "2020 Olympics", "Tunisia", "Tunisia" },
                    { 11, "Indoor", "Men", "2020 Olympics", "United States", "USA" },
                    { 12, "Indoor", "Men", "2020 Olympics", "Venezuela", "Venezuela" },
                    { 13, "Indoor", "Women", "Big 12 Conference", "University of Texas, Austin TX", "Texas" },
                    { 14, "Indoor", "Women", "Big 12 Conference", "University of Kansas, Lawrence KS", "Kansas" },
                    { 15, "Indoor", "Women", "Big 12 Conference", "Brigham Young University, Provo UT", "BYU" },
                    { 16, "Indoor", "Women", "Big 12 Conference", "University of Central Florida, Orlando FL", "UCF" },
                    { 17, "Indoor", "Women", "Big 12 Conference", "Baylor University, Waco TX", "Baylor" },
                    { 18, "Indoor", "Women", "Big 12 Conference", "Iowa State University, Ames IA", "Iowa State" },
                    { 19, "Indoor", "Women", "Big 12 Conference", "University of Houston, Houston TX", "Houston" },
                    { 20, "Indoor", "Women", "Big 12 Conference", "Kansas State University, Manhattan KS", "Kansas State" },
                    { 21, "Indoor", "Women", "Big 12 Conference", "Texas Christian University, Fort Worth TX", "TCU" },
                    { 22, "Indoor", "Women", "Big 12 Conference", "University of Cincinnati, Cincinnati OH", "Cincinnati" },
                    { 23, "Indoor", "Women", "Big 12 Conference", "University of Oklahoma, Norman OK", "Oklahoma" },
                    { 24, "Indoor", "Women", "Big 12 Conference", "West Virginia University, Morgantown WV", "West Virginia" },
                    { 25, "Indoor", "Women", "Big 12 Conference", "Texas Tech University, Lubbock TX", "Texas Tech" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 25);
        }
    }
}
