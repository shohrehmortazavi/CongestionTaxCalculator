namespace CongestionTaxCalculator.Application.Entities.TollFreeDays.Dtos
{
    public class TollFreeDayResponseDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DayOfWeek Day { get;  set; }
        public DateTime CreatedDate { get; set; }
    }
}
