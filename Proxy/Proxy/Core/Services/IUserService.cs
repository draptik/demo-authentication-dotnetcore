using Proxy.Core.Models;
using Proxy.Core.Services.Communication;
using System.Threading.Tasks;

namespace Proxy.Core.Services
{
    public interface IUserService
    {
        Task<CreateUserResponse> CreateUserAsync(User user, params ERole[] userRoles);
        Task<User> FindByEmailAsync(string email);
    }
}
