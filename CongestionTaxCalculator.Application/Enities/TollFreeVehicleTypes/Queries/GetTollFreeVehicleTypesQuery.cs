using AutoMapper;
using CongestionTaxCalculator.Application.Entities;
using CongestionTaxCalculator.Application.Entities.TollFreeVehicleTypes.Dtos;
using CongestionTaxCalculator.Domain.Shared.Interfaces;
using MediatR;

namespace CongestionTaxCalculator.Application.EntitiesB.TollFreeVehicleType.Queries
{
    public record GetTollFreeVehicleTypesQuery : IRequest<List<TollFreeVehicleTypeResponseDto>>;

    public class GetTollFreeVehicleTypeQueryHandler : BaseService, IRequestHandler<GetTollFreeVehicleTypesQuery, List<TollFreeVehicleTypeResponseDto>>
    {
        public GetTollFreeVehicleTypeQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<List<TollFreeVehicleTypeResponseDto>> Handle(GetTollFreeVehicleTypesQuery request, CancellationToken cancellationToken)
        {
            var freeTollVehicleTypes = await _unitOfWork.TollFreeVehicleTypeReadRepository.GetAllAsynce();

            if (!freeTollVehicleTypes.Any())
                return null;

            return freeTollVehicleTypes.Select(x => _mapper.Map<TollFreeVehicleTypeResponseDto>(x)).ToList();
        }
    }

}
