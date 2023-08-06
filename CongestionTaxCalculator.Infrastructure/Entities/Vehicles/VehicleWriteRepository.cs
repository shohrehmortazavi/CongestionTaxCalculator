using CongestionTaxCalculator.Domain.Entities.Vehicles;
using CongestionTaxCalculator.Infrastructure.Data;

namespace CongestionTaxCalculator.Infrastructure.Entities.Vehicles
{
    public class VehicleWriteRepository : WriteRepository<Vehicle>, IVehicleWriteRepository
    {
        public VehicleWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
