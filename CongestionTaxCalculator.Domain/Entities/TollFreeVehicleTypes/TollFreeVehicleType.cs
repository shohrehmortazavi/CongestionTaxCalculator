using CongestionTaxCalculator.Domain.Shared;

namespace CongestionTaxCalculator.Domain.Entities.TollFreeVehicleTypes
{
    public class TollFreeVehicleType : BaseEntity
    {
        private TollFreeVehicleType()
        {

        }
        public TollFreeVehicleType(Guid id)
        {
            Id = id;
            CreatedDate = DateTime.Now;
        }

    }
}
