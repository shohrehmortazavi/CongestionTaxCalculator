using CongestionTaxCalculator.Domain.Entities.TollFreeDays;
using CongestionTaxCalculator.Infrastructure.Data;

namespace CongestionTaxCalculator.Infrastructure.Entities.TollFreeDays
{
    public class TollFreeDayWriteRepository : WriteRepository<TollFreeDay>, ITollFreeDayWriteRepository
    {
        public TollFreeDayWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
