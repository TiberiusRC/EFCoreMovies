using AutoMapper;
using AutoMapper.QueryableExtensions;
using EFCoreMovies.DTOs;
using EFCoreMovies.Entities;
using EFCoreMovies.Entities.Keyless;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite;
using NetTopologySuite.Geometries;

namespace EFCoreMovies.Controllers
{
    [ApiController]
    [Route("api/cinemas")]
    public class CinemasController : ControllerBase 
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public CinemasController(ApplicationDbContext context,IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IEnumerable<CinemaDTO>>Get()
        {
            return await context.Cinemas.ProjectTo<CinemaDTO>(mapper.ConfigurationProvider).ToListAsync();
        }

        // A api endpoint for a keyless entity
        [HttpGet("withoutLocation")]
        public async Task<IEnumerable<CinemaWithoutLocation>> GetWithoutLocation()
        {   // Set<>() is an example to create a DBSet without going to ApplicationDbContext and adding it there.
            return await context.Set<CinemaWithoutLocation>().ToListAsync();
        }






        [HttpGet("closetome")]
        public async Task<ActionResult>Get(double latitude,double longitude)
        {
            var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);
            var myLocation = geometryFactory.CreatePoint(new Coordinate(longitude,latitude));
            var maxDistanceInMeters = 2000;
            var cinemas = await context.Cinemas
                .OrderBy(c => c.Location.Distance(myLocation))
                .Where(c => c.Location.IsWithinDistance(myLocation, maxDistanceInMeters))
                .Select(c => new
                {
                    Name = c.Name,
                    Distance = Math.Round(c.Location.Distance(myLocation))
                }).ToListAsync();
            return Ok(cinemas);
                
        }
        [HttpPost]
        public async Task<ActionResult>Post()
        {
            var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);
            var cinemaLocation = geometryFactory.CreatePoint(new Coordinate(-69.913539,18.476256));

            //Create a small json setup for post request
            var cinema = new Cinema()
            {
                Name = "My cinema",
                Location = cinemaLocation,
                CinemaOffer = new CinemaOffer()
                {
                    DiscountPercentage = 5,
                    Begin = DateTime.Today,
                    End = DateTime.Today.AddDays(7)
                },
                CinemaHall = new HashSet<CinemaHall>()
                {
                    new CinemaHall()
                    {
                        Cost = 200,
                        CinemaHallType = CinemaHallType.ThreeDimensions
                    }
                }
            };
            context.Add(cinema);
            await context.SaveChangesAsync();
            return Ok();
        }
                
        [HttpPost("withDTO")]
        public async Task<ActionResult> Post(CinemaCreationDTO cinemaCreationDTO)
        {
            var cinema = mapper.Map<Cinema>(cinemaCreationDTO);
            context.Add(cinema);
            await context.SaveChangesAsync();
            return Ok();
        }


        //Endpoint to return multiple items together ( cinema,cinemHall and cinemaOffer)
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var cinemaDB = await context.Cinemas
               .Include(c => c.CinemaHall)
               .Include(c => c.CinemaOffer)
               .FirstOrDefaultAsync(c => c.Id == id);
            if (cinemaDB is null)
            {
                return NotFound();
            }
            cinemaDB.Location = null;
            return Ok(cinemaDB);
        }


        // Endpoint to update multiple items together ( cinema,cinemHall and cinemaOffer)
        [HttpPut("{id:int}")]
        public async Task<ActionResult>Put(CinemaCreationDTO cinemaCreationDTO ,int id)
        {
            var cinemaDB = await context.Cinemas
                .Include(c => c.CinemaHall)
                .Include(c => c.CinemaOffer)
                .FirstOrDefaultAsync(c => c.Id==id);
            if(cinemaDB is null)
            {
                return NotFound();
            }
            //This will handle all the use cases
            cinemaDB = mapper.Map(cinemaCreationDTO, cinemaDB);
            await context.SaveChangesAsync();
            return Ok();
        }


    }
}
