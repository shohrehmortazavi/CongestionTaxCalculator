namespace CongestionTaxCalculator.Application.Entities.Vehicles.Dtos
{
    public class TaxCalculatorRequestDto
    {
        public VehicleRequestDto Vehicle { get; set; }
        public DateTime[] RequestedDates { get; set; }
    }
}
