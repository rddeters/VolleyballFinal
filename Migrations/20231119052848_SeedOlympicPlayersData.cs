using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VolleyballFinal.Migrations
{
    public partial class SeedOlympicPlayersData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Player",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "Age", "Height", "Number", "PlayerName", "Position", "TeamId", "TeamName" },
                values: new object[,]
                {
                    { 1, "27", "175cm", 1, "Matias Sanchez", "Setter", null, "Argentina" },
                    { 2, "35", "200cm", 2, "Federico Pereyra", "Opposite Hitter", null, "Argentina" },
                    { 3, "34", "195cm", 6, "Cristian Poglajen", "Outside Hitter", null, "Argentina" },
                    { 4, "34", "197cm", 7, "Facundo Conte", "Outside Hitter", null, "Argentina" },
                    { 5, "26", "198cm", 8, "Agustin Loser", "Middle Blocker", null, "Argentina" },
                    { 6, "27", "176cm", 9, "Santiago Danani", "Libero", null, "Argentina" },
                    { 7, "32", "200cm", 11, "Sebastian Sole", "Middle Blocker", null, "Argentina" },
                    { 8, "27", "198cm", 12, "Bruno Lima", "Opposite Hitter", null, "Argentina" },
                    { 9, "31", "198cm", 13, "Ezequiel Palacios", "Outside Hitter", null, "Argentina" },
                    { 10, "35", "191cm", 15, "Luciano De Cecco", "Setter", null, "Argentina" },
                    { 11, "31", "191cm", 17, "Nicolas Mendez", "Outside Hitter", null, "Argentina" },
                    { 12, "32", "197cm", 18, "Martin Ramos", "Middle Blocker", null, "Argentina" },
                    { 13, "37", "190cm", 1, "Bruno Mossa Rezende", "Setter", null, "Brazil" },
                    { 14, "34", "199cm", 5, "Maurício Borges Almeida Silva", "Outside Hitter", null, "Brazil" },
                    { 15, "27", "186cm", 6, "Fernando Gil Kreling", "Setter", null, "Brazil" },
                    { 16, "36", "198cm", 8, "Wallace De Souza", "Opposite Hitter", null, "Brazil" },
                    { 17, "35", "202cm", 9, "Yoandy Leal Hidalgo", "Outside Hitter", null, "Brazil" },
                    { 18, "32", "208cm", 12, "Isac Santos", "Middle Blocker", null, "Brazil" },
                    { 19, "35", "207cm", 13, "Mauricio Luiz De Souza", "Middle Blocker", null, "Brazil" },
                    { 20, "28", "199cm", 14, "Douglas Correia De Souza", "Outside Hitter", null, "Brazil" },
                    { 21, "37", "209cm", 16, "Lucas Saatkamp", "Middle Blocker", null, "Brazil" },
                    { 22, "34", "190cm", 17, "Thales Hoss", "Libero", null, "Brazil" },
                    { 23, "31", "196cm", 18, "Ricardo Lucarelli Souza", "Outside Hitter", null, "Brazil" },
                    { 24, "29", "202cm", 21, "Alan Souza", "Opposite Hitter", null, "Brazil" },
                    { 25, "31", "191cm", 1, "Tyler Sanders", "Setter", null, "Canada" },
                    { 26, "34", "201cm", 2, "Tyler Gordon Perrin", "Outside Hitter", null, "Canada" },
                    { 27, "33", "191cm", 3, "Steven Marshall", "Libero", null, "Canada" },
                    { 28, "31", "200cm", 4, "Nicholas Hoag", "Outside Hitter", null, "Canada" },
                    { 29, "28", "201cm", 7, "Stephen Timothy Maar", "Outside Hitter", null, "Canada" },
                    { 30, "34", "194cm", 9, "Jay Blankenau", "Setter", null, "Canada" },
                    { 31, "29", "200cm", 10, "Ryan Joseph Sclater", "Opposite Hitter", null, "Canada" },
                    { 32, "31", "210cm", 12, "Lucas Van Berkel", "Middle Blocker", null, "Canada" },
                    { 33, "25", "206cm", 13, "Sharone Vernon-Evans", "Opposite Hitter", null, "Canada" },
                    { 34, "34", "205cm", 17, "Graham Vigrass", "Middle Blocker", null, "Canada" },
                    { 35, "35", "184cm", 19, "Blair Cameron Bann", "Libero", null, "Canada" },
                    { 36, "28", "209cm", 20, "Arthur Szwarc", "Opposite Hitter", null, "Canada" },
                    { 37, "25", "204cm", 1, "Barthélémy Chinenyeze", "Middle Blocker", null, "France" },
                    { 38, "33", "188cm", 2, "Jenia Grebennikov", "Libero", null, "France" },
                    { 39, "26", "207cm", 4, "Jean Patry", "Opposite Hitter", null, "France" },
                    { 40, "34", "183cm", 6, "Benjamin Toniutti", "Setter", null, "France" },
                    { 41, "33", "200cm", 7, "Kevin Tillie", "Outside Hitter", null, "France" },
                    { 42, "32", "194cm", 9, "Earvin Ngapeth", "Outside Hitter", null, "France" }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "Age", "Height", "Number", "PlayerName", "Position", "TeamId", "TeamName" },
                values: new object[,]
                {
                    { 43, "29", "196cm", 11, "Antoine Brizard", "Setter", null, "France" },
                    { 44, "27", "196cm", 12, "Stephen Boyer", "Opposite Hitter", null, "France" },
                    { 45, "31", "206cm", 14, "Nicolas Le Goff", "Middle Blocker", null, "France" },
                    { 46, "27", "197cm", 16, "Daryl Bultor", "Middle Blocker", null, "France" },
                    { 47, "29", "199cm", 17, "Trevor Clevenot", "Outside Hitter", null, "France" },
                    { 48, "31", "198cm", 19, "Yacine Louati", "Outside Hitter", null, "France" },
                    { 49, "30", "196cm", 2, "Milad Ebadipour Ghara H.", "Outside Hitter", null, "Iran" },
                    { 50, "38", "189cm", 4, "Mir Saeid Marouflakrani", "Setter", null, "Iran" },
                    { 51, "36", "203cm", 6, "Seyed Mohammad Mousavi Eraghi", "Middle Blocker", null, "Iran" },
                    { 52, "33", "204cm", 9, "Masoud Gholami", "Middle Blocker", null, "Iran" },
                    { 53, "32", "202cm", 10, "Amir Ghafour", "Opposite Hitter", null, "Iran" },
                    { 54, "24", "205cm", 11, "Saber Kazemi", "Opposite Hitter", null, "Iran" },
                    { 55, "24", "193cm", 12, "Morteza Sharifi", "Outside Hitter", null, "Iran" },
                    { 56, "26", "205cm", 15, "Aliasghar Mojarad", "Middle Blocker", null, "Iran" },
                    { 57, "24", "198cm", 17, "Meisam Salehi", "Outside Hitter", null, "Iran" },
                    { 58, "37", "172cm", 19, "Mahdi Marandi", "Libero", null, "Iran" },
                    { 59, "31", "180cm", 21, "Arman Salehi", "Libero", null, "Iran" },
                    { 60, "25", "204cm", 24, "Javad Karimisouchelmaei", "Setter", null, "Iran" },
                    { 61, "34", "202cm", 2, "Jiri Kovar", "Outside Hitter", null, "Italy" },
                    { 62, "32", "200cm", 4, "Luca Vettori", "Opposite Hitter", null, "Italy" },
                    { 63, "38", "200cm", 5, "Osmany Juantorena", "Outside Hitter", null, "Italy" },
                    { 64, "27", "200cm", 6, "Simone Giannelli", "Setter", null, "Italy" },
                    { 65, "35", "204cm", 9, "Ivan Zaytsev", "Outside Hitter", null, "Italy" },
                    { 66, "33", "208cm", 11, "Matteo Piano", "Middle Blocker", null, "Italy" },
                    { 67, "38", "180cm", 13, "Massimo Colaci", "Libero", null, "Italy" },
                    { 68, "26", "201cm", 14, "Gianluca Galassi", "Middle Blocker", null, "Italy" },
                    { 69, "25", "188cm", 15, "Riccardo Sbertoli", "Setter", null, "Italy" },
                    { 70, "31", "204cm", 17, "Simone Anzani", "Middle Blocker", null, "Italy" },
                    { 71, "21", "205cm", 18, "Alessandro Michieletto", "Outside Hitter", null, "Italy" },
                    { 72, "24", "200cm", 19, "Daniele Lavia", "Outside Hitter", null, "Italy" },
                    { 73, "37", "193cm", 1, "Kunihiro Shimizu", "Opposite Hitter", null, "Japan" },
                    { 74, "27", "200cm", 2, "Taishi Onodera", "Middle Blocker", null, "Japan" },
                    { 75, "31", "183cm", 3, "Naonobu Fujii", "Setter", null, "Japan" },
                    { 76, "29", "204cm", 6, "Akihiro Yamauchi", "Middle Blocker", null, "Japan" },
                    { 77, "23", "187cm", 11, "Yuji Nishida", "Opposite Hitter", null, "Japan" },
                    { 78, "29", "175cm", 12, "Masahiro Sekita", "Setter", null, "Japan" },
                    { 79, "27", "191cm", 14, "Yuki Ishikawa", "Outside Hitter", null, "Japan" },
                    { 80, "32", "193cm", 15, "Haku Ri", "Middle Blocker", null, "Japan" },
                    { 81, "26", "190cm", 17, "Kenta Takanashi", "Outside Hitter", null, "Japan" },
                    { 82, "22", "194cm", 19, "Tatsunori Otsuka", "Outside Hitter", null, "Japan" },
                    { 83, "28", "171cm", 20, "Tomohiro Yamamoto", "Libero", null, "Japan" },
                    { 84, "22", "188cm", 21, "Ran Takahashi", "Outside Hitter", null, "Japan" }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "Age", "Height", "Number", "PlayerName", "Position", "TeamId", "TeamName" },
                values: new object[,]
                {
                    { 85, "35", "205cm", 1, "Piotr Nowakowski", "Middle Blocker", null, "Poland" },
                    { 86, "29", "204cm", 5, "Lukasz Kaczmarek", "Opposite Hitter", null, "Poland" },
                    { 87, "35", "205cm", 6, "Bartosz Kurek", "Opposite Hitter", null, "Poland" },
                    { 88, "30", "202cm", 9, "Wilfredo Leon Venero", "Outside Hitter", null, "Poland" },
                    { 89, "33", "196cm", 11, "Fabian Drzyzga", "Setter", null, "Poland" },
                    { 90, "36", "187cm", 12, "Grzegorz Lomacz", "Setter", null, "Poland" },
                    { 91, "35", "191cm", 13, "Michal Kubiak", "Outside Hitter", null, "Poland" },
                    { 92, "28", "196cm", 14, "Aleksander Sliwka", "Outside Hitter", null, "Poland" },
                    { 93, "26", "199cm", 15, "Jakub Kochanowski", "Middle Blocker", null, "Poland" },
                    { 94, "27", "195cm", 16, "Kamil Semeniuk", "Outside Hitter", null, "Poland" },
                    { 95, "33", "184cm", 17, "Pawel Zatorski", "Libero", null, "Poland" },
                    { 96, "29", "210cm", 20, "Mateusz Bieniek", "Middle Blocker", null, "Poland" },
                    { 97, "29", "198cm", 1, "Yaroslav Podlesnykh", "Outside Hitter", null, "ROC" },
                    { 98, "33", "208cm", 4, "Artem Volvich", "Middle Blocker", null, "ROC" },
                    { 99, "28", "201cm", 7, "Dmitry Volkov", "Outside Hitter", null, "ROC" },
                    { 100, "28", "207cm", 9, "Ivan Iakovlev", "Middle Blocker", null, "ROC" },
                    { 101, "27", "200cm", 10, "Denis Bogdan", "Outside Hitter", null, "ROC" },
                    { 102, "28", "198cm", 11, "Pavel Pankov", "Setter", null, "ROC" },
                    { 103, "28", "197cm", 15, "Victor Poletaev", "Opposite Hitter", null, "ROC" },
                    { 104, "35", "202cm", 17, "Maxim Mikhaylov", "Opposite Hitter", null, "ROC" },
                    { 105, "28", "209cm", 18, "Egor Kliuka", "Outside Hitter", null, "ROC" },
                    { 106, "29", "207cm", 20, "Ilyas Kurkaev", "Middle Blocker", null, "ROC" },
                    { 107, "32", "198cm", 24, "Igor Kobzar", "Setter", null, "ROC" },
                    { 108, "31", "190cm", 27, "Valentin Golubev", "Libero", null, "ROC" },
                    { 109, "34", "199cm", 2, "Ahmed Kadhi", "Middle Blocker", null, "Tunisia" },
                    { 110, "28", "193cm", 3, "Khaled Ben Slimene", "Setter", null, "Tunisia" },
                    { 111, "32", "188cm", 6, "Mohamed Ali Ben Othmen", "Outside Hitter", null, "Tunisia" },
                    { 112, "34", "198cm", 7, "Elyes Karamosli", "Outside Hitter", null, "Tunisia" },
                    { 113, "31", "205cm", 9, "Omar Agrebi", "Middle Blocker", null, "Tunisia" },
                    { 114, "33", "191cm", 10, "Hamza Nagga", "Opposite Hitter", null, "Tunisia" },
                    { 115, "33", "195cm", 11, "Ismail Moalla", "Outside Hitter", null, "Tunisia" },
                    { 116, "44", "184cm", 12, "Mehdi Ben Cheikh", "Setter", null, "Tunisia" },
                    { 117, "27", "198cm", 13, "Selim Mbareki", "Middle Blocker", null, "Tunisia" },
                    { 118, "27", "199cm", 15, "Wassim Ben Tara", "Opposite Hitter", null, "Tunisia" },
                    { 119, "22", "188cm", 19, "Aymen Bouguerra", "Outside Hitter", null, "Tunisia" },
                    { 120, "32", "186cm", 20, "Saddem Hmissi", "Libero", null, "Tunisia" },
                    { 121, "36", "202cm", 1, "Matthew Anderson", "Opposite Hitter", null, "USA" },
                    { 122, "31", "196cm", 3, "Taylor Sander", "Outside Hitter", null, "USA" },
                    { 123, "26", "201cm", 5, "Kyle Ensing", "Opposite Hitter", null, "USA" },
                    { 124, "29", "203cm", 6, "Mitchell Stahl", "Middle Blocker", null, "USA" },
                    { 125, "35", "190cm", 7, "Kawika Shoji", "Setter", null, "USA" },
                    { 126, "26", "198cm", 8, "Torey Defalco", "Outside Hitter", null, "USA" }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "Age", "Height", "Number", "PlayerName", "Position", "TeamId", "TeamName" },
                values: new object[,]
                {
                    { 127, "30", "198cm", 11, "Micah Christenson", "Setter", null, "USA" },
                    { 128, "36", "205cm", 12, "Maxwell Holt", "Middle Blocker", null, "USA" },
                    { 129, "30", "198cm", 17, "Thomas Jaeschke", "Outside Hitter", null, "USA" },
                    { 130, "35", "205cm", 18, "Garrett Muagututia", "Outside Hitter", null, "USA" },
                    { 131, "38", "201cm", 20, "David Smith", "Middle Blocker", null, "USA" },
                    { 132, "34", "184cm", 22, "Erik Shoji", "Libero", null, "USA" },
                    { 133, "35", "185cm", 1, "Armando Fernando Velasquez Escalante", "Setter", null, "Venezuela" },
                    { 134, "34", "194cm", 3, "Fernando Gonzalez", "Outside Hitter", null, "Venezuela" },
                    { 135, "32", "179cm", 4, "Héctor Mata", "Libero", null, "Venezuela" },
                    { 136, "30", "204cm", 5, "Emerson Alexander Rodriguez Gonzalez", "Opposite Hitter", null, "Venezuela" },
                    { 137, "39", "200cm", 6, "Robert Manuel Oramas Brizuela", "Middle Blocker", null, "Venezuela" },
                    { 138, "35", "200cm", 7, "Edson Alberto Valencia Gonzalez", "Middle Blocker", null, "Venezuela" },
                    { 139, "34", "192cm", 9, "Jose Manuel Carrasco Angulo", "Setter", null, "Venezuela" },
                    { 140, "33", "196cm", 11, "José Verdi", "Middle Blocker", null, "Venezuela" },
                    { 141, "25", "196cm", 14, "Eliecer Alfonso Canelo Sanchez", "Outside Hitter", null, "Venezuela" },
                    { 142, "34", "196cm", 15, "Luis Antonio Arias Guzman", "Opposite Hitter", null, "Venezuela" },
                    { 143, "28", "198cm", 17, "Ronald Daniel Fayola Hurtado", "Outside Hitter", null, "Venezuela" },
                    { 144, "28", "194cm", 19, "Willner Enrique Rivas Quijada", "Outside Hitter", null, "Venezuela" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Player_TeamId",
                table: "Player",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Teams_TeamId",
                table: "Player",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Teams_TeamId",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Player_TeamId",
                table: "Player");

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Player");
        }
    }
}
