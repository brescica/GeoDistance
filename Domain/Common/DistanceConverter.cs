using Domain.Enums;

namespace GeoDistance.Domain.Common
{
    public static class DistanceConverter
    {
        /// <summary>
        /// Converts kilometres to kilometre, meter or Mile
        /// </summary>
        public static double ConvertUnit(MeasuringUnit measuringUnit, double distanceInKm)
        {
            return measuringUnit switch
            {
                MeasuringUnit.Kilometre => distanceInKm,
                MeasuringUnit.Meter => KilometresToMeters(distanceInKm),
                MeasuringUnit.Mile => KilometresToMiles(distanceInKm),
                _ => distanceInKm
            };
        }

        private static double KilometresToMeters(double distanceInKm)
        {
            return distanceInKm * 1000d;
        }

        private static double KilometresToMiles(double distanceInKm)
        {
            return distanceInKm * 0.621371d;
        }
    }
}
