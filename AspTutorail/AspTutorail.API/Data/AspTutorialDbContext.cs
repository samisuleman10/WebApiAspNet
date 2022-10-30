using AspTutorail.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace AspTutorail.API.Data
{
    public class AspTutorialDbContext : DbContext
    {
        public AspTutorialDbContext(DbContextOptions<AspTutorialDbContext> options) : base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }

    }
}
