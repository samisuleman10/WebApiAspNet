using AspTutorail.API.Models.Domain;

namespace AspTutorail.API.Repositories
{

    public interface IRegionRepository
    {
        Task <IEnumerable<Region>> GetAllAsync();
    }

}
