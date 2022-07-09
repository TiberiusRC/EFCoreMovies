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
            //Amother way of making a index for a property and will be unique
            //builder.HasIndex(p => p.Name).IsUnique(); //ATM used in Genre.cs

        }


    }
}
