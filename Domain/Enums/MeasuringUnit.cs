using System.ComponentModel;

namespace Domain.Enums
{
    public enum MeasuringUnit
    {
        [Description("Kilometre")]
        Kilometre = 0,
        [Description("Meter")]
        Meter = 1,
        [Description("Mile")]
        Mile = 2
    }
}
