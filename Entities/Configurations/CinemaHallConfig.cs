using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreMovies.Entities.Configurations
{
    public class CinemaHallConfig : IEntityTypeConfiguration<CinemaHall>
    {
        public void Configure(EntityTypeBuilder<CinemaHall> builder)
        {
            //Creation of CinemaHall entity
            builder.Property(p => p.Cost).HasPrecision(precision: 9, scale: 2);
            builder.Property(p => p.CinemaHallType).HasDefaultValue(CinemaHallType.TwoDimensions);
        }
    }
}
