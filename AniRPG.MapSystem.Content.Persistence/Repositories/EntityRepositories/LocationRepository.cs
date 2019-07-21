using AniRPG.MapSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AniRPG.MapSystem.Content.Persistence.Repositories.EntityRepositories
{
    public class LocationRepository : EntityRepositoryBase<Location>
    {
        public LocationRepository(DbContext dbContext, DbSet<Location> dbSet) : base(dbContext, dbSet)
        {
        }
    }
}