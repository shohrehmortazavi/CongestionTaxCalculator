using CongestionTaxCalculator.Application.Services.VehicleTypes.Commands;
using CongestionTaxCalculator.Application.Services.VehicleTypes.Dtos;
using CongestionTaxCalculator.Application.Services.VehicleTypes.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CongestionTaxCalculator.Application.Controllers
{

    public class VehicleTypeController : BaseApiController
    {
        /// <summary>
        /// Get list of vehicleTypes
        /// </summary>
        /// <returns>List of vehicle types</returns>
        /// <response code="200">returns list of vehicle types</response>
        /// <response code="204">There is not any vehicle type</response>
        /// <response code="500"> Application failed to process the request</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get()
        {
            var response = await Mediator.Send(new GetVehicleTypesQuery());

            if (response == null || !response.Any())
                return NoContent();

            return Ok(response);
        }


        /// <summary>
        /// Creates new Vehicle Type
        /// </summary>
        /// <param name="vehicleTypeRequestDto">Data for creating new vehicle type</param>
        /// <returns>Returns created vehicle type</returns>
        /// <response code="200">returns created vehicle type</response>
        /// <response code="500"> Application failed to process the request</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post(VehicleTypeRequestDto vehicleTypeRequestDto)
        {
            var response = await Mediator.Send(new CreateVehicleTypeCommand(vehicleTypeRequestDto));
            return StatusCode(StatusCodes.Status201Created, response);
        }

    }
}
