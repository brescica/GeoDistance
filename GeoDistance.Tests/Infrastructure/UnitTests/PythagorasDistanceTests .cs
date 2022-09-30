using Domain.Entities;
using GeoDistance.Infrastructure.CalculateDistance;

namespace GeoDistance.Tests.Infrastructure.UnitTests
{
    public class PythagorasDistanceTests
    {
        [Fact]
        public void GetDistanceTest()
        {
            // Arrange            
            var pythagorasDistance = new PythagorasDistance();
            var pointA = new GeoPoint() { Latitude = 0.0405, Longitude = 51.0561 };
            var pointB = new GeoPoint() { Latitude = 0.1807, Longitude = 78.4678 };

            // Act
            var result = pythagorasDistance.GetDistance(pointA, pointB);

            //Assert
            Assert.True(result > 3046d && result < 3049d);
        }
    }
}