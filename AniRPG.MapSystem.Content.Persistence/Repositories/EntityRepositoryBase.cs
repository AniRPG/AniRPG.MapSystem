using System.Threading.Tasks;
using AniRPG.Core.Common.Repositories;
using AniRPG.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace AniRPG.MapSystem.Content.Persistence.Repositories
{
    public abstract class EntityRepositoryBase<T> : IEntityRepository<T>
        where T : class, IEntity
    {
        private readonly DbSet<T> _dbSet;
        private readonly DbContext _dbContext;

        public async Task CreateEntity(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task DeleteEntity(int entityId)
        {
            var entity = await GetEntity(entityId);
            _dbSet.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateEntity(T entity)
        {
            _dbSet.Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<T> GetEntity(int entityId)
        {
            return await _dbSet.FirstAsync(e => e.Id == entityId);
        }

        protected EntityRepositoryBase(DbContext dbContext, DbSet<T> dbSet)
        {
            _dbContext = dbContext;
            _dbSet = dbSet;
        }
    }
}