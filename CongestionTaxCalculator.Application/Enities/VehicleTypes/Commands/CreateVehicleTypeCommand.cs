using AutoMapper;
using CongestionTaxCalculator.Application.Entities;
using CongestionTaxCalculator.Application.Services.VehicleTypes.Dtos;
using CongestionTaxCalculator.Domain.Entities.VehicleTypes;
using CongestionTaxCalculator.Domain.Shared.Interfaces;
using MediatR;

namespace CongestionTaxCalculator.Application.Services.VehicleTypes.Commands
{
    public record CreateVehicleTypeCommand(VehicleTypeRequestDto VehicleTypeRequest) : IRequest<VehicleTypeResponseDto>;

    public class CreateVehicleTypeCommandHandler : BaseService, IRequestHandler<CreateVehicleTypeCommand, VehicleTypeResponseDto>
    {
        public CreateVehicleTypeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<VehicleTypeResponseDto> Handle(CreateVehicleTypeCommand request, CancellationToken cancellationToken)
        {
            var newVehicleType = new VehicleType(request.VehicleTypeRequest.Title);

            var result = await _unitOfWork.VehicleTypeWriteRepository.AddAsync(newVehicleType);

            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<VehicleTypeResponseDto>(result);
        }
    }
}
