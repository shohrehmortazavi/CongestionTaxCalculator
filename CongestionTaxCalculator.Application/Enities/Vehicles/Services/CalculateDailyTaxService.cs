using AutoMapper;
using CongestionTaxCalculator.Application.Entities.Vehicles.Dtos;
using CongestionTaxCalculator.Domain.Shared.Interfaces;

namespace CongestionTaxCalculator.Application.Entities.Vehicles.Services
{
    public class CalculateDailyTaxService : BaseService, ICalculateDailyTaxService
    {
        public CalculateDailyTaxService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public int GetDailyTollFee(VehicleRequestDto vehicle, DateTime date)
        {
            if (IsTollFreeDay(date.DayOfWeek) || IsTollFreeDate(date) || IsTollFreeVehicleType(vehicle.VehicleTypeId))
                return 0;

            int hour = date.Hour;
            int minute = date.Minute;

            if (hour == 6 && minute >= 0 && minute <= 29) return 8;
            else if (hour == 6 && minute >= 30 && minute <= 59) return 13;
            else if (hour == 7 && minute >= 0 && minute <= 59) return 18;
            else if (hour == 8 && minute >= 0 && minute <= 29) return 13;
            else if (hour >= 8 && hour <= 14 && minute >= 30 && minute <= 59) return 8;
            else if (hour == 15 && minute >= 0 && minute <= 29) return 13;
            else if (hour == 15 && minute >= 0 || hour == 16 && minute <= 59) return 18;
            else if (hour == 17 && minute >= 0 && minute <= 59) return 13;
            else if (hour == 18 && minute >= 0 && minute <= 29) return 8;
            else return 0;
        }


        private bool IsTollFreeDay(DayOfWeek day)
        {
            var tollFreeDays = _unitOfWork.TollFreeDayReadRepository.GetAllAsynce().Result;

            if (!tollFreeDays.Any()) throw new Exception("TollFreeDay not found");


            foreach (var freeDay in tollFreeDays)
                if (day.Equals(freeDay))
                    return true;

            return false;
        }

        private bool IsTollFreeDate(DateTime date)
        {
            var tollFreeDates = _unitOfWork.TollFreeDateReadRepository.GetAllAsynce().Result;

            if (!tollFreeDates.Any()) throw new Exception("TollFreeDates not found");

            var dateOnly = DateOnly.FromDateTime(date);

            foreach (var freeDate in tollFreeDates)
                if (dateOnly.Equals(freeDate))
                    return true;

            return false;
        }

        private bool IsTollFreeVehicleType(Guid vehicleTypeId)
        {
            var tollFreeVehicle = _unitOfWork.TollFreeVehicleTypeReadRepository.Find(x => x.Id == vehicleTypeId).Result;
            if (tollFreeVehicle.Any())
                return true;
            else
                return false;
        }
    }
}
