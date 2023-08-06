using CongestionTaxCalculator.Domain.Entities.TollFreeVehicleTypes;
using CongestionTaxCalculator.Infrastructure.Data;

namespace CongestionTaxCalculator.Infrastructure.Entities.TollFreeVehicleTypes
{
    public class TollFreeVehicleTypeReadRepository : ReadRepository<TollFreeVehicleType>, ITollFreeVehicleTypeReadRepository
    {
        public TollFreeVehicleTypeReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
