using AutoMapper;
using CongestionTaxCalculator.Application.Entities.TollFreeDays.Dtos;
using CongestionTaxCalculator.Domain.Shared.Interfaces;
using MediatR;

namespace CongestionTaxCalculator.Application.Entities.TollFreeDay.Queries
{
    public record GetTollFreeDaysQuery : IRequest<List<TollFreeDayResponseDto>>;

    public class GetTollFreeDayQueryHandler : BaseService, IRequestHandler<GetTollFreeDaysQuery, List<TollFreeDayResponseDto>>
    {
        public GetTollFreeDayQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<List<TollFreeDayResponseDto>> Handle(GetTollFreeDaysQuery request, CancellationToken cancellationToken)
        {
            var freeTollDays = await _unitOfWork.TollFreeDayReadRepository.GetAllAsynce();

            if (!freeTollDays.Any())
                return null;

            return freeTollDays.Select(x => _mapper.Map<TollFreeDayResponseDto>(x)).ToList();
        }
    }

}
