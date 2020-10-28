using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Pipeline.Api.Test.Integration
{
    public class HealthTests
    {
        [Fact]
        public async Task Given_Health_Ping_Returns_Successfully()
        {
            using (var client = new HttpTestClientProvider().Client)
            {
                var response = await client.GetAsync("/api/health/ping");
                var content = await response.Content.ReadAsStringAsync();

                Assert.Equal(HttpStatusCode.OK, response.StatusCode);
                Assert.Equal("\"pong\"", content);
            }

        }
    }
}
