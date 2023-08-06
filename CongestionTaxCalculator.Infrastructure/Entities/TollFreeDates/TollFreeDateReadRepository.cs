using CongestionTaxCalculator.Domain.Entities.TollFreeDates;
using CongestionTaxCalculator.Infrastructure.Data;

namespace CongestionTaxCalculator.Infrastructure.Entities.TollFreeDates
{
    public class TollFreeDateReadRepository : ReadRepository<TollFreeDate>, ITollFreeDateReadRepository
    {
        public TollFreeDateReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
