using EFCoreMovies.Entities;
using EFCoreMovies.Entities.Seeding;
using EFCoreMovies.Entities.Configurations;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using EFCoreMovies.Entities.Keyless;

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
            M3Seeding.Seed(modelBuilder);

            // This ensure that no tables or extra columns will be created in the database , but will be usable.(same as [NotMapped] in the class itself.
            modelBuilder.Ignore<Address>();

            //This is for a keyless entitie....
            modelBuilder.Entity<CinemaWithoutLocation>().ToSqlQuery("Select Id , Name FROM Cinemas").ToView(null);

        }
        //Setting the Entities(in plural) ( So that the tables are also queryable)
        public DbSet<Genre>Genres{get;set;}
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<CinemaOffer> CinemaOffers { get; set; }
        public DbSet<CinemaHall>CinemaHalls { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }
        public DbSet<Log>Logs { get; set; }
    }
}
