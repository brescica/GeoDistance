using GeoDistance.Domain.Common;

namespace GeoDistance.Tests.Domain.UnitTests
{
    public class AngleConverterTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(180d, Math.PI)]
        [InlineData(360d, 2 * Math.PI)]
        public void ConvertDegreesToRadiansTest(double value, double expected)
        {
            // Arrange            

            // Act
            var result = AngleConverter.ConvertDegreesToRadians(value);
            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(Math.PI, 180d)]
        [InlineData(2*Math.PI, 360d)]
        public void ConvertRadiansToDegreesTest(double value, double expected)
        {
            // Arrange
            
            // Act
            var result = AngleConverter.ConvertRadiansToDegrees(value);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}