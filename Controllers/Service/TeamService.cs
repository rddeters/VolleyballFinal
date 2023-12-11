using Microsoft.AspNetCore.Mvc;
using VolleyballFinal.Models;

namespace VolleyballFinal.Controllers.Service
{
    public class TeamService
    {
        private readonly TeamContext _context;

        public TeamService(TeamContext context)
        {
            _context = context;
        }

        public List<Team> GetAllTeams()
        {
            return _context.Teams.ToList();
        }

        public List<Team> GetTeamsByLeague(string leagueType)
        {
            if (string.IsNullOrEmpty(leagueType) || leagueType.ToLower() == "all")
            {
                return _context.Teams.OrderBy(t => t.TeamName).ToList();
            }
            else
            {
                return _context.Teams.Where(t => t.LeagueType.ToLower() == leagueType.ToLower())
                                     .OrderBy(t => t.TeamName).ToList();
            }
        }

        public Team GetTeam(int id)
        {
            return _context.Teams.FirstOrDefault(t => t.Id == id);
        }

        public List<Player> GetPlayersByTeamName(string teamName)
        {
            return _context.Player.Where(p => p.TeamName == teamName).ToList();
        }


        public void AddTeam(Team team)
        {
            _context.Teams.Add(team);
            _context.SaveChanges();
        }

        public void UpdateTeam(Team team)
        {
            _context.Teams.Update(team);
            _context.SaveChanges();
        }

        public void DeleteTeam(Team team)
        {
            _context.Teams.Remove(team);
            _context.SaveChanges();
        }
    }
}
