using Application;
using Domain.Constants;
using Domain.Entities;

namespace Infrastructure
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
