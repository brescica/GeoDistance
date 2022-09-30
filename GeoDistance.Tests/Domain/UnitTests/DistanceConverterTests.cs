using Domain.Enums;
using GeoDistance.Domain.Common;

namespace GeoDistance.Tests.Domain.UnitTests
{
    public class DistanceConverterTests
    {
        [Fact]
        public void StaticMethodConvertUnitToMetersTest()
        {
            // Arrange            
            var expected = 2345d;
            // Act
            var result = DistanceConverter.ConvertUnit(MeasuringUnit.Meter, 2.345);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}