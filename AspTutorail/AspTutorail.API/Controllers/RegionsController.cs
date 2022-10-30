using AspTutorail.API.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace AspTutorail.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        [HttpGet]
        public IActionResult GetAllRegions()
        {
            List<Region> regions = new List<Region>()
            {
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "xxx",
                    Code = "WLG",
                    Area = 227755,
                    Lat = -1.8822,
                    Long = 299.88,
                    Population = 5000
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "yyy",
                    Code = "wer",
                    Area = 447755,
                    Lat = -2.8822,
                    Long = 333.18,
                    Population = 2000
                },

            };
            return Ok(regions);
        }


    }
}
