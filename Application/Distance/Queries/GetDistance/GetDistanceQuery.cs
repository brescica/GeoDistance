using Domain.Constants;
using Domain.Entities;
using Domain.Enums;
using GeoDistance.Application.Interfaces;
using GeoDistance.Domain.Common;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Distance.Queries.GetDistance
{
    public record GetDistanceQuery : IRequest<double>
    {
        public GeoPoint PointA { get; set; } = new GeoPoint();
        public GeoPoint PointB { get; set; } = new GeoPoint();
        public CalculationType CalculationType { get; set; } = CalculationType.Ellipsoid;
        public MeasuringUnit MeasuringUnit { get; set; } = MeasuringUnit.Kilometre;
    }

    public class GetDistanceQueryHandler : IRequestHandler<GetDistanceQuery, double>
    {
        private ICalculateDistance? _distanceCalculation;
        private readonly IDistanceFactory _distanceFactory;
        private readonly ILogger<GetDistanceQueryHandler> _logger;

        public GetDistanceQueryHandler(IDistanceFactory distanceFactory, ILogger<GetDistanceQueryHandler> logger)
        {
            _distanceFactory = distanceFactory;
            _logger = logger;
        }

        public Task<double> Handle(GetDistanceQuery request, CancellationToken cancellationToken)
        {
            try
            {
                double distance = 0d;
                // get the wanted calculation method (Ellipsoid or Pythagoras)
                _distanceCalculation = _distanceFactory.GetDistanceClass(request.CalculationType);

                // if the coordinates are the same, return 0
                if ((request.PointA.Latitude == request.PointB.Latitude) && (request.PointA.Longitude == request.PointB.Longitude))
                {
                    distance = 0d;
                }
                else
                {
                    var distanceInKm = _distanceCalculation.GetDistance(request.PointA, request.PointB);
                    distance = DistanceConverter.ConvertUnit(request.MeasuringUnit, distanceInKm);
                }

                return Task.FromResult(distance);                
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return Task.FromResult(0d);
            }
        }
    }
}
