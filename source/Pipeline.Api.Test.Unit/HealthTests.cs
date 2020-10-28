using System;
using Pipeline.Api.Controllers;
using Xunit;

namespace Pipeline.Api.Test.Unit
{
    public class HealthTests
    {
        [Fact]
        public void Test1()
        {
            var controller = new HealthController(null);

            Assert.Equal("pong", controller.Ping())
;        }
    }
}
