using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace AniRPG.MapSystem.Game.UseCases.Commands.MoveCharacterByPlaceTransition
{
    public class MoveCharacterByTransitionCommandHandler : IRequestHandler<MoveCharacterByPlaceTransitionCommand, bool>
    {
        // TO DO: wait for Content.Persistence
        public Task<bool> Handle(MoveCharacterByPlaceTransitionCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
