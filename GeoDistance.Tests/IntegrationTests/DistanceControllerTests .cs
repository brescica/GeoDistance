namespace GeoDistance.Tests.IntegrationTests
{
    public class DistanceControllerTests : IClassFixture<TestingWebAppFactory<Program>>
    {
        private readonly HttpClient _client;

        public DistanceControllerTests(TestingWebAppFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async void GetDistanceEllipsoidTest()
        {
            // Arrange            
            var expected = 3047.9286391101837;
            var uri = "/api/distance?PointA.Latitude=0.0405&PointA.Longitude=51.0561&PointB.Latitude=0.1807&PointB.Longitude=78.4678";

            // Act
            var result = await _client.GetAsync(uri, new CancellationToken());

            //Assert
            Assert.True(result.IsSuccessStatusCode);
            var responseString = await result.Content.ReadAsStringAsync();
            double.TryParse(responseString, out double num);
            Assert.Equal(expected, num);
        }

        [Fact]
        public async void GetDistancePythagorasTest()
        {
            // Arrange            
            var uri = "/api/distance?PointA.Latitude=0.0405&PointA.Longitude=51.0561&PointB.Latitude=0.1807&PointB.Longitude=78.4678&CalculationType=Pythagoras";

            // Act
            var result = await _client.GetAsync(uri, new CancellationToken());

            //Assert
            Assert.True(result.IsSuccessStatusCode);
            var responseString = await result.Content.ReadAsStringAsync();
            double.TryParse(responseString, out double num);
            Assert.True(num > 3046d && num < 3049d);
        }
    }
}