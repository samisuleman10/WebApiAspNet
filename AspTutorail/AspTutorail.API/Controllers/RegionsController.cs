using AspTutorail.API.Models.Domain;
using AspTutorail.API.Models.DTO;
using AspTutorail.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AspTutorail.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;
        
        public RegionsController(IRegionRepository regionRepository)
        {
            this.regionRepository = regionRepository;
        }
        
        
        [HttpGet]
        public IActionResult GetAllRegions()
        {
            var regions = regionRepository.GetAllAsync();

            // lets return DTOs not domains
            var regionsDTO = new List<Models.DTO.Region>();
            regions.ToList().ForEach(region =>
            {
                var regionDTO = new Models.DTO.Region()
                {
                    Id = region.Id,
                    Code = region.Code,
                    Name = region.Name,
                    Area = region.Area,
                    Lat = region.Lat,
                    Long = region.Long,
                    Population = region.Population,
                };

                regionsDTO.Add(regionDTO);
            });

            return Ok(regionsDTO);
        }
    }
}
