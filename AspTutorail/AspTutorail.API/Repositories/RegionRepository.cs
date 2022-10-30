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

            public async Task<IEnumerable<Region>> GetAllAsync()
            {
                return await nZWalksDbContext.Regions.ToListAsync();
            }
    }
}
