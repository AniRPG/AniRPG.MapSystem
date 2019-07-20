using System.Collections.Generic;

namespace AniRPG.MapSystem.Domain.Entities
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Place> Places { get; private set; }
        public Location()
        {
            Places = new List<Place>();
        }
    }
}
