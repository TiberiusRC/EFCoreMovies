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
            //Implementing the modelbuilder files: And applying seed data
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            M3Seeding.Seed(modelBuilder);
            M6Seeding.Seed(modelBuilder);

            // This ensure that no tables or extra columns will be created in the database , but will be usable.(same as [NotMapped] in the class itself.
            //modelBuilder.Ignore<Address>();

            //This is for a keyless entity....
            modelBuilder.Entity<CinemaWithoutLocation>().ToSqlQuery("Select Id , Name FROM Cinemas").ToView(null);

            //Automatic config with fluent api lesson.for configuring URL entries (No longer needed in module 6 , kept for future referrence)
            //foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            //{
            //    //iterate through properties
            //    foreach (var property in entityType.GetProperties())
            //    {
            //        if (property.ClrType==typeof(string)
            //            && property.Name.Contains("URL",StringComparison.CurrentCultureIgnoreCase))
            //        {   //With this any URL will not be of type unicode but varchar
            //            property.SetIsUnicode(false);
            //        }
            //    }
            //}
            modelBuilder.Entity<Merchandising>().ToTable("Merchandising");
            modelBuilder.Entity<RentableMovie>().ToTable("RentableMovies");
            var movie1 = new RentableMovie()
            {
                Id = 1,
                Name = "Starship Troopers",
                MovieId = 1,
                Price = 9.99m,
            };
            var merch1 = new Merchandising()
            {
                Id = 2,
                Available = true,
                IsClothing = true,
                Name = "Tigerstriped goat wool , thong",
                Weight = 1,
                Volume = 1,
                Price = 21
            };
            modelBuilder.Entity<Merchandising>().HasData(merch1);
            modelBuilder.Entity<RentableMovie>().HasData(movie1);




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
        public DbSet<Person>People { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<CinemaDetail>CinemaDetails { get; set; }
        public DbSet<Payment>Payments { get; set; }
        public DbSet<Product>Products { get; set; } 

    }
}
