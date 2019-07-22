using System;
using System.Collections.Generic;
using System.Text;
using AniRPG.Core.Domain;

namespace AniRPG.MapSystem.Domain.Entities
{
    public class CharacterInfo : IEntity
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public int LocationId { get; set; }
        public int PlaceId { get; set; }
    }
}
