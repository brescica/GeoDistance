using Domain.Entities;

namespace Application
{
    public interface ICalculateDistance
    {
        double GetDistance(GeoPoint pointA, GeoPoint pointB);
    }
}
