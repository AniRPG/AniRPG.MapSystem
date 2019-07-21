using AniRPG.MapSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AniRPG.MapSystem.Content.Persistence.Repositories.EntityRepositories
{
    public class PlaceTransitionRepository : EntityRepositoryBase<PlaceTransition>
    {
        public PlaceTransitionRepository(DbContext dbContext, DbSet<PlaceTransition> dbSet) : base(dbContext, dbSet)
        {
        }
    }
}