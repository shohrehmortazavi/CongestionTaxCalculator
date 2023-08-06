using CongestionTaxCalculator.Domain.Entities.TollFees;
using CongestionTaxCalculator.Domain.Entities.TollFreeDates;
using CongestionTaxCalculator.Domain.Entities.TollFreeDays;
using CongestionTaxCalculator.Domain.Entities.TollFreeVehicleTypes;
using CongestionTaxCalculator.Domain.Entities.Vehicles;
using CongestionTaxCalculator.Domain.Entities.VehicleTypes;

namespace CongestionTaxCalculator.Domain.Shared.Interfaces
{
    public interface IUnitOfWork : IBaseUnitOfWork
    {
        public IVehicleTypeReadRepository VehicleTypeReadRepository { get; }
        public IVehicleTypeWriteRepository VehicleTypeWriteRepository { get; }

        public IVehicleReadRepository VehicleReadRepository { get; }
        public IVehicleWriteRepository VehicleWriteRepository { get; }

        public ITollFreeDateReadRepository TollFreeDateReadRepository { get; }
        public ITollFreeDateWriteRepository TollFreeDateWriteRepository { get; }

        public ITollFreeDayReadRepository TollFreeDayReadRepository { get; }
        public ITollFreeDayWriteRepository TollFreeDayWriteRepository { get; }

        public ITollFreeVehicleTypeReadRepository TollFreeVehicleTypeReadRepository { get; }
        public ITollFreeVehicleTypeWriteRepository TollFreeVehicleTypeWriteRepository { get; }

        public ITollFeeReadRepository TollFeeReadRepository { get; }
        public ITollFeeWriteRepository TollFeeWriteRepository { get; }
    }
}
