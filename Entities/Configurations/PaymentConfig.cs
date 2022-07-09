using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreMovies.Entities.Configurations
{
    public class PaymentConfig : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {   // For amount decimal entry
            builder.Property(p => p.Amount).HasPrecision(18, 2);

            builder.HasDiscriminator(p => p.PaymentType)
                 .HasValue<PaypalPayment>(PaymentType.Paypal)
                 .HasValue<CardPayment>(PaymentType.Card);
        }
    }


}
