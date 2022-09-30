using Domain.Entities;
using GeoDistance.Application.Interfaces;
using GeoDistance.Domain.Common;

namespace GeoDistance.Infrastructure.CalculateDistance
{
    public class EllipsoidDistance : ICalculateDistance
    {
        public double GetDistance(GeoPoint pointA, GeoPoint pointB)
        {
            double theta = pointA.Longitude - pointB.Longitude;
            double dist = Math.Sin(AngleConverter.ConvertDegreesToRadians(pointA.Latitude)) * Math.Sin(AngleConverter.ConvertDegreesToRadians(pointB.Latitude)) +
                Math.Cos(AngleConverter.ConvertDegreesToRadians(pointA.Latitude)) * Math.Cos(AngleConverter.ConvertDegreesToRadians(pointB.Latitude)) * Math.Cos(AngleConverter.ConvertDegreesToRadians(theta));
            dist = Math.Acos(dist);
            dist = AngleConverter.ConvertRadiansToDegrees(dist);
            dist = dist * 60 * 1.1515;
            dist = dist * 1.609344;
            return dist;
        }
    }
}
