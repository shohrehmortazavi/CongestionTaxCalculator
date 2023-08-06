using CongestionTaxCalculator.Domain.Entities.TollFreeDates;
using CongestionTaxCalculator.Domain.Entities.TollFreeDays;
using CongestionTaxCalculator.Domain.Entities.TollFreeVehicleTypes;
using CongestionTaxCalculator.Domain.Entities.Vehicles;
using CongestionTaxCalculator.Domain.Entities.VehicleTypes;
using CongestionTaxCalculator.Domain.Shared.Interfaces;
using CongestionTaxCalculator.Infrastructure.Entities.TollFreeDates;
using CongestionTaxCalculator.Infrastructure.Entities.TollFreeDays;
using CongestionTaxCalculator.Infrastructure.Entities.TollFreeVehicleTypes;
using CongestionTaxCalculator.Infrastructure.Entities.Vehicles;
using CongestionTaxCalculator.Infrastructure.Entities.VehicleTypes;

namespace CongestionTaxCalculator.Infrastructure.Data
{
    public class UnitOfWork : BaseUnitOfWork, IUnitOfWork
    {
        public UnitOfWork(AppDbContext context) : base(context)
        {
        }

        public IVehicleTypeReadRepository VehicleTypeReadRepository => new VehicleTypeReadRepository(AppDbContext());
        public IVehicleTypeWriteRepository VehicleTypeWriteRepository => new VehicleTypeWriteRepository(AppDbContext());

        public IVehicleReadRepository VehicleReadRepository => new VehicleReadRepository(AppDbContext());
        public IVehicleWriteRepository VehicleWriteRepository => new VehicleWriteRepository(AppDbContext());

        public ITollFreeDateReadRepository TollFreeDateReadRepository => new TollFreeDateReadRepository(AppDbContext());
        public ITollFreeDateWriteRepository TollFreeDateWriteRepository => new TollFreeDateWriteRepository(AppDbContext());

        public ITollFreeDayReadRepository TollFreeDayReadRepository => new TollFreeDayReadRepository(AppDbContext());
        public ITollFreeDayWriteRepository TollFreeDayWriteRepository => new TollFreeDayWriteRepository(AppDbContext());

        public ITollFreeVehicleTypeReadRepository TollFreeVehicleTypeReadRepository => new TollFreeVehicleTypeReadRepository(AppDbContext());
        public ITollFreeVehicleTypeWriteRepository TollFreeVehicleTypeWriteRepository => new TollFreeVehicleTypeWriteRepository(AppDbContext());
    }
}
