using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using Banking.Application.DTO.request;

namespace Banking.IntegrationTests
{
    public class AccountControllerTest : IClassFixture<WebApplicationFactory<Banking.Api.Startup>>
    {
        [Fact]
        public async Task Add_Account_Should_Return_HttpStatusCode_Ok()
        {
            using (var client = new TestClientProvider().Client)
            {
                var response = await client.PostAsync("api/account"
                        , new StringContent(
                        JsonConvert.SerializeObject(new AccountRequestModel()
                        {
                            accountBranch = "maltepe",
                            accountName = "tl hesabı",
                            accountNo = 10,
                            balance = 100.00M,
                            customerId = 1,
                        }),
                    Encoding.UTF8,
                    "application/json"));

                response.EnsureSuccessStatusCode();

                Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            }
        }
    }
}
