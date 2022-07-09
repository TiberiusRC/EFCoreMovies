using EFCoreMovies.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMovies.Controllers
{
    [ApiController]
    [Route("api/people")]
    public class PeopleController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public PeopleController(ApplicationDbContext context)
        {
            this.context = context;
        }
        //Get to see person and messages
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Person>> Get(int id)
        {
            var person = await context.People
                .Include(p=>p.SentMessages)
                .Include(p=>p.RecievedMessages)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (person is null)
            {
                return NotFound();
            }
            return person;



        }


    }
}
