using Domain.Constants;
using Domain.Entities;
using Domain.Enums;
using MediatR;

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
       //private readonly ICalculateDistance _distanceCalculation;

        public GetDistanceQueryHandler(/*IDistanceFactory factory*/)
        {
            //_distanceCalculation = factory.GetDistanceClass(CalculationType.Pythagora);
        }

        public Task<double> Handle(GetDistanceQuery request, CancellationToken cancellationToken)
        {
            double distance = 0d;

            if ((request.PointA.Latitude == request.PointB.Latitude) && (request.PointA.Longitude == request.PointB.Longitude))
            {
                distance = 0d;
            }
            else if (request.CalculationType == CalculationType.Ellipsoid)
            {
                // calculate in radians
                double theta = request.PointA.Longitude - request.PointB.Longitude;
                double dist = Math.Sin(deg2rad(request.PointA.Latitude)) * Math.Sin(deg2rad(request.PointB.Latitude)) +
                    Math.Cos(deg2rad(request.PointA.Latitude)) * Math.Cos(deg2rad(request.PointB.Latitude)) * Math.Cos(deg2rad(theta));
                dist = Math.Acos(dist);
                dist = rad2deg(dist);
                dist = dist * 60 * 1.1515;
                distance = dist * 1.609344;
            }
            // Pythagoras ->  ignoring the sphericity of the earth, apply Pythagoras
            else if (request.CalculationType == CalculationType.Pythagoras)
            {
                distance = Constants.EarthRadius_km *
                    Math.Sqrt(Math.Pow(request.PointA.Latitude - request.PointB.Latitude, 2) +
                    Math.Pow(request.PointA.Longitude - request.PointB.Longitude, 2)) * Math.PI / 180;
            }

            return request.MeasuringUnit switch
            {
                MeasuringUnit.Kilometre => Task.FromResult(distance),
                MeasuringUnit.Meter => Task.FromResult(km2metre(distance)),
                MeasuringUnit.Mile => Task.FromResult(km2mile(distance)),
                _ => Task.FromResult(distance)
            };
        }

        private double deg2rad(double deg)
        {
            return deg * Math.PI / 180.0;
        }

        private double rad2deg(double rad)
        {
            return rad / Math.PI * 180.0;
        }

        private double km2metre(double distanceInKm)
        {
            return distanceInKm * 1000d;
        }

        private double km2mile(double distanceInKm)
        {
            return distanceInKm * 0.621371d;
        }
    }
}
