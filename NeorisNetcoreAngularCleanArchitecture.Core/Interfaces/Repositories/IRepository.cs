using System.Collections.Generic;
using System.Threading.Tasks;
using NeorisNetcoreAngularCleanArchitecture.Core.Entities;

namespace NeorisNetcoreAngularCleanArchitecture.Core.Interfaces.Repositories
{
    public interface IRepository<T> where T: Entity
    {
        IEnumerable<T> Get();
        Task Store(T entity);
        void Update(T entity);
    }
}