using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreMovies.Entities.Configurations
{
    public class ActorConfig : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            //Creation of Actor entity
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Biography).HasColumnType("nvarchar(max)");
        }
    }
}
