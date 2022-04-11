using Banking.Application.Interfaces;
using Banking.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Banking.Application
{
    public static class RegisterApplicationLayer
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITranscationService, TranscationService>();
            services.AddTransient<IWithDrawService, WithDrawService>();
        }
    }
}
