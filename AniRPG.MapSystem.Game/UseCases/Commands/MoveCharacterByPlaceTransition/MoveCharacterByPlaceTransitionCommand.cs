using MediatR;

namespace AniRPG.MapSystem.Game.UseCases.Commands.MoveCharacterByPlaceTransition
{
    public class MoveCharacterByPlaceTransitionCommand : IRequest<bool>
    {
        public int CharacterId { get; set; }
        public int PlaceTransitionId { get; set; }
    }
}
