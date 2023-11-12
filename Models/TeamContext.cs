using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace VolleyballFinal.Models
{
    public class TeamContext : DbContext
    {
        public TeamContext(DbContextOptions<TeamContext> options) : base(options) { }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<Statistic> Statistics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
                new Team { Id = 1, TeamName = "Argentina", Location = "Argentina", LeagueType = "2020 Olympics", Category = "Indoor", Gender = "Men" },
                new Team { Id = 2, TeamName = "Brazil", Location = "Brazil", LeagueType = "2020 Olympics", Category = "Indoor", Gender = "Men" },
                new Team { Id = 3, TeamName = "Canada", Location = "Canada", LeagueType = "2020 Olympics", Category = "Indoor", Gender = "Men" },
                new Team { Id = 4, TeamName = "France", Location = "France", LeagueType = "2020 Olympics", Category = "Indoor", Gender = "Men" },
                new Team { Id = 5, TeamName = "Iran", Location = "Iran", LeagueType = "2020 Olympics", Category = "Indoor", Gender = "Men" },
                new Team { Id = 6, TeamName = "Italy", Location = "Italy", LeagueType = "2020 Olympics", Category = "Indoor", Gender = "Men" },
                new Team { Id = 7, TeamName = "Japan", Location = "Japan", LeagueType = "2020 Olympics", Category = "Indoor", Gender = "Men" },
                new Team { Id = 8, TeamName = "Poland", Location = "Poland", LeagueType = "2020 Olympics", Category = "Indoor", Gender = "Men" },
                new Team { Id = 9, TeamName = "ROC", Location = "Russia", LeagueType = "2020 Olympics", Category = "Indoor", Gender = "Men" },
                new Team { Id = 10, TeamName = "Tunisia", Location = "Tunisia", LeagueType = "2020 Olympics", Category = "Indoor", Gender = "Men" },
                new Team { Id = 11, TeamName = "USA", Location = "United States", LeagueType = "2020 Olympics", Category = "Indoor", Gender = "Men" },
                new Team { Id = 12, TeamName = "Venezuela", Location = "Venezuela", LeagueType = "2020 Olympics", Category = "Indoor", Gender = "Men" },
                new Team { Id = 13, TeamName = "Texas", Location = "University of Texas, Austin TX", LeagueType = "Big 12 Conference", Category = "Indoor", Gender = "Women" },
                new Team { Id = 14, TeamName = "Kansas", Location = "University of Kansas, Lawrence KS", LeagueType = "Big 12 Conference", Category = "Indoor", Gender = "Women" },
                new Team { Id = 15, TeamName = "BYU", Location = "Brigham Young University, Provo UT", LeagueType = "Big 12 Conference", Category = "Indoor", Gender = "Women" },
                new Team { Id = 16, TeamName = "UCF", Location = "University of Central Florida, Orlando FL", LeagueType = "Big 12 Conference", Category = "Indoor", Gender = "Women" },
                new Team { Id = 17, TeamName = "Baylor", Location = "Baylor University, Waco TX", LeagueType = "Big 12 Conference", Category = "Indoor", Gender = "Women" },
                new Team { Id = 18, TeamName = "Iowa State", Location = "Iowa State University, Ames IA", LeagueType = "Big 12 Conference", Category = "Indoor", Gender = "Women" },
                new Team { Id = 19, TeamName = "Houston", Location = "University of Houston, Houston TX", LeagueType = "Big 12 Conference", Category = "Indoor", Gender = "Women" },
                new Team { Id = 20, TeamName = "Kansas State", Location = "Kansas State University, Manhattan KS", LeagueType = "Big 12 Conference", Category = "Indoor", Gender = "Women" },
                new Team { Id = 21, TeamName = "TCU", Location = "Texas Christian University, Fort Worth TX", LeagueType = "Big 12 Conference", Category = "Indoor", Gender = "Women" },
                new Team { Id = 22, TeamName = "Cincinnati", Location = "University of Cincinnati, Cincinnati OH", LeagueType = "Big 12 Conference", Category = "Indoor", Gender = "Women" },
                new Team { Id = 23, TeamName = "Oklahoma", Location = "University of Oklahoma, Norman OK", LeagueType = "Big 12 Conference", Category = "Indoor", Gender = "Women" },
                new Team { Id = 24, TeamName = "West Virginia", Location = "West Virginia University, Morgantown WV", LeagueType = "Big 12 Conference", Category = "Indoor", Gender = "Women" },
                new Team { Id = 25, TeamName = "Texas Tech", Location = "Texas Tech University, Lubbock TX", LeagueType = "Big 12 Conference", Category = "Indoor", Gender = "Women" }
            );
        }
    }
}
