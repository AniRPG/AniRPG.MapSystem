using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AniRPG.MapSystem.Domain.Entities;
using MediatR;

namespace AniRPG.MapSystem.Content.UseCases.Queries.GetTransitionsFromPlace
{
    public class GetTransitionsFromPlaceQueryHandler
        : IRequestHandler<GetTransitionsFromPlaceQuery, IEnumerable<PlaceTransition>>
    {
        private readonly IContentRepository _repository;

        public GetTransitionsFromPlaceQueryHandler(IContentRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<PlaceTransition>> Handle(
            GetTransitionsFromPlaceQuery request,
            CancellationToken cancellationToken)
        {
            return await _repository.GetTransitionsFromPlace(request.PlaceId);
        }
    }
}