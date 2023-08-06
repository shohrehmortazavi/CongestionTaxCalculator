using AutoMapper;
using CongestionTaxCalculator.Application.Entities.Vehicles.Dtos;
using CongestionTaxCalculator.Domain.Shared.Interfaces;
using MediatR;

namespace CongestionTaxCalculator.Application.Entities.Vehicles.Queries
{
    public record GetVehiclesQuery : IRequest<List<VehicleResponseDto>>;

    public class GetVehiclesQueryHandler : BaseService, IRequestHandler<GetVehiclesQuery, List<VehicleResponseDto>>
    {
        public GetVehiclesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<List<VehicleResponseDto>> Handle(GetVehiclesQuery request, CancellationToken cancellationToken)
        {
            var vehicles = await _unitOfWork.VehicleReadRepository.GetAllAsynce();

            if (!vehicles.Any())
                return null;

            return vehicles.Select(x => _mapper.Map<VehicleResponseDto>(x)).ToList();
        }
    }

}
