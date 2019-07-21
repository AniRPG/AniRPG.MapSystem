namespace AniRPG.MapSystem.Content.Persistence.Repositories
{
    public abstract class MapSystemRepositoryBase
    {
        protected MapSystemContentDbContext DbContext { get; }

        protected MapSystemRepositoryBase(MapSystemContentDbContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}