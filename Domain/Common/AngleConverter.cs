namespace GeoDistance.Domain.Common
{
    public static class AngleConverter
    {
        public static double ConvertDegreesToRadians(double deg)
        {
            return Math.PI * deg / 180.0;
        }

        public static double ConvertRadiansToDegrees(double rad)
        {
            return 180.0 * rad / Math.PI;
        }
    }
}
