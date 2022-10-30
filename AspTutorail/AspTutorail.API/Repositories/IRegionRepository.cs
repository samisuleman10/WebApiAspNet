using AspTutorail.API.Models.Domain;

namespace AspTutorail.API.Repositories
{

    public interface IRegionRepository
    {
        IEnumerable<Region> GetAllAsync();
    }

}
