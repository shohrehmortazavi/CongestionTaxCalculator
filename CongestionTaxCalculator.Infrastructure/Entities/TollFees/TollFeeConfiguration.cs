using CongestionTaxCalculator.Domain.Entities.TollFees;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CongestionTaxCalculator.Infrastructure.Entities.TollFees
{
    public class TollFeeConfiguration : IEntityTypeConfiguration<TollFee>
    {
        public void Configure(EntityTypeBuilder<TollFee> builder)
        {
            builder.Property(t => t.MinTime).IsRequired();
            builder.Property(t => t.MaxTime).IsRequired();
            builder.Property(t => t.Fee).IsRequired();

        }
    }
}
