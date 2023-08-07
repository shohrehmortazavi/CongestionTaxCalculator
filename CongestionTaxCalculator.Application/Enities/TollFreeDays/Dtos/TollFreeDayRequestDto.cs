namespace CongestionTaxCalculator.Application.Entities.TollFreeDays.Dtos
{
    public class TollFreeDayRequestDto
    {
        public Guid Id { get; set; }
        public DayOfWeek Day { get; set; }
    }
}
