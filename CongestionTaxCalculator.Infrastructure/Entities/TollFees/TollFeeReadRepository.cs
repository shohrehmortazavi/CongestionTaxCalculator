using CongestionTaxCalculator.Domain.Entities.TollFees;
using CongestionTaxCalculator.Infrastructure.Data;

namespace CongestionTaxCalculator.Infrastructure.Entities.TollFees
{
    public class TollFeeReadRepository : ReadRepository<TollFee>, ITollFeeReadRepository
    {
        public TollFeeReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
