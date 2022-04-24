using System.Threading.Tasks;
using NeorisNetcoreAngularCleanArchitecture.Core.Entities;
using NeorisNetcoreAngularCleanArchitecture.Core.Interfaces.Repositories;

namespace NeorisNetcoreAngularCleanArchitecture.Core.Interfaces
{
    public interface IUnitOfWork
    {
        
        IRepository<Usuario> userRepository { get; }
        Task SaveChangesAsync();
        void SaveChanges();
    }
}