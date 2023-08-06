using CongestionTaxCalculator.Domain.Entities.Vehicles;

namespace CongestionTaxCalculator.Domain.Entities.Cars
{
    public class Car : Vehicle
    {
        public override string GetVehicleType()
        {
            return "Car";
        }
    }
}
