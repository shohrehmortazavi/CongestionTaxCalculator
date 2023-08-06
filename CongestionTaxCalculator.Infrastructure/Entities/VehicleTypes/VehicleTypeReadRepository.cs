using CongestionTaxCalculator.Domain.Entities.VehicleTypes;
using CongestionTaxCalculator.Infrastructure.Data;

namespace CongestionTaxCalculator.Infrastructure.Entities.VehicleTypes
{
    public class VehicleTypeReadRepository : ReadRepository<VehicleType>, IVehicleTypeReadRepository
    {
        public VehicleTypeReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
