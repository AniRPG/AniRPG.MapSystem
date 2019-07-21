using AniRPG.MapSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AniRPG.MapSystem.Content.Persistence.Repositories.EntityRepositories
{
    public class PlaceRepository : EntityRepositoryBase<Place>
    {
        public PlaceRepository(DbContext dbContext, DbSet<Place> dbSet) : base(dbContext, dbSet)
        {
        }
    }
}