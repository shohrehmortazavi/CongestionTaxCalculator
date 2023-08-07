using CongestionTaxCalculator.Domain.Shared;
using CongestionTaxCalculator.Domain.Shared.Interfaces;

namespace CongestionTaxCalculator.Domain.Entities.Vehicles
{
    public class Vehicle : BaseEntity, IAggregateRoot
    {
        public Guid VehicleTypeId { get; private set; }
        protected Vehicle()
        {
        }

        public static Vehicle Create(Guid vehicleTypeId)
        {
            return new Vehicle()
            {
                Id = Guid.NewGuid(),
                VehicleTypeId = vehicleTypeId,
                CreatedDate = DateTime.Now
            };
        }

    }
}

