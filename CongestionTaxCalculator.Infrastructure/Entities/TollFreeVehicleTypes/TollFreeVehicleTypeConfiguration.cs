using CongestionTaxCalculator.Domain.Entities.TollFreeVehicleTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CongestionTaxCalculator.Infrastructure.Entities.TollFreeVehicleTypes
{
    public class TollFreeVehicleTypeConfiguration : IEntityTypeConfiguration<TollFreeVehicleType>
    {
        public void Configure(EntityTypeBuilder<TollFreeVehicleType> builder)
        {
        }
    }
}
