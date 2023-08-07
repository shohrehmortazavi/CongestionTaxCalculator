using CongestionTaxCalculator.Domain.Shared;

namespace CongestionTaxCalculator.Domain.Entities.VehicleTypes
{
    public class VehicleType : BaseEntity
    {
        public string Title { get; private set; }
   
        private VehicleType()
        {

        }

        public VehicleType(string title)
        {
            Id = Guid.NewGuid();
            Title = title;
            CreatedDate = DateTime.Now;
        }

        public VehicleType(Guid id, string title)
        {
            Id = id;
            Title = title;
            CreatedDate = DateTime.Now;
        }

    }
}
