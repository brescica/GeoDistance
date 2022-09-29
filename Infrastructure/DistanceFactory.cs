using Application;
using Domain.Enums;

namespace Infrastructure
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
