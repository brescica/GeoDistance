using Domain.Entities;

namespace GeoDistance.Application.Interfaces
{
    public interface ICalculateDistance
    {
        double GetDistance(GeoPoint pointA, GeoPoint pointB);
    }
}
