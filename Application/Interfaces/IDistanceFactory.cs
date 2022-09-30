using Domain.Enums;

namespace GeoDistance.Application.Interfaces
{
    public interface IDistanceFactory
    {
        ICalculateDistance GetDistanceClass(CalculationType type);
    }
}
