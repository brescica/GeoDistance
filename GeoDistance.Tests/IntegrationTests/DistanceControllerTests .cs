using Application.Distance.Queries.GetDistance;
using Domain.Entities;
using Domain.Enums;
using GeoDistance.Controllers;
using GeoDistance.Infrastructure.CalculateDistance;
using MediatR;

namespace GeoDistance.Tests.Infrastructure.UnitTests
{
    public class DistanceControllerTests
    {

        [Fact]
        public void GetDistanceEllipsoidTest()
        {
            // Arrange            
            var query = new GetDistanceQuery() { };
            var pointA = new GeoPoint() { Latitude = 0.0405, Longitude = 51.0561 };
            var pointB = new GeoPoint() { Latitude = 0.1807, Longitude = 78.4678 };
            query.PointA = pointA;
            query.PointB = pointB;
            query.CalculationType = CalculationType.Ellipsoid;
            query.MeasuringUnit = MeasuringUnit.Kilometre;
            var expected = 3047.9286391101837;

            // Act
            //Assert

        }
    }
}