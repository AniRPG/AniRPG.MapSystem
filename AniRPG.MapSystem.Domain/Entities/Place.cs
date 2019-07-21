using AniRPG.Core.Domain;

namespace AniRPG.MapSystem.Domain.Entities
{
    public class Place : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
