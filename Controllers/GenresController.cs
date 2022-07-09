using EFCoreMovies.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EFCoreMovies.Utilities;
using EFCoreMovies.DTOs;
using AutoMapper;

namespace EFCoreMovies.Controllers
{   // Creating a controller / API (End points)for Genres
    [ApiController]
    [Route("api/genres")]
    public class GenresController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public GenresController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        // Good practice is to always use Async when using IO operations in this method.
        [HttpGet]
        public async Task<IEnumerable<Genre>> Get()
        {
            context.Logs.Add(new Log { Message = "Executing Get from GenresController!" });
            await context.SaveChangesAsync();   
            return await context.Genres.AsNoTracking()                
                //.OrderBy(g => g.Name)
                .OrderByDescending(g=> EF.Property<DateTime>(g,"CreatedDate"))//Ordered by date , through shadow property
                .ToListAsync();
        }


        [HttpGet("{id:int} Shadow prop lesson")]
        public async Task<ActionResult<Genre>>Get(int id)
        {
            var genre = await context.Genres.FirstOrDefaultAsync(p => p.Id == id);
            if(genre is null)
            {
                return NotFound();
            }
            //context.Entry() is to access metadata in this case the shadowproperties
            var createdDate = context.Entry(genre).Property<DateTime>("CreatedDate").CurrentValue;
            return Ok(new
            {
                Id = genre.Id,
                Name = genre.Name,
                CreatedDate = createdDate
            });
        }


        [HttpPost]
        public async Task<ActionResult>Post(GenreCreationDTO genreCreationDTO)
        {
            // Genre name was indexed and declared unique , this is to check for duplicate entry. See index at Genre.cs or Genreconfig.cs
            var genreExists = await context.Genres.AnyAsync(p=>p.Name == genreCreationDTO.Name);
            if (genreExists)
            {
                return BadRequest($"This Genre name already exists , Name = {genreCreationDTO.Name}");
            }

            var genre = mapper.Map<Genre>(genreCreationDTO);
            context.Add(genre);//marking genre as added.not directly posting in db           
            await context.SaveChangesAsync();//apply changes to Db            
            return Ok();
            //Added DTO to access only the name property
        }
        [HttpPost("several")]
        //API to post several entry in the json.
        public async Task<ActionResult> Post(GenreCreationDTO[] genreDTO)
        {
            var genres = mapper.Map<Genre[]>(genreDTO);
            context.AddRange(genres);
            await context.SaveChangesAsync();   
            return Ok();
           
        }
        //Endpoint api for deleting genres by id
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var genre = await context.Genres.FirstOrDefaultAsync(p=>p.Id == id);
            if (genre is null)
            {
                return NotFound();
            }
            context.Remove(genre);
            await context.SaveChangesAsync();
            return Ok();
        }
        //Endpoint api for soft deleting genres by id (hiding from view)
        [HttpDelete("softdelete/{id:int}")]
        public async Task<ActionResult> SoftDelete(int id)
        {
            var genre = await context.Genres.FirstOrDefaultAsync(p => p.Id == id);
            if (genre is null)
            {
                return NotFound();
            }
            genre.IsDeleted = true;
            await context.SaveChangesAsync();
            return Ok();
        }
        //Endpoint api for restoring ,soft deleted genres by id (bringing back in to view)
        [HttpPost("restore/{id:int}")]
        public async Task<ActionResult> Restore(int id)
        {
            var genre = await context.Genres.IgnoreQueryFilters().FirstOrDefaultAsync(p => p.Id == id);
            if (genre is null)
            {
                return NotFound();
            }
            genre.IsDeleted = false;
            await context.SaveChangesAsync();
            return Ok();
        }
        

    }
}
