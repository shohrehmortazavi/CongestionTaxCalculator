using CongestionTaxCalculator.Domain.Entities.Cars;
using CongestionTaxCalculator.Domain.Entities.TollFreeDates;
using CongestionTaxCalculator.Domain.Entities.TollFreeDays;
using CongestionTaxCalculator.Domain.Entities.TollFreeVehicleTypes;
using CongestionTaxCalculator.Domain.Entities.Motorbike;
using CongestionTaxCalculator.Domain.Entities.Vehicles;
using CongestionTaxCalculator.Domain.Entities.VehicleTypes;
using CongestionTaxCalculator.Infrastructure.Entities.TollFreeDates;
using CongestionTaxCalculator.Infrastructure.Entities.TollFreeDays;
using CongestionTaxCalculator.Infrastructure.Entities.TollFreeVehicleTypes;
using CongestionTaxCalculator.Infrastructure.Entities.Vehicles;
using CongestionTaxCalculator.Infrastructure.Entities.VehicleTypes;
using Microsoft.EntityFrameworkCore;
using CongestionTaxCalculator.Domain.Entities.TollFees;
using CongestionTaxCalculator.Infrastructure.Entities.TollFees;

namespace CongestionTaxCalculator.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<TollFreeVehicleType> TollFreeVehicleTypes { get; set; }
        public DbSet<TollFreeDay> TollFreeDays { get; set; }
        public DbSet<TollFreeDate> TollFreeDates { get; set; }
        public DbSet<TollFee> TollFees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Vehicle>().UseTpcMappingStrategy();
            modelBuilder.Entity<VehicleType>();
            modelBuilder.Entity<TollFreeVehicleType>();
            modelBuilder.Entity<TollFreeDate>();
            modelBuilder.Entity<TollFreeDay>();
            modelBuilder.Entity<TollFee>();


            modelBuilder.ApplyConfiguration(new VehicleConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TollFreeVehicleTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TollFreeDateConfiguration());
            modelBuilder.ApplyConfiguration(new TollFreeDayConfiguration());
            modelBuilder.ApplyConfiguration(new TollFeeConfiguration());

        }
    }
}
