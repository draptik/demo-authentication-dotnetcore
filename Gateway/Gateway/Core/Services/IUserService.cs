using Gateway.Core.Models;
using Gateway.Core.Services.Communication;
using System.Threading.Tasks;

namespace Gateway.Core.Services
{
    public interface IUserService
    {
        Task<CreateUserResponse> CreateUserAsync(User user, params ERole[] userRoles);
        Task<User> FindByEmailAsync(string email);
    }
}
