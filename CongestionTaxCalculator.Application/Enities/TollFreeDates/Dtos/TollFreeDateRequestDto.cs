namespace CongestionTaxCalculator.Application.Entities.TollFreeDates.Dtos
{
    public class TollFreeDateRequestDto
    {
        public Guid Id { get; set; }
        public DateOnly FreeDate { get; set; }
    }
}
