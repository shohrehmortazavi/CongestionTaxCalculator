using AutoMapper;
using CongestionTaxCalculator.Application.Entities.TollFreeDates.Dtos;
using CongestionTaxCalculator.Domain.Shared.Interfaces;
using MediatR;

namespace CongestionTaxCalculator.Application.Entities.TollFreeDates.Queries
{
    public record GetTollFreeDatesQuery : IRequest<List<TollFreeDateResponseDto>>;

    public class GetTollFreeDatesQueryHandler : BaseService, IRequestHandler<GetTollFreeDatesQuery, List<TollFreeDateResponseDto>>
    {
        public GetTollFreeDatesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<List<TollFreeDateResponseDto>> Handle(GetTollFreeDatesQuery request, CancellationToken cancellationToken)
        {
            var freeTollDates = await _unitOfWork.TollFreeDateReadRepository.GetAllAsynce();

            if (!freeTollDates.Any())
                return null;

            return freeTollDates.Select(x => _mapper.Map<TollFreeDateResponseDto>(x)).ToList();
        }
    }

}
