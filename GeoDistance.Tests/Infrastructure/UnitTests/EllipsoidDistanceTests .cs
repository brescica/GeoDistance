using Domain.Entities;
using GeoDistance.Infrastructure.CalculateDistance;

namespace GeoDistance.Tests.Infrastructure.UnitTests
{
    public class EllipsoidDistanceTests
    {
        [Fact]
        public void GetDistanceTest()
        {
            // Arrange            
            var ellipsoidDistance = new EllipsoidDistance();
            var pointA = new GeoPoint() { Latitude = 0.0405, Longitude = 51.0561 };
            var pointB = new GeoPoint() { Latitude = 0.1807, Longitude = 78.4678 };
            var expected = 3047.9286391101837;

            // Act
            var result = ellipsoidDistance.GetDistance(pointA, pointB);

            //Assert
            Assert.Equal(expected, result);
            Assert.True(result > 3047d && result < 3048.5);
        }
    }
}