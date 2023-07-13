using Microsoft.AspNetCore.Identity;

namespace ZakluczMnie.Data
{
    public class ApplicationUser : IdentityUser
    {
        public required List<AspNetUserRiddle> Riddles { get; set; }
    }
}
