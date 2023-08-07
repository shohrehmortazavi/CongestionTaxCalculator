using CongestionTaxCalculator.Domain.Entities.TollFreeDates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CongestionTaxCalculator.Infrastructure.Entities.TollFreeDates
{
    public class TollFreeDateConfiguration : IEntityTypeConfiguration<TollFreeDate>
    {
        public void Configure(EntityTypeBuilder<TollFreeDate> builder)
        {
            builder.Property(t => t.FreeDate).IsRequired();
        }
    }
}
