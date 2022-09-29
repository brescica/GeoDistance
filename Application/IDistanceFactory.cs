using Domain.Enums;

namespace Application
{
    public interface IDistanceFactory
    {
        ICalculateDistance GetDistanceClass(CalculationType type);
    }
}
