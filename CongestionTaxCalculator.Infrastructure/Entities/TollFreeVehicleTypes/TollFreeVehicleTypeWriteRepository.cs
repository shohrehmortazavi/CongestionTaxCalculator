using CongestionTaxCalculator.Domain.Entities.TollFreeVehicleTypes;
using CongestionTaxCalculator.Infrastructure.Data;

namespace CongestionTaxCalculator.Infrastructure.Entities.TollFreeVehicleTypes
{
    public class TollFreeVehicleTypeWriteRepository : WriteRepository<TollFreeVehicleType>, ITollFreeVehicleTypeWriteRepository
    {
        public TollFreeVehicleTypeWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
