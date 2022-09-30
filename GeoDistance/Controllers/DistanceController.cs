using Application.Distance.Queries.GetDistance;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GeoDistance.Controllers
{
    /// <summary>
    /// Controller for calculating geo distance
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class DistanceController : ControllerBase
    {
        private readonly IMediator _mediator;

        /// inject mediator
        public DistanceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Calculate distance between two coordinates in km, m or M
        /// </summary>
        /// <returns>Distance between two coordinates in km, m or M</returns>
        /// <response code="200">Returns the calculated distance</response>
        [HttpGet(Name = "CalculateDistance")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> CalculateDistance([FromQuery] GetDistanceQuery query)
        {
            return Ok(await _mediator.Send(query));
        }
    }
}
