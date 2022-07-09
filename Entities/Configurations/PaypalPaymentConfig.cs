using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreMovies.Entities.Configurations
{
    public class PaypalPaymentConfig : IEntityTypeConfiguration<PaypalPayment>
    {
        public void Configure(EntityTypeBuilder<PaypalPayment> builder)
        {
            builder.Property(p => p.EmailAddress).IsRequired();

            var payment1 = new PaypalPayment()
            {
                Id = 1,
                PaymentDate = new DateTime(2022, 5, 5),
                PaymentType = PaymentType.Paypal,
                Amount = 69420,
                EmailAddress = "tiberius@underthesea.com"
            };
            var payment2 = new PaypalPayment()
            {
                Id = 2,
                PaymentDate = new DateTime(2022, 9, 10),
                PaymentType = PaymentType.Paypal,
                Amount = 1337,
                EmailAddress = "bonga@boingboing.com"
            };
            builder.HasData(payment1, payment2);
        }
    }
}
