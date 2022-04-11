using Banking.Application.DTO.request;
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
    public class WithDrawControllerTest
    {
        [Fact]
        public async Task Add_Account_Should_Return_HttpStatusCode_Ok()
        {
            using (var client = new TestClientProvider().Client)
            {
                var response = await client.PutAsync("api/withdraw"
                        , new StringContent(
                        JsonConvert.SerializeObject(new WithDrawRequestModel()
                        {
                            accountId = 1,
                            customerId = 1,
                            money = 5.50M
                        }),
                    Encoding.UTF8,
                    "application/json"));

                response.EnsureSuccessStatusCode();

                Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            }
        }
    }
}
