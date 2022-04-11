using Banking.Infrastructure.Interfaces;
using Banking.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Infrastructure
{
    public static class RegisterInfrastructureLayer
    {
        public static void AddInfrastructureLayer(this IServiceCollection services)
        {
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<ICustormerRepository, CustormerRepository>();
            services.AddScoped<ITranscationRepository, TranscationRepository>();

        }
    }
}
