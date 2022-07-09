using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreMovies.Entities.Configurations
{
    public class MovieActorConfig : IEntityTypeConfiguration<MovieActor>
    {
        public void Configure(EntityTypeBuilder<MovieActor> builder)
        {
            //Creation of MovieActor entity
            builder.HasKey(p => new { p.MovieId, p.ActorId });

            // configuring many to many relation by adding multiple one to may relations without Skipping
            builder.HasOne(p => p.Actor).WithMany(p => p.MovieActors).HasForeignKey(p => p.ActorId);
            builder.HasOne(p => p.Movie).WithMany(p => p.MovieActors).HasForeignKey(p => p.MovieId);
        }
    }
}
