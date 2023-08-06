using AutoMapper;
using CongestionTaxCalculator.Application.Entities.Vehicles.Dtos;
using CongestionTaxCalculator.Application.Entities.Vehicles.Services;
using CongestionTaxCalculator.Domain.Shared.Interfaces;
using MediatR;

namespace CongestionTaxCalculator.Application.Entities.Vehicles.Commands
{
    public record CalculateTaxCommand(TaxCalculatorRequestDto TaxCalculatorRequest) : IRequest<int>;

    public class CalculateTaxCommandHandler : BaseService, IRequestHandler<CalculateTaxCommand, int>
    {
        private readonly ICalculateDailyTaxService _calculateDailyTaxService;
        public CalculateTaxCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ICalculateDailyTaxService calculateDailyTaxService)
            : base(unitOfWork, mapper)
        {
            _calculateDailyTaxService = calculateDailyTaxService;
        }

        public async Task<int> Handle(CalculateTaxCommand request, CancellationToken cancellationToken)
        {
            var dates = request.TaxCalculatorRequest.RequestedDates;
            var vehicle = request.TaxCalculatorRequest.Vehicle;

            DateTime intervalStart = dates[0];
            int totalFee = 0;

            foreach (DateTime date in dates)
            {
                var nextFee = _calculateDailyTaxService.GetDailyTollFee(vehicle, date);
                var tempFee = _calculateDailyTaxService.GetDailyTollFee(vehicle, intervalStart);

                long diffInMillies = date.Millisecond - intervalStart.Millisecond;
                long minutes = diffInMillies / 1000 / 60;

                if (minutes <= 60)
                {
                    if (totalFee > 0) totalFee -= tempFee;
                    if (nextFee >= tempFee) tempFee = nextFee;
                    totalFee += tempFee;
                }
                else
                    totalFee += nextFee;
            }

            if (totalFee > 60) totalFee = 60;

            return await Task.FromResult(totalFee);
        }
    }
}
