using AniRPG.MapSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AniRPG.MapSystem.Content.Persistence
{
    public class MapSystemContentDbContext : DbContext
    {
        public MapSystemContentDbContext(DbContextOptions<MapSystemContentDbContext> options)
        {
            Database.EnsureCreated();
        }
        
        public DbSet<Location> Locations { get; set; }

        public DbSet<Place> Places { get; set; }

        public DbSet<PlaceTransition> PlaceTransitions { get; set; }
    }
}