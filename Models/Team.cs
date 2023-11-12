using System.Runtime.CompilerServices;

namespace VolleyballFinal.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public string Location { get; set; }
        public string LeagueType { get; set; }
        public string Category { get; set; }
        public string Gender { get; set; }
    }
}
