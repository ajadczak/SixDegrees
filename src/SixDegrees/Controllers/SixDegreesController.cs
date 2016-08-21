using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SixDegrees.Core;

namespace SixDegrees.API.Controllers
{
    [Route("api/[controller]")]
    public class SixDegreesController : Controller
    {
        private readonly ISixDegreesService _service;

        public SixDegreesController(ISixDegreesService service)
        {
            _service = service;
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var result = await _service.GetMovieById(id);
            if (result.Response)
            {
                return Ok(result);
            }
            return NotFound();
        }
    }
}
