using CongestionTaxCalculator.Domain.Entities.Vehicles;
using CongestionTaxCalculator.Infrastructure.Data;

namespace CongestionTaxCalculator.Infrastructure.Entities.Vehicles
{
    public class VehicleReadRepository : ReadRepository<Vehicle>, IVehicleReadRepository
    {
        public VehicleReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
