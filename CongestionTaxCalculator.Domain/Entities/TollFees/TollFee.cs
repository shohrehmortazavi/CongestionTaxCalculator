using CongestionTaxCalculator.Domain.Shared;

namespace CongestionTaxCalculator.Domain.Entities.TollFees
{
    public class TollFee : BaseEntity
    {
        public TimeOnly MinTime { get;private set; }
        public TimeOnly MaxTime { get;private set; }
        public int Fee { get;private set; }
        private TollFee()
        {

        }
        public TollFee(TimeOnly minTime, TimeOnly maxTime, int fee)
        {
            Id = Guid.NewGuid();
            MinTime = minTime;
            MaxTime = maxTime;
            Fee = fee;  
        }
        
        public TollFee(Guid id,TimeOnly minTime, TimeOnly maxTime, int fee)
        {
            Id = id;
            MinTime = minTime;
            MaxTime = maxTime;
            Fee = fee;  
        }
    }
}
