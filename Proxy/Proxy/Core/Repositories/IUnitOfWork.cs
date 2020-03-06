using System.Threading.Tasks;

namespace Proxy.Core.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
