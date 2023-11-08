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
            base.OnModelCreating(modelBuilder);

            //seed initial data here for team, player, statistic
            
        }

    }
}
