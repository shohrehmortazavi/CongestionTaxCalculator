using CongestionTaxCalculator.Domain.Entities.VehicleTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CongestionTaxCalculator.Infrastructure.Entities.VehicleTypes
{
    public class VehicleTypeConfiguration : IEntityTypeConfiguration<VehicleType>
    {
        public void Configure(EntityTypeBuilder<VehicleType> builder)
        {
            builder.Property(t => t.Title).IsRequired().HasMaxLength(50);
        }
    }
}
