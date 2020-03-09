using Gateway.Core.Models;
using System.Threading.Tasks;

namespace Gateway.Core.Repositories
{
    public interface IUserRepository
    {
        Task AddAsync(User user, ERole[] userRoles);
        Task<User> FindByEmailAsync(string email);
    }
}
