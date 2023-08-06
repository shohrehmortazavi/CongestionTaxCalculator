using AutoMapper;
using CongestionTaxCalculator.Application.Entities;
using CongestionTaxCalculator.Application.Services.VehicleTypes.Dtos;
using CongestionTaxCalculator.Domain.Shared.Interfaces;
using MediatR;

namespace CongestionTaxCalculator.Application.Services.VehicleTypes.Queries
{
    public record GetVehicleTypesQuery : IRequest<List<VehicleTypeResponseDto>>;

    public class GetVehicleTypesQueryHandler : BaseService, IRequestHandler<GetVehicleTypesQuery, List<VehicleTypeResponseDto>>
    {
        public GetVehicleTypesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<List<VehicleTypeResponseDto>> Handle(GetVehicleTypesQuery request, CancellationToken cancellationToken)
        {
            var vehicleTypes = await _unitOfWork.VehicleTypeReadRepository.GetAllAsynce();

            if (!vehicleTypes.Any())
                return null;

            return vehicleTypes.Select(x => _mapper.Map<VehicleTypeResponseDto>(x)).ToList();
        }
    }

}
