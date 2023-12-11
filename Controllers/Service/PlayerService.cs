using Microsoft.AspNetCore.Mvc;
using VolleyballFinal.Models;

namespace VolleyballFinal.Controllers.Service
{
    public class PlayerService
    {
        private readonly TeamContext _context;

        public PlayerService(TeamContext context)
        {
            _context = context;
        }

        public List<Player> GetAllPlayers()
        {
            return _context.Player.ToList();
        }

        public List<Player> GetPlayersByPosition(string position)
        {
            if (string.IsNullOrEmpty(position) || position.ToLower() == "all")
            {
                return _context.Player.OrderBy(p => p.PlayerName).ToList();
            }
            else
            {
                return _context.Player.Where(p => p.Position.ToLower() == position.ToLower())
                                      .OrderBy(p => p.PlayerName).ToList();
            }
        }

        public Player GetPlayerById(int id)
        {
            return _context.Player.FirstOrDefault(p => p.PlayerId == id);
        }

        public void AddOrUpdatePlayer(Player player)
        {
            if (player.PlayerId == 0)
            {
                _context.Player.Add(player);
            }
            else
            {
                _context.Player.Update(player);
            }
            _context.SaveChanges();
        }

        public void DeletePlayer(Player player)
        {
            _context.Player.Remove(player);
            _context.SaveChanges();
        }
    }
}
