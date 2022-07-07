using EFCoreMovies.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EFCoreMovies.Utilities;

namespace EFCoreMovies.Controllers
{   // Creating a controller / API (End points)for Genres
    [ApiController]
    [Route("api/genres")]
    public class GenresController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public GenresController(ApplicationDbContext context)
        {
            this.context = context;
        }
        // Good practice is to always use Async when using IO operations in this method.
        [HttpGet]
        public async Task<IEnumerable<Genre>> Get()
        {
            return await context.Genres.AsNoTracking()
                .OrderBy(g => g.Name)
                .ToListAsync();
        }       


    }
}
