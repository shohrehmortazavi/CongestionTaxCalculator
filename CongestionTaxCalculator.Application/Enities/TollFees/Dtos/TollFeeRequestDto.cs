namespace CongestionTaxCalculator.Application.Entities.TollFees.Dtos
{
    public class TollFeeRequestDto
    {
        public Guid Id { get; set; }
        public DateTime MinTime { get; set; }
        public DateTime MaxTime { get; set; }
        public int Fee { get; set; }
    }
}
