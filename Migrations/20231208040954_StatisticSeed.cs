using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VolleyballFinal.Migrations
{
    public partial class StatisticSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PlayerName",
                table: "Player",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 14,
                column: "PlayerName",
                value: "Mauricio Borges Almeida Silva");

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 37,
                column: "PlayerName",
                value: "Barthelemy Chinenyeze");

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 135,
                column: "PlayerName",
                value: "Hector Mata");

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 140,
                column: "PlayerName",
                value: "Jose Verdi");

            migrationBuilder.InsertData(
                table: "Statistics",
                columns: new[] { "Id", "AttackPoints", "BlockPoints", "Efficiency", "PlayerName", "ServePoints", "TotalPoints" },
                values: new object[,]
                {
                    { 1, 0, 0, 0.0, "Matias Sanchez", 0, 0 },
                    { 2, 5, 2, 31.25, "Federico Pereyra", 0, 7 },
                    { 3, 25, 2, 50.0, "Cristian Poglajen", 1, 28 },
                    { 4, 111, 7, 45.119999999999997, "Facundo Conte", 7, 125 },
                    { 5, 55, 22, 61.109999999999999, "Agustin Loser", 4, 81 },
                    { 6, 0, 0, 0.0, "Santiago Danani", 0, 0 },
                    { 7, 49, 14, 54.439999999999998, "Sebastian Sole", 3, 66 },
                    { 8, 119, 10, 52.420000000000002, "Bruno Lima", 9, 138 },
                    { 9, 64, 10, 42.380000000000003, "Ezequiel Palacios", 3, 77 },
                    { 10, 10, 6, 50.0, "Luciano De Cecco", 3, 19 },
                    { 11, 0, 0, 0.0, "Nicolas Mendez", 0, 0 },
                    { 12, 3, 2, 50.0, "Martin Ramos", 1, 6 },
                    { 13, 2, 7, 50.0, "Bruno Mossa Rezende", 2, 11 },
                    { 14, 2, 0, 50.0, "Mauricio Borges Almeida Silva", 0, 2 },
                    { 15, 0, 2, 0.0, "Fernando Gil Kreling", 0, 2 },
                    { 16, 94, 15, 44.340000000000003, "Wallace De Souza", 5, 114 },
                    { 17, 93, 6, 48.189999999999998, "Yoandy Leal Hidalgo", 5, 104 },
                    { 18, 8, 2, 47.060000000000002, "Isac Santos", 1, 11 },
                    { 19, 27, 10, 52.939999999999998, "Mauricio Luiz De Souza", 4, 41 },
                    { 20, 34, 0, 50.75, "Douglas Correia De Souza", 0, 34 },
                    { 21, 69, 21, 66.349999999999994, "Lucas Saatkamp", 3, 93 },
                    { 22, 0, 0, 0.0, "Thales Hoss", 0, 0 },
                    { 23, 82, 7, 47.399999999999999, "Ricardo Lucarelli Souza", 12, 101 },
                    { 24, 15, 0, 41.670000000000002, "Alan Souza", 1, 16 },
                    { 25, 0, 1, 0.0, "Tyler Sanders", 1, 2 },
                    { 26, 66, 7, 55.0, "Tyler Gordon Perrin", 3, 76 },
                    { 27, 0, 0, 0.0, "Steven Marshall", 0, 0 },
                    { 28, 63, 5, 45.990000000000002, "Nicholas Hoag", 7, 75 },
                    { 29, 22, 3, 45.829999999999998, "Stephen Timothy Maar", 2, 27 },
                    { 30, 2, 2, 100.0, "Jay Blankenau", 0, 4 },
                    { 31, 31, 1, 52.539999999999999, "Ryan Joseph Sclater", 2, 34 },
                    { 32, 32, 14, 69.569999999999993, "Lucas Van Berkel", 2, 48 },
                    { 33, 30, 6, 41.670000000000002, "Sharone Vernon-Evans", 3, 39 },
                    { 34, 20, 4, 58.82, "Graham Vigrass", 3, 27 },
                    { 35, 0, 0, 0.0, "Blair Cameron Bann", 0, 0 },
                    { 36, 3, 1, 37.5, "Arthur Szwarc", 1, 5 },
                    { 37, 42, 20, 61.759999999999998, "Barthelemy Chinenyeze", 0, 62 },
                    { 38, 0, 0, 0.0, "Jenia Grebennikov", 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Statistics",
                columns: new[] { "Id", "AttackPoints", "BlockPoints", "Efficiency", "PlayerName", "ServePoints", "TotalPoints" },
                values: new object[,]
                {
                    { 39, 115, 13, 53.740000000000002, "Jean Patry", 7, 135 },
                    { 40, 0, 1, 0.0, "Benjamin Toniutti", 0, 1 },
                    { 41, 3, 0, 27.27, "Kevin Tillie", 0, 3 },
                    { 42, 124, 6, 50.82, "Earvin Ngapeth", 6, 136 },
                    { 43, 4, 7, 40.0, "Antoine Brizard", 8, 19 },
                    { 44, 12, 2, 50.0, "Stephen Boyer", 0, 14 },
                    { 45, 33, 20, 55.93, "Nicolas Le Goff", 0, 53 },
                    { 46, 0, 0, 0.0, "Daryl Bultor", 0, 0 },
                    { 47, 102, 9, 53.399999999999999, "Trevor Clevenot", 2, 113 },
                    { 48, 2, 0, 66.670000000000002, "Yacine Louati", 2, 4 },
                    { 49, 46, 6, 41.82, "Milad Ebadipour Ghara H.", 11, 63 },
                    { 50, 2, 2, 28.57, "Mir Saeid Marouflakrani", 0, 4 },
                    { 51, 22, 12, 53.659999999999997, "Seyed Mohammad Mousavi Eraghi", 1, 35 },
                    { 52, 3, 3, 37.5, "Masoud Gholami", 0, 6 },
                    { 53, 64, 2, 53.329999999999998, "Amir Ghafour", 6, 72 },
                    { 54, 20, 1, 50.0, "Saber Kazemi", 3, 24 },
                    { 55, 2, 1, 50.0, "Morteza Sharifi", 0, 3 },
                    { 56, 23, 9, 67.650000000000006, "Aliasghar Mojarad", 0, 32 },
                    { 57, 71, 7, 54.619999999999997, "Meisam Salehi", 2, 80 },
                    { 58, 0, 0, 0.0, "Mahdi Marandi", 0, 0 },
                    { 59, 0, 0, 0.0, "Arman Salehi", 0, 0 },
                    { 60, 1, 1, 100.0, "Javad Karimisouchelmaei", 1, 3 },
                    { 61, 1, 0, 50.0, "Jiri Kovar", 0, 1 },
                    { 62, 29, 3, 50.880000000000003, "Luca Vettori", 1, 33 },
                    { 63, 99, 8, 56.899999999999999, "Osmany Juantorena", 4, 111 },
                    { 64, 5, 3, 55.560000000000002, "Simone Giannelli", 3, 11 },
                    { 65, 41, 5, 43.159999999999997, "Ivan Zaytsev", 3, 49 },
                    { 66, 13, 8, 76.469999999999999, "Matteo Piano", 0, 21 },
                    { 67, 0, 0, 0.0, "Massimo Colaci", 0, 0 },
                    { 68, 39, 12, 70.909999999999997, "Gianluca Galassi", 2, 53 },
                    { 69, 1, 2, 100.0, "Riccardo Sbertoli", 1, 4 },
                    { 70, 22, 8, 57.890000000000001, "Simone Anzani", 1, 31 },
                    { 71, 72, 8, 50.0, "Alessandro Michieletto", 9, 89 },
                    { 72, 12, 1, 63.159999999999997, "Daniele Lavia", 0, 13 },
                    { 73, 5, 1, 83.329999999999998, "Kunihiro Shimizu", 0, 6 },
                    { 74, 24, 10, 48.979999999999997, "Taishi Onodera", 3, 37 },
                    { 75, 0, 0, 0.0, "Naonobu Fujii", 0, 0 },
                    { 76, 24, 6, 57.140000000000001, "Akihiro Yamauchi", 2, 32 },
                    { 77, 92, 5, 53.799999999999997, "Yuji Nishida", 8, 105 },
                    { 78, 3, 3, 37.5, "Masahiro Sekita", 1, 7 },
                    { 79, 94, 9, 48.960000000000001, "Yuki Ishikawa", 9, 112 },
                    { 80, 4, 0, 100.0, "Haku Ri", 0, 4 }
                });

            migrationBuilder.InsertData(
                table: "Statistics",
                columns: new[] { "Id", "AttackPoints", "BlockPoints", "Efficiency", "PlayerName", "ServePoints", "TotalPoints" },
                values: new object[,]
                {
                    { 81, 8, 2, 34.780000000000001, "Kenta Takanashi", 0, 10 },
                    { 82, 0, 0, 0.0, "Tatsunori Otsuka", 0, 0 },
                    { 83, 0, 0, 0.0, "Tomohiro Yamamoto", 0, 0 },
                    { 84, 51, 1, 44.740000000000002, "Ran Takahashi", 0, 52 },
                    { 85, 8, 7, 53.329999999999998, "Piotr Nowakowski", 1, 16 },
                    { 86, 8, 2, 44.439999999999998, "Lukasz Kaczmarek", 0, 10 },
                    { 87, 76, 9, 58.020000000000003, "Bartosz Kurek", 4, 89 },
                    { 88, 85, 4, 60.280000000000001, "Wilfredo Leon Venero", 14, 103 },
                    { 89, 6, 6, 66.670000000000002, "Fabian Drzyzga", 1, 13 },
                    { 90, 0, 0, 0.0, "Grzegorz Lomacz", 0, 0 },
                    { 91, 14, 1, 40.0, "Michal Kubiak", 1, 16 },
                    { 92, 33, 2, 44.0, "Aleksander Sliwka", 1, 36 },
                    { 93, 26, 9, 60.469999999999999, "Jakub Kochanowski", 3, 38 },
                    { 94, 24, 0, 61.539999999999999, "Kamil Semeniuk", 6, 30 },
                    { 95, 0, 0, 0.0, "Pawel Zatorski", 0, 0 },
                    { 96, 39, 9, 67.239999999999995, "Mateusz Bieniek", 7, 55 },
                    { 97, 19, 1, 50.0, "Yaroslav Podlesnykh", 1, 21 },
                    { 98, 29, 11, 58.0, "Artem Volvich", 1, 41 },
                    { 99, 73, 18, 43.450000000000003, "Dmitry Volkov", 6, 97 },
                    { 100, 49, 21, 61.25, "Ivan Iakovlev", 4, 74 },
                    { 101, 2, 0, 66.670000000000002, "Denis Bogdan", 0, 2 },
                    { 102, 0, 2, 0.0, "Pavel Pankov", 6, 8 },
                    { 103, 4, 0, 66.670000000000002, "Victor Poletaev", 1, 5 },
                    { 104, 110, 14, 48.890000000000001, "Maxim Mikhaylov", 6, 130 },
                    { 105, 86, 6, 46.990000000000002, "Egor Kliuka", 7, 99 },
                    { 106, 8, 2, 50.0, "Ilyas Kurkaev", 0, 10 },
                    { 107, 7, 2, 43.75, "Igor Kobzar", 3, 12 },
                    { 108, 0, 0, 0.0, "Valentin Golubev", 0, 0 },
                    { 109, 21, 10, 46.670000000000002, "Ahmed Kadhi", 0, 31 },
                    { 110, 5, 3, 45.450000000000003, "Khaled Ben Slimene", 1, 9 },
                    { 111, 28, 4, 35.899999999999999, "Mohamed Ali Ben Othmen", 1, 33 },
                    { 112, 4, 0, 33.329999999999998, "Elyes Karamosli", 0, 4 },
                    { 113, 7, 7, 31.82, "Omar Agrebi", 2, 16 },
                    { 114, 16, 0, 57.140000000000001, "Hamza Nagga", 0, 16 },
                    { 115, 31, 4, 43.060000000000002, "Ismail Moalla", 1, 36 },
                    { 116, 0, 0, 0.0, "Mehdi Ben Cheikh", 0, 0 },
                    { 117, 8, 0, 57.140000000000001, "Selim Mbareki", 0, 8 },
                    { 118, 62, 8, 43.969999999999999, "Wassim Ben Tara", 1, 71 },
                    { 119, 6, 0, 37.5, "Aymen Bouguerra", 0, 6 },
                    { 120, 0, 0, 0.0, "Saddem Hmissi", 0, 0 },
                    { 121, 66, 1, 50.770000000000003, "Matthew Anderson", 3, 70 },
                    { 122, 62, 6, 52.539999999999999, "Taylor Sander", 6, 74 }
                });

            migrationBuilder.InsertData(
                table: "Statistics",
                columns: new[] { "Id", "AttackPoints", "BlockPoints", "Efficiency", "PlayerName", "ServePoints", "TotalPoints" },
                values: new object[,]
                {
                    { 123, 0, 0, 0.0, "Kyle Ensing", 0, 0 },
                    { 124, 20, 4, 62.5, "Mitchell Stahl", 2, 26 },
                    { 125, 0, 0, 0.0, "Kawika Shoji", 0, 0 },
                    { 126, 66, 7, 47.479999999999997, "Torey Defalco", 3, 76 },
                    { 127, 3, 5, 50.0, "Micah Christenson", 1, 9 },
                    { 128, 40, 8, 67.799999999999997, "Maxwell Holt", 1, 49 },
                    { 129, 0, 1, 0.0, "Thomas Jaeschke", 0, 1 },
                    { 130, 1, 0, 12.5, "Garrett Muagututia", 0, 1 },
                    { 131, 19, 2, 70.370000000000005, "David Smith", 1, 22 },
                    { 132, 0, 0, 0.0, "Erik Shoji", 0, 0 },
                    { 133, 1, 0, 100.0, "Armando Fernando Velasquez Escalante", 0, 1 },
                    { 134, 1, 0, 50.0, "Fernando Gonzalez", 0, 1 },
                    { 135, 0, 0, 0.0, "Hector Mata", 0, 0 },
                    { 136, 33, 1, 40.240000000000002, "Emerson Alexander Rodriguez Gonzalez", 2, 36 },
                    { 137, 2, 0, 28.57, "Robert Manuel Oramas Brizuela", 0, 2 },
                    { 138, 23, 6, 57.5, "Edson Alberto Valencia Gonzalez", 3, 32 },
                    { 139, 1, 1, 25.0, "Jose Manuel Carrasco Angulo", 1, 3 },
                    { 140, 13, 4, 48.149999999999999, "Jose Verdi", 1, 18 },
                    { 141, 0, 0, 0.0, "Eliecer Alfonso Canelo Sanchez", 0, 0 },
                    { 142, 18, 0, 42.859999999999999, "Luis Antonio Arias Guzman", 0, 18 },
                    { 143, 36, 6, 49.32, "Ronald Daniel Fayola Hurtado", 0, 42 },
                    { 144, 38, 3, 37.619999999999997, "Willner Enrique Rivas Quijada", 3, 44 },
                    { 145, 64, 61, 26.399999999999999, "Ella Swindle", 23, 148 },
                    { 146, 1, 0, 100.0, "Emma Halter", 26, 27 },
                    { 147, 0, 0, 0.0, "Sydney Helmers", 0, 0 },
                    { 148, 103, 88, 34.899999999999999, "Bella Bergmark", 0, 191 },
                    { 149, 353, 46, 27.300000000000001, "Madisen Skinner", 26, 425 },
                    { 150, 116, 100, 40.399999999999999, "Asjia O’Neal", 13, 229 },
                    { 151, 0, 0, 0.0, "Auburn Tomkinson", 0, 0 },
                    { 152, 1, 0, 20.0, "Kenna Miller", 0, 1 },
                    { 153, 0, 0, 0.0, "Carissa Barnes", 0, 0 },
                    { 154, 18, 11, 37.100000000000001, "Marianna Singletary", 0, 29 },
                    { 155, 0, 0, 0.0, "Keonilei Akana", 22, 22 },
                    { 156, 225, 34, 21.5, "Jenna Wenaas", 0, 259 },
                    { 157, 0, 0, 0.0, "Jordyn Byrd", 0, 0 },
                    { 158, 109, 61, 25.0, "Molly Phillips", 3, 173 },
                    { 159, 0, 0, 0.0, "Reilly Heinrich", 1, 1 },
                    { 160, 0, 0, 0.0, "Mariana Crownover", 0, 0 },
                    { 161, 41, 16, 15.300000000000001, "Devin Kahahawai", 0, 57 },
                    { 162, 0, 0, 0.0, "Nya Bunton", 0, 0 },
                    { 163, 0, 0, 0.0, "Kennedy Farris", 0, 0 },
                    { 164, 4, 0, 33.329999999999998, "Raegan Burns", 9, 13 }
                });

            migrationBuilder.InsertData(
                table: "Statistics",
                columns: new[] { "Id", "AttackPoints", "BlockPoints", "Efficiency", "PlayerName", "ServePoints", "TotalPoints" },
                values: new object[,]
                {
                    { 165, 27, 4, 20.899999999999999, "Rhian Swanson", 0, 31 },
                    { 166, 0, 0, 0.0, "Bryn McGehe", 3, 3 },
                    { 167, 0, 0, 0.0, "Molly Schultz", 9, 9 },
                    { 168, 2, 0, 0.0, "Katie Dalton", 12, 14 },
                    { 169, 246, 29, 31.600000000000001, "Reagan Cooper", 0, 266 },
                    { 170, 1, 2, 0.0, "Kim Whetstone", 0, 3 },
                    { 171, 163, 81, 30.199999999999999, "Toyosi Onabanjo", 7, 218 },
                    { 172, 62, 63, 22.199999999999999, "Mykayla Myers", 0, 97 },
                    { 173, 0, 1, 0.0, "Kaiti Parks", 0, 1 },
                    { 174, 62, 7, 25.5, "Caroline Bien", 12, 79 },
                    { 175, 7, 1, 23.5, "Ellie Schneider", 0, 8 },
                    { 176, 246, 25, 25.399999999999999, "Ayah Elnady", 22, 283 },
                    { 177, 0, 0, -100.0, "Brynn Kirsch", 4, 4 },
                    { 178, 222, 55, 30.899999999999999, "London Davis", 0, 251 },
                    { 179, 59, 38, 17.699999999999999, "Camryn Turner", 17, 97 },
                    { 180, 1, 8, -7.7000000000000002, "Aisha Aiono", 0, 6 },
                    { 181, 139, 65, 21.699999999999999, "Kate Prior", 0, 204 },
                    { 182, 0, 0, -50.0, "Silina Damuni", 0, 0 },
                    { 183, 0, 0, 0.0, "Hannah Billeter", 29, 29 },
                    { 184, 0, 0, 0.0, "Kalia Thunstrom", 0, 0 },
                    { 185, 113, 58, 35.899999999999999, "Whitney Bower", 29, 200 },
                    { 186, 67, 17, 20.0, "Eden Bower", 0, 84 },
                    { 187, 1, 1, 0.0, "Alyssa Erickson", 2, 4 },
                    { 188, 320, 43, 25.800000000000001, "Erin Livingston", 17, 380 },
                    { 189, 2, 0, -14.300000000000001, "Addie Benson", 0, 2 },
                    { 190, 73, 18, 18.199999999999999, "Claire Little", 0, 91 },
                    { 191, 103, 101, 29.899999999999999, "Mia Lee", 3, 207 },
                    { 192, 0, 0, 0.0, "Aria McComber", 16, 16 },
                    { 193, 54, 13, 26.5, "Elyse Stowell", 0, 67 },
                    { 194, 0, 0, -50.0, "Brielle Miller", 1, 1 },
                    { 195, 2, 0, 14.300000000000001, "Kamaile Hiapo", 25, 27 },
                    { 196, 179, 98, 34.600000000000001, "Whitney McEwan-Llarenas", 14, 291 },
                    { 197, 8, 14, 8.0, "Brielle Kemavor", 0, 22 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "PlayerName",
                table: "Player",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 14,
                column: "PlayerName",
                value: "Maurício Borges Almeida Silva");

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 37,
                column: "PlayerName",
                value: "Barthélémy Chinenyeze");

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 135,
                column: "PlayerName",
                value: "Héctor Mata");

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 140,
                column: "PlayerName",
                value: "José Verdi");
        }
    }
}
