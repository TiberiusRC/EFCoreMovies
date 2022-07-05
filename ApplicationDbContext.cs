using EFCoreMovies.Entities;
using Microsoft.EntityFrameworkCore;

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
            //Creation of Genre entity
            modelBuilder.Entity<Genre>().Property(p => p.Name).IsRequired();
            //Creation of Actor entity
            modelBuilder.Entity<Actor>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<Actor>().Property(p => p.Biography).HasColumnType("nvarchar(max)");
            //Creation of Cinema entity
            modelBuilder.Entity<Cinema>().Property(p => p.Name).IsRequired();
            //Creation of CinemaHall entity
            modelBuilder.Entity<CinemaHall>().Property(p => p.Cost).HasPrecision(precision: 9, scale: 2);
            modelBuilder.Entity<CinemaHall>().Property(p => p.CinemaHallType).HasDefaultValue(CinemaHallType.TwoDimensions);
            //Creation of Movie entity
            modelBuilder.Entity<Movie>().Property(p => p.Title).HasMaxLength(250).IsRequired();           
            modelBuilder.Entity<Movie>().Property(p => p.PosterUrl).HasMaxLength(500).IsUnicode(false);
            //Creation of CinemaOffer entity
            modelBuilder.Entity<CinemaOffer>().Property(p => p.DiscountPercentage).HasPrecision(precision: 5, scale: 2);                      
            //Creation of MovieActor entity
            modelBuilder.Entity<MovieActor>().HasKey(p => new { p.MovieId, p.ActorId });          

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
