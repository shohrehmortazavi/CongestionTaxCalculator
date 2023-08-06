using CongestionTaxCalculator.Application.Entities.Vehicles.Services;
using CongestionTaxCalculator.Domain.Entities.Vehicles;
using CongestionTaxCalculator.Domain.Entities.VehicleTypes;
using CongestionTaxCalculator.Domain.Shared.Interfaces;
using CongestionTaxCalculator.Infrastructure.Data;
using CongestionTaxCalculator.Infrastructure.Entities.Vehicles;
using CongestionTaxCalculator.Infrastructure.Entities.VehicleTypes;
using Microsoft.EntityFrameworkCore;

namespace CongestionTaxCalculator.Application.SeedWorks
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAppDbContext(this IServiceCollection services, string connectionString)
        {
            return services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString, x =>
            {
                x.MigrationsAssembly(typeof(AppDbContext).Assembly.ToString());
                x.UseDateOnlyTimeOnly();
            }));
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>))
                .AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>))
                .AddScoped<IVehicleReadRepository, VehicleReadRepository>()
                .AddScoped<IVehicleWriteRepository, VehicleWriteRepository>()
                .AddScoped<IVehicleTypeReadRepository, VehicleTypeReadRepository>()
                .AddScoped<IVehicleTypeWriteRepository, VehicleTypeWriteRepository>();
        }

        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            return services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services.AddScoped<ICalculateDailyTaxService, CalculateDailyTaxService>();
        }
    }
}

