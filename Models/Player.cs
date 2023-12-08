using System.ComponentModel.DataAnnotations;

namespace VolleyballFinal.Models
{
    public class Player
    {
        public int PlayerId { get; set; }

        [Required(ErrorMessage = "Player name is required.")]
        [StringLength(100, ErrorMessage = "Player name cannot be longer than 100 characters.")]
        public string PlayerName { get; set; }

        [Required(ErrorMessage = "Number is required.")]
        [Range(1, 99, ErrorMessage = "Number must be between 1 and 99.")]
        public int Number { get; set; }

        [Required(ErrorMessage = "Team name is required.")]
        public string TeamName { get; set; }

        [Required(ErrorMessage = "Position is required.")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Age is required.")]
        [Range(1, 100, ErrorMessage = "Age must be between 1 and 100.")]
        public string Age { get; set; }

        [Required(ErrorMessage = "Height is required.")]
        public string Height { get; set; }
    }
}
