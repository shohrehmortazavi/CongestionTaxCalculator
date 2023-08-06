using AutoMapper;
using CongestionTaxCalculator.Application.Entities.TollFees.Dtos;
using CongestionTaxCalculator.Domain.Shared.Interfaces;
using MediatR;

namespace CongestionTaxCalculator.Application.Entities.TollFees.Queries
{
    public record GetTollFeesQuery : IRequest<List<TollFeeResponseDto>>;

    public class GetTollFeesQueryHandler : BaseService, IRequestHandler<GetTollFeesQuery, List<TollFeeResponseDto>>
    {
        public GetTollFeesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<List<TollFeeResponseDto>> Handle(GetTollFeesQuery request, CancellationToken cancellationToken)
        {
            var freeTollDates = await _unitOfWork.TollFeeReadRepository.GetAllAsynce();

            if (!freeTollDates.Any())
                return null;

            return freeTollDates.Select(x => _mapper.Map<TollFeeResponseDto>(x)).ToList();
        }
    }

}
