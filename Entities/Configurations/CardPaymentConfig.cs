using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreMovies.Entities.Configurations
{
    public class CardPaymentConfig : IEntityTypeConfiguration<CardPayment>
    {
        public void Configure(EntityTypeBuilder<CardPayment> builder)
        {
            builder.Property(p => p.Last4Digits).HasColumnType("char(4)").IsRequired();

            var payment1 = new CardPayment()
            {
                Id = 3,
                PaymentDate = new DateTime(2022, 3, 12),
                PaymentType = PaymentType.Card,
                Amount = 777,
                Last4Digits = "9876"
            };
            var payment2 = new CardPayment()
            {
                Id = 4,
                PaymentDate = new DateTime(2022, 12, 12),
                PaymentType = PaymentType.Card,
                Amount = 999.99m,
                Last4Digits = "5432"
            };
            builder.HasData(payment1, payment2);

        }
    }
}
