using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFDBFrist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly moviesContext _context;

        public MoviesController(moviesContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetMovies()
        {
            return Ok(await _context.Movies
                .Include(g => g.Genre)
                .Include(r => r.Reviews)
                .Include(d => d.Director)
                .ToListAsync());
        }
    }
}
