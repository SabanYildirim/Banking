using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Banking.IntegrationTests.Tests
{
    public class TranscationControllerTest : IClassFixture<WebApplicationFactory<Banking.Api.Startup>>
    {
        [Fact]
        public async Task Get_Transcations_AccountId_Should_Return_HttpStatusCode_Ok()
        {
            using (var client = new TestClientProvider().Client)
            {
                var response = await client.GetAsync("/api/transcation?accountId=1");
             
                response.EnsureSuccessStatusCode();

                Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            }
        }

        [Fact]
        public async Task Get_Transcations_TimePeriod_Should_Return_HttpStatusCode_Ok()
        {
            using (var client = new TestClientProvider().Client)
            {
                var response = await client.GetAsync($"/api/transcation?startDate={DateTime.Now.AddDays(-1)}&endDate={DateTime.Now.AddDays(1)}");

                response.EnsureSuccessStatusCode();

                Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            }
        }
    }
}
