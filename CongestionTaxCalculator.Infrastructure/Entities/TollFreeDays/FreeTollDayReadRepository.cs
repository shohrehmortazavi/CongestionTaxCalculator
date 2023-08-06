using CongestionTaxCalculator.Domain.Entities.TollFreeDays;
using CongestionTaxCalculator.Infrastructure.Data;

namespace CongestionTaxCalculator.Infrastructure.Entities.TollFreeDays
{
    public class TollFreeDayReadRepository : ReadRepository<TollFreeDay>, ITollFreeDayReadRepository
    {
        public TollFreeDayReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
