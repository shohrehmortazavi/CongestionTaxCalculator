using CongestionTaxCalculator.Domain.Entities.VehicleTypes;
using CongestionTaxCalculator.Infrastructure.Data;

namespace CongestionTaxCalculator.Infrastructure.Entities.VehicleTypes
{
    public class VehicleTypeWriteRepository : WriteRepository<VehicleType>, IVehicleTypeWriteRepository
    {
        public VehicleTypeWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
