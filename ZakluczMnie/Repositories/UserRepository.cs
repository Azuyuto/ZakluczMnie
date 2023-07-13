using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ZakluczMnie.Data;
using ZakluczMnie.Interfaces;

namespace ZakluczMnie.Repositories
{
    public class UserRepository : Repository<IdentityUser>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
