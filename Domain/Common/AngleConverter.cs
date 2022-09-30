namespace GeoDistance.Domain.Common
{
    public static class AngleConverter
    {
        /// <summary>
        /// Converts degrees to radians
        /// </summary>
        public static double ConvertDegreesToRadians(double deg)
        {
            return Math.PI * deg / 180.0;
        }

        /// <summary>
        /// Converts radians to degrees
        /// </summary>
        public static double ConvertRadiansToDegrees(double rad)
        {
            return 180.0 * rad / Math.PI;
        }
    }
}
