using EFCoreMovies.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMovies.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ProductsController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Get()
        {
            return await context.Products.ToListAsync();
        }
        [HttpGet("merchandising")]
        public async Task<ActionResult<IEnumerable<Merchandising>>> GetMerchandising()
        {
            return await context.Set<Merchandising>().ToListAsync();
        }
        [HttpGet("rentableMovie")]
        public async Task<ActionResult<IEnumerable<RentableMovie>>> GetRentableMovie()
        {
            return await context.Set<RentableMovie>().ToListAsync();
        }
    }
}
