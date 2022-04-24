
using NeorisNetcoreAngularCleanArchitecture.Core.CustomEntities;
using NeorisNetcoreAngularCleanArchitecture.Core.Entities;

namespace NeorisNetcoreAngularCleanArchitecture.Core.Interfaces.Services
{
    public interface IUserService
    {
        PageList<Usuario> Get();
    }
}