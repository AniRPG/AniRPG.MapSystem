using System.Collections.Generic;
using AniRPG.MapSystem.Domain.Entities;
using MediatR;

namespace AniRPG.MapSystem.Content.UseCases.Queries.GetTransitionsFromPlace
{
    public class GetTransitionsFromPlaceQuery : IRequest<IEnumerable<PlaceTransition>>
    {
        public int PlaceId { get; set; }
    }
}