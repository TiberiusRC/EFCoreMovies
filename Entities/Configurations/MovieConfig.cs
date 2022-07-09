using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreMovies.Entities.Configurations
{
    public class MovieConfig : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            //Creation of Movie entity
            builder.Property(p => p.Title).HasMaxLength(250).IsRequired();
            builder.Property(p => p.PosterUrl).HasMaxLength(500).IsUnicode(false);

            //Many to many relation with skipping navigation
            builder.HasMany(p => p.Genres).WithMany(p => p.Movies);
                //.UsingEntity(j => j.ToTable("GenreMovies").HasData(new {MoviesId =1,GenresId=7}));// Creation of a intermediate table..(HasData is to seed the table-optional)



        }
    }
}
