using System.Threading.Tasks;

namespace Gateway.Core.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
