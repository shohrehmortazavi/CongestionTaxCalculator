using CongestionTaxCalculator.Domain.Entities.Vehicles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CongestionTaxCalculator.Infrastructure.Entities.Vehicles
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
        }
    }
}
