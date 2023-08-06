using CongestionTaxCalculator.Domain.Shared;
using CongestionTaxCalculator.Domain.Shared.Interfaces;

namespace CongestionTaxCalculator.Domain.Entities.Vehicles
{
    public class Vehicle : BaseEntity, IAggregateRoot
    {
        public Guid VehicleTypeId { get; private set; }
        public Vehicle()
        {
        }

        public virtual string GetVehicleType()
        {
            return "";
        }
    }
}
