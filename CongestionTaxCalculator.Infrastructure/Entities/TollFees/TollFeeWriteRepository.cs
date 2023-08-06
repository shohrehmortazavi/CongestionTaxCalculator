using CongestionTaxCalculator.Domain.Entities.TollFees;
using CongestionTaxCalculator.Infrastructure.Data;

namespace CongestionTaxCalculator.Infrastructure.Entities.TollFees
{
    public class TollFeeWriteRepository : WriteRepository<TollFee>, ITollFeeWriteRepository
    {
        public TollFeeWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
