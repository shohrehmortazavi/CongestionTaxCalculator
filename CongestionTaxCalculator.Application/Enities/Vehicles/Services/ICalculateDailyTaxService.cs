using CongestionTaxCalculator.Application.Entities.Vehicles.Dtos;

namespace CongestionTaxCalculator.Application.Entities.Vehicles.Services
{
    public interface ICalculateDailyTaxService
    {
        int GetDailyTollFee(VehicleRequestDto vehicle, DateTime date);
    }
}
