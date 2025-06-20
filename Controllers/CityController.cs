using Microsoft.AspNetCore.Mvc;
using RailwayTicketSystem.Models;
using System.Linq;

namespace RailwayTicketSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly RailwayDbContext _context;

        public CityController(RailwayDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get(string term)
        {
            if (string.IsNullOrWhiteSpace(term))
            {
                return Ok(new List<string>());
            }

            var matchedCities = _context.Cities
                .Where(c => c.Name.StartsWith(term))
                .Select(c => c.Name)
                .Take(10)
                .ToList();

            return Ok(matchedCities);
        }
    }
}
