using Domain.Entities;

namespace GeoDistance.Application.Interfaces
{
    public interface ICalculateDistance
    {
        /// <summary>
        /// Calculate distance between two geo coordinates
        /// </summary>
        double GetDistance(GeoPoint pointA, GeoPoint pointB);
    }
}
