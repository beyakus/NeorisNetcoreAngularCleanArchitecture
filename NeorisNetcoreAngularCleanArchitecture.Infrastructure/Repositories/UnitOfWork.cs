using System.Threading.Tasks;
using NeorisNetcoreAngularCleanArchitecture.Core.Entities;
using NeorisNetcoreAngularCleanArchitecture.Core.Interfaces;
using NeorisNetcoreAngularCleanArchitecture.Core.Interfaces.Repositories;
using NeorisNetcoreAngularCleanArchitecture.Infrastructure.Data;

namespace NeorisNetcoreAngularCleanArchitecture.Infrastructure.Repositories
{
  public class UnitOfWork : IUnitOfWork
  {
    private readonly IRepository<Usuario> _userRepository;

    private readonly CaimanDbContext _context; 
    public UnitOfWork(CaimanDbContext _context)
    {
        this._context = _context;
    }

    public IRepository<Usuario> userRepository => this._userRepository ?? new Repository<Usuario>(this._context);
    

    public void Dispose()
    {
      if(this._context != null)
      {
          this._context.Dispose();
      }
    }

    public async Task SaveChangesAsync()
    {
      await this._context.SaveChangesAsync();
    }

    public void SaveChanges()
    {
        this._context.SaveChanges();
    }
  }
}