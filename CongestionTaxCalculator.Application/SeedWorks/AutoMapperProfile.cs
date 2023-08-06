using AutoMapper;
using CongestionTaxCalculator.Application.Entities.TollFees.Dtos;
using CongestionTaxCalculator.Application.Entities.TollFreeDates.Dtos;
using CongestionTaxCalculator.Application.Entities.TollFreeDays.Dtos;
using CongestionTaxCalculator.Application.Entities.TollFreeVehicleTypes.Dtos;
using CongestionTaxCalculator.Application.Entities.VehicleTypes.Dtos;
using CongestionTaxCalculator.Domain.Entities.TollFees;
using CongestionTaxCalculator.Domain.Entities.TollFreeDates;
using CongestionTaxCalculator.Domain.Entities.TollFreeDays;
using CongestionTaxCalculator.Domain.Entities.TollFreeVehicleTypes;
using CongestionTaxCalculator.Domain.Entities.VehicleTypes;

namespace CongestionTaxCalculator.Application.SeedWorks
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<VehicleType, VehicleTypeResponseDto>();
            CreateMap<TollFreeDate, TollFreeDateResponseDto>();
            CreateMap<TollFreeDay, TollFreeDayResponseDto>();
            CreateMap<TollFreeVehicleType, TollFreeVehicleTypeResponseDto>();
            CreateMap<TollFee, TollFeeResponseDto>();

        }
    }
}
