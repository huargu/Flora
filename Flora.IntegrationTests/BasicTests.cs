using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;
using System.Net.Http;

namespace Flora.Tests.IntegrationTests
{
    public class BasicTests
    {
        [Theory]
        [InlineData("http://localhost:5000/api/material")]
        [InlineData("http://localhost:5000/api/bouquet")]
        public async Task Get_RoutesSuccess(string url)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();
            Assert.Equal("application/json; charset=utf-8",
                response.Content.Headers.ContentType.ToString());
        }
    }
}