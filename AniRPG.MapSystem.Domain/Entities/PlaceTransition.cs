using AniRPG.MapSystem.Domain.Common;

namespace AniRPG.MapSystem.Domain.Entities
{
    public class PlaceTransition : IEntity
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public Place From { get; set; }
        public Place To { get; set; }

    }
}
