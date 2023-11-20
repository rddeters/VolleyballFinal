using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VolleyballFinal.Migrations
{
    public partial class SeedCollegePlayerData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Player",
                newName: "PlayerId");

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Age", "Height", "Number", "PlayerName", "Position", "TeamId", "TeamName" },
                values: new object[,]
                {
                    { 145, "Freshman", "6'3\"", 1, "Ella Swindle", "Setter", null, "Texas" },
                    { 146, "Sophomore", "5'5\"", 2, "Emma Halter", "Libero", null, "Texas" },
                    { 147, "Freshman", "6'4\"", 4, "Sydney Helmers", "Outside Hitter", null, "Texas" },
                    { 148, "Senior", "6'2\"", 5, "Bella Bergmark", "Middle Blocker", null, "Texas" },
                    { 149, "Junior", "6'2\"", 6, "Madisen Skinner", "Outside Hitter", null, "Texas" },
                    { 150, "Senior", "6'3\"", 7, "Asjia O'Neal", "Middle Blocker", null, "Texas" },
                    { 151, "Freshman", "6'5\"", 8, "Auburn Tomkinson", "Opposite Hitter", null, "Texas" },
                    { 152, "Freshman", "6'0\"", 9, "Kenna Miller", "Outside Hitter", null, "Texas" },
                    { 153, "Senior", "5'7\"", 10, "Carissa Barnes", "Libero", null, "Texas" },
                    { 154, "Freshman", "6'4\"", 11, "Marianna Singletary", "Middle Blocker", null, "Texas" },
                    { 155, "Junior", "5'9\"", 12, "Keonilei Akana", "Libero", null, "Texas" },
                    { 156, "Junior", "6'1\"", 13, "Jenna Wenaas", "Outside Hitter", null, "Texas" },
                    { 157, "Freshman", "6'4\"", 14, "Jordyn Byrd", "Outside Hitter", null, "Texas" },
                    { 158, "Senior", "6'5\"", 15, "Molly Phillips", "Opposite Hitter", null, "Texas" },
                    { 159, "Junior", "5'6\"", 19, "Reilly Heinrich", "Libero", null, "Texas" },
                    { 160, "Freshman", "5'10\"", 22, "Mariana Crownover", "Setter", null, "Texas" },
                    { 161, "Sophomore", "6'4\"", 44, "Devin Kahahawai", "Outside Hitter", null, "Texas" },
                    { 162, "Freshman", "6'3\"", 55, "Nya Bunton", "Middle Blocker", null, "Texas" },
                    { 163, "Senior", "5'7\"", 1, "Kennedy Farris", "Libero", null, "Kansas" },
                    { 164, "Freshman", "5'5\"", 3, "Raegan Burns", "Libero", null, "Kansas" },
                    { 165, "Sophomore", "6'2\"", 4, "Rhian Swanson", "Outside Hitter", null, "Kansas" },
                    { 166, "Sophomore", "5'6\"", 5, "Bryn McGehe", "Libero", null, "Kansas" },
                    { 167, "Senior", "5'7\"", 6, "Molly Schultz", "Libero", null, "Kansas" },
                    { 168, "Sophomore", "6'1\"", 7, "Katie Dalton", "Setter", null, "Kansas" },
                    { 169, "Graduate", "6'2\"", 8, "Reagan Cooper", "Outside", null, "Kansas" },
                    { 170, "Senior", "6'0\"", 10, "Kim Whetstone", "Middle Blocker", null, "Kansas" },
                    { 171, "Junior", "6'1\"", 11, "Toyosi Onabanjo", "Middle Blocker", null, "Kansas" },
                    { 172, "Graduate", "6'1\"", 12, "Mykayla Myers", "Middle Blocker", null, "Kansas" },
                    { 173, "Junior", "6'2\"", 13, "Kaiti Parks", "Middle Blocker", null, "Kansas" },
                    { 174, "Junior", "6'0\"", 14, "Caroline Bien", "Outside Hitter", null, "Kansas" },
                    { 175, "Freshman", "6'5\"", 15, "Ellie Schneider", "Middle Blocker", null, "Kansas" },
                    { 176, "Junior", "5'10\"", 17, "Ayah Elnady", "Outside Hitter", null, "Kansas" },
                    { 177, "Sophomore", "5'11\"", 19, "Molly McCarthy", "Libero", null, "Kansas" },
                    { 178, "Sophomore", "5'8\"", 20, "Brynn Kirsch", "Libero", null, "Kansas" },
                    { 179, "Junior", "6'0\"", 21, "London Davis", "Opposite", null, "Kansas" },
                    { 180, "Junior", "5'8\"", 22, "Camryn Turner", "Setter", null, "Kansas" },
                    { 181, "Freshman", "6'3\"", 24, "Aisha Aiono", "Middle Blocker", null, "Kansas" },
                    { 182, "Sophomore", "6'4\"", 1, "Kate Prior", "Opposite Hitter", null, "BYU" },
                    { 183, "Freshman", "5'9\"", 3, "Silina Damuni", "Setter", null, "BYU" },
                    { 184, "Sophomore", "5'11\"", 4, "Hannah Billeter", "Libero", null, "BYU" },
                    { 185, "Junior", "5'10\"", 6, "Kalia Thunstrom", "Setter", null, "BYU" },
                    { 186, "Senior", "5'9\"", 7, "Whitney Bower", "Setter", null, "BYU" }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Age", "Height", "Number", "PlayerName", "Position", "TeamId", "TeamName" },
                values: new object[,]
                {
                    { 187, "Sophomore", "6'3\"", 8, "Eden Bower", "Outside Hitter", null, "BYU" },
                    { 188, "Junior", "6'1\"", 9, "Alyssa Erickson", "Outside Hitter", null, "BYU" },
                    { 189, "Senior", "6'2\"", 10, "Erin Livingston", "Outside Hitter", null, "BYU" },
                    { 190, "Freshman", "6'2\"", 11, "Addie Benson", "Outside Hitter", null, "BYU" },
                    { 191, "Freshman", "6'3\"", 12, "Claire Little", "Outside Hitter", null, "BYU" },
                    { 192, "Freshman", "6'0\"", 13, "Mia Lee", "Middle Blocker", null, "BYU" },
                    { 193, "Graduate", "5'6\"", 14, "Aria McComber", "Libero", null, "BYU" },
                    { 194, "Junior", "6'2\"", 15, "Elyse Stowell", "Outside Hitter", null, "BYU" },
                    { 195, "Freshman", "5'5\"", 16, "Brielle Miller", "Libero", null, "BYU" },
                    { 196, "Graduate", "5'7\"", 18, "Kamaile Hiapo", "Libero", null, "BYU" },
                    { 197, "Graduate", "6'3\"", 21, "Whitney McEwan-Llarenas", "Middle Blocker", null, "BYU" },
                    { 198, "Freshman", "6'5\"", 24, "Brielle Kemavor", "Middle Blocker", null, "BYU" },
                    { 199, "Freshman", "6'0\"", 1, "Abby Schomers", "Setter", null, "UCF" },
                    { 200, "Senior", "5'8\"", 2, "Chloe Scheer", "Libero", null, "UCF" },
                    { 201, "Freshman", "6'2\"", 3, "Sasha Cohen", "Middle Blocker", null, "UCF" },
                    { 202, "Sophomore", "6'4\"", 4, "Megan Holland", "Middle Blocker", null, "UCF" },
                    { 203, "Freshman", "6'2\"", 5, "Doga Ocal", "Outside Hitter", null, "UCF" },
                    { 204, "Freshman", "5'10\"", 7, "Annika Sokol", "Libero", null, "UCF" },
                    { 205, "Graduate", "6'5\"", 9, "Abby Hansen", "Middle Blocker", null, "UCF" },
                    { 206, "Freshman", "6'5\"", 10, "Avah Armour", "Outside Hitter", null, "UCF" },
                    { 207, "Junior", "5'6\"", 11, "Katelyn Grimes", "Libero", null, "UCF" },
                    { 208, "Junior", "6'4\"", 12, "Heidi Bonde", "Outside Hitter", null, "UCF" },
                    { 209, "Graduate", "6'0\"", 13, "Lauren Clark", "Outside Hitter", null, "UCF" },
                    { 210, "Graduate", "6'2\"", 15, "Claudia Dillon", "Middle Blocker", null, "UCF" },
                    { 211, "Sophomore", "5'11\"", 18, "Renee Ralls", "Libero", null, "UCF" },
                    { 212, "Freshman", "6'4\"", 23, "Britt Carlson", "Outside Hitter", null, "UCF" },
                    { 213, "Junior", "6'3\"", 26, "Emily Wilson", "Outside Hitter", null, "UCF" },
                    { 214, "Freshman", "6'0\"", 1, "Harley Kreck", "Setter", null, "Baylor" },
                    { 215, "Junior", "5'7\"", 2, "Lauren Briseno", "Libero", null, "Baylor" },
                    { 216, "Sophomore", "5'11\"", 3, "Averi Carlson", "Setter", null, "Baylor" },
                    { 217, "Sophomore", "6'4\"", 4, "Allie Sczech", "Opposite Hitter", null, "Baylor" },
                    { 218, "Freshman", "5'11\"", 5, "Kyndal Stowers", "Outside Hitter", null, "Baylor" },
                    { 219, "Junior", "5'7\"", 6, "Faith Lynch", "Libero", null, "Baylor" },
                    { 220, "Freshman", "6'2\"", 7, "Victoria Davis", "Middle Blocker", null, "Baylor" },
                    { 221, "Sophomore", "5'11\"", 8, "Brianna Denney", "Setter", null, "Baylor" },
                    { 222, "Junior", "6'1\"", 9, "Ava Grace Haggard", "Middle Blocker", null, "Baylor" },
                    { 223, "Sophomore", "6'2\"", 10, "Sophia Keene", "Outside Hitter", null, "Baylor" },
                    { 224, "Freshman", "6'3\"", 11, "Kendal Murphy", "Outside Hitter", null, "Baylor" },
                    { 225, "Freshman", "6'3\"", 12, "Joya Screen", "Middle Blocker", null, "Baylor" },
                    { 226, "Sophomore", "6'4\"", 13, "Riley Simpson", "Outside Hitter", null, "Baylor" },
                    { 227, "Sophomore", "5'11\"", 15, "Alexis Dacosta", "Libero", null, "Baylor" },
                    { 228, "Sophomore", "6'3\"", 18, "Alicia Andrew", "Middle Blocker", null, "Baylor" }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Age", "Height", "Number", "PlayerName", "Position", "TeamId", "TeamName" },
                values: new object[,]
                {
                    { 229, "Junior", "6'3\"", 20, "Manuela Bibinbe", "Middle Blocker", null, "Baylor" },
                    { 230, "Junior", "6'4\"", 21, "Elise McGhee", "Outside Hitter", null, "Baylor" },
                    { 231, "Freshman", "5'5\"", 26, "Tehani Ulufatu", "Libero", null, "Baylor" },
                    { 232, "Freshman", "6' 0\"", 1, "Pam McCune", "Middle Blocker", null, "Iowa State" },
                    { 233, "Sophomore", "6' 0\"", 2, "Morgan Brandt", "Setter", null, "Iowa State" },
                    { 234, "Senior", "6' 2\"", 4, "Jordan Hopp", "Middle Blocker", null, "Iowa State" },
                    { 235, "Sophomore", "5' 8\"", 5, "Maya Duckworth", "Outside Hitter", null, "Iowa State" },
                    { 236, "Sophomore", "5' 10\"", 7, "Addi Heidemann", "Setter", null, "Iowa State" },
                    { 237, "Junior", "5' 10\"", 8, "Brooke Stonestreet", "Libero", null, "Iowa State" },
                    { 238, "Senior", "6' 1\"", 9, "Annie Hatch", "Outside Hitter", null, "Iowa State" },
                    { 239, "Freshman", "6' 2\"", 11, "Reaghan Larkin", "Outside Hitter", null, "Iowa State" },
                    { 240, "Senior", "6' 2\"", 12, "Alexis Engelbrecht", "Middle Blocker", null, "Iowa State" },
                    { 241, "Freshman", "6' 2\"", 13, "Lilly Wachholz", "Outside Hitter", null, "Iowa State" },
                    { 242, "Freshman", "6' 2\"", 14, "Nayeli Gonzalez", "Outside Hitter", null, "Iowa State" },
                    { 243, "Freshman", "6' 0\"", 15, "Kiersten Schmitt", "Outside Hitter", null, "Iowa State" },
                    { 244, "Sophomore", "6' 4\"", 18, "Kelsey Perry", "Middle Blocker", null, "Iowa State" },
                    { 245, "Sophomore", "5' 11\"", 19, "Faith DeRonde", "Outside Hitter", null, "Iowa State" },
                    { 246, "Sophomore", "5' 6\"", 21, "Paula Krzeslak", "Libero", null, "Iowa State" },
                    { 247, "Graduate", "5'10\"", 1, "Morgan Janda", "Setter", null, "Houston" },
                    { 248, "Sophomore", "5'5\"", 2, "Alana Torres-Rivera", "Libero", null, "Houston" },
                    { 249, "Junior", "5'8\"", 3, "Bryshanna Brown", "Libero", null, "Houston" },
                    { 250, "Graduate", "6'1\"", 4, "Kenna Sauer", "Outside Hitter", null, "Houston" },
                    { 251, "Freshman", "6'2\"", 5, "Reagan Fifer", "Setter", null, "Houston" },
                    { 252, "Freshman", "6'0\"", 6, "Ella Busey", "Outside Hitter", null, "Houston" },
                    { 253, "Junior", "6'2\"", 7, "Grace Wiley", "Outside Hitter", null, "Houston" },
                    { 254, "Freshman", "6'0\"", 8, "Kayla Knowles", "Outside Hitter", null, "Houston" },
                    { 255, "Graduate", "6'0\"", 9, "Nena Mbonu", "Outside Hitter", null, "Houston" },
                    { 256, "Graduate", "6'1\"", 11, "Rachel Tullos", "Middle Blocker", null, "Houston" },
                    { 257, "Freshman", "5'4\"", 12, "Sunni Sheppard", "Libero", null, "Houston" },
                    { 258, "Sophomore", "6'1\"", 13, "Barakat Rahmon", "Middle Blocker", null, "Houston" },
                    { 259, "Freshman", "6'1\"", 14, "Ella Wendel", "Middle Blocker", null, "Houston" },
                    { 260, "Senior", "5'9\"", 17, "Kate Georgiades", "Libero", null, "Houston" },
                    { 261, "Senior", "5'11\"", 18, "Annie Cooke", "Setter", null, "Houston" },
                    { 262, "Junior", "6'1\"", 21, "Katie Corelli", "Outside Hitter", null, "Houston" },
                    { 263, "Sophomore", "6'2\"", 22, "Kennedi Bray", "Outside Hitter", null, "Houston" },
                    { 264, "Freshman", "6'1\"", 23, "Ashlyn Bellamy", "Outside Hitter", null, "Houston" },
                    { 265, "Graduate", "6'0\"", 24, "Abbie Jackson", "Outside Hitter", null, "Houston" },
                    { 266, "Junior", "6'4\"", 25, "Kellen Morin", "Middle Blocker", null, "Houston" },
                    { 267, "Senior", "5'11\"", 1, "Liz Gregorski", "Outside Hitter", null, "Kansas State" },
                    { 268, "Senior", "5'10\"", 2, "Aliyah Carter", "Outside Hitter", null, "Kansas State" },
                    { 269, "Junior", "5'4\"", 3, "Molly Ramsey", "Libero", null, "Kansas State" },
                    { 270, "Senior", "6'1\"", 4, "Kadye Fernholz", "Middle Blocker", null, "Kansas State" }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Age", "Height", "Number", "PlayerName", "Position", "TeamId", "TeamName" },
                values: new object[,]
                {
                    { 271, "Freshman", "6'2\"", 5, "Aniya Clinton", "Outside Hitter", null, "Kansas State" },
                    { 272, "Freshman", "6'1\"", 6, "Makinsey Jones", "Middle Blocker", null, "Kansas State" },
                    { 273, "Freshman", "5'5\"", 7, "Symone Sims", "Libero", null, "Kansas State" },
                    { 274, "Freshman", "5'9\"", 9, "Lauren Schneider", "Outside Hitter", null, "Kansas State" },
                    { 275, "Sophomore", "6'4\"", 10, "Dalia Wilson", "Opposite Hitter", null, "Kansas State" },
                    { 276, "Sophomore", "6'0\"", 11, "Ava LeGrand", "Setter", null, "Kansas State" },
                    { 277, "Senior", "5'9\"", 12, "Loren Hinkle", "Setter", null, "Kansas State" },
                    { 278, "Sophomore", "6'0\"", 14, "Shaylee Myers", "Outside Hitter", null, "Kansas State" },
                    { 279, "Junior", "5'7\"", 15, "Izzi Szulczewski", "Setter", null, "Kansas State" },
                    { 280, "Graduate", "6'5\"", 16, "Sydney Bolding", "Middle Blocker", null, "Kansas State" },
                    { 281, "Freshman", "6'2\"", 17, "Reagan Fox", "Outside Hitter", null, "Kansas State" },
                    { 282, "Sophomore", "6'6\"", 18, "Brenna Schmidt", "Middle Blocker", null, "Kansas State" },
                    { 283, "Senior", "5'7\"", 20, "Mackenzie Morris", "Libero", null, "Kansas State" },
                    { 284, "Junior", "6'3\"", 1, "Zoe Hall", "Middle Blocker", null, "TCU" },
                    { 285, "Sophomore", "6'1\"", 2, "Riley Buckley", "Setter", null, "TCU" },
                    { 286, "Freshman", "6'2\"", 3, "Samiyah Abdur-Rahim", "Outside Hitter", null, "TCU" },
                    { 287, "Sophomore", "6'3\"", 4, "Sarah Sylvester", "Middle Blocker", null, "TCU" },
                    { 288, "Sophomore", "6'2\"", 5, "Jalyn Gibson", "Outside Hitter", null, "TCU" },
                    { 289, "Senior", "6'0\"", 6, "Taylor Raiola", "Outside Hitter", null, "TCU" },
                    { 290, "Graduate", "6'1\"", 10, "Brianna Green", "Middle Blocker", null, "TCU" },
                    { 291, "Graduate", "6'3\"", 12, "Julia Adams", "Outside Hitter", null, "TCU" },
                    { 292, "Graduate", "6'1\"", 15, "Audrey Nalls", "Outside Hitter", null, "TCU" },
                    { 293, "Freshman", "5'7\"", 16, "Jaylen Clark", "Libero", null, "TCU" },
                    { 294, "Freshman", "5'9\"", 17, "Megan Walsh", "Libero", null, "TCU" },
                    { 295, "Freshman", "6'0\"", 18, "Eryn Jones", "Outside Hitter", null, "TCU" },
                    { 296, "Freshman", "5'11\"", 21, "Lily Nicholson", "Setter", null, "TCU" },
                    { 297, "Sophomore", "5'9\"", 22, "Ashlyn Bourland", "Setter", null, "TCU" },
                    { 298, "Junior", "5'11\"", 23, "Melanie Parra", "Outside Hitter", null, "TCU" },
                    { 299, "Freshman", "6'1\"", 24, "Alyssa Gonzales", "Outside Hitter", null, "TCU" },
                    { 300, "Freshman", "6'5\"", 25, "Lydia Seymour", "Middle Blocker", null, "TCU" },
                    { 301, "Sophomore", "5'9\"", 33, "Riley Weigelt", "Libero", null, "TCU" },
                    { 302, "Junior", "5'9\"", 35, "Cecily Bramschreiber", "Libero", null, "TCU" },
                    { 303, "Freshman", "6'5\"", 1, "Nina Horning", "Outside Hitter", null, "Cincinnati" },
                    { 304, "Junior", "6'0\"", 3, "Katelyn Lefler", "Setter", null, "Cincinnati" },
                    { 305, "Sophomore", "6'2\"", 4, "Carly Glendinning", "Outside Hitter", null, "Cincinnati" },
                    { 306, "Freshman", "6'1\"", 5, "Lilian Entenmann", "Middle Blocker", null, "Cincinnati" },
                    { 307, "Graduate", "6'0\"", 6, "Jadyn Bauss", "Outside Hitter", null, "Cincinnati" },
                    { 308, "Sophomore", "5'11\"", 8, "Ligia Williams", "Middle Blocker", null, "Cincinnati" },
                    { 309, "Freshman", "5'6\"", 9, "Kayla Hostetler", "Libero", null, "Cincinnati" },
                    { 310, "Senior", "6'2\"", 11, "Elissa Alcantara", "Outside Hitter", null, "Cincinnati" },
                    { 311, "Junior", "6'0\"", 12, "Shaye Eggleston", "Outside Hitter", null, "Cincinnati" },
                    { 312, "Graduate", "5'6\"", 14, "Carly Skrabak", "Libero", null, "Cincinnati" }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Age", "Height", "Number", "PlayerName", "Position", "TeamId", "TeamName" },
                values: new object[,]
                {
                    { 313, "Sophomore", "5'10\"", 17, "Paige Pickering", "Outside Hitter", null, "Cincinnati" },
                    { 314, "Freshman", "5'10\"", 19, "Vivian Campbell", "Setter", null, "Cincinnati" },
                    { 315, "Sophomore", "5'10\"", 22, "Caroline Endres", "Setter", null, "Cincinnati" },
                    { 316, "Junior", "6'1\"", 24, "Abby Walker", "Middle Blocker", null, "Cincinnati" },
                    { 317, "Junior", "5'8\"", 30, "Julie Wittekind", "Libero", null, "Cincinnati" },
                    { 318, "Junior", "5'9\"", 33, "Molly Harrison", "Libero", null, "Cincinnati" },
                    { 319, "Freshman", "6'2\"", 99, "Zeta Washington", "Middle Blocker", null, "Cincinnati" },
                    { 320, "Senior", "6' 3\"", 1, "Kelsey Carrington", "Middle Blocker", null, "Oklahoma" },
                    { 321, "Junior", "6' 0\"", 2, "Payton Chamberlain", "Setter", null, "Oklahoma" },
                    { 322, "Junior", "5' 9\"", 4, "Rylee Fay", "Setter", null, "Oklahoma" },
                    { 323, "Junior", "6' 1\"", 5, "Kristen Birmingham", "Opposite Hitter", null, "Oklahoma" },
                    { 324, "Freshman", "6' 1\"", 7, "Hannah Pfiffner", "Middle Blocker", null, "Oklahoma" },
                    { 325, "Freshman", "6' 1\"", 8, "Mele Corral-Blagojevich", "Outside Hitter", null, "Oklahoma" },
                    { 326, "Junior", "5' 6\"", 10, "Callie Kemohah", "Libero", null, "Oklahoma" },
                    { 327, "Freshman", "5' 8\"", 11, "Emma Henry", "Setter", null, "Oklahoma" },
                    { 328, "Sophomore", "6' 2\"", 12, "Alexis Shelton", "Outside Hitter", null, "Oklahoma" },
                    { 329, "Freshman", "5' 9\"", 16, "Ireland McNees", "Outside Hitter", null, "Oklahoma" },
                    { 330, "Junior", "5' 11\"", 17, "Daleigh Ellison", "Outside Hitter", null, "Oklahoma" },
                    { 331, "Senior", "6' 3\"", 22, "Lydia Burts", "Middle Blocker", null, "Oklahoma" },
                    { 332, "Sophomore", "6' 2\"", 23, "Taylor Preston", "Outside Hitter", null, "Oklahoma" },
                    { 333, "Sophomore", "5' 9\"", 24, "Sydney Thompson", "Libero", null, "Oklahoma" },
                    { 334, "Sophomore", "5' 8\"", 25, "Chloe Kaminski", "Libero", null, "Oklahoma" },
                    { 335, "Freshman", "6'1\"", 0, "Sarah Gooch", "Outside Hitter", null, "West Virginia" },
                    { 336, "Freshman", "5'9\"", 1, "Katie Kolar", "Setter", null, "West Virginia" },
                    { 337, "Sophomore", "6'3\"", 2, "Bailey Miller", "Outside Hitter", null, "West Virginia" },
                    { 338, "Sophomore", "5'9\"", 4, "Samiha Foster", "Libero", null, "West Virginia" },
                    { 339, "Senior", "6'2\"", 6, "Lauren DeLo", "Setter", null, "West Virginia" },
                    { 340, "Freshman", "6'0\"", 7, "Emma Winter", "Outside Hitter", null, "West Virginia" },
                    { 341, "Sophomore", "6'4\"", 8, "Tierney Jackson", "Middle Blocker", null, "West Virginia" },
                    { 342, "Graduate", "5'6\"", 9, "Camilla Covas", "Libero", null, "West Virginia" },
                    { 343, "Sophomore", "6'0\"", 10, "Quincey Coyle", "Outside Hitter", null, "West Virginia" },
                    { 344, "Sophomore", "6'3\"", 11, "Melanie McGann", "Opposite Hitter", null, "West Virginia" },
                    { 345, "Freshman", "5'9\"", 12, "Danilyn Neil", "Libero", null, "West Virginia" },
                    { 346, "Freshman", "6'2\"", 13, "Emma Beretich", "Middle Blocker", null, "West Virginia" },
                    { 347, "Freshman", "6'2\"", 16, "Nele Broszat", "Middle Blocker", null, "West Virginia" },
                    { 348, "Sophomore", "6'4\"", 17, "Lauren Bodily", "Opposite Hitter", null, "West Virginia" },
                    { 349, "Junior", "6'2\"", 20, "Hailey Green", "Outside Hitter", null, "West Virginia" },
                    { 350, "Junior", "5'9\"", 21, "Kristen McBride", "Libero", null, "West Virginia" },
                    { 351, "Freshman", "6'2\"", 22, "Maddy McGath", "Middle Blocker", null, "West Virginia" },
                    { 352, "Graduate", "6' 1\"", 1, "Destiny Cox", "Outside Hitter", null, "Texas Tech" },
                    { 353, "Freshman", "5' 8\"", 2, "Abby Dickinson", "Libero", null, "Texas Tech" },
                    { 354, "Graduate", "6' 1\"", 3, "Caitlin Dugan", "Outside Hitter", null, "Texas Tech" }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Age", "Height", "Number", "PlayerName", "Position", "TeamId", "TeamName" },
                values: new object[,]
                {
                    { 355, "Sophomore", "5' 10\"", 4, "Brynn Williams", "Outside Hitter", null, "Texas Tech" },
                    { 356, "Junior", "6' 2\"", 5, "Madison Gilliland", "Middle Blocker", null, "Texas Tech" },
                    { 357, "Sophomore", "6' 0\"", 6, "Currie Marusak", "Outside Hitter", null, "Texas Tech" },
                    { 358, "Sophomore", "5' 8\"", 7, "Paige Mooney", "Libero", null, "Texas Tech" },
                    { 359, "Junior", "5' 6\"", 9, "Maddie Correa", "Libero", null, "Texas Tech" },
                    { 360, "Freshman", "6' 1\"", 10, "Katelyn Cochran", "Setter", null, "Texas Tech" },
                    { 361, "Graduate", "6' 2\"", 11, "Elena Leontaridou", "Middle Blocker", null, "Texas Tech" },
                    { 362, "Freshman", "5' 11\"", 12, "Courtney O'Brien", "Libero", null, "Texas Tech" },
                    { 363, "Graduate", "6' 0\"", 13, "Simone Overbeck", "Outside Hitter", null, "Texas Tech" },
                    { 364, "Freshman", "5' 8\"", 14, "Claudia Rossi", "Libero", null, "Texas Tech" },
                    { 365, "Sophomore", "6' 3\"", 15, "Ellie Baumert", "Setter", null, "Texas Tech" },
                    { 366, "Senior", "6' 1\"", 16, "Reese Rhodes", "Setter", null, "Texas Tech" },
                    { 367, "Freshman", "6' 1\"", 17, "Reagan Engler", "Middle Blocker", null, "Texas Tech" },
                    { 368, "Senior", "6' 2\"", 18, "Maddie O'Brien", "Middle Blocker", null, "Texas Tech" },
                    { 369, "Freshman", "6' 3\"", 19, "Kate Hansen", "Middle Blocker", null, "Texas Tech" },
                    { 370, "Freshman", "5' 5\"", 21, "Emily Contreras", "Libero", null, "Texas Tech" },
                    { 371, "Graduate", "6' 4\"", 23, "Emily Merrick", "Outside Hitter", null, "Texas Tech" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 371);

            migrationBuilder.RenameColumn(
                name: "PlayerId",
                table: "Player",
                newName: "Id");
        }
    }
}
