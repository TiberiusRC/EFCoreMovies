using EFCoreMovies.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EFCoreMovies
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {            

        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            //Creates defaults for fluent api
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
            configurationBuilder.Properties<string>().HaveMaxLength(150);
        }

        //For use with fluent API.
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);  
            //All modelbuilder files have been moved to their seperate Config files in the Configurations folder  to reduce code                 
            //Implementing the modelbuilder files:
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());                

        }
        //Setting the Entities(in plural) ( So that the tables are also queryable)
        public DbSet<Genre>Genres{get;set;}
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<CinemaOffer> CinemaOffers { get; set; }
        public DbSet<CinemaHall>CinemaHalls { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }
    }
}
