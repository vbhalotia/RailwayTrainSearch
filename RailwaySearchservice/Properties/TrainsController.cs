using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace RailwaySearchservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainsController : ControllerBase
    {

        private readonly ITrainService _trainService;

        public TrainsController(ITrainService trainService)
        {
            _trainService = trainService;
        }

        [HttpGet("search")]
        public IActionResult SearchTrains(string origin, string destination)
        {
            var trains = _trainService.SearchTrains(origin, destination);
            if (!trains.Any())
            {
                return NotFound("No trains found for the specified route.");
            }
            return Ok(trains);
        }
    }
}
