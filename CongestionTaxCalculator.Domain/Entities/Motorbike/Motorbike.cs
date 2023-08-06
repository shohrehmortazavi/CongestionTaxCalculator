using CongestionTaxCalculator.Domain.Entities.Vehicles;

namespace CongestionTaxCalculator.Domain.Entities.Motorbike
{
    public class Motorbike : Vehicle
    {
        public override string GetVehicleType()
        {
            return "Motorbike";
        }
    }
}
