using AspTutorail.API.Data;
using AspTutorail.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace AspTutorail.API.Repositories
{
    public class RegionRepository : IRegionRepository
    {
            private readonly AspTutorialDbContext nZWalksDbContext;

            public RegionRepository(AspTutorialDbContext nZWalksDbContext)
            {
                this.nZWalksDbContext = nZWalksDbContext;
            }

        public async Task<Region> AddAsync(Region region)
        {
            region.Id = Guid.NewGuid();
            await nZWalksDbContext.AddAsync(region);
            await nZWalksDbContext.SaveChangesAsync(); 
            return region;
        }

        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            return await nZWalksDbContext.Regions.ToListAsync();
        }

        public async Task<Region> GetAsync(Guid id)
        {
            return await nZWalksDbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
