using Banking.Application.DTO.request;
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

namespace Banking.IntegrationTests
{
    public class CustomerControllerTest : IClassFixture<WebApplicationFactory<Banking.Api.Startup>>
    {
        [Fact]
        public async Task Add_Account_Should_Return_HttpStatusCode_Ok()
        {
            using (var client = new TestClientProvider().Client)
            {
                var response = await client.PostAsync("api/customer"
                        , new StringContent(
                        JsonConvert.SerializeObject(new CustomerRequestModel()
                        {
                            address = "istanbul",
                            email = "test@test.com",
                            mobile = "05555555555",
                            name = "test name",
                            surname = "test surname"
                        }),

                    Encoding.UTF8,
                    "application/json"));

                response.EnsureSuccessStatusCode();

                Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            }
        }
    }
}
