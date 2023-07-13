using Microsoft.AspNetCore.Identity;
using ZakluczMnie.Data;

namespace ZakluczMnie.Interfaces
{
    public interface IUserRepository : IRepository<IdentityUser>
    {
    }
}
