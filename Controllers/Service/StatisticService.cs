using Microsoft.AspNetCore.Mvc;
using VolleyballFinal.Models;

namespace VolleyballFinal.Controllers.Service
{
    public class StatisticService
    {
        private readonly TeamContext _context;

        public StatisticService(TeamContext context)
        {
            _context = context;
        }

        public List<Statistic> GetAllStatistics()
        {
            return _context.Statistics.ToList();
        }

        public Statistic GetStatisticById(int id)
        {
            return _context.Statistics.FirstOrDefault(s => s.Id == id);
        }

        public void AddOrUpdateStatistic(Statistic statistic)
        {

            var existingStatistic = _context.Statistics.Find(statistic.Id);
            if (existingStatistic == null)
            {
                _context.Statistics.Add(statistic);
            }
            else
            {
                _context.Statistics.Update(statistic);
            }
            _context.SaveChanges();
        }

        public void DeleteStatistic(Statistic statistic)
        {
            _context.Statistics.Remove(statistic);
            _context.SaveChanges();
        }
    }
}
