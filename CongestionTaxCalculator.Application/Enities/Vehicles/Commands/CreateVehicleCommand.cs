using AutoMapper;
using CongestionTaxCalculator.Application.Entities.Vehicles.Dtos;
using CongestionTaxCalculator.Domain.Entities.Vehicles;
using CongestionTaxCalculator.Domain.Shared.Interfaces;
using MediatR;

namespace CongestionTaxCalculator.Application.Entities.Vehicles.Commands
{
    public record CreateVehicleCommand(VehicleRequestDto VehicleRequest) : IRequest<VehicleResponseDto>;

    public class CreateVehicleCommandHandler : BaseService, IRequestHandler<CreateVehicleCommand, VehicleResponseDto>
    {
        public CreateVehicleCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<VehicleResponseDto> Handle(CreateVehicleCommand request, CancellationToken cancellationToken)
        {
            var newVehicle = new Vehicle(request.VehicleRequest.VehicleTypeId);

            var result = await _unitOfWork.VehicleWriteRepository.AddAsync(newVehicle);

            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<VehicleResponseDto>(result);
        }
    }
}
