using AspTutorail.API.Models.Domain;
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
             return Ok(regionRepository.GetAllAsync());
        }


    }
}
