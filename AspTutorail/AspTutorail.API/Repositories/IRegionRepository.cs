using AspTutorail.API.Models.Domain;

namespace AspTutorail.API.Repositories
{

    public interface IRegionRepository
    {
        Task <IEnumerable<Region>> GetAllAsync();
        Task <Region> GetAsync(Guid id);
        Task <Region> AddAsync(Region id);
        Task<Region> DeleteAsync(Guid id);
        Task<Region> UpdateAsync(Guid id, Region region);
    }

}
