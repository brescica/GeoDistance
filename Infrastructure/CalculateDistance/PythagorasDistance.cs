using Domain.Constants;
using Domain.Entities;
using GeoDistance.Application.Interfaces;

namespace GeoDistance.Infrastructure.CalculateDistance
{
    public class PythagorasDistance : ICalculateDistance
    {
        public double GetDistance(GeoPoint pointA, GeoPoint pointB)
        {
            return Constants.EarthRadius_km *
                    Math.Sqrt(Math.Pow(pointA.Latitude - pointB.Latitude, 2) +
                    Math.Pow(pointA.Longitude - pointB.Longitude, 2)) * Math.PI / 180;
        }
    }
}
