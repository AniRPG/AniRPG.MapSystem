using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AniRPG.MapSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AniRPG.MapSystem.Content.Persistence.Repositories
{
    public class ContentRepository : MapSystemRepositoryBase, IContentRepository
    {
        public async Task<IEnumerable<PlaceTransition>> GetTransitionsFromPlace(int placeId)
        {
            return await DbContext.PlaceTransitions.Where(pt => pt.From.Id == placeId).ToListAsync();
        }

        public ContentRepository(MapSystemContentDbContext dbContext) : base(dbContext)
        {
        }
    }
}