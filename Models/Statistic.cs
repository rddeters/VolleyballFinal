namespace VolleyballFinal.Models
{
    public class Statistic
    {
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public int TotalPoints { get; set; }
        public int AttackPoints { get; set; }
        public int BlockPoints { get; set; }
        public int ServePoints { get; set; }
        public double Efficiency { get; set; }
    }
}

