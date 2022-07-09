using EFCoreMovies.Entities.Conversions;
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
            builder.Property(p => p.CinemaHallType).HasDefaultValue(CinemaHallType.TwoDimensions)
                .HasConversion<string>(); // added conversion from enum to string datatype.

            //Custom value conversion.(see in conversions the CurrencyToSymbolConverter.cs file and in entities the Currency.cs
            builder.Property(p => p.Currency).HasConversion<CurrencyToSymbolConverter>();
        }
    }
}
