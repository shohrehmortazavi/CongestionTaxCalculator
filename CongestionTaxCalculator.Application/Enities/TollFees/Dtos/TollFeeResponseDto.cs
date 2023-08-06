namespace CongestionTaxCalculator.Application.Entities.TollFees.Dtos
{
    public class TollFeeResponseDto
    {
        public Guid Id { get; set; }
        public TimeOnly MinTime { get; set; }
        public TimeOnly MaxTime { get; set; }
        public int Fee { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
