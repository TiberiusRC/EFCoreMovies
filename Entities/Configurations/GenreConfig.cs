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
        }
    }
}
