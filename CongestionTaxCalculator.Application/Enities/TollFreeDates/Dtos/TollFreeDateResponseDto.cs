namespace CongestionTaxCalculator.Application.Entities.TollFreeDates.Dtos
{
    public class TollFreeDateResponseDto
    {
        public Guid Id { get; set; }
        public DateOnly FreeDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
