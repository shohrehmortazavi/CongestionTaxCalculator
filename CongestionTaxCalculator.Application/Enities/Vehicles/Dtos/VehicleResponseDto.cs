namespace CongestionTaxCalculator.Application.Entities.Vehicles.Dtos
{
    public class VehicleResponseDto
    {
        public Guid Id { get; set; }
        public Guid VehicleTypeId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
