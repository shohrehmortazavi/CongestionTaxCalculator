namespace CongestionTaxCalculator.Domain.Shared
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
