using Domain.Enums;
using GeoDistance.Domain.Common;

namespace GeoDistance.Tests.Domain.UnitTests
{
    public class AngleConverterTests
    {
        [Fact]
        public void ConvertDegreesToRadiansTest()
        {
            // Arrange            
            var expected = Math.PI;
            // Act
            var result = AngleConverter.ConvertDegreesToRadians(180d);
            //Assert
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void ConvertRadiansToDegreesTest()
        {
            // Arrange            
            var expected = 180d;
            // Act
            var result = AngleConverter.ConvertRadiansToDegrees(Math.PI);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}