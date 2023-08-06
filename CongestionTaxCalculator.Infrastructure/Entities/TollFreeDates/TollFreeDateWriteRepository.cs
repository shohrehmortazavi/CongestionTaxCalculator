using CongestionTaxCalculator.Domain.Entities.TollFreeDates;
using CongestionTaxCalculator.Infrastructure.Data;

namespace CongestionTaxCalculator.Infrastructure.Entities.TollFreeDates
{
    public class TollFreeDateWriteRepository : WriteRepository<TollFreeDate>, ITollFreeDateWriteRepository
    {
        public TollFreeDateWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
