using NeorisNetcoreAngularCleanArchitecture.Core.CustomEntities;
using NeorisNetcoreAngularCleanArchitecture.Core.Entities;
using NeorisNetcoreAngularCleanArchitecture.Core.Interfaces;
using NeorisNetcoreAngularCleanArchitecture.Core.Interfaces.Services;
using Microsoft.Extensions.Options;

namespace NeorisNetcoreAngularCleanArchitecture.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly PaginationConfiguration paginationConfiguration;
        public UserService(IUnitOfWork unitOfWork, IOptions<PaginationConfiguration> options)
        {
            this.unitOfWork = unitOfWork;
            paginationConfiguration = options.Value;
        }
        
        public PageList<Usuario> Get()
        {
            var users = this.unitOfWork.userRepository.Get();
            var paginateUsers = PageList<Usuario>.Create(users, paginationConfiguration.DefaultPageNumber, paginationConfiguration.DefaultPageSize);
            return paginateUsers;
        }
    }
}