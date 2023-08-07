using CongestionTaxCalculator.Domain.Shared;

namespace CongestionTaxCalculator.Domain.Entities.TollFreeDates
{
    public class TollFreeDate : BaseEntity
    {
        public DateOnly FreeDate { get; private set; }
        private TollFreeDate()
        {
        }
        public TollFreeDate(DateOnly freeDate)
        {
            Id = Guid.NewGuid();
            FreeDate = freeDate;
            CreatedDate = DateTime.Now;
        }

    }
}
