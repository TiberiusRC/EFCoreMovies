using EFCoreMovies.DTOs;
using EFCoreMovies.Entities;
using EFCoreMovies.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMovies.Controllers
{
    [ApiController]
    [Route("api/actors")]
    public class ActorController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ActorController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<IEnumerable<ActorDTO>> Get(int page = 1, int recordsToTake = 2)
        {
            return await context.Actors.AsNoTracking()
                .OrderBy(g => g.Name)
                .Select(a => new ActorDTO { Id=a.Id,Name=a.Name,DateOfBirth=a.DateOfBirth})
                .Paginate(page, recordsToTake)
                .ToListAsync();
        }
    }
}
