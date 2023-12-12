using System.IdentityModel.Tokens.Jwt;

namespace VolleyballFinal.Models
{
    public class VolleyballSession
    {
        private const string TeamsKey = "myteams";
        private const string PlayersKey = "myplayers";
        private const string CountKey = "teamcount";

        private ISession session { get; set; }
        public VolleyballSession(ISession session) => this.session = session;

        public void SetMyTeams(List<Team> teams)
        {
            session.SetObject(TeamsKey, teams); 
            session.SetInt32(CountKey, teams.Count());
        }

        public void SetMyPlayers(List<Player> players)
        {
            session.SetObject(PlayersKey, players);
            session.SetInt32(CountKey, players.Count());
        }

        public List<Team> GetMyTeams() => session.GetObject<List<Team>>(TeamsKey) ?? new List<Team>();
        public int? GetMyTeamCount() => session.GetInt32(CountKey);

        public List<Player> GetMyPlayers() => session.GetObject<List<Player>>(PlayersKey) ?? new List<Player>();
        public int? GetMyPlayerCount() => session.GetInt32(CountKey);
    }
}
