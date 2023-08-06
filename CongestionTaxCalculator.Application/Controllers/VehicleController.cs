using CongestionTaxCalculator.Application.Entities.Vehicles.Commands;
using CongestionTaxCalculator.Application.Entities.Vehicles.Dtos;
using CongestionTaxCalculator.Application.Entities.Vehicles.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CongestionTaxCalculator.Application.Controllers
{

    public class VehicleController : BaseApiController
    {
        /// <summary>
        /// Get list of vehicles
        /// </summary>
        /// <returns>List of vehicle</returns>
        /// <response code="200">returns list of vehicle</response>
        /// <response code="204">There is not any vehicle</response>
        /// <response code="500"> Application failed to process the request</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get()
        {
            var response = await Mediator.Send(new GetVehiclesQuery());

            if (response == null || !response.Any())
                return NoContent();

            return Ok(response);
        }


        /// <summary>
        /// Creates new Vehicle
        /// </summary>
        /// <param name="vehicleRequestDto">Data for creating new vehicle</param>
        /// <returns>Returns created vehicle </returns>
        /// <response code="200">returns created vehicle</response>
        /// <response code="500"> Application failed to process the request</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post(VehicleRequestDto vehicleRequestDto)
        {
            var response = await Mediator.Send(new CreateVehicleCommand(vehicleRequestDto));
            return StatusCode(StatusCodes.Status201Created, response);
        }


        /// <summary>
        /// Calculates congestion tax
        /// </summary>
        /// <param name="taxCalculatorRequest">requested data: vehicle and requested dates</param>
        /// <returns></returns>
        [HttpPost("CalculateTax")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PostCalculateTax(TaxCalculatorRequestDto taxCalculatorRequest)
        {
            var response = await Mediator.Send(new CalculateTaxCommand(taxCalculatorRequest));

            return Ok(response);
        }




    }
}
