using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreMovies.Entities.Configurations
{
    public class GenreConfig : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            //Creation of Genre entity
            builder.Property(p => p.Name).IsRequired();
            //A filter for soft delete
            builder.HasQueryFilter(g=>!g.IsDeleted);

            //Another way of making a index for a property and will be unique
            //builder.HasIndex(p => p.Name).IsUnique(); //ATM used in Genre.cs

            //Another way of making a index for a property and has a filter in it. In case of soft deleted Genre entry.
            builder.HasIndex(p => p.Name).IsUnique().HasFilter("IsDeleted = 'false'");

        }


    }
}
