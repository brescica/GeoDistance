using System.ComponentModel;

namespace Domain.Enums
{
    public enum CalculationType
    {
        [Description("Ellipsoid")]
        Ellipsoid = 0,
        [Description("Pythagoras")]
        Pythagoras = 1
    }
}
