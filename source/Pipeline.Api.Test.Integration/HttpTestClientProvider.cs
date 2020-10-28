using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace Pipeline.Api.Test.Integration
{
    public class HttpTestClientProvider
    {
        public HttpClient Client { get; private set; }

        public HttpTestClientProvider()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());

            Client = server.CreateClient();
        }
    }
}
