using Application.Distance.Queries.GetDistance;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GeoDistance.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DistanceController : ControllerBase
    {
        private readonly IMediator _mediator;

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
        public async Task<ActionResult<double>> CalculateDistance([FromQuery] GetDistanceQuery query)
        {
            return await _mediator.Send(query);
        }

        /// <summary>
        /// Calculate distance between two coordinates in km, m or M
        /// </summary>
        /// <returns>Distance between two coordinates in km, m or M</returns>
        /// <response code="200">Returns the calculated distance</response>
        [HttpGet("factory", Name = "CalculateDistanceFactory")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<double>> CalculateDistanceFactory([FromQuery] GetDistanceQueryTwo query)
        {
            return await _mediator.Send(query);
        }
    }
}
