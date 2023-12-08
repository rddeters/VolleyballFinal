using System.ComponentModel.DataAnnotations;

namespace VolleyballFinal.Models
{
    public class Statistic
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Player name is required.")]
        [StringLength(100, ErrorMessage = "Player name cannot be more than 100 characters long.")]
        public string PlayerName { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Total points must be a positive number.")]
        public int TotalPoints { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Attack points must be a positive number.")]
        public int AttackPoints { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Block points must be a positive number.")]
        public int BlockPoints { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Serve points must be a positive number.")]
        public int ServePoints { get; set; }

        [Range(-100, 100, ErrorMessage = "Efficiency must be between -100 and 100.")]
        public double Efficiency { get; set; }
    }
}
