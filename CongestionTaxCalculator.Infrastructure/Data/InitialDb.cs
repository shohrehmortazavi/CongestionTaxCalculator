using CongestionTaxCalculator.Domain.Entities.TollFees;
using CongestionTaxCalculator.Domain.Entities.TollFreeDates;
using CongestionTaxCalculator.Domain.Entities.TollFreeDays;
using CongestionTaxCalculator.Domain.Entities.TollFreeVehicleTypes;
using CongestionTaxCalculator.Domain.Entities.VehicleTypes;
using CongestionTaxCalculator.Domain.Shared;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CongestionTaxCalculator.Infrastructure.Data
{
    public static class InitialDb
    {
        public static void EnsureMigrationOfContext<T>(this IApplicationBuilder app) where T : AppDbContext
        {
            using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            var _context = serviceScope.ServiceProvider.GetService<T>();

            Seed(_context);
        }

        private static void Seed<T>(T _context) where T : AppDbContext
        {
            try
            {
                CreateVehicleTypes(_context);
                CreateTollFreeVehicleTypes(_context);
                CreateTollFreeDays(_context);
                CreateTollFreeDates(_context);
                CreateTollFees(_context);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static void CreateVehicleTypes(AppDbContext _context)
        {
            _context.Database.EnsureCreated();
            if (!_context.VehicleTypes.Any())
            {
                _context.VehicleTypes.Add(new VehicleType(Guid.Parse("51c2c107-393e-4377-9094-11aa6d97dcda"), TollFreeVehicles.Motorcycle.ToString()));
                _context.VehicleTypes.Add(new VehicleType(Guid.Parse("52c2c107-393e-4377-9094-11aa6d97dcdb"), TollFreeVehicles.Tractor.ToString()));
                _context.VehicleTypes.Add(new VehicleType(Guid.Parse("53c2c107-393e-4377-9094-11aa6d97dcdc"), TollFreeVehicles.Emergency.ToString()));
                _context.VehicleTypes.Add(new VehicleType(Guid.Parse("54c2c107-393e-4377-9094-11aa6d97dcdd"), TollFreeVehicles.Diplomat.ToString()));
                _context.VehicleTypes.Add(new VehicleType(Guid.Parse("55c2c107-393e-4377-9094-11aa6d97dcde"), TollFreeVehicles.Foreign.ToString()));
                _context.VehicleTypes.Add(new VehicleType(Guid.Parse("56c2c107-393e-4377-9094-11aa6d97dcdf"), TollFreeVehicles.Military.ToString()));
                _context.SaveChanges();
            }
        }

        private static void CreateTollFreeVehicleTypes(AppDbContext _context)
        {
            _context.Database.EnsureCreated();
            if (!_context.TollFreeVehicleTypes.Any())
            {
                _context.TollFreeVehicleTypes.Add(new TollFreeVehicleType(Guid.Parse("51c2c107-393e-4377-9094-11aa6d97dcda")));
                _context.TollFreeVehicleTypes.Add(new TollFreeVehicleType(Guid.Parse("52c2c107-393e-4377-9094-11aa6d97dcdb")));
                _context.TollFreeVehicleTypes.Add(new TollFreeVehicleType(Guid.Parse("53c2c107-393e-4377-9094-11aa6d97dcdc")));
                _context.TollFreeVehicleTypes.Add(new TollFreeVehicleType(Guid.Parse("54c2c107-393e-4377-9094-11aa6d97dcdd")));
                _context.TollFreeVehicleTypes.Add(new TollFreeVehicleType(Guid.Parse("55c2c107-393e-4377-9094-11aa6d97dcde")));
                _context.TollFreeVehicleTypes.Add(new TollFreeVehicleType(Guid.Parse("56c2c107-393e-4377-9094-11aa6d97dcdf")));
                _context.SaveChanges();
            }
        }

        private static void CreateTollFreeDays(AppDbContext _context)
        {
            _context.Database.EnsureCreated();
            if (!_context.TollFreeDays.Any())
            {
                _context.TollFreeDays.Add(new TollFreeDay(DayOfWeek.Saturday));
                _context.TollFreeDays.Add(new TollFreeDay(DayOfWeek.Sunday));
                _context.SaveChanges();
            }
        }

        private static void CreateTollFreeDates(AppDbContext _context)
        {
            _context.Database.EnsureCreated();
            if (!_context.TollFreeDates.Any())
            {
                _context.TollFreeDates.Add(new TollFreeDate(new DateOnly(2023, 1, 1)));
                _context.TollFreeDates.Add(new TollFreeDate(new DateOnly(2023, 3, 28)));
                _context.TollFreeDates.Add(new TollFreeDate(new DateOnly(2023, 3, 29)));
                _context.TollFreeDates.Add(new TollFreeDate(new DateOnly(2023, 4, 30)));
                _context.TollFreeDates.Add(new TollFreeDate(new DateOnly(2023, 5, 1)));
                _context.TollFreeDates.Add(new TollFreeDate(new DateOnly(2023, 5, 8)));
                _context.TollFreeDates.Add(new TollFreeDate(new DateOnly(2023, 5, 9)));
                _context.TollFreeDates.Add(new TollFreeDate(new DateOnly(2023, 6, 5)));
                _context.TollFreeDates.Add(new TollFreeDate(new DateOnly(2023, 6, 6)));
                _context.TollFreeDates.Add(new TollFreeDate(new DateOnly(2023, 6, 21)));
                _context.TollFreeDates.Add(new TollFreeDate(new DateOnly(2023, 11, 1)));
                _context.TollFreeDates.Add(new TollFreeDate(new DateOnly(2023, 12, 24)));
                _context.TollFreeDates.Add(new TollFreeDate(new DateOnly(2023, 12, 25)));
                _context.TollFreeDates.Add(new TollFreeDate(new DateOnly(2023, 12, 26)));
                _context.TollFreeDates.Add(new TollFreeDate(new DateOnly(2023, 12, 31)));

                for (int i = 1; i <= 31; i++)
                    _context.TollFreeDates.Add(new TollFreeDate(new DateOnly(2023, 7, i)));
                _context.SaveChanges();
            }
        }
        private static void CreateTollFees(AppDbContext _context)
        {
            _context.Database.EnsureCreated();
            if (!_context.TollFees.Any())
            {
                _context.TollFees.Add(new TollFee(new TimeOnly(6, 0), new TimeOnly(6, 29), 8));
                _context.TollFees.Add(new TollFee(new TimeOnly(6, 30), new TimeOnly(6, 59), 13));
                _context.TollFees.Add(new TollFee(new TimeOnly(7, 0), new TimeOnly(7, 59), 18));
                _context.TollFees.Add(new TollFee(new TimeOnly(8, 0), new TimeOnly(8, 29), 13));
                _context.TollFees.Add(new TollFee(new TimeOnly(8, 30), new TimeOnly(14, 59), 8));
                _context.TollFees.Add(new TollFee(new TimeOnly(15, 0), new TimeOnly(15, 29), 13));
                _context.TollFees.Add(new TollFee(new TimeOnly(15, 0), new TimeOnly(16, 59), 18));
                _context.TollFees.Add(new TollFee(new TimeOnly(17, 0), new TimeOnly(17, 59), 13));
                _context.TollFees.Add(new TollFee(new TimeOnly(18, 0), new TimeOnly(18, 29), 8));

                _context.SaveChanges();
            }
        }
    }
}