using Microsoft.AspNetCore.Identity;

namespace VolleyballFinal.Models.Admin
{
    public class AdminViewModel
    {
        public IEnumerable<User> Users { get; set; } = null!;
        public IEnumerable<IdentityRole> Roles { get; set; } = null!;
    }
}
