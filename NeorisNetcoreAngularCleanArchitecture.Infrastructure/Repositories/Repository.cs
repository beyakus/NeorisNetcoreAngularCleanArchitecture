using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NeorisNetcoreAngularCleanArchitecture.Core.Entities;
using NeorisNetcoreAngularCleanArchitecture.Core.Interfaces.Repositories;
using NeorisNetcoreAngularCleanArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace NeorisNetcoreAngularCleanArchitecture.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
  {
        private readonly CaimanDbContext _context; 
        protected readonly DbSet<T> entity;
        public Repository(CaimanDbContext _context)
        {
            this._context = _context;
            this.entity = this._context.Set<T>();
        }
        
        public IEnumerable<T> Get()
        {
            return this.entity.AsEnumerable();
        }

        public async Task Store(T entity)
        {
            await this.entity.AddAsync(entity);
        }

        public void Update(T entity)
        {
            this.entity.Update(entity);
        }
    }
}