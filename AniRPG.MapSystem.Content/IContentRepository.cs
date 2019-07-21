using System.Collections.Generic;
using System.Threading.Tasks;
using AniRPG.MapSystem.Domain.Entities;

namespace AniRPG.MapSystem.Content
{
    public interface IContentRepository
    {
        Task<IEnumerable<PlaceTransition>> GetTransitionsFromPlace(int placeId);
    }
}