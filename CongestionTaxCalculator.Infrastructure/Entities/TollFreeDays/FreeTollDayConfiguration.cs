using CongestionTaxCalculator.Domain.Entities.TollFreeDays;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CongestionTaxCalculator.Infrastructure.Entities.TollFreeDays
{
    public class TollFreeDayConfiguration : IEntityTypeConfiguration<TollFreeDay>
    {
        public void Configure(EntityTypeBuilder<TollFreeDay> builder)
        {
            builder.Property(t => t.Day).IsRequired();
        }
    }
}
