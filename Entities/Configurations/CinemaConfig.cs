using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreMovies.Entities.Configurations
{
    public class CinemaConfig : IEntityTypeConfiguration<Cinema>
    {
        public void Configure(EntityTypeBuilder<Cinema> builder)
        {
            //Creation of Cinema entity
            builder.Property(p => p.Name).IsRequired();

            // Example of a one to one relation with fluent api
            builder.HasOne(c => c.CinemaOffer).WithOne().HasForeignKey<CinemaOffer>(co => co.CinemaId);// after WithOne() is optional....
            // Example of a one to many relation with fluent api
            builder.HasMany(c => c.CinemaHall).WithOne(ch => ch.Cinema).HasForeignKey(ch => ch.CinemaId);//.OnDelete(DeleteBehavior.Restrict); to restrict deletion before other relation have been deleted

            //Relation to cinemadetail with nav prop and foreignkey
            builder.HasOne(c => c.CinemaDetail).WithOne(c => c.Cinema).HasForeignKey<CinemaDetail>(cd => cd.Id);

            //Custom column names for Owned Address table.
            builder.OwnsOne(c => c.Address,add =>
            {
                add.Property(p => p.Street).HasColumnName("Street");
                add.Property(p => p.Province).HasColumnName("Province");
                add.Property(p => p.Country).HasColumnName("Country");
            });

        }
    }
}
