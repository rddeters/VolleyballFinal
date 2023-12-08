using System.ComponentModel.DataAnnotations;

namespace VolleyballFinal.Models
{
    public class Team
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Team name is required.")]
        [StringLength(100, ErrorMessage = "Team name cannot be more than 100 characters long.")]
        public string TeamName { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        [StringLength(100, ErrorMessage = "Location cannot be more than 100 characters long.")]
        public string Location { get; set; }

        [Required(ErrorMessage = "League type is required.")]
        public string LeagueType { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }
    }
}
