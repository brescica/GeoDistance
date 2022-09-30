using Domain.Enums;
using GeoDistance.Domain.Common;

namespace GeoDistance.Tests.Domain.UnitTests
{
    public class DistanceConverterTests
    {
        [Theory]
        [InlineData(2.345, 2.345, MeasuringUnit.Kilometre)]
        [InlineData(2345, 2.345, MeasuringUnit.Meter)]
        [InlineData(1.4571149950000002, 2.345, MeasuringUnit.Mile)]
        public void ConvertUnitTest(double expected, double value, MeasuringUnit measuringUnit)
        {
            // Arrange            

            // Act
            var result = DistanceConverter.ConvertUnit(measuringUnit, value);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}