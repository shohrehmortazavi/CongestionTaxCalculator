namespace CongestionTaxCalculator.Application.Entities.Vehicles.Dtos
{
    public class VehicleRequestDto
    {
        public Guid Id { get; set; }
        public Guid VehicleTypeId { get; set; }
        public string Title { get; set; }
    }
}
