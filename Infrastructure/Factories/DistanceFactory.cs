using Domain.Enums;
using GeoDistance.Application.Interfaces;
using GeoDistance.Infrastructure.CalculateDistance;

namespace GeoDistance.Infrastructure.Factories
{
    public class DistanceFactory : IDistanceFactory
    {
        public ICalculateDistance GetDistanceClass(CalculationType type)
        {
            return type switch
            {
                CalculationType.Ellipsoid => new EllipsoidDistance(),
                CalculationType.Pythagoras => new PythagorasDistance(),
                _ => new EllipsoidDistance()
            };
        }
    }
}
