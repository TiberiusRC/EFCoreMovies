using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreMovies.Entities.Configurations
{
    public class CinemaOfferConfig : IEntityTypeConfiguration<CinemaOffer>
    {
        public void Configure(EntityTypeBuilder<CinemaOffer> builder)
        {
            //Creation of CinemaOffer entity
            builder.Property(p => p.DiscountPercentage).HasPrecision(precision: 5, scale: 2);
        }
    }
}
